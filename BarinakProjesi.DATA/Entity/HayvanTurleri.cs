using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BarinakProjesi.DATA.Context
{
    public class HayvanTurleri
    {
        [Key]
        public int id { get; set; }

        [Display(Name = "Hayvan Türü")]
        public string hayvan_turu { get; set; }

        public virtual List<HayvanCinsleri> hayvan_cinsleri { get; set; }
    }
}
