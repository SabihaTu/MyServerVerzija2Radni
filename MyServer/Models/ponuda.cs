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
    
    public partial class ponuda
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ponuda()
        {
            this.faktura = new HashSet<faktura>();
            this.link = new HashSet<link>();
            this.ponudaKontakt = new HashSet<ponudaKontakt>();
            this.ponudaStavke = new HashSet<ponudaStavke>();
            this.porukaSistemska = new HashSet<porukaSistemska>();
        }
    
        public int ponudaId { get; set; }
        public Nullable<int> brojZahtjeva { get; set; }
        public Nullable<int> poolId { get; set; }
        public Nullable<int> agencijaId { get; set; }
        public Nullable<int> klijentId { get; set; }
        public Nullable<int> podklijentId { get; set; }
        public Nullable<System.DateTime> datumZahtjeva { get; set; }
        public Nullable<int> plakatTipId { get; set; }
        public string kampanja { get; set; }
        public Nullable<bool> isDatumska { get; set; }
        public Nullable<System.DateTime> pocetakKampanje { get; set; }
        public Nullable<int> trajanjeKampanje { get; set; }
        public Nullable<int> budzetKampanje { get; set; }
        public Nullable<decimal> rabat { get; set; }
        public Nullable<int> ponudaStatusId { get; set; }
        public string brojPonude { get; set; }
        public Nullable<System.DateTime> datumPonude { get; set; }
        public Nullable<int> brojDanaVazenjaPonude { get; set; }
        public string protokol { get; set; }
        public Nullable<System.DateTime> datumOtkazivanja { get; set; }
        public Nullable<int> brojDanaOtk { get; set; }
        public Nullable<System.DateTime> datumSlanja { get; set; }
        public Nullable<bool> isParcijalnoPlacanje { get; set; }
        public Nullable<int> rokPlacanja { get; set; }
        public Nullable<System.DateTime> krajKampanje { get; set; }
        public Nullable<int> trajanjeKampanjeId { get; set; }
        public Nullable<bool> isMreza { get; set; }
        public Nullable<int> zaposleniId { get; set; }
        public Nullable<int> accountManagerId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<faktura> faktura { get; set; }
        public virtual klijent klijent { get; set; }
        public virtual klijent klijent1 { get; set; }
        public virtual klijent klijent2 { get; set; }
        public virtual klijent klijent3 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<link> link { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ponudaKontakt> ponudaKontakt { get; set; }
        public virtual zaposleni zaposleni { get; set; }
        public virtual zaposleni zaposleni1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ponudaStavke> ponudaStavke { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<porukaSistemska> porukaSistemska { get; set; }
    }
}