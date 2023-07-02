using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace act.Models
{
    internal class ScreenModel
    {
        private int id;
        private int projectId;
        private int key;

        private string name;
        private int diagramElementState;
        private int screenElementState;
        private string imagePath;

        private ProjectModel projectModel;

        [DisplayName("Id")]
        [AutoIncrement]
        public int Id { get { return id; } set { id = value; } }

        [DisplayName("Id de proyecto")]
        [ForeignKey("Project")]
        public int ProjectId { get { return projectId; } set { projectId = value; } }


        [DisplayName("Estado")]
        public string Name { get { return name; } set { name = value; } }
    }
}
