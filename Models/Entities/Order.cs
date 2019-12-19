using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models
{
    public class Order
    {
        [Key]
        public int ID { get; set; }
        public DateTime OrderedTime { get; set; }
        [StringLength(250)]
        public string ErrorMessage { get; set; }
        public decimal Price { get; set; }
        public decimal PaidPrice { get; set; }
        [StringLength(250)]
        public string TransactionID { get; set; }
        public OrderStatus Status { get; set; }
        public virtual Box Box { get; set; }
        public virtual int BoxID { get; set; }
        public virtual string UserId { get; set; }
        public virtual BedBoxUser BedBoxUser { get; set; }
    }
}
