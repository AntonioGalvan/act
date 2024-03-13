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
using act.Forms.States;
using act.Models.States;
using act.Models.Objects;
using act.Forms.Object;
using act.Forms.Screens.Index;
using act.Models.Screens;
using act.Forms.BaseFlows.Index;
using act.Models.BaseFlows;
using act.Forms.AlternativeFlows.Index;
using act.Models.AlternativeFlows;

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

            this.mainView.ShowStateView += ShowStateView;

            this.mainView.ShowObjectTypeView += ShowObjectTypeView;

            this.mainView.ShowObjectView += ShowObjectView;

            this.mainView.ShowScreenView += ShowScreenView;

            this.mainView.ShowBaseFlowsView += ShowBFlowView;

            this.mainView.ShowAlternativeFlowsView += ShowAFlowView;

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

        private void ShowStateView(object sender, EventArgs e)
        {
            IStateView view = StateView.GetInstance((Form)mainView);
            IStateRepository repository = new StateRepository(sqlConnectionString, projectId);
            new StatePresenter(view, repository);
        }

        private void ShowObjectTypeView(object sender, EventArgs e)
        {
            IObjectTypeView view = ObjectTypeView.GetInstance((Form)mainView);
            IObjectTypeRepository repository = new ObjectTypeRepository(sqlConnectionString);
            new ObjectTypePresenter(view, repository);
        }
        private void ShowObjectView(object sender, EventArgs e)
        {
            IObjectView view = ObjectView.GetInstance((Form)mainView);
            IObjectRepository repository = new ObjectRepository(sqlConnectionString, projectId);
            new ObjectPresenter(view, repository);
        }
        private void ShowScreenView(object sender, EventArgs e)
        {
            IScreenView view = ScreenView.GetInstance((Form)mainView);
            IScreenRepository repository = new ScreenRepository(sqlConnectionString, projectId);
            new ScreenPresenter(view, repository);
        }

        private void ShowBFlowView(object sender, EventArgs e)
        {
            IBaseFlowView view = BaseFlow.GetInstance((Form)mainView);
            IBaseFlowRepository repository = new BaseFlowRepository(sqlConnectionString, projectId);
            new BaseFlowPresenter(view, repository, sqlConnectionString, projectId, mainView);

        }

        private void ShowAFlowView(object sender, EventArgs e)
        {
            IAlternativeFlowView view = AlternativeFlow.GetInstance((Form)mainView);
            IAlternativeFlowRepository repository = new AlternativeFlowRepository(sqlConnectionString, projectId);
            new AlternativeFlowPresenter(view, repository, sqlConnectionString, projectId, mainView);
        }
    }
}
