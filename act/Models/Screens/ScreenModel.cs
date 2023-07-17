using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using act.Models.Projects;

namespace act.Models.Screens
{
    internal class ScreenModel
    {
        [Key]
        public int Id { get; set; }
        public int ProjectId { get; set; }
        [MaxLength(6)]
        [DisplayName("Clave")]
        [Required(ErrorMessage = "La clave es requerida")]
        public string Key { get; set; }
        [MaxLength(15)]
        [DisplayName("Nombre")]
        [Required(ErrorMessage = "El nombre es requerido")]
        public string Name { get; set; }
        [DisplayName("Ubicación de imagen")]
        public string ImagePath { get; set; }
        public int DiagramElementState { get; set; }
        public int ScreenElementState { get; set; }
        [DisplayName("Proyecto")]
        public string Project { get; set; }
        //public Image Picture { get; set; }
    }
}
