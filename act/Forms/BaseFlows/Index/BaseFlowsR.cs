using act.Forms.Roles;
using act.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace act.Forms.BaseFlows.Index
{
    public partial class BaseFlowsR : Form, IBaseFlowsRView
    {
        private string message;
        private bool isSuccessful;
        private bool isEdit;

        public BaseFlowsR()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            tbcBFlows.TabPages.Remove(tbpAdd);
            btnOut.Click += delegate { this.Close(); };
        }

        private void AssociateAndRaiseViewEvents()
        {

            btnAdd.Click += delegate
            {
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                tbcBFlows.TabPages.Remove(tbpList);
                tbcBFlows.TabPages.Add(tbpAdd);
                tbpAdd.Text = "Agregar flujo base";
            };

            btnEdit.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);
                tbcBFlows.TabPages.Remove(tbpList);
                tbcBFlows.TabPages.Add(tbpAdd);
                tbpAdd.Text = "Editar flujo base";
            };

            btnSave.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (IsSuccessful)
                {
                    tbcBFlows.TabPages.Remove(tbpAdd);
                    tbcBFlows.TabPages.Add(tbpList);
                }
                MessageBox.Show(Message);
            };

            btnCancel.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tbcBFlows.TabPages.Remove(tbpAdd);
                tbcBFlows.TabPages.Add(tbpList);
            };

            btnDelete.Click += delegate
            {
                var result = MessageBox.Show("¿Deseas eliminar el registro seleccionado?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
            };
        }

        public string Id
        {
            get { return tbxId.Text; }
            set { tbxId.Text = value; }
        }

        public string Key
        {
            get { return tbxKey.Text; }
            set { tbxKey.Text = value; }
        }

        public string Name
        {
            get { return tbxName.Text; }
            set { tbxName.Text = value; }
        }

        public string FlowChartPath
        {
            get { return tbxImage.Text; }
            set { tbxImage.Text = value; }
        }

        public bool IsEdit
        {
            get { return isEdit; }
            set { isEdit = value; }
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

        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        public void SetProjectListBindingSource(BindingSource baseFlowsRList)
        {
            dgvBFlows.DataSource = baseFlowsRList;
        }

        private static BaseFlowsR instance;

        public static BaseFlowsR GetInstance(Form parent)
        {
            if (instance == null || instance.IsDisposed)
            {

                instance = new BaseFlowsR();

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
    }
}
