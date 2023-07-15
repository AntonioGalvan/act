using act.Views;

namespace act.Forms.Roles
{
    public partial class RoleView : Form, IRoleView
    {

        private string message;
        private bool isSuccessful;
        private bool isEdit;

        public RoleView()
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
                {
                    SearchEvent?.Invoke(this, EventArgs.Empty);
                    SearchValue = "";
                }

            };

            btnAdd.Click += delegate
            {
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                tbcRoles.TabPages.Remove(tbpList);
                tbcRoles.TabPages.Add(tbpAdd);
                tbpAdd.Text = "Agregar rol";
            };

            btnEdit.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);
                tbcRoles.TabPages.Remove(tbpList);
                tbcRoles.TabPages.Add(tbpAdd);
                tbpAdd.Text = "Editar rol";
            };

            btnSave.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (IsSuccessful)
                {
                    tbcRoles.TabPages.Remove(tbpAdd);
                    tbcRoles.TabPages.Add(tbpList);
                }
                MessageBox.Show(Message, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        public void SetProjectListBindingSource(BindingSource roleList)
        {
            dgvRoles.DataSource = roleList;
        }

        private static RoleView instance;

        public static RoleView GetInstance(Form parent)
        {
            if (instance == null || instance.IsDisposed)
            {

                instance = new RoleView();

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

        private void RoleView_Load(object sender, EventArgs e)
        {
            dgvRoles.Columns["Id"].Visible = false;
            dgvRoles.Columns["ProjectId"].Visible = false;


        }
    }
}
