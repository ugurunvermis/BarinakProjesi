using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BarinakProjesi.DATA.Context
{
    public class SahiplenmeBasvuruDurumlari
    {
        [Key]
        public int id { get; set; }

        [Display(Name ="Sahiplenme Başvuru Durumu")]
        public string durum { get; set; }
        public virtual List<SahiplenmeTalepleri> talepler { get; set; }
    }
}
