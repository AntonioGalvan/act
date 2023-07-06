using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace act.Models
{
    [Table("Projects")]
    internal class ProjectModel
    {
        public int Id { get; set; }

        [DisplayName("Nombre")]
        [Required(ErrorMessage = "El nombre es requerido")]
        [MaxLength(15)]
        public string Name { get; set; }

        [DisplayName("Descripción")]
        [Required(ErrorMessage = "La descripción es requerida")]
        [MaxLength(40)]
        public string Description { get; set; }

        [DisplayName("Fecha de inicio")]
        [Required(ErrorMessage = "La fecha de inicio es requerida")]
        public DateTime StartDate { get; set; }

        [DisplayName("Fecha de finalización")]
        [Required(ErrorMessage = "La fecha de finalización es requerida")]
        public DateTime EndDate { get; set; }

        public virtual ICollection<RoleModel> Roles { get; set; }
        //public virtual ICollection<ScreenModel> Screens { get; set; }
        //public virtual ICollection<BusinessRuleModel> BusinessRules { get; set; }
        //public virtual ICollection<MessageModel> Messages { get; set; }
        //public virtual ICollection<BusinessRuleMessageModel> BusinessRuleMessages { get; set; }
        //public virtual ICollection<ReportModel> Reports { get; set; }
        //public virtual ICollection<UseCaseModel> UseCases { get; set; }
        //public virtual ICollection<BaseFlowModel> BaseFlows { get; set; }
        //public virtual ICollection<AlternativeFlowModel> AlternativeFlows { get; set; }
        //public virtual ICollection<ObjectStateModel> ObjectStates { get; set; }
        //public virtual ICollection<ObjectModel> Objects { get; set; }
        //public virtual ICollection<ObjectsWithStatesModel> ObjectsWithStates { get; set; }
        //public virtual ICollection<ObjectStatesChangeModel> ObjectStatesChanges { get; set; }
        //public virtual ICollection<ObjectsForStatesChangeModel> ObjectsForStatesChanges { get; set; }
        //public virtual ICollection<RolesForStatesChangeModel> RolesForStatesChanges { get; set; }
    }
}
