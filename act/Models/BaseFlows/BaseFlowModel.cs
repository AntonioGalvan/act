using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace act.Models.BaseFlows
{
    internal class BaseFlowModel
    {
        [Key]
        public int Id { get; set; }

        public int ProjectId { get; set; }
        [MaxLength(6)]

        [DisplayName("Clave")]
        [Required(ErrorMessage = "La clave es requerida")]
        public string Key { get; set; }

        [MaxLength(15)]
        [DisplayName("Nombre")]
        [Required(ErrorMessage = "El nombre es requerido")]
        public string Name { get; set; }

        [DisplayName("Imagen")]
        public string FlowChartPath { get; set; }
        public int DiagramElementState { get; set; }
        public int ScreenElementState { get; set; }

        [Required(ErrorMessage = "El caso de uso es requerido")]
        public int useCaseId { get; set; }

        [DisplayName("Caso de uso")]
        public string useCaseName { get; set; }

        [DisplayName("Proyecto")]
        public string projectName { get; set; }
    }
}
