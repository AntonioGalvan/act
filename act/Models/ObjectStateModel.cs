using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace act.Models
{
    internal class ObjectStateModel
    {
        [Key]
        [MaxLength(8)]
        public int Id { get; set; }
        [MaxLength(2)]
        public int Key { get; set; }
        [MaxLength(8)]
        public int ProyectId { get; set; }
        [MaxLength(15)]
        public string Name { get; set; }
        [MaxLength(70)]
        public string Purpose { get; set; }
    }
}
