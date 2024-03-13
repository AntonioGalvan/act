using act.Models.BaseFlows;
using act.Models.UseCases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace act.Models.AlternativeFlows
{
    internal interface IAlternativeFlowRepository
    {
        void Add(AlternativeFlowModel aFlowModel);
        void Edit(AlternativeFlowModel aFlowModel);
        void Delete(int id);

        //Listados
        IEnumerable<AlternativeFlowModel> GetAll();

        IEnumerable<AlternativeFlowModel> GetByValue(string value);
    }
}
