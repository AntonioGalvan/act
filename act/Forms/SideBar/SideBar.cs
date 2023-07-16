using act.Views;

namespace act.Forms.Side_bar
{
    public partial class SideBar : Form, IMainView
    {
        public SideBar()
        {
            InitializeComponent();
            pnlRelationEContainer.Visible = true;
            btnElementosR.Click += delegate { ShowRelationElementsView?.Invoke(this, EventArgs.Empty); };
            btnRoles.Click += delegate { ShowRoleView?.Invoke(this, EventArgs.Empty); };
            btnMessages.Click += delegate { ShowMessageView?.Invoke(this, EventArgs.Empty); };
            btnBusinessRules.Click += delegate { ShowRuleView?.Invoke(this, EventArgs.Empty); };
            btnCUs.Click += delegate { ShowUseCaseView?.Invoke(this, EventArgs.Empty); };
            btnStates.Click += delegate { ShowStateView?.Invoke(this, EventArgs.Empty); };
            btnObjectTypes.Click += delegate { ShowObjectTypeView?.Invoke(this, EventArgs.Empty); };
            btnObjects.Click += delegate { ShowObjectView?.Invoke(this, EventArgs.Empty); };
            btnScreens.Click += delegate { ShowScreenView?.Invoke(this, EventArgs.Empty); };
            btnBaseFlows.Click += delegate { ShowBaseFlowsView?.Invoke(this, EventArgs.Empty); };
        }

        public event EventHandler ShowRelationElementsView;
        public event EventHandler ShowRoleView;
        public event EventHandler ShowMessageView;
        public event EventHandler ShowRuleView;
        public event EventHandler ShowUseCaseView;
        public event EventHandler ShowStateView;
        public event EventHandler ShowObjectTypeView;
        public event EventHandler ShowObjectView;
        public event EventHandler ShowScreenView;
        public event EventHandler ShowBaseFlowsView;

        private void CloseAll()
        {
            foreach (Form form in this.MdiChildren)
            {
                form.Close();
            }

            pnlRelationEContainer.Visible = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //Ocultar y mostrar botones
        //El panel se va a ocultar al dar click al que se desee acceder
        private void btnMessages_Click(object sender, EventArgs e)
        {
            CloseAll();
        }

        private void btnBusinessRules_Click(object sender, EventArgs e)
        {
            CloseAll();
        }

        private void btnElementosR_Click(object sender, EventArgs e)
        {
            CloseAll();
            pnlRelationEContainer.Visible = true;
        }

        private void btnRoles_Click(object sender, EventArgs e)
        {
            CloseAll();
        }

        private void btnCUs_Click(object sender, EventArgs e)
        {
            CloseAll();
        }

        private void btnStates_Click(object sender, EventArgs e)
        {
            CloseAll();
        }

        private void btnObjectTypes_Click(object sender, EventArgs e)
        {
            CloseAll();
        }

        private void btnObjects_Click(object sender, EventArgs e)
        {
            CloseAll();
        }

        private void btnScreens_Click(object sender, EventArgs e)
        {
            CloseAll();
        }

        private void btnBaseFlows_Click(object sender, EventArgs e)
        {
            CloseAll();
        }
    }
}
