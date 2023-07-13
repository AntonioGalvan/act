using act.Forms.UseCases;
using act.Views;

namespace act.Forms.UseCases.Index
{
    public partial class UseCaseView : Form, IUseCaseView
    {
        public UseCaseView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            tbcUseCases.TabPages.Remove(tbpAdd);
            btnOut.Click += delegate { this.Close(); };
        }
        private string message;
        private bool isSuccessful;
        private bool isEdit;

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
                tbcUseCases.TabPages.Remove(tbpList);
                tbcUseCases.TabPages.Add(tbpAdd);
                tbpAdd.Text = "Agregar caso de uso";
            };

            btnEdit.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);
                tbcUseCases.TabPages.Remove(tbpList);
                tbcUseCases.TabPages.Add(tbpAdd);
                tbpAdd.Text = "Editar rol";
            };

            btnSave.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (IsSuccessful)
                {
                    tbcUseCases.TabPages.Remove(tbpAdd);
                    tbcUseCases.TabPages.Add(tbpList);
                }
                MessageBox.Show(Message);
            };

            btnCancel.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tbcUseCases.TabPages.Remove(tbpAdd);
                tbcUseCases.TabPages.Add(tbpList);
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

            btnBaseFlow.Click += delegate
            {
                this.Close();
                OpenbFlowEvent?.Invoke(this, EventArgs.Empty);
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

        public string FlowChartPath
        {
            get { return tbxFlowChartPath.Text; }
            set { tbxFlowChartPath.Text = value; }
        }

        public string Name
        {
            get { return tbxName.Text; }
            set { tbxName.Text = value; }
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
        public event EventHandler OpenbFlowEvent;

        public void SetProjectListBindingSource(BindingSource roleList)
        {
            dgvRoles.DataSource = roleList;
        }

        private static UseCaseView instance;

        public static UseCaseView GetInstance(Form parent)
        {
            if (instance == null || instance.IsDisposed)
            {

                instance = new UseCaseView();

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
