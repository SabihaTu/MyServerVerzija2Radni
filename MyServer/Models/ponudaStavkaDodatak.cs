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
    
    public partial class ponudaStavkaDodatak
    {
        public int ponudaStavkaDodatakId { get; set; }
        public Nullable<int> ponudaStavkeId { get; set; }
        public Nullable<int> trosakId { get; set; }
        public Nullable<System.DateTime> datumZahtjeva { get; set; }
        public Nullable<System.DateTime> datumRealizacije { get; set; }
        public Nullable<decimal> cijena { get; set; }
        public string opis { get; set; }
    
        public virtual ponudaStavke ponudaStavke { get; set; }
        public virtual trosak trosak { get; set; }
    }
}