using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Web;

namespace MyServer.Models
{

    public class TuraSedmicaZapJSON
    {      
        //public String status { get; set; }
        //public String method { get; set; }

        public int slikaCount { get; set; }

        public String datumId { get; set; }

        public int tura { get; set; }


        public static explicit operator TuraSedmicaZapJSON(ObjectResult<TuraSedmicaZapJSON> v)
        {
            throw new NotImplementedException();
        }
        //public string tura { get; set; }
        //public string posta { get; set; }
        //public string tumjestora { get; set; }
        //public string ulica { get; set; }
        //public string Format { get; set; }
        //public string akcija { get; set; }
        //public string Napomena { get; set; }
        //public int plakatId { get; set; }
        //public int redniBroj { get; set; }

    }
}