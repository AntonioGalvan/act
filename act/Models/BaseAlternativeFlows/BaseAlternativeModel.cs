using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace act.Models.BaseAlternativeFlows
{
    internal class BaseAlternativeModel
    {
        [Key]
        public int Id { get; set; }

        public int ProjectId { get; set; }

        public int BaseFlowId { get; set; }

        public int AlternativeFlowId { get; set; }



        [DisplayName("Clave Flujo base")]
        public string baseFlowKey { get; set; }

        [DisplayName("Flujo base")]
        public string baseFlowName { get; set; }

        [DisplayName("Clave Flujo alterno")]
        public string alternativeFlowKey { get; set; }

        [DisplayName("Flujo alterno")]
        public string alternativeFlowName { get; set; }
    }
}
