using act.Forms.UseCases.Index;
using act.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Metadata.Edm;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace act.Forms.BaseAlternativeFlows.Index
{
    //Código referente a la interfaz gráfica
    //Implementamos interfaz de la vista
    public partial class BaseAlternativeFlow : Form, IBaseAlternativeView
    {
        public BaseAlternativeFlow()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            tbcBaseAlternativeFlows.TabPages.Remove(tbpAdd);
            btnOut.Click += delegate { this.Close(); };
        }
        private string message;
        private bool isSuccessful;


        //Asociamos los eventos con los métodos
        private void AssociateAndRaiseViewEvents()
        {
            btnSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            tbxSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                    SearchEvent?.Invoke(this, EventArgs.Empty);
            };

            btnAdd.Click += delegate
            {
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                tbcBaseAlternativeFlows.TabPages.Remove(tbpList);
                tbcBaseAlternativeFlows.TabPages.Add(tbpAdd);
                tbpAdd.Text = "Agregar";
            };

            btnSave.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                //realizamos acciones si el guardado fue exitoso
                if (IsSuccessful)
                {
                    tbcBaseAlternativeFlows.TabPages.Remove(tbpAdd);
                    tbcBaseAlternativeFlows.TabPages.Add(tbpList);
                }
                MessageBox.Show(Message, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            };

            btnCancel.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tbcBaseAlternativeFlows.TabPages.Remove(tbpAdd);
                tbcBaseAlternativeFlows.TabPages.Add(tbpList);
            };

            btnDelete.Click += delegate
            {
                var result = MessageBox.Show("¿Deseas eliminar el registro seleccionado?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    if (IsSuccessful)
                    {
                        MessageBox.Show(Message, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            };

            btnAlternatingFlow.Click += delegate
            {
                this.Close();
                //OpenbFlowEvent?.Invoke(this, EventArgs.Empty);
            };
        }

        //Asociamos propiedades a campos disponibles en pantalla
        public string Id
        {
            get { return tbxId.Text; }
            set { tbxId.Text = value; }
        }

        public string BaseFlowId
        {
            get { return tbxId.Text; }
            set { tbxId.Text = value; }
        }

        public int AlternativeFlowId
        {
            get
            {
                if (cmbAlternativeFlow.SelectedValue != null)
                {
                    return Convert.ToInt32(cmbAlternativeFlow.SelectedValue.ToString());
                }
                else
                {

                    return 0;
                }

            }
            set { AlternativeFlowId = value; }
        }

        //Varaible de control para operaciones de pantalla
        public string SearchValue
        {
            get { return tbxSearch.Text; }
            set { tbxSearch.Text = value; }
        }
        public bool IsSuccessful
        {
            get { return isSuccessful; }
            set { isSuccessful = value; }
        }
        public string Message
        {
            get { return message; }
            set { message = value; }
        }


        //Declaramos los handlers para los eventos disparados en la vista
        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;


        public void SetBaseAlternateBindingSource(BindingSource baList)
        {
            dgvBaseAlternativeFlows.DataSource = baList;
        }

        //Asociamos a lista la lista de casos de uso
        public void SetAlternativeFlowsListBindingSource(BindingSource typeList)
        {

            cmbAlternativeFlow.DisplayMember = "name";
            cmbAlternativeFlow.ValueMember = "id";
            cmbAlternativeFlow.DataSource = typeList;
        }

        private static BaseAlternativeFlow instance;

        //Obtenemos la instancia de la pantalla
        public static BaseAlternativeFlow GetInstance(Form parent)
        {
            if (instance == null || instance.IsDisposed)
            {

                instance = new BaseAlternativeFlow();

                //Código para fijar vista en pantalla
                instance.MdiParent = parent;
                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                {
                    instance.WindowState = FormWindowState.Normal;
                }

                instance.BringToFront();
            }
            return instance;
        }

        //Ocultamos columnas innecesarias
        private void BaseFlow_Load(object sender, EventArgs e)
        {
            dgvBaseAlternativeFlows.Columns["Id"].Visible = false;
            dgvBaseAlternativeFlows.Columns["ProjectId"].Visible = false;
        }

        
    }
}
