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
    
    public partial class getPlakatiRegijaTipPeriod_Result
    {
        public int plakatId { get; set; }
        public Nullable<System.DateTime> pocetakKampanje { get; set; }
        public Nullable<System.DateTime> krajKampanje { get; set; }
        public int isSlobodan { get; set; }
        public Nullable<int> ponudaId { get; set; }
        public Nullable<System.DateTime> zauzetoOd { get; set; }
        public Nullable<System.DateTime> zauzetoDo { get; set; }
        public Nullable<int> plakatTipId { get; set; }
        public string plakatTip { get; set; }
        public string plakatOznaka { get; set; }
        public int plakatId1 { get; set; }
        public Nullable<int> inventarniBroj { get; set; }
        public string Regija { get; set; }
        public string regijaOznaka { get; set; }
        public string mjesto { get; set; }
        public string adresa { get; set; }
        public Nullable<bool> isOsvjetljen { get; set; }
        public Nullable<bool> isDvostrano { get; set; }
        public string klijent { get; set; }
    }
}