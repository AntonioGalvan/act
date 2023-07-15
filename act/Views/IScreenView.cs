namespace act.Views
{
    internal interface IScreenView
    {
        string Id { get; set; }
        string Name { get; set; }
        string Key { get; set; }
        string ImagePath { get; set; }
        //Necesarios para operaciones de pantalla
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

        void SetProjectListBindingSource(BindingSource screenList);
        void Show();
    }
}
