using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace act.Models
{
    internal interface IProjectRepository
    {
        void Add(ProjectModel projectModel);
        void Edit(ProjectModel projectModel);
        void Delete(int id);

        //Listados
        IEnumerable<ProjectModel> GetAll();

        //Busquedas
        IEnumerable<ProjectModel> GetByValue();
    }
}
