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
    
    public partial class porukaSistemska
    {
        public int porukaSistemskaId { get; set; }
        public Nullable<int> zaposleniId { get; set; }
        public Nullable<System.DateTime> vrijeme { get; set; }
        public string sadrzaj { get; set; }
        public Nullable<bool> isPoslano { get; set; }
        public Nullable<int> ponudaId { get; set; }
        public string putanja { get; set; }
        public string putanjaUvjeti { get; set; }
        public Nullable<bool> isAccount { get; set; }
        public Nullable<int> radniNalogId { get; set; }
    
        public virtual ponuda ponuda { get; set; }
        public virtual radniNalog radniNalog { get; set; }
        public virtual zaposleni zaposleni { get; set; }
    }
}
