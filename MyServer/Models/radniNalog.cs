//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyServer.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class radniNalog
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public radniNalog()
        {
            this.link = new HashSet<link>();
            this.porukaSistemska = new HashSet<porukaSistemska>();
            this.radniNalogStavke = new HashSet<radniNalogStavke>();
        }
    
        public int radniNalogId { get; set; }
        public Nullable<System.DateTime> datum { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<link> link { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<porukaSistemska> porukaSistemska { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<radniNalogStavke> radniNalogStavke { get; set; }
    }
}
