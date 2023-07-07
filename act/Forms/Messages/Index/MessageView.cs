using act.Views;

namespace act.Forms.Messages.Index
{
    public partial class MessageView : Form, IMessageView
    {
        private string message;
        private bool isSuccessful;
        private bool isEdit;
        public MessageView()
        {
            InitializeComponent();
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            tbcMessages.TabPages.Remove(tbpAdd);
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
                tbcMessages.TabPages.Remove(tbpList);
                tbcMessages.TabPages.Add(tbpAdd);
                tbpAdd.Text = "Agregar mensaje";
            };

            btnEdit.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);
                tbcMessages.TabPages.Remove(tbpList);
                tbcMessages.TabPages.Add(tbpAdd);
                tbpAdd.Text = "Editar mensaje";
            };

            btnSave.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (IsSuccessful)
                {
                    tbcMessages.TabPages.Remove(tbpAdd);
                    tbcMessages.TabPages.Add(tbpList);
                }
                MessageBox.Show(Message);
            };

            btnCancel.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tbcMessages.TabPages.Remove(tbpAdd);
                tbcMessages.TabPages.Add(tbpList);
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

        //Sacar del modelo
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
        public string Description
        {
            get { return tbxDescription.Text; }
            set { tbxDescription.Text = value; }
        }
        //Necesarios
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

        public void SetProjectListBindingSource(BindingSource projectList)
        {
            dgvMessages.DataSource = projectList;
        }

        private static MessageView instance;

        public static MessageView GetInstance(Form parent)
        {
            if (instance == null || instance.IsDisposed)
            {

                instance = new MessageView();

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
