using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models
{
    public class BoxImage
    {
        [Key]
        public int ID { get; set; }
        [StringLength(500)]
        public string FileName { get; set; }
        public virtual int BoxID { get; set; }
        public virtual Box Box { get; set; }
    }
}
