using act.Models.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace act.Models.Screens
{
    internal interface IScreenRepository
    {
        void Add(ScreenModel projectModel);
        void Edit(ScreenModel projectModel);
        void Delete(int id);

        //Listados
        IEnumerable<ScreenModel> GetAll();

        //Busquedas
        IEnumerable<ScreenModel> GetByValue(string value);
    }
}
