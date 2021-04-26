﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyLayer.Concrete
{
    public class Writer
    {
        [Key]
        public int WriterID { get; set; }
        [StringLength(50)]
        public string WriterName { get; set; }
        [StringLength(50)]
        public string WriterSurname { get; set; }
        [StringLength(50)]
        public string WriterImage { get; set; }
        [StringLength(500)]
        public string WriterMail { get; set; }
        [StringLength(300)]
        public string WriterPassword { get; set; }
        [StringLength(50)]

        public ICollection<Heading> Headings { get; set; }
        public ICollection<Content> Contents { get; set; }


    }
}