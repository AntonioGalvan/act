using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace act.Views
{
    internal interface IMainView
    {
        event EventHandler ShowRoleView;
        event EventHandler ShowRelationElementsView;
    }
}
