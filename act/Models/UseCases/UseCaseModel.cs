using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        [DisplayName("Clave")]
        [Required(ErrorMessage = "La clave es requerida")]
        public string Key { get; set; }

        [MaxLength(15)]
        [DisplayName("Nombre")]
        [Required(ErrorMessage = "El nombre es requerido")]
        public string Name { get; set; }

        [DisplayName("Descripción")]
        public string FlowChartPath { get; set; }
        public int DiagramElementState { get; set; }
        public int ScreenElementState { get; set; }
        public int ProjectId { get; set; }
    }
}
