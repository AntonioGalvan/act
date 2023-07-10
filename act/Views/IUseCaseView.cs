using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace act.Views
{
    internal interface IUseCaseView
    {
        string Id { get; set; }
        string Name { get; set; }
        string Key { get; set; }
        string FlowChartPath { get; set; }
        //Operaciones de pantalla
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
        event EventHandler OpenbFlowEvent;

        void SetProjectListBindingSource(BindingSource useCaseList);
        void Show();
    }
}
