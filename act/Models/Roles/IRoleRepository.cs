namespace act.Models.Roles
{
    internal interface IRoleRepository
    {
        void Add(RoleModel projectModel);
        void Edit(RoleModel projectModel);
        void Delete(int id);

        //Listados
        IEnumerable<RoleModel> GetAll();

        //Busquedas
        IEnumerable<RoleModel> GetByValue(string value);
    }
}
