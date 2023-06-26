using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace act.Views
{
    internal interface IProjectview
    {
        int Id { get; set; }
        string Name { get; set; }
        string Description { get; set; }
        DateOnly startDate { get; set; }
        DateTime endDate { get; set; }

        string SearchValue { get; set; }
        bool isEdit { get; set; }
        bool isSuccessful { get; set; }
        string isMessage { get; set; }

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
