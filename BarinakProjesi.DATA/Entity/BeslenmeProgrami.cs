using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BarinakProjesi.DATA.Context
{
    public class BeslenmeProgrami
    {
        [Key]
        public int id { get; set; }
        [Display(Name ="Beslenme Programı Adı")]
        public string beslenme_programi_adi { get; set; }

        [Display(Name = "Sabah Öğün")]
        public string sabah { get; set; }

        [Display(Name = "Öğle Öğün")]
        public string ogle { get; set; }

        [Display(Name = "Akşam Öğün")]
        public string aksam { get; set; }

        [Display(Name = "Gece Öğün")]
        public string gece { get; set; }
        public virtual List<KayitliHayvanlar> hayvanlar { get; set; }
    }
}
