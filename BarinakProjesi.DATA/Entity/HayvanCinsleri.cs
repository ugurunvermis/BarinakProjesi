using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BarinakProjesi.DATA.Context
{
    public class HayvanCinsleri
    {
        [Key]
        public int id { get; set; }

        [Display(Name = "Hayvanın Cinsi")]
        public string hayvan_cinsi { get; set; }

        [Display(Name = "Cinsin Genel Özellikleri")]
        public string cinsin_genel_ozellikleri { get; set; }

        [Display(Name = "Hayvan Türü")]
        public int hayvan_tur_id { get; set; }

        [ForeignKey("hayvan_tur_id")]
        public virtual HayvanTurleri hayvan_turu { get; set; }

        public virtual List<KayitliHayvanlar> kayitli_hayvanlar { get; set; }
    }
}
