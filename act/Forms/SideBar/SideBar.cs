using act.Views;

namespace act.Forms.Side_bar
{
    public partial class SideBar : Form, IMainView
    {
        public SideBar()
        {
            InitializeComponent();
            pnlRelationEContainer.Visible = false;
            btnElementosR.Click += delegate { ShowRelationElementsView?.Invoke(this, EventArgs.Empty); };
            btnRoles.Click += delegate { ShowRoleView?.Invoke(this, EventArgs.Empty); };
            btnMessages.Click += delegate { ShowMessageView?.Invoke(this, EventArgs.Empty); };
            btnBusinessRules.Click += delegate { ShowRuleView?.Invoke(this, EventArgs.Empty); };
        }

        public event EventHandler ShowRelationElementsView;
        public event EventHandler ShowRoleView;
        public event EventHandler ShowMessageView;
        public event EventHandler ShowRuleView;

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
