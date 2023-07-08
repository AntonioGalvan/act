using act.Models.Roles;
using act.Views;

namespace act.Presenters
{
    internal class RolePresenter
    {
        private IRoleView view;
        private IRoleRepository repository;
        private BindingSource rolesBindingSource;
        private IEnumerable<RoleModel> roleList;

        public RolePresenter(IRoleView pView, IRoleRepository pRepository)
        {
            this.rolesBindingSource = new BindingSource();
            view = pView;
            repository = pRepository;

            this.view.SearchEvent += SearchRole;
            this.view.AddNewEvent += AddNewRole;
            this.view.EditEvent += LoadSelectedRoleToEdit;
            this.view.DeleteEvent += DeleteSelectedRole;
            this.view.SaveEvent += SaveRole;
            this.view.CancelEvent += CancelAction;

            this.view.SetProjectListBindingSource(rolesBindingSource);

            LoadAllRoleList();

            this.view.Show();
        }

        private void LoadAllRoleList()
        {
            roleList = repository.GetAll();
            rolesBindingSource.DataSource = roleList;
        }

        private void SearchRole(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
                roleList = repository.GetByValue(this.view.SearchValue);
            else roleList = repository.GetAll();
            rolesBindingSource.DataSource = roleList;
        }


        private void CancelAction(object? sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void SaveRole(object? sender, EventArgs e)
        {
            var model = new RoleModel();
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
                    view.Message = "Rol editado correctamente";
                }
                else
                {
                    repository.Add(model);
                    view.Message = "Rol agregado correctamente";
                }

                view.IsSuccessful = true;
                LoadAllRoleList();
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

        private void DeleteSelectedRole(object? sender, EventArgs e)
        {
            try
            {
                var role = (RoleModel)rolesBindingSource.Current;
                repository.Delete(role.Id);
                view.IsSuccessful = true;
                view.Message = "Rol eliminado correctamente";
                LoadAllRoleList();
            }
            catch (Exception ex)
            {

                view.IsSuccessful = false;
                view.Message = "Ha ocurrido un error, se pudo eliminar el rol";
            }
        }

        private void LoadSelectedRoleToEdit(object? sender, EventArgs e)
        {
            var role = (RoleModel)rolesBindingSource.Current;
            view.Id = role.Id.ToString();
            view.Name = role.Name;
            view.Key = role.Key;
            view.Purpose = role.Purpose;
            view.IsEdit = true;
        }

        private void AddNewRole(object? sender, EventArgs e)
        {
            view.Name = "";
            view.IsEdit = false;
        }
    }
}
