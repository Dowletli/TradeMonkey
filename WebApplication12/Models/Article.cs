using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication12.Models
{
    [Table("WUP_Eigenfertigung")]
    public class Article
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? Id { get; set; }
        public string Mantantid { get; set; }
        public string partlist { get; set; }
        public float? Anzahl { get; set; }
        public string Artikel { get; set; }
        public string Bezeichnung { get; set; }
        public float? Einkaufspreis { get; set; }
        public float? EinkaufspreisTotal { get; set; }
        public float? Einstandspreis { get; set; }
        public float? EinstandspreisTotal { get; set; }
        public string Lieferant { get; set; }
        public string Ursprungsland { get; set; }
        public string Praferenz { get; set; }
        public string Zolltarifnummer { get; set; }
        public float? Verkaufspreis { get; set; }
        public string createdBy { get; set; }
        public DateTime? createdOn { get; set; }
        public string updatedBy { get; set; }
        public DateTime? updatedOn { get; set; }
        public string P_nein { get; set; }
        public string P_gepr { get; set; }
        public string column_change_flag { get; set; }
        public string column_change_value { get; set; }
        public string TarifNr { get; set; }
        public string Tarifschlussel { get; set; }
        public DateTime? GeaendertAm { get; set; }
        public string kundenname { get; set; }
        public string land { get; set; }
        public string internal_search_id { get; set; }
        public string LS { get; set; }
        public string preis_Stk_CHF { get; set; }
        public string WaehrungNr { get; set; }
        public string Einheit { get; set; }
        public string stuckliste { get; set; }
        public string zukauf { get; set; }
        public string Leistung { get; set; }
        public string version { get; set; }
        public DateTime? orderdate { get; set; }
        public string verkaufspreis_chf { get; set; }
        public string tick_status { get; set; }
        public int? versender_ref_id { get; set; }
    }
}