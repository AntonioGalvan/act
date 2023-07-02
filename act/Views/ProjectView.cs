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
        }

        public int Id
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }
        public string Description
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
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
        public string IsMessage
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
            dgbProjects.DataSource = projectList;
        }
    }
}
