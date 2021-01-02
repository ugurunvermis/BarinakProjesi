using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BarinakProjesi.DATA.Context
{
    public class SaglikDurumu
    {
        [Key]
        public int id { get; set; }

        [Display(Name="Sağlık Durumu")]
        public bool durum { get; set; } //true sağlıklı -- false hasta
        public virtual List<KayitliHayvanlar> hayvanlar { get; set; }
    }
}