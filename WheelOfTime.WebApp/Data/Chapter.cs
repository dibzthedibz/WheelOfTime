﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WheelOfTime.WebApp.Data
{
    public class Chapter
    {
        [Key]
        public int ChapterId { get; set; }

        [Required]
        public Guid OwnerId { get; set; }

        [Required]
        public int ChapNum { get; set; }

        [Required]
        public string ChapTitle { get; set; }

        [Required]
        public int PageCount { get; set; }
        public string BookIn { get; set; }

        public int? BookId { get; set; }

        [ForeignKey(nameof(BookId))]
        public virtual Book Book { get; set; }

        public int? CharacterId { get; set; }
        [ForeignKey(nameof(CharacterId))]
        public virtual Character Character { get; set; }

        public int? NationId { get; set; }
        [ForeignKey(nameof(NationId))]
        public virtual Nation Nation { get; set; }

        public virtual string Narrator { get; set; }
        public virtual string Location { get; set; }
    }
}
