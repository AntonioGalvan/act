using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace act.Models.Objects
{
    internal interface IObjectTypeRepository
    {
       //Listados
        IEnumerable<ObjectTypeModel> GetAll();

    }
}
