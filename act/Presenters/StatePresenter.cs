using act.Models.States;
using act.Views;

namespace act.Presenters
{
    internal class StatePresenter
    {
        private IStateView view;
        private IStateRepository repository;
        private BindingSource stateBindingSource;
        private IEnumerable<ObjectStateModel> stateList;

        public StatePresenter(IStateView pView, IStateRepository pRepository)
        {
            this.stateBindingSource = new BindingSource();
            view = pView;
            repository = pRepository;

            this.view.SearchEvent += SearchState;
            this.view.AddNewEvent += AddNewState;
            this.view.EditEvent += LoadSelectedStateToEdit;
            this.view.DeleteEvent += DeleteSelectedState;
            this.view.SaveEvent += SaveState;
            this.view.CancelEvent += CancelAction;

            this.view.SetProjectListBindingSource(stateBindingSource);

            LoadAllStateList();

            this.view.Show();
        }

        private void LoadAllStateList()
        {
            stateList = repository.GetAll();
            stateBindingSource.DataSource = stateList;
        }

        private void SearchState(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
                stateList = repository.GetByValue(this.view.SearchValue);
            else stateList = repository.GetAll();
            stateBindingSource.DataSource = stateList;
        }


        private void CancelAction(object? sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void SaveState(object? sender, EventArgs e)
        {
            var model = new ObjectStateModel();
            if (view.IsEdit)
            {
                model.Id = Convert.ToInt32(this.view.Id);
            }
            model.Name = this.view.Name;
            model.Key = this.view.Key;
            model.Purpose = this.view.Purpose;

            try
            {
                new Common.ModelDataValidation().Validate(model);

                if (view.IsEdit)
                {
                    repository.Edit(model);
                    view.Message = "Estado editado correctamente";
                }
                else
                {
                    repository.Add(model);
                    view.Message = "Estado agregado correctamente";
                }

                view.IsSuccessful = true;
                LoadAllStateList();
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
            view.Purpose = "";
        }

        private void DeleteSelectedState(object? sender, EventArgs e)
        {
            try
            {
                var state = (ObjectStateModel)stateBindingSource.Current;
                repository.Delete(state.Id);
                view.IsSuccessful = true;
                view.Message = "Estado eliminado correctamente";
                LoadAllStateList();
            }
            catch (Exception ex)
            {

                view.IsSuccessful = false;
                view.Message = "Ha ocurrido un error, se pudo eliminar el estado";
            }
        }

        private void LoadSelectedStateToEdit(object? sender, EventArgs e)
        {
            var state = (ObjectStateModel)stateBindingSource.Current;
            view.Id = state.Id.ToString();
            view.Name = state.Name;
            view.Key = state.Key.Remove(0,3);
            view.Purpose = state.Purpose;
            view.IsEdit = true;
        }

        private void AddNewState(object? sender, EventArgs e)
        {
            view.Name = "";
            view.IsEdit = false;
        }
    }
}
