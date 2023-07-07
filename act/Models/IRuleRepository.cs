using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace act.Models
{
    internal interface IRuleRepository
    {
        void Add(BusinessRuleModel projectModel);
        void Edit(BusinessRuleModel projectModel);
        void Delete(int id);

        //Listados
        IEnumerable<BusinessRuleModel> GetAll();

        //Busquedas
        IEnumerable<BusinessRuleModel> GetByValue(string value);
    }
}
