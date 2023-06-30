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
    internal class ProjectModel
    {
        private int id;
        private string name;
        private string description;
        private DateTime startDate;
        private DateTime endDate;

        [DisplayName("Id")]
        [Required(ErrorMessage = "Id es requerido")]
        [AutoIncrement]
        [Key]
        public int Id { get { return id; } set {  id = value; } }

        [DisplayName("Nombre")]
        [Required(ErrorMessage = "El nombre es requerido")]
        public string Name { get { return name; } set { name = value; } }

        [DisplayName("Descripción")]
        [Required(ErrorMessage = "La descripción es requerida")]
        public string Description { get { return description; } set { description = value; } }

        [DisplayName("Fecha de inicio")]
        [Required(ErrorMessage = "La fecha de inicio es requerida")]
        public DateTime StartDate { get {  return startDate; } set { startDate = value; } }

        [DisplayName("Fecha de finalización")]
        [Required(ErrorMessage = "La fecha de finalización es requerida")]
        public DateTime EndDate { get {  return endDate; } set {  endDate = value; } }
    }
}
