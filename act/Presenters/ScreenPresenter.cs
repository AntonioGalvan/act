using act.Models.Screens;
using act.Views;

namespace act.Presenters
{
    internal class ScreenPresenter
    {
        private IScreenView view;
        private IScreenRepository repository;
        private BindingSource screensBindingSource;
        private IEnumerable<ScreenModel> screenList;

        public ScreenPresenter(IScreenView pView, IScreenRepository pRepository)
        {
            this.screensBindingSource = new BindingSource();
            view = pView;
            repository = pRepository;

            this.view.SearchEvent += SearchScreen;
            this.view.AddNewEvent += AddNewScreen;
            this.view.EditEvent += LoadSelectedScreenToEdit;
            this.view.DeleteEvent += DeleteSelectedScreen;
            this.view.SaveEvent += SaveScreen;
            this.view.CancelEvent += CancelAction;

            this.view.SetProjectListBindingSource(screensBindingSource);

            LoadAllScreenList();

            this.view.Show();
        }

        private void LoadAllScreenList()
        {
            screenList = repository.GetAll();
            screensBindingSource.DataSource = screenList;
        }

        private void SearchScreen(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
                screenList = repository.GetByValue(this.view.SearchValue);
            else screenList = repository.GetAll();
            screensBindingSource.DataSource = screenList;
        }


        private void CancelAction(object? sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void SaveScreen(object? sender, EventArgs e)
        {
            var model = new ScreenModel();
            if (view.IsEdit)
            {
                model.Id = Convert.ToInt32(this.view.Id);
            }
            model.Name = this.view.Name;
            model.Key = this.view.Key;
            model.ImagePath = this.view.ImagePath;

            try
            {
                new Common.ModelDataValidation().Validate(model);

                if (view.IsEdit)
                {
                    repository.Edit(model);
                    view.Message = "Pantalla editada correctamente";
                }
                else
                {
                    repository.Add(model);
                    view.Message = "Pantalla agregada correctamente";
                }

                view.IsSuccessful = true;
                LoadAllScreenList();
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
            view.ImagePath = "";
        }

        private void DeleteSelectedScreen(object? sender, EventArgs e)
        {
            try
            {
                var screen = (ScreenModel)screensBindingSource.Current;
                repository.Delete(screen.Id);
                view.IsSuccessful = true;
                view.Message = "Pantalla eliminada correctamente";
                LoadAllScreenList();
            }
            catch (Exception ex)
            {

                view.IsSuccessful = false;
                view.Message = "Ha ocurrido un error, no se pudo eliminar la pantalla";
            }
        }

        private void LoadSelectedScreenToEdit(object? sender, EventArgs e)
        {
            var role = (ScreenModel)screensBindingSource.Current;
            view.Id = role.Id.ToString();
            view.Name = role.Name;
            view.Key = role.Key;
            view.ImagePath = role.ImagePath;
            view.IsEdit = true;
        }

        private void AddNewScreen(object? sender, EventArgs e)
        {
            view.Name = "";
            view.IsEdit = false;
        }
    }
}
