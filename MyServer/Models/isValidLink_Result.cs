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
    
    public partial class isValidLink_Result
    {
        public int linkId { get; set; }
        public string naziv { get; set; }
        public Nullable<System.DateTime> datumOd { get; set; }
        public Nullable<System.DateTime> datumDo { get; set; }
        public string sifra { get; set; }
        public Nullable<int> ponudaId { get; set; }
        public Nullable<int> radniNalogId { get; set; }
    }
}
