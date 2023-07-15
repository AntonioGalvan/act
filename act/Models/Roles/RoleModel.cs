using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace act.Models.Roles
{
    internal class RoleModel
    {
        [Key]
        public int Id { get; set; }

        public int ProjectId { get; set; }

        [DisplayName("Clave")]
        [Required(ErrorMessage = "La clave es requerida")]
        public string Key { get; set; }

        [DisplayName("Nombre")]
        [Required(ErrorMessage = "El nombre es requerido")]
        [MaxLength(15)]
        public string Name { get; set; }

        [DisplayName("Propósito")]
        [Required(ErrorMessage = "El propósito es requerido")]
        [MaxLength(70)]
        public string Purpose { get; set; }

        [DisplayName("Proyecto")]
        public string Project { get; set; }
    }
}
