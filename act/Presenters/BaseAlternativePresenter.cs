using act.Models.AlternativeFlows;
using act.Models.BaseAlternativeFlows;
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
    internal class BaseAlternativePresenter
    {
        private IBaseAlternativeView view;
        private IBaseAlternativeRepository repository;
        private BindingSource baFlowsBindingSource;
        private BindingSource aFlowsBindingSource;
        private IEnumerable<BaseAlternativeModel> baFlowList;
        private IEnumerable<AlternativeFlowModel> aFlowList;

        private readonly string sqlConnectionString;
        int projectId;
        private IMainView mainView;

        public BaseAlternativePresenter(IBaseAlternativeView pView, IBaseAlternativeRepository pRepository, string pSqlConnectionString, int pProjectId, IMainView pMainView)
        {
            this.baFlowsBindingSource = new BindingSource();
            this.aFlowsBindingSource = new BindingSource();

            view = pView;
            repository = pRepository;

            this.view.SearchEvent += SearchBAFlow;
            this.view.AddNewEvent += AddNewBAFlow;
            this.view.DeleteEvent += DeleteSelectedBAFlow;
            this.view.SaveEvent += SaveBAFlow;
            this.view.CancelEvent += CancelAction;

            this.view.SetBaseAlternateBindingSource(baFlowsBindingSource);
            this.view.SetAlternativeFlowsListBindingSource(aFlowsBindingSource);

            LoadAllBAFlowList();
            LoadAllAFlowsList();

            this.view.Show();
            this.sqlConnectionString = pSqlConnectionString;
            this.projectId = pProjectId;
            this.mainView = pMainView;
        }

        private void LoadAllBAFlowList()
        {
            baFlowList = repository.GetAll();
            baFlowsBindingSource.DataSource = baFlowList;
        }

        //Cargamos información a la lista de casos de uso
        private void LoadAllAFlowsList()
        {
            aFlowList = repository.GetAllAlternativeFlows();
            aFlowsBindingSource.DataSource = aFlowList;
        }

        private void SearchBAFlow(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
                baFlowList = repository.GetByValue(this.view.SearchValue);
            else baFlowList = repository.GetAll();
            baFlowsBindingSource.DataSource = baFlowList;
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void SaveBAFlow(object? sender, EventArgs e)
        {
            //Guardamos en un objeto de tipo flujo base la información de los campos en la vista
            var model = new BaseAlternativeModel();

            model.BaseFlowId = Convert.ToInt32(this.view.BaseFlowId);
            model.AlternativeFlowId = this.view.AlternativeFlowId;


            try
            {
                new Common.ModelDataValidation().Validate(model);

                repository.Add(model);
                view.Message = "Relación flujo base a alterno agregada correctamente";

                view.IsSuccessful = true;
                LoadAllBAFlowList();
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
            view.AlternativeFlowId = 0;
        }

        private void DeleteSelectedBAFlow(object? sender, EventArgs e)
        {
            try
            {
                var baFlow = (BaseAlternativeModel)baFlowsBindingSource.Current;
                repository.Delete(baFlow.Id);
                view.IsSuccessful = true;
                view.Message = "Relación flujo base a alterno eliminada correctamente";
                LoadAllBAFlowList();
            }
            catch (Exception ex)
            {

                view.IsSuccessful = false;
                view.Message = "Ha ocurrido un error, se pudo eliminar la relación";
            }
        }

        private void AddNewBAFlow(object? sender, EventArgs e)
        {
            aFlowList = repository.GetAllAlternativeFlows();
            aFlowsBindingSource.DataSource = aFlowList;
        }
    }
}
