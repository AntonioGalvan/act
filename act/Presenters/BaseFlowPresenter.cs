using act._Repositories;
using act.Forms.BaseFlows.Index;
using act.Models.BaseFlows;
using act.Models.UseCases;
using act.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace act.Presenters
{
    internal class BaseFlowPresenter
    {
        private IBaseFlowView view;
        private IBaseFlowRepository repository;
        private BindingSource bFlowsBindingSource;
        private BindingSource useCaseBindingSource;
        private IEnumerable<BaseFlowModel> bFlowList;
        private IEnumerable<UseCaseModel> useCaseList;

        private readonly string sqlConnectionString;
        int projectId;
        private IMainView mainView;

        public BaseFlowPresenter(IBaseFlowView pView, IBaseFlowRepository pRepository, string pSqlConnectionString, int pProjectId, IMainView pMainView)
        {
            this.bFlowsBindingSource = new BindingSource();
            this.useCaseBindingSource = new BindingSource();
            view = pView;
            repository = pRepository;

            this.view.SearchEvent += SearchBaseFlow;
            this.view.AddNewEvent += AddNewBaseFlow;
            this.view.EditEvent += LoadSelectedBaseFlowToEdit;
            this.view.DeleteEvent += DeleteSelectedBaseFlow;
            this.view.SaveEvent += SaveBaseFlow;
            this.view.CancelEvent += CancelAction;

            this.view.SetProjectListBindingSource(bFlowsBindingSource);

            this.view.SetObjectTypeListBindingSource(useCaseBindingSource);

            LoadAllBaseFlowList();
            LoadAllUseCaseList();

            this.view.Show();
            this.sqlConnectionString = pSqlConnectionString;
            this.projectId = pProjectId;
            this.mainView = pMainView;
        }

        private void LoadAllBaseFlowList()
        {
            bFlowList = repository.GetAll();
            bFlowsBindingSource.DataSource = bFlowList;
        }

        private void LoadAllUseCaseList()
        {
            useCaseList = repository.GetAllUseCases();
            useCaseBindingSource.DataSource = useCaseList;
        }

        private void SearchBaseFlow(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
                bFlowList = repository.GetByValue(this.view.SearchValue);
            else bFlowList = repository.GetAll();
            bFlowsBindingSource.DataSource = bFlowList;
        }


        private void CancelAction(object? sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void SaveBaseFlow(object? sender, EventArgs e)
        {
            var model = new BaseFlowModel();
            if (view.IsEdit)
            {
                model.Id = Convert.ToInt32(this.view.Id);
            }
            model.Name = this.view.Name;
            model.Key = this.view.Key;
            model.FlowChartPath = this.view.FlowChartPath;
            model.useCaseId = this.view.UseCaseId;

            try
            {
                new Common.ModelDataValidation().Validate(model);

                if(!repository.Check(model.useCaseId))
                {
                    if (view.IsEdit)
                    {
                        repository.Edit(model);
                        view.Message = "Flujo base editado correctamente";
                    }
                    else
                    {
                        repository.Add(model);
                        view.Message = "Flujo base agregado correctamente";
                    }

                    view.IsSuccessful = true;
                    LoadAllBaseFlowList();
                    CleanViewFields();
                }
                else
                {
                    view.HaveUseCase = true;
                    view.Message = "El caso de uso ya cuenta con un flujo base";
                }

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
            view.UseCaseId = 0;
        }

        private void DeleteSelectedBaseFlow(object? sender, EventArgs e)
        {
            try
            {
                var baseFlow = (BaseFlowModel)bFlowsBindingSource.Current;
                repository.Delete(baseFlow.Id);
                view.IsSuccessful = true;
                view.Message = "Flujo base eliminado correctamente";
                LoadAllBaseFlowList();
            }
            catch (Exception ex)
            {

                view.IsSuccessful = false;
                view.Message = "Ha ocurrido un error, se pudo eliminar el flujo base";
            }
        }

        private void LoadSelectedBaseFlowToEdit(object? sender, EventArgs e)
        {
            var baseFlow = (BaseFlowModel)bFlowsBindingSource.Current;
            view.Id = baseFlow.Id.ToString();
            view.Name = baseFlow.Name;
            view.Key = baseFlow.Key;
            view.FlowChartPath = baseFlow.FlowChartPath;
            view.UseCaseId = baseFlow.useCaseId;
            view.IsEdit = true;
        }

        private void AddNewBaseFlow(object? sender, EventArgs e)
        {
            view.Name = "";
            view.IsEdit = false;
        }
    }
}
