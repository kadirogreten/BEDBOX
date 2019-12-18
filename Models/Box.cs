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

    public class BoxImage
    {
        [Key]
        public int ID { get; set; }
        [StringLength(500)]
        public string FileName { get; set; }
        public virtual int BoxID { get; set; }
        public virtual Box Box { get; set; }
    }

    public class Product
    {
        [Key]
        public int ID { get; set; }
        [StringLength(100)]
        public string Name { get; set; }
        public virtual Box Box { get; set; }
        public virtual int BoxID { get; set; }
    }

    public enum BoxType : byte
    {
        Free,
        Small,
        Medium,
        High,
        Premium
    }

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

    public enum AdressType : byte
    {
        Billing,
        Shipping
    }

    public enum Gender : byte
    {
        Man,
        Woman,
        UniSex,
        Pasif,
        Aktif,
        Lezbiyen,
        Tro
    }

    public class Adress
    {
        [Key]
        public int ID { get; set; }
        [StringLength(100)]
        public string Name { get; set; }
        [StringLength(250)]
        public string FullAdress { get; set; }
        public AdressType AdressType { get; set; }
        public virtual string UserId { get; set; }
        [StringLength(18)]
        public string Phone { get; set; }
        [StringLength(100)]
        public string Country { get; set; } = "Türkiye";
        [StringLength(100)]
        public string City { get; set; }
        [StringLength(100)]
        public string District { get; set; }
    }

    public enum OrderStatus:byte
    {
        [Description("Bekleniyor")]
        Bekleniyor = 0,
        [Description("Kargoya Verildi")]
        KargoyaVerildi = 1,
        [Description("Teslim Edildi")]
        TeslimEdildi = 2,
        [Description("İptal Edildi")]
        IptalEdildi = 3,
        [Description("İade Edildi")]
        IadeEdildi = 4
    }

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
    }
}
