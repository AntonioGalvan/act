﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace act.Models.States
{
    internal class ObjectStateModel
    {
        [Key]
        public int Id { get; set; }
        public string Key { get; set; }
        public int ProyectId { get; set; }
        [MaxLength(15)]
        public string Name { get; set; }
        [MaxLength(70)]
        public string Purpose { get; set; }
    }
}
