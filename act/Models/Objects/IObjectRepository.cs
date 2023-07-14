using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace act.Models.Objects
{
    internal interface IObjectRepository
    {
        void Add(ObjectModel projectModel);
        void Edit(ObjectModel projectModel);
        void Delete(int id);

        //Listados
        IEnumerable<ObjectModel> GetAll();
        IEnumerable<ObjectTypeModel> GetAllTypes();

        //Busquedas
        IEnumerable<ObjectModel> GetByValue(string value);
    }
}
