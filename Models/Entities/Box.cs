using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models
{
    public class Box
    {
        [Key]
        public int ID { get; set; }
        [StringLength(100)]
        public string Name { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime? UpdatedTime { get; set; }
        public decimal Price { get; set; }
        public decimal PaidPrice { get; set; }
        public int Stock { get; set; }
        public BoxType BoxType { get; set; }
        public virtual Category Category { get; set; }
        public virtual int CategoryID { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<BoxImage> BoxImages { get; set; }
    }

}
