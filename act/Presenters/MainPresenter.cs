using act.Views;
using act._Repositories;
using act.Forms.Roles;
using act.Forms.Messages.Index;
using act.Forms.Business_Rules.Index;
using act.Models.Roles;
using act.Models.Rules;
using act.Models.Messages;
using act.Forms.UseCases.Index;
using act.Models.UseCases;

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

            this.mainView.ShowRuleView += ShowRuleView;

            this.mainView.ShowUseCaseView += ShowUseCaseView;

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

        private void ShowRuleView(object sender, EventArgs e)
        {
            IRuleView view = RuleView.GetInstance((Form)mainView);
            IRuleRepository repository = new RuleRepository(sqlConnectionString, projectId);
            new RulePresenter(view, repository);
        }

        private void ShowUseCaseView(object sender, EventArgs e)
        {
            IUseCaseView view = UseCaseView.GetInstance((Form)mainView);
            IUseCaseRepository repository = new UseCaseRepository(sqlConnectionString, projectId);
            new UseCasePresenter(view, repository, sqlConnectionString, projectId,mainView);
        }
    }
}
