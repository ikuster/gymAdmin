//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace gymAdmin
{
    using System;
    using System.Collections.Generic;
    
    public partial class Mjerenje
    {
        public int Id_Mjerenje { get; set; }
        public double Visina { get; set; }
        public double Tezina { get; set; }
        public System.DateTime Datum_mjerenja { get; set; }
        public int Id_Klijent { get; set; }
        public double Mast { get; set; }
    
        public virtual Klijent Klijent { get; set; }
    }
}
