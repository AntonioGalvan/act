namespace act.Views
{
    internal interface IStateObjectView
    {
        string Id { get; set; }
        string Name { get; set; }
        string Key { get; set; }
        string Purpose { get; set; }

        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }

        //Events
        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;

        void SetProjectListBindingSource(BindingSource list);
        void SetObjectListBindingSource(BindingSource list);
        void SetStateListBindingSource(BindingSource list);
        void Show();
    }
}
