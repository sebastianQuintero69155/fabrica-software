﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName ="varchar(100)")]
        public string Name { get; set; }
        [Column(TypeName = "varchar(100)")]
        public string Category { get; set;  }
        [Column(TypeName = "varchar(100)")]
        public int Price { get; set; }
    }
}
