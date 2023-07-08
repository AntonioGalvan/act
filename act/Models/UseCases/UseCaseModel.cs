using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace act.Models.UseCases
{
    internal class UseCaseModel
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(6)]
        public string Key { get; set; }

        [MaxLength(15)]
        public string Name { get; set; }

        public string FlowChartPath { get; set; }
        public int DiagramElementState { get; set; }
        public int ScreenElementState { get; set; }
        public int ProjectId { get; set; }
    }
}
