//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Report
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public string Key { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int DiagramElementStateId { get; set; }
        public int ScreenElementStateId { get; set; }
    
        public virtual Project Project { get; set; }
        public virtual ElementState DiagramElementState { get; set; }
        public virtual ElementState ScreenElementState { get; set; }
    }
}
