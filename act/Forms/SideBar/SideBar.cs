using act.Forms.Roles;
using act.Forms.Relation_Elements;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using act.Views;

namespace act.Forms.Side_bar
{
    public partial class SideBar : Form, IMainView
    {
        public SideBar()
        {
            InitializeComponent();

            btnElementosR.Click += delegate { ShowRelationElementsView?.Invoke(this, EventArgs.Empty); };
            btnRoles.Click += delegate { ShowRoleView?.Invoke(this, EventArgs.Empty); };
        }

        public event EventHandler ShowRoleView;
        public event EventHandler ShowRelationElementsView;

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            //Salir del proyecto actual
        }

    }
}
