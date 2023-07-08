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
        }

        public event EventHandler ShowRelationElementsView;
        public event EventHandler ShowRoleView;
        public event EventHandler ShowMessageView;
        public event EventHandler ShowRuleView;
        public event EventHandler ShowUseCaseView;

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //Ocultar y mostrar botones
        //El panel se va a ocultar al dar click al que se desee acceder
        private void btnMessages_Click(object sender, EventArgs e)
        {
            pnlRelationEContainer.Visible = false;
        }

        private void btnBusinessRules_Click(object sender, EventArgs e)
        {
            pnlRelationEContainer.Visible = false;
        }

        private void btnElementosR_Click(object sender, EventArgs e)
        {
            pnlRelationEContainer.Visible = true;
        }

        private void btnRoles_Click(object sender, EventArgs e)
        {
            pnlRelationEContainer.Visible = false;
        }

        private void btnCUs_Click(object sender, EventArgs e)
        {
            pnlRelationEContainer.Visible = false;
        }
    }
}
