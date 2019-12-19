using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models
{
    public class Product
    {
        [Key]
        public int ID { get; set; }
        [StringLength(100)]
        public string Name { get; set; }
        public virtual Box Box { get; set; }
        public virtual int BoxID { get; set; }
    }
}
