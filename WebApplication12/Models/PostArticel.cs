using System.Collections.Generic;

namespace WebApplication12.Models
{
    public class PostArtikel
    {
        public string Artikel { get; set; }
        public string kundenname { get; set; }
        public string Strasse { get; set; }
        public string Bezeichnung { get; set; }
        public string Adresse1 { get; set; }
        public string Adresse2 { get; set; }
        public string Adresse3 { get; set; }
        public string PLZ { get; set; }
        public string Ort { get; set; }
        public string Land { get; set; }
        public string Auftragsnummer { get; set; }
        public float? Verkaufspreis { get; set; }
        public string WaehrungNr { get; set; }
        public string Einheit{ get; set; }
        public string Zolltarifnummer { get; set; }
        public List <PostStuckliste> Stucklisten { get; set; }
        public bool validate()
        {
            return (
                this.Artikel != null && 
                this.Bezeichnung != null && 
                this.kundenname != null && 
                this.Land != null && 
                this.Auftragsnummer != null && 
                this.Verkaufspreis != null && 
                this.WaehrungNr != null && 
                this.Einheit !=null && 
                this.Zolltarifnummer != null);
        }
}
}