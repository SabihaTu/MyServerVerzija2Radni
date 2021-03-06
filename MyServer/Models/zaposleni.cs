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
    
    public partial class zaposleni
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public zaposleni()
        {
            this.plakat = new HashSet<plakat>();
            this.ponuda = new HashSet<ponuda>();
            this.ponuda1 = new HashSet<ponuda>();
            this.ponudaStavke = new HashSet<ponudaStavke>();
            this.porukaSistemska = new HashSet<porukaSistemska>();
            this.radniNalogStavke = new HashSet<radniNalogStavke>();
            this.turaSedmicaZaposleni = new HashSet<turaSedmicaZaposleni>();
            this.ugovor = new HashSet<ugovor>();
            this.ugovorStavke = new HashSet<ugovorStavke>();
        }
    
        public int zaposleniId { get; set; }
        public string ime { get; set; }
        public string prezime { get; set; }
        public string jmb { get; set; }
        public Nullable<System.DateTime> datumZaposlenja { get; set; }
        public Nullable<System.DateTime> datumKrajaZaposlenja { get; set; }
        public string telefon { get; set; }
        public string eMail { get; set; }
        public string posta { get; set; }
        public Nullable<int> mjestoId { get; set; }
        public string aspNetUserId { get; set; }
        public Nullable<bool> aktivan { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<plakat> plakat { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ponuda> ponuda { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ponuda> ponuda1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ponudaStavke> ponudaStavke { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<porukaSistemska> porukaSistemska { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<radniNalogStavke> radniNalogStavke { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<turaSedmicaZaposleni> turaSedmicaZaposleni { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ugovor> ugovor { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ugovorStavke> ugovorStavke { get; set; }
    }
}
