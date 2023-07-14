using act.Models.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace act.Models.BaseFlows
{
    internal interface IBaseFlowsRRepository
    {
        void Add(BaseFlowModel bFlowModel);
        void Edit(BaseFlowModel bFlowModel);
        void Delete(int id);

        bool Check();

        //Listados
        IEnumerable<BaseFlowModel> GetAll();

    }
}
