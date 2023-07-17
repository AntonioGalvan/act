using act._Repositories;
using act.Forms.BaseFlows.Index;
using act.Forms.UseCases.Index;
using act.Models.BaseFlows;
using act.Models.Roles;
using act.Models.UseCases;
using act.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace act.Presenters
{
    internal class BaseFlowsPresenter
    {
        private IBaseFlowsRView view;
        private IBaseFlowsRRepository repository;
        private BindingSource bFlowBindingSource;
        private IEnumerable<BaseFlowModel> bFlowList;

        private readonly string sqlConnectionString;
        int projectId;
        private IMainView mainView;

        public BaseFlowsPresenter(IBaseFlowsRView pView, IBaseFlowsRRepository pRepository, string pSqlConnectionString, int pProjectId, IMainView pMainView)
        {
            this.bFlowBindingSource = new BindingSource();
            view = pView;
            repository = pRepository;

            this.view.AddNewEvent += AddNewBFlow;
            this.view.EditEvent += LoadSelectedBFlowToEdit;
            this.view.DeleteEvent += DeleteSelectedBFlow;
            this.view.SaveEvent += SaveBFlow;
            this.view.CancelEvent += CancelAction;
            this.view.ReturnUseCaseView += ReturnUseCase;
            this.view.CheckBaseFlow += CheckBaseF;

            this.view.SetProjectListBindingSource(bFlowBindingSource);

            LoadAllBFlowList();

            this.view.Show();
            this.sqlConnectionString = pSqlConnectionString;
            this.projectId = pProjectId;
            this.mainView = pMainView;
        }

        private void CheckBaseF(object? sender, EventArgs e)
        {
            if(repository.Check())
            {
                view.HaveBaseFlow = true;
                view.Message = "El caso de uso ya cuenta con un flujo base";
            }  
            else
                view.HaveBaseFlow = false;
        }

        public void ReturnUseCase(object? sender, EventArgs e)
        {

            IUseCaseView view = UseCaseView.GetInstance((Form)mainView);
            IUseCaseRepository repository = new UseCaseRepository(sqlConnectionString, projectId);
            new UseCasePresenter(view, repository, sqlConnectionString, projectId, mainView);
        }

        private void LoadAllBFlowList()
        {
            bFlowList = repository.GetAll();
            bFlowBindingSource.DataSource = bFlowList;
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void SaveBFlow(object? sender, EventArgs e)
        {
            var model = new BaseFlowModel();
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
                    view.Message = "Flujo base editado correctamente";
                }
                else
                {
                    repository.Add(model);
                    view.Message = "Flujo base agregado correctamente";
                }

                view.IsSuccessful = true;
                LoadAllBFlowList();
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

        private void DeleteSelectedBFlow(object? sender, EventArgs e)
        {
            try
            {
                var role = (BaseFlowModel)bFlowBindingSource.Current;
                repository.Delete(role.Id);
                view.IsSuccessful = true;
                view.Message = "Flujo base eliminado correctamente";
                LoadAllBFlowList();
            }
            catch (Exception ex)
            {

                view.IsSuccessful = false;
                view.Message = "Ha ocurrido un error, se pudo eliminar el flujo base";
            }
        }

        private void LoadSelectedBFlowToEdit(object? sender, EventArgs e)
        {
            var bFlow = (BaseFlowModel)bFlowBindingSource.Current;
            view.Id = bFlow.Id.ToString();
            view.Name = bFlow.Name;
            view.Key = bFlow.Key.Remove(0, 3);
            view.FlowChartPath = bFlow.FlowChartPath;
            view.IsEdit = true;
        }

        private void AddNewBFlow(object? sender, EventArgs e)
        {
            view.Name = "";
            view.IsEdit = false;
        }
    }
}
