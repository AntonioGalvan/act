using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using act.Views;
using act.Forms;
using act.Models;
using act._Repositories;
using act.Forms.Roles;

namespace act.Presenters
{
    internal class MainPresenter
    {
        private IMainView mainView;
        private readonly string sqlConnectionString;

        public MainPresenter(IMainView pMainView, string pSqlConnectionString)
        {
            this.mainView = pMainView;
            sqlConnectionString = pSqlConnectionString;
            this.mainView.ShowRelationElementsView += ShowRelationElementsView;

            this.mainView.ShowRoleView += ShowRoleView;
        }

        private void ShowRelationElementsView(object sender, EventArgs e)
        {
            
        }

        private void ShowRoleView(object sender, EventArgs e)
        {
            IRoleView view = new RoleView();
            IRoleRepository repository = new RoleRepository(sqlConnectionString, 2);
            new RolePresenter(view, repository);
        }
    }
}
