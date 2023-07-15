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
using System.Xml.Linq;

namespace act.Forms.Screens.Index
{
    public partial class ScreenView : Form, IScreenView
    {
        private string message;
        private bool isSuccessful;
        private bool isEdit;

        public ScreenView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            tbcScreens.TabPages.Remove(tbpAdd);
            btnOut.Click += delegate { this.Close(); };
        }

        private void AssociateAndRaiseViewEvents()
        {
            btnSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            tbxSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchEvent?.Invoke(this, EventArgs.Empty);
                    SearchValue = "";
                }

            };

            btnAdd.Click += delegate
            {
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                tbcScreens.TabPages.Remove(tbpList);
                tbcScreens.TabPages.Add(tbpAdd);
                tbpAdd.Text = "Agregar pantalla";
            };

            btnEdit.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);
                tbcScreens.TabPages.Remove(tbpList);
                tbcScreens.TabPages.Add(tbpAdd);
                tbpAdd.Text = "Editar pantalla";
            };

            btnSave.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (IsSuccessful)
                {
                    tbcScreens.TabPages.Remove(tbpAdd);
                    tbcScreens.TabPages.Add(tbpList);
                }
                MessageBox.Show(Message, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            };

            btnCancel.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tbcScreens.TabPages.Remove(tbpAdd);
                tbcScreens.TabPages.Add(tbpList);
            };

            btnDelete.Click += delegate
            {
                var result = MessageBox.Show("¿Deseas eliminar el registro seleccionado?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        public string ImagePath
        {
            get { return tbxImagePath.Text; }
            set { tbxImagePath.Text = value; }
        }
        //Necesarios para operaciones de pantalla
        public string SearchValue
        {
            get { return tbxSearch.Text; }
            set { tbxSearch.Text = value; }
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

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        public void SetProjectListBindingSource(BindingSource screenList)
        {
            dgvScreens.DataSource = screenList;
        }

        private static ScreenView instance;

        public static ScreenView GetInstance(Form parent)
        {
            if (instance == null || instance.IsDisposed)
            {

                instance = new ScreenView();

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

        private void ScreenView_Load(object sender, EventArgs e)
        {
            dgvScreens.Columns["Id"].Visible = false;
            dgvScreens.Columns["ProjectId"].Visible = false;
            dgvScreens.Columns["DiagramElementState"].Visible = false;
            dgvScreens.Columns["ScreenElementState"].Visible = false;
        }
    }
}
