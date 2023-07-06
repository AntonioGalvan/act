﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using act.Views;
using act.Forms;
using act.Models;
using act._Repositories;
using act.Forms.Roles;
using act.Forms.Side_bar;

namespace act.Presenters
{
    internal class MainPresenter
    {
        private IMainView mainView;
        private readonly string sqlConnectionString;
        private int projectId;

        public MainPresenter(IMainView pMainView, string pSqlConnectionString, int projectId)
        {
            this.mainView = pMainView;
            sqlConnectionString = pSqlConnectionString;
            this.mainView.ShowRelationElementsView += ShowRelationElementsView;

            this.mainView.ShowRoleView += ShowRoleView;

            this.mainView.Show();
            this.projectId = projectId;
        }

        private void ShowRelationElementsView(object sender, EventArgs e)
        {
            
        }

        private void ShowRoleView(object sender, EventArgs e)
        {
            IRoleView view = RoleView.GetInstance((Form)mainView);
            IRoleRepository repository = new RoleRepository(sqlConnectionString, projectId);
            new RolePresenter(view, repository);
        }
    }
}
