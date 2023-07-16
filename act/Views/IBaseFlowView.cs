using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace act.Views
{
    internal interface IBaseFlowView
    {
        string Id { get; set; }
        string Key { get; set; }
        string Name { get; set; }
        string FlowChartPath { get; set; }
        int UseCaseId { get; set; }

        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }

        bool HaveUseCase { get; set; }

        //Events
        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;

        void SetProjectListBindingSource(BindingSource roleList);

        void SetObjectTypeListBindingSource(BindingSource useCaseList);
        void Show();
    }
}
