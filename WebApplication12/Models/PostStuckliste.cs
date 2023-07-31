using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication12.Models
{
    public class PostStuckliste
    {
        public int? Positionsnummer { get; set; }
        public string Artikel_S { get; set; }
        public string Bezeichnung_S { get; set; }
        public int? Anzahl { get; set; }
        public string Zolltarifnummer_S { get; set; }
        public int? Einkaufspreis_S { get; set; }
        public int? Waehrung { get; set; }
        public string Einheit { get; set; }
        public string Lieferant { get; set; }
        public string Ursprungsland { get; set; }
        public string Praf_S { get; set; }
    }
}