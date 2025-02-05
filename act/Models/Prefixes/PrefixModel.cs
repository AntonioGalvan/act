﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace act.Models.Prefixes
{
    internal class PrefixModel
    {
        [MaxLength(8)]
        [Key]
        public int Id { get; set; }

        [MaxLength(3)]
        public string Name { get; set; }
    }
}
