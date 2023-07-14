using act.Models.Objects;
using act.Views;

namespace act.Presenters
{
    internal class ObjectPresenter
    {
        private IObjectView view;
        private IObjectRepository repository;
        private BindingSource objectsBindingSource;
        private BindingSource typesBindingSource;
        private IEnumerable<ObjectModel> objectList;
        private IEnumerable<ObjectTypeModel> typeList;

        public ObjectPresenter(IObjectView pView, IObjectRepository pRepository)
        {
            this.objectsBindingSource = new BindingSource();
            this.typesBindingSource = new BindingSource();
            view = pView;
            repository = pRepository;

            this.view.SearchEvent += SearchObject;
            this.view.AddNewEvent += AddNewObject;
            this.view.EditEvent += LoadSelectedObjectToEdit;
            this.view.DeleteEvent += DeleteSelectedObject;
            this.view.SaveEvent += SaveObject;
            this.view.CancelEvent += CancelAction;

            this.view.SetProjectListBindingSource(objectsBindingSource);
            this.view.SetObjectTypeListBindingSource(typesBindingSource);

            LoadAllObjectList();

            this.view.Show();
        }

        private void LoadAllObjectList()
        {
            objectList = repository.GetAll();
            objectsBindingSource.DataSource = objectList;
            typeList = repository.GetAllTypes();
            typesBindingSource.DataSource = typeList;
        }

        private void SearchObject(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
                objectList = repository.GetByValue(this.view.SearchValue);
            else objectList = repository.GetAll();
            objectsBindingSource.DataSource = objectList;
        }


        private void CancelAction(object? sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void SaveObject(object? sender, EventArgs e)
        {
            var model = new ObjectModel();
            if (view.IsEdit)
            {
                model.Id = Convert.ToInt32(this.view.Id);
            }
            model.Name = this.view.Name;
            model.Key = this.view.Key;
            model.Purpose = this.view.Purpose;
            model.ObjectTypeId = this.view.ObjectTypeId;

            try
            {
                new Common.ModelDataValidation().Validate(model);

                if (view.IsEdit)
                {
                    repository.Edit(model);
                    view.Message = "Rol editado correctamente";
                }
                else
                {
                    repository.Add(model);
                    view.Message = "Rol agregado correctamente";
                }

                view.IsSuccessful = true;
                LoadAllObjectList();
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
            view.ObjectTypeId = 0;

        }

        private void DeleteSelectedObject(object? sender, EventArgs e)
        {
            try
            {
                var obj = (ObjectModel)objectsBindingSource.Current;
                repository.Delete(obj.Id);
                view.IsSuccessful = true;
                view.Message = "Rol eliminado correctamente";
                LoadAllObjectList();
            }
            catch (Exception ex)
            {

                view.IsSuccessful = false;
                view.Message = "Ha ocurrido un error, se pudo eliminar el rol";
            }
        }

        private void LoadSelectedObjectToEdit(object? sender, EventArgs e)
        {
            var obj = (ObjectModel)objectsBindingSource.Current;
            view.Id = obj.Id.ToString();
            view.Name = obj.Name;
            view.Key = obj.Key;
            view.Purpose = obj.Purpose;
            view.ObjectTypeId = obj.ObjectTypeId;
            view.IsEdit = true;
        }

        private void AddNewObject(object? sender, EventArgs e)
        {
            view.Name = "";
            view.IsEdit = false;
        }
    }
}
