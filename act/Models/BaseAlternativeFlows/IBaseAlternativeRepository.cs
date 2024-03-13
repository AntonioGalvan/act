using act.Models.AlternativeFlows;
using act.Models.BaseFlows;
using act.Models.UseCases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace act.Models.BaseAlternativeFlows
{
    internal interface IBaseAlternativeRepository
    {
        void Add(BaseAlternativeModel bFlowModel);
        void Delete(int id);

        //Listados
        IEnumerable<BaseAlternativeModel> GetAll();
        IEnumerable<BaseAlternativeModel> GetByValue(string value);
        IEnumerable<AlternativeFlowModel> GetAllAlternativeFlows();
    }
}
