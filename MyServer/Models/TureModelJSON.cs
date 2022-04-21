using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyServer.Models
{
    public class TureModelJSON
    {
        public int id { get; set; }
        public String pbr { get; set; }
        public String stdort { get; set; }
        public int rb { get; set; }
        public String format { get; set; }
        public String ulica { get; set; }
        public String ulica2 { get; set; }
        public String akcija { get; set; }
        public String stara_akcija { get; set; }
        public String tura { get; set; }
        public String napomena { get; set; }
        public String datum { get; set; }
        public int odradeno { get; set; }
    }
}