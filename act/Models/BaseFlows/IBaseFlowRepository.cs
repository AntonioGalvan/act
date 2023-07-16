using act.Models.Objects;
using act.Models.UseCases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace act.Models.BaseFlows
{
    internal interface IBaseFlowRepository
    {
        void Add(BaseFlowModel bFlowModel);
        void Edit(BaseFlowModel bFlowModel);
        void Delete(int id);

        bool Check(int id, int? useCaseId);

        //Listados
        IEnumerable<BaseFlowModel> GetAll();
        IEnumerable<UseCaseModel> GetAllUseCases(bool exclude, int? useCaseId);

        IEnumerable<BaseFlowModel> GetByValue(string value);
    }
}
