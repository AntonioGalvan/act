using act.Models.Objects;
using act.Views;
using System.Data;

namespace act.Forms.Object
{
    public partial class ObjectView : Form, IObjectView
    {

        private string message;
        private bool isSuccessful;
        private bool isEdit;
        private int idType;

        public ObjectView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            tbcRoles.TabPages.Remove(tbpAdd);
            btnOut.Click += delegate { this.Close(); };
        }

        private void AssociateAndRaiseViewEvents()
        {
            btnSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            tbxSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                    SearchEvent?.Invoke(this, EventArgs.Empty);

                SearchValue = "";
            };

            btnAdd.Click += delegate
            {
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                tbcRoles.TabPages.Remove(tbpList);
                tbcRoles.TabPages.Add(tbpAdd);
                tbpAdd.Text = "Agregar objeto";
            };

            btnEdit.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);

                tbcRoles.TabPages.Remove(tbpList);
                tbcRoles.TabPages.Add(tbpAdd);
                cmbObjectType.SelectedValue = idType;
                tbpAdd.Text = "Editar objeto";
            };

            btnSave.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (IsSuccessful)
                {
                    tbcRoles.TabPages.Remove(tbpAdd);
                    tbcRoles.TabPages.Add(tbpList);
                }
                MessageBox.Show(Message);
            };

            btnCancel.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tbcRoles.TabPages.Remove(tbpAdd);
                tbcRoles.TabPages.Add(tbpList);
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

        public string Purpose
        {
            get { return tbxPurpose.Text; }
            set { tbxPurpose.Text = value; }
        }

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
        public int ObjectTypeId
        {
            get { return Convert.ToInt32(cmbObjectType.SelectedValue.ToString()); }
            set { idType = value; }
        }


        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        public void SetProjectListBindingSource(BindingSource objectList)
        {
            dgvRoles.DataSource = objectList;
        }

        public void SetObjectTypeListBindingSource(BindingSource typeList)
        {

            cmbObjectType.DisplayMember = "name";
            cmbObjectType.ValueMember = "id";
            cmbObjectType.DataSource = typeList;
        }

        private static ObjectView instance;

        public static ObjectView GetInstance(Form parent)
        {
            if (instance == null || instance.IsDisposed)
            {

                instance = new ObjectView();

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
