using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using act.Models.Projects;

namespace act.Models.Roles
{
    internal class RoleModel
    {
        [Key]
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public string Key { get; set; }

        [MaxLength(15)]
        public string Name { get; set; }
        [MaxLength(70)]

        public virtual ProjectModel Project { get; set; }
        public string Purpose { get; set; }
    }
}
