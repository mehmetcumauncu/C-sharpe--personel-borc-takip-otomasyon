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
    
    public partial class DBpersonel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DBpersonel()
        {
            this.DBgider = new HashSet<DBgider>();
            this.DBmusteri = new HashSet<DBmusteri>();
        }
    
        public int ID { get; set; }
        public string personelad { get; set; }
        public Nullable<int> personelprim { get; set; }
        public string personelmail { get; set; }
        public string personeliban { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DBgider> DBgider { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DBmusteri> DBmusteri { get; set; }
    }
}
