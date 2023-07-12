using act.Views;

namespace act.Forms.States
{
    public partial class StateView : Form, IStateView
    {

        private string message;
        private bool isSuccessful;
        private bool isEdit;

        public StateView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            tbcStates.TabPages.Remove(tbpAdd);
            btnOut.Click += delegate { this.Close(); };
        }

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
                tbcStates.TabPages.Remove(tbpList);
                tbcStates.TabPages.Add(tbpAdd);
                tbpAdd.Text = "Agregar estado";
            };

            btnEdit.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);
                tbcStates.TabPages.Remove(tbpList);
                tbcStates.TabPages.Add(tbpAdd);
                tbpAdd.Text = "Editar edtado";
            };

            btnSave.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (IsSuccessful)
                {
                    tbcStates.TabPages.Remove(tbpAdd);
                    tbcStates.TabPages.Add(tbpList);
                }
                MessageBox.Show(Message);
            };

            btnCancel.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tbcStates.TabPages.Remove(tbpAdd);
                tbcStates.TabPages.Add(tbpList);
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

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        public void SetProjectListBindingSource(BindingSource stateList)
        {
            dgvStates.DataSource = stateList;
        }

        private static StateView instance;

        public static StateView GetInstance(Form parent)
        {
            if (instance == null || instance.IsDisposed)
            {

                instance = new StateView();

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
