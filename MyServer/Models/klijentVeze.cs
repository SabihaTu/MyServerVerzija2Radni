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
    
    public partial class klijentVeze
    {
        public int klijentVezaId { get; set; }
        public Nullable<int> klijentTipVezeId { get; set; }
        public Nullable<int> klijentId { get; set; }
        public Nullable<int> klijentVezaniId { get; set; }
        public Nullable<System.DateTime> pocetak { get; set; }
        public Nullable<System.DateTime> kraj { get; set; }
    
        public virtual klijent klijent { get; set; }
        public virtual klijent klijent1 { get; set; }
    }
}
