﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ERocks.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public String Name { get; set; }
        [Display(Name="Display Order")]
        [Required]
        [Range(1,int.MaxValue,ErrorMessage ="Display Order for category must be greater than 0")]
        public int DisplayOrder { get; set; }
    }
}
