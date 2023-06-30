using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace act.Models
{
    internal class ObjectTypeModel
    {
        private int id;
        private string name;
        private string purpose;

        [DisplayName("Id")]
        [AutoIncrement]
        public int Id { get { return id; } set { id = value; } }

        [DisplayName("Estado")]
        public string Name { get { return name; } set { name = value; } }

        [DisplayName("Propósito")]
        public string Purpose { get { return purpose; } set { purpose = value; } }
    }
}
