using System;
using System.Collections.Generic;
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
    }
}
