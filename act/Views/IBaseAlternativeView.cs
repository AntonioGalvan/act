using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace act.Views
{
    internal interface IBaseAlternativeView
    {
        string Id { get; set; }
        int BaseFlowId { get; set; }
        int AlternativeFlowId { get; set; }

        string SearchValue { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }

        //Events
        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;

        void SetBaseAlternateBindingSource(BindingSource baList);

        void SetAlternativeFlowsListBindingSource(BindingSource AFlowsList);
        void Show();
    }
}
