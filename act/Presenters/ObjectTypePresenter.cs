using act.Models.Objects;
using act.Views;

namespace act.Presenters
{
    internal class ObjectTypePresenter
    {
        private IObjectTypeView view;
        private IObjectTypeRepository repository;
        private BindingSource typeBindingSource;
        private IEnumerable<ObjectTypeModel> typeList;

        public ObjectTypePresenter(IObjectTypeView pView, IObjectTypeRepository pRepository)
        {
            this.typeBindingSource = new BindingSource();
            view = pView;
            repository = pRepository;

            this.view.SetProjectListBindingSource(typeBindingSource);

            LoadAllObjectTypeList();

            this.view.Show();
        }

        private void LoadAllObjectTypeList()
        {
            typeList = repository.GetAll();
            typeBindingSource.DataSource = typeList;
        }

    }
}
