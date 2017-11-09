﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EnigmaShop.Areas.Admin.Models
{
    public class Size
    {
        public int Id { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        public int Sorting { get; set; }


    }
}
