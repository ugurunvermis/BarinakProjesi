using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BarinakProjesi.DATA.Context
{
    public class SahiplenebilirlikDurumu
    {
        [Key
            ]
        public int id { get; set; }

        [Display(Name ="Sahiplenebilirlik Durumu")]
        public bool durum { get; set; }
        public virtual List<KayitliHayvanlar> hayvanlar { get; set; }
    }
}