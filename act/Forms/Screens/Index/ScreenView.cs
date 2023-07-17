using act.Views;

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
                pbxImage.ImageLocation = tbxImagePath.Text;
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
            //Crear directorio para imágenes
            try
            {
                // If the directory doesn't exist, create it.
                if (!Directory.Exists("C:\\ACTImages"))
                {
                    Directory.CreateDirectory("C:\\ACTImages");
                }
            }
            catch (Exception)
            {
                // Fail silently
            }
            //Ocultar columnas no necesarias
            dgvScreens.Columns["Id"].Visible = false;
            dgvScreens.Columns["ProjectId"].Visible = false;
            dgvScreens.Columns["DiagramElementState"].Visible = false;
            dgvScreens.Columns["ScreenElementState"].Visible = false;
            dgvScreens.Columns["ImagePath"].Visible = false;
            tbxImagePath.Enabled = false;
        }

        //Prueba para agregar imagen
        private void btnAddImage_Click(object sender, EventArgs e)
        {
            String imageLocation = "";
            String savedImage = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(.*jpg) | *.jpg | PNG files(.*png) | *.png | All Files(*.*) | *.*";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    //La imágen debe ser nullable en la BD
                    imageLocation = dialog.FileName;
                    //Copiar la ubicación de la imagen a la carpeta creada
                    savedImage = Path.Combine("C:\\ACTImages\\", Path.GetFileName(imageLocation));
                    File.Copy(imageLocation, savedImage, true);
                    //Obtiene la ruta y muestra la imagen en el pctbox
                    tbxImagePath.Text = savedImage;
                    pbxImage.ImageLocation = savedImage;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error al subir la imagen", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
