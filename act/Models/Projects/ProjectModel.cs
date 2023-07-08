using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace act.Models.Projects
{
    [Table("Projects")]
    internal class ProjectModel
    {
        public int Id { get; set; }

        [DisplayName("Nombre")]
        [Required(ErrorMessage = "El nombre es requerido")]
        [MaxLength(15)]
        public string Name { get; set; }

        [DisplayName("Descripción")]
        [Required(ErrorMessage = "La descripción es requerida")]
        [MaxLength(40)]
        public string Description { get; set; }

        [DisplayName("Fecha de inicio")]
        [Required(ErrorMessage = "La fecha de inicio es requerida")]
        public DateTime StartDate { get; set; }

        [DisplayName("Fecha de finalización")]
        [Required(ErrorMessage = "La fecha de finalización es requerida")]
        public DateTime EndDate { get; set; }

    }
}
