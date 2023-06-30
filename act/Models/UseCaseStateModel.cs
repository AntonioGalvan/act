using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using SQLite;

namespace act.Models
{
    internal class ElementStateModel
    {
        private int id;
        private string name;

        [DisplayName("Id")]
        [AutoIncrement]
        public int Id { get { return id; } set {  id = value; } }

        [DisplayName("Estado")]
        public string Name { get { return name; } set { name = value; } }
    }
}
