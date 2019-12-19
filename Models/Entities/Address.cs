using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models
{
    public class Address
    {
        [Key]
        public int ID { get; set; }
        [StringLength(100)]
        public string Name { get; set; }
        [StringLength(250)]
        public string FullAdress { get; set; }
        public AdressType AdressType { get; set; }
        public virtual string UserId { get; set; }
        public virtual BedBoxUser BedBoxUser { get; set; }
        [StringLength(18)]
        public string Phone { get; set; }
        [StringLength(100)]
        public string Country { get; set; } = "Türkiye";
        [StringLength(100)]
        public string City { get; set; }
        [StringLength(100)]
        public string District { get; set; }
    }
}
