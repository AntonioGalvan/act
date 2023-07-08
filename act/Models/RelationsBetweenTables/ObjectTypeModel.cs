using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace act.Models.RelationsBetweenTables
{
    internal class ObjectTypeModel
    {
        [MaxLength(8)]
        [Key]
        public int Id { get; set; }

        [MaxLength(15)]
        public string Name { get; set; }

        [MaxLength(70)]
        public string Purpose { get; set; }
    }
}
