namespace act.Views
{
    internal interface IObjectTypeView
    {
        string Id { get; set; }
        string Name { get; set; }
        string Purpose { get; set; }

        void SetProjectListBindingSource(BindingSource objectList);
        void Show();
    }
}
