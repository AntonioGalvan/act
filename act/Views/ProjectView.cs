using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace act.Views
{
    public partial class ProjectView : Form, IProjectview
    {
        private string message;
        private bool isSuccessful;
        private bool isEdit;

        public ProjectView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            tbcProjects.TabPages.Remove(tbpAdd);
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
                tbcProjects.TabPages.Remove(tbpList);
                tbcProjects.TabPages.Add(tbpAdd);
                tbpAdd.Text = "Agregar proyecto";
            };

            btnEdit.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);
                tbcProjects.TabPages.Remove(tbpList);
                tbcProjects.TabPages.Add(tbpAdd);
                tbpAdd.Text = "Editar proyecto";
            };

            btnSave.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (IsSuccessful)
                {
                    tbcProjects.TabPages.Remove(tbpAdd);
                    tbcProjects.TabPages.Add(tbpList);
                }
                MessageBox.Show(Message);
            };

            btnCancel.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tbcProjects.TabPages.Remove(tbpAdd);
                tbcProjects.TabPages.Add(tbpList);
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

            btnOpen.Click += delegate
            {
                OpenEvent?.Invoke(this, EventArgs.Empty);
            };
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

        public string Description
        {
            get { return tbxDesc.Text; }
            set { tbxDesc.Text = value; }
        }
        public DateTime StartDate
        {
            get { return dtpStart.Value; }
            set { dtpStart.Value = value; }
        }
        public DateTime EndDate
        {
            get { return dtpEnd.Value; }
            set { dtpEnd.Value = value; }
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
        public event EventHandler OpenEvent;

        public void SetProjectListBindingSource(BindingSource projectList)
        {
            dgbProjects.DataSource = projectList;
        }
    }
}
