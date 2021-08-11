﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WheelOfTime.WebApp.Models.BookMods
{
    public class BookCreate
    {
        [Required]
        public string Title { get; set; }

        [Required]
        public int PageCount { get; set; }
    }
}
