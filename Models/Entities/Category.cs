using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models
{
    public class Category
    {
        [Key]
        public int ID { get; set; }
        [StringLength(100)]
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public int Row { get; set; }
        public virtual ICollection<Box> Boxes { get; set; }
    }
}
