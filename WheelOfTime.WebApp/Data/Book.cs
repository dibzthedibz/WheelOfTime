using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WheelOfTime.WebApp.Data
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }
    }
}
