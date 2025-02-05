﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace act.Models.Reports
{
    internal class ReportModel
    {
        [MaxLength(8)]
        [Key]
        public int Id { get; set; }
        [MaxLength(8)]
        public int ProjectId { get; set; }
        [MaxLength(2)]
        public int Key { get; set; }

        [MaxLength(15)]
        public string Name { get; set; }
        [MaxLength(40)]
        public string Description { get; set; }
        public int DiagramElementState { get; set; }
        public int ScreenElementState { get; set; }
    }
}
