//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Berk_MVC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Kategori
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Kategori()
        {
            this.Makales = new HashSet<Makale>();
        }
    
        public int katid { get; set; }
        public string KategoriAdi { get; set; }
        public string KategoriOzet { get; set; }
        public int KategoriSira { get; set; }
        public System.DateTime KategoriTarih { get; set; }
        public string KategoriResim { get; set; }
        public bool Aktif { get; set; }
        public bool sil { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Makale> Makales { get; set; }
    }
}
