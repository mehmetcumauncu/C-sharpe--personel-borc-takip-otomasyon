//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace muhasebe_otomasyon.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class DBmusteri
    {
        public int ID { get; set; }
        public string adsoyad { get; set; }
        public string tc { get; set; }
        public string plaka { get; set; }
        public string belgerino { get; set; }
        public string iletisim { get; set; }
        public Nullable<int> personel { get; set; }
        public Nullable<int> urun { get; set; }
        public Nullable<System.DateTime> baslangictarih { get; set; }
        public Nullable<System.DateTime> bitistarih { get; set; }
        public Nullable<int> urunyuzde { get; set; }
        public Nullable<int> netprim { get; set; }
        public Nullable<int> brütprim { get; set; }
        public Nullable<int> kar { get; set; }
    
        public virtual DBpersonel DBpersonel { get; set; }
        public virtual DBurun DBurun { get; set; }
    }
}