using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace act.Models.RelationsBetweenTables
{
    internal class UseCaseStateModel
    {

        [MaxLength(1)]
        [Key]
        public int Id { get; set; }

        [MaxLength(15)]
        public string Name { get; set; }
    }
}
