using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BarinakProjesi.DATA.Context
{
    public class Cinsiyet
    {
        [Key]
        public int id { get; set; }

        [Display(Name = "Cinsiyet")]
        public string cinsiyet { get; set; }
        public virtual List<KayitliHayvanlar> hayvanlar { get; set; }
    }
}
