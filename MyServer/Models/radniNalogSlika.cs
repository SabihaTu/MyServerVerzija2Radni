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
    
    public partial class radniNalogSlika
    {
        public int radniNalogSlikaId { get; set; }
        public Nullable<int> radniNalogStavkaId { get; set; }
        public byte[] slika { get; set; }
    
        public virtual radniNalogStavke radniNalogStavke { get; set; }
    }
}
