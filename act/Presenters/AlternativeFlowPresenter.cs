using act.Models.AlternativeFlows;
using act.Models.BaseFlows;
using act.Models.UseCases;
using act.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace act.Presenters
{
    internal class AlternativeFlowPresenter
    {
        private IAlternativeFlowView view;
        private IAlternativeFlowRepository repository;
        private BindingSource aFlowsBindingSource;
        private IEnumerable<AlternativeFlowModel> aFlowList;

        private readonly string sqlConnectionString;
        int projectId;
        private IMainView mainView;

        public AlternativeFlowPresenter(IAlternativeFlowView pView, IAlternativeFlowRepository pRepository, string pSqlConnectionString, int pProjectId, IMainView pMainView)
        {
            //Generamos los binding sources
            this.aFlowsBindingSource = new BindingSource();

            //Asignamos la vista y el repositorio
            view = pView;
            repository = pRepository;

            //Asignamos los handlers de la vista a metódos en esta clase
            this.view.SearchEvent += SearchAlternativeFlow;
            this.view.AddNewEvent += AddNewAlternativeFlow;
            this.view.EditEvent += LoadSelectedAlternativeFlowToEdit;
            this.view.DeleteEvent += DeleteSelectedAlternativeFlow;
            this.view.SaveEvent += SaveAlternativeFlow;
            this.view.CancelEvent += CancelAction;

            //Asginamos a la vista los binding sources
            this.view.SetProjectListBindingSource(aFlowsBindingSource);

            //Cargamos con la información los binding sources
            LoadAllAlternativeFlowList();

            this.view.Show();
            this.sqlConnectionString = pSqlConnectionString;
            this.projectId = pProjectId;
            this.mainView = pMainView;
        }

        //Cargamos información a la lista de flujos alternos
        private void LoadAllAlternativeFlowList()
        {
            aFlowList = repository.GetAll();
            aFlowsBindingSource.DataSource = aFlowList;
        }

        private void SearchAlternativeFlow(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
                aFlowList = repository.GetByValue(this.view.SearchValue);
            else aFlowList = repository.GetAll();
            aFlowsBindingSource.DataSource = aFlowList;
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void SaveAlternativeFlow(object? sender, EventArgs e)
        {
            //Guardamos en un objeto de tipo flujo base la información de los campos en la vista
            var model = new AlternativeFlowModel();
            if (view.IsEdit)
            {
                model.Id = Convert.ToInt32(this.view.Id);
            }
            model.Name = this.view.Name;
            model.Key = this.view.Key;
            model.FlowChartPath = this.view.FlowChartPath;

            try
            {
                new Common.ModelDataValidation().Validate(model);

                if (view.IsEdit)
                {
                    repository.Edit(model);
                    view.Message = "Flujo alterno editado correctamente";
                }
                //Si estamos agregando un registro haremos un insert
                else
                {
                    repository.Add(model);
                    view.Message = "Flujo alterno agregado correctamente";
                }

                view.IsSuccessful = true;
                LoadAllAlternativeFlowList();
                CleanViewFields();

            }
            catch (Exception ex)
            {

                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
        }

        private void CleanViewFields()
        {
            view.Id = "0";
            view.Name = "";
            view.Key = "";
            view.FlowChartPath = "";
        }

        private void DeleteSelectedAlternativeFlow(object? sender, EventArgs e)
        {
            try
            {
                var alternativeFlow = (AlternativeFlowModel)aFlowsBindingSource.Current;
                repository.Delete(alternativeFlow.Id);
                view.IsSuccessful = true;
                view.Message = "Flujo alterno eliminado correctamente";
                LoadAllAlternativeFlowList();
            }
            catch (Exception ex)
            {

                view.IsSuccessful = false;
                view.Message = "Ha ocurrido un error, se pudo eliminar el flujo alterno";
            }
        }

        private void LoadSelectedAlternativeFlowToEdit(object? sender, EventArgs e)
        {
            var alternativeFlow = (AlternativeFlowModel)aFlowsBindingSource.Current;
            view.Id = alternativeFlow.Id.ToString();
            view.Name = alternativeFlow.Name;
            view.Key = alternativeFlow.Key.Remove(0, 3);
            view.FlowChartPath = alternativeFlow.FlowChartPath;
            view.IsEdit = true;
        }

        private void AddNewAlternativeFlow(object? sender, EventArgs e)
        {
            view.Name = "";
            view.IsEdit = false;
        }
    }
}
