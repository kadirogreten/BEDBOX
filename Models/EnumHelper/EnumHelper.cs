using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Models
{
    public enum BoxType : byte
    {
        Free,
        Small,
        Medium,
        High,
        Premium
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
        None
    }

    public enum OrderStatus : byte
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
}
