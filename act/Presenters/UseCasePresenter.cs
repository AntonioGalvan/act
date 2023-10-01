using act._Repositories;
using act.Forms.BaseFlows.Index;
using act.Forms.Side_bar;
using act.Models.BaseFlows;
using act.Models.Projects;
using act.Models.UseCases;
using act.Views;

namespace act.Presenters
{
    internal class UseCasePresenter
    {
        private IUseCaseView view;
        private IUseCaseRepository repository;
        private BindingSource useCasesBindingSource;
        private IEnumerable<UseCaseModel> useCaseList;

        private readonly string sqlConnectionString;
        int projectId;
        private IMainView mainView;

        public UseCasePresenter(IUseCaseView pView, IUseCaseRepository pRepository, string pSqlConnectionString, int pProjectId, IMainView pMainView)
        {
            this.useCasesBindingSource = new BindingSource();
            view = pView;
            repository = pRepository;

            this.view.SearchEvent += SearchUseCase;
            this.view.AddNewEvent += AddNewUseCase;
            this.view.EditEvent += LoadSelectedUseCaseToEdit;
            this.view.DeleteEvent += DeleteSelectedUseCase;
            this.view.SaveEvent += SaveUseCase;
            this.view.CancelEvent += CancelAction;
            this.view.OpenbFlowEvent += OpenBFlow;

            this.view.SetProjectListBindingSource(useCasesBindingSource);

            LoadAllUseCaseList();

            this.view.Show();
            this.sqlConnectionString = pSqlConnectionString;
            this.projectId = pProjectId;
            this.mainView = pMainView;
        }

        private void OpenBFlow(object? sender, EventArgs e)
        {
            var useCase = (UseCaseModel)useCasesBindingSource.Current;
            var useCasetId = useCase.Id;

            IBaseFlowsRView view = BaseFlowsR.GetInstance((Form)mainView);
            IBaseFlowsRRepository repository = new BaseFlowsRRepository(sqlConnectionString, projectId, useCasetId);
            new BaseFlowsPresenter(view, repository, sqlConnectionString, projectId, mainView);

        }

        private void LoadAllUseCaseList()
        {
            useCaseList = repository.GetAll();
            useCasesBindingSource.DataSource = useCaseList;
        }

        private void SearchUseCase(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
                useCaseList = repository.GetByValue(this.view.SearchValue);
            else useCaseList = repository.GetAll();
            useCasesBindingSource.DataSource = useCaseList;
        }


        private void CancelAction(object? sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void SaveUseCase(object? sender, EventArgs e)
        {
            var model = new UseCaseModel();
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
                    view.Message = "Caso de uso editado correctamente";
                }
                else
                {
                    repository.Add(model);
                    view.Message = "Caso de uso agregado correctamente";
                }

                view.IsSuccessful = true;
                LoadAllUseCaseList();
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

        private void DeleteSelectedUseCase(object? sender, EventArgs e)
        {
            try
            {
                var useCase = (UseCaseModel)useCasesBindingSource.Current;
                repository.Delete(useCase.Id);
                view.IsSuccessful = true;
                view.Message = "Caso de uso eliminado correctamente";
                LoadAllUseCaseList();
            }
            catch (Exception ex)
            {

                view.IsSuccessful = false;
                view.Message = "Ha ocurrido un error, se pudo eliminar el caso de uso";
            }
        }

        private void LoadSelectedUseCaseToEdit(object? sender, EventArgs e)
        {
            var useCase = (UseCaseModel)useCasesBindingSource.Current;
            view.Id = useCase.Id.ToString();
            view.Name = useCase.Name;
            view.Key = useCase.Key.Remove(0,3);
            view.FlowChartPath = useCase.FlowChartPath;
            view.IsEdit = true;
        }

        private void AddNewUseCase(object? sender, EventArgs e)
        {
            view.Name = "";
            view.IsEdit = false;
        }
    }
}
