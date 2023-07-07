namespace act.Views
{
    internal interface IMainView
    {
        event EventHandler ShowRelationElementsView;
        event EventHandler ShowRoleView;
        event EventHandler ShowMessageView;

        void Show();
    }
}
