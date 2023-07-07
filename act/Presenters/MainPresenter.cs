using act.Views;
using act.Models;
using act._Repositories;
using act.Forms.Roles;
using act.Forms.Messages.Index;

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

            this.mainView.ShowMessageView += ShowMessageView;

            this.mainView.Show();
            this.projectId = projectId;
        }

        private void ShowRelationElementsView(object sender, EventArgs e)
        {
            //IMessageView view = MessageView.GetInstance((Form)mainView);
            //IMessageRepository repository = new MessageRepository(sqlConnectionString, projectId);
            //new MessagePresenter(view, repository);
        }

        private void ShowRoleView(object sender, EventArgs e)
        {
            IRoleView view = RoleView.GetInstance((Form)mainView);
            IRoleRepository repository = new RoleRepository(sqlConnectionString, projectId);
            new RolePresenter(view, repository);
        }

        private void ShowMessageView(object sender, EventArgs e)
        {
            IMessageView view = MessageView.GetInstance((Form)mainView);
            IMessageRepository repository = new MessageRepository(sqlConnectionString, projectId);
            new MessagePresenter(view, repository);
        }
    }
}
