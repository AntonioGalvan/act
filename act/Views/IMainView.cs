namespace act.Views
{
    internal interface IMainView
    {
        event EventHandler ShowRelationElementsView;
        event EventHandler ShowRoleView;
        event EventHandler ShowMessageView;
        event EventHandler ShowRuleView;
        event EventHandler ShowUseCaseView;
        event EventHandler ShowStateView;
        event EventHandler ShowObjectTypeView;
        event EventHandler ShowObjectView;

        void Show();
    }
}
