﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyLayer.Concrete
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }
        [StringLength(100)]
        public string CategoryName { get; set; }
        [StringLength(300)]
        public string CategoryDescription { get; set; }
        
        public bool CategoryStatus { get; set; }


        public ICollection<Heading> Headings { get; set; }
    }
}
