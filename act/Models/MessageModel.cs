using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace act.Models
{
    internal class MessageModel
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(6)]
        public string Key { get; set; }
        [MaxLength(40)]
        public string Description { get; set; }
        public int ProjectId { get; set; }
    }
}
