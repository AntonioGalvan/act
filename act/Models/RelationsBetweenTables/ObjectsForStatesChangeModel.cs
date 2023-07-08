using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace act.Models.RelationsBetweenTables
{
    internal class ObjectsForStatesChangeModel
    {
        [MaxLength(8)]
        [Key]
        public int Id { get; set; }
        [MaxLength(8)]
        public int ProjectId { get; set; }

        [MaxLength(8)]
        public int ObjectsStatesChangeId { get; set; }
        [MaxLength(8)]
        public int ObjectId { get; set; }
    }
}
