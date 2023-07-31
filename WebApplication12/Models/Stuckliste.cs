using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication12.Models
{
    [Table("WUP_Eigenfertigung_Child")]
    public class Stuckliste
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? id { get; set; }
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
        public int? Parentid { get; set; }
        public string Parent_Artikel { get; set; }
        public string column_change_flag { get; set; }
        public string column_change_value { get; set; }
        public string EinheitNr { get; set; }
        public string Z_Tarifschl_ssel { get; set; }
        public string Z_Ursprungsnachweis { get; set; }
        public DateTime? GeaendertAm { get; set; }
        public string Percentage_cal { get; set; }
        public string stuckliste { get; set; }
        public string zukauf { get; set; }
        public string Leistung { get; set; }
        public string p_cp_flag { get; set; }
    }
}