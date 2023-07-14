using act.Views;

namespace act.Forms.Object
{
    public partial class ObjectTypeView : Form, IObjectTypeView
    {

        private string message;
        private bool isSuccessful;
        private bool isEdit;

        public ObjectTypeView()
        {
            InitializeComponent();
            btnOut.Click += delegate { this.Close(); };
        }

        public string Id
        {
            get { return tbxId.Text; }
            set { tbxId.Text = value; }
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

        public void SetProjectListBindingSource(BindingSource typeList)
        {
            dgvObjectTypes.DataSource = typeList;
        }

        private static ObjectTypeView instance;

        public static ObjectTypeView GetInstance(Form parent)
        {
            if (instance == null || instance.IsDisposed)
            {

                instance = new ObjectTypeView();

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

        private void ObjectTypeView_Load(object sender, EventArgs e)
        {
            int columns = dgvObjectTypes.Columns.Count;
            dgvObjectTypes.Columns[columns - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}
