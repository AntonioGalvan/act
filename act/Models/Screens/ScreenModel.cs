using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using act.Models.Projects;

namespace act.Models.Screens
{
    internal class ScreenModel
    {
        [Key]
        public int Id { get; set; }
        public int ProjectId { get; set; }
        [MaxLength(6)]
        public string Key { get; set; }
        [MaxLength(15)]
        public string Name { get; set; }
        public int DiagramElementState { get; set; }
        public int ScreenElementState { get; set; }
        [DisplayName("Ubicación de imagen")]
        public string ImagePath { get; set; }

        public virtual ProjectModel Project { get; set; }
    }
}
