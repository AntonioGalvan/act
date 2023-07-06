using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace act.Models
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
