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
    //Esta clase funciona como intermediario entre la vista (BaseFlow) y el repositorio (BaseFlowRepository)
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

        //Pasamos como parámetros al constructor la vista, el repositorio, la cadena de conexión, el proyecto actual y la vista principal
        public BaseFlowPresenter(IBaseFlowView pView, IBaseFlowRepository pRepository, string pSqlConnectionString, int pProjectId, IMainView pMainView)
        {
            this.bFlowsBindingSource = new BindingSource();
            this.useCaseBindingSource = new BindingSource();
            view = pView;
            repository = pRepository;

            //Asignamos los handlers de la vista a metódos en esta clase
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

        //Cargamos la lista de flujos base
        private void LoadAllBaseFlowList()
        {
            bFlowList = repository.GetAll();
            bFlowsBindingSource.DataSource = bFlowList;
        }

        //Cargamos la lista de casos de uso
        private void LoadAllUseCaseList()
        {
            useCaseList = repository.GetAllUseCases(0);
            useCaseBindingSource.DataSource = useCaseList;
        }

        //Método de búsqueda
        private void SearchBaseFlow(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
                bFlowList = repository.GetByValue(this.view.SearchValue);
            else bFlowList = repository.GetAll();
            bFlowsBindingSource.DataSource = bFlowList;
        }


        //Limpiamos campos en vista
        private void CancelAction(object? sender, EventArgs e)
        {
            CleanViewFields();
        }

        //Guardamos flujo base
        private void SaveBaseFlow(object? sender, EventArgs e)
        {
            //Guardamos en un objeto de tipo flujo base la información de los campos en la vista
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

                //Validamos que el flujo base no use un caso de uso que ya cuente con otro flujo base
                if(!repository.Check(model.Id, model.useCaseId))
                {
                    //Si elejimos "Ninguno" en la pantalla se guardará como 0
                    if (model.useCaseId == 0)
                    {
                        //En caso de ser 0 será considerado como nulo
                        model.useCaseId = null;
                    }
                    //Si estamos en vista de edición solo actualizaremos la información
                    if (view.IsEdit)
                    {
                        repository.Edit(model);
                        view.Message = "Flujo base editado correctamente";
                    }
                    //Si estamos agregando un registro haremos un insert
                    else
                    {
                        repository.Add(model);
                        view.Message = "Flujo base agregado correctamente";
                    }

                    view.IsSuccessful = true;
                    view.HaveUseCase = false;
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

        //Limpiamos campos en vista
        private void CleanViewFields()
        {
            view.Id = "0";
            view.Name = "";
            view.Key = "";
            view.FlowChartPath = "";
            view.UseCaseId = 0;
        }

        //Borramos el flujo base seleccionado
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

        //Cargamos información para editar un flujo base
        private void LoadSelectedBaseFlowToEdit(object? sender, EventArgs e)
        {
            var baseFlow = (BaseFlowModel)bFlowsBindingSource.Current;
            view.Id = baseFlow.Id.ToString();
            view.Name = baseFlow.Name;
            view.Key = baseFlow.Key.Remove(0,3);
            view.FlowChartPath = baseFlow.FlowChartPath;
            view.UseCaseId = baseFlow.useCaseId;
            useCaseList = repository.GetAllUseCases(baseFlow.useCaseId);
            useCaseBindingSource.DataSource = useCaseList;
            view.IsEdit = true;
        }

        //Cargamos información para agregar nuevo flujo base
        private void AddNewBaseFlow(object? sender, EventArgs e)
        {
            view.Name = "";
            useCaseList = repository.GetAllUseCases(0);
            useCaseBindingSource.DataSource = useCaseList;
            view.IsEdit = false;
        }
    }
}
