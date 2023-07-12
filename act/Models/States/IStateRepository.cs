using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace act.Models.States
{
    internal interface IStateRepository
    {
        void Add(ObjectStateModel stateModel);
        void Edit(ObjectStateModel stateModel);
        void Delete(int id);

        //Listados
        IEnumerable<ObjectStateModel> GetAll();

        //Busquedas
        IEnumerable<ObjectStateModel> GetByValue(string value);
    }
}
