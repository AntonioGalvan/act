using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using act.Views;
using act.Forms;
using act.Models;
using act._Repositories;

namespace act.Presenters
{
    internal class MainPresenter
    {
        private IMainView mainView;
        private readonly string SqlConnectionString;

        public MainPresenter(IMainView pMainView, string pSqlConnectionString)
        {
            this.mainView = pMainView;
            SqlConnectionString = pSqlConnectionString;
            this.mainView.ShowRelationElementsView += ShowRelationElementsView;
        }

        private void ShowRelationElementsView(object sender, EventArgs e)
        {
            //Codigo TODO
        }
    }
}
