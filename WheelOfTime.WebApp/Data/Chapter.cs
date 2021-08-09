using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WheelOfTime.WebApp.Data
{
    public class Chapter
    {
        [Key]
        public int ChapterId { get; set; }
    }
}
