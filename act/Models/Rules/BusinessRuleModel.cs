using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace act.Models.Rules
{
    internal class BusinessRuleModel
    {
        [Key]
        public int Id { get; set; }
        public int ProjectId { get; set; }
        [MaxLength(6)]
        [DisplayName("Clave")]
        [Required(ErrorMessage = "La clave es requerida")]
        public string Key { get; set; }
        [MaxLength(50)]
        [DisplayName("Descripción")]
        [Required(ErrorMessage = "La descripción es requerida")]
        public string Description { get; set; }
        public int DiagramElementState { get; set; }
        public int ScreenElementState { get; set; }

        [DisplayName("Proyecto")]
        public string Project { get; set; }
    }
}
