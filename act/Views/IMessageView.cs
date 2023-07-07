using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace act.Views
{
    internal interface IMessageView
    {
        string Id { get; set; }
        string Key { get; set; }
        string Description { get; set; }

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
        void SetProjectListBindingSource(BindingSource projectList);
        void Show();
    }
}
