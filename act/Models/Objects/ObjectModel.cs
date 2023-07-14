using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace act.Models.Objects
{
    internal class ObjectModel
    {
        [Key]
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        [DisplayName("Clave")]
        public string Key { get; set; }

        [DisplayName("Nombre")]
        [MaxLength(15)]
        public string Name { get; set; }
        [DisplayName("Propósito")]
        [MaxLength(70)]
        public string Purpose { get; set; }
        public int ObjectTypeId { get; set; }
        [DisplayName("Tipo de objeto")]
        public string ObjectTypeName { get; set; }
        public int DiagramElementState { get; set; }
        public int ScreenElementState { get; set; }
    }
}
