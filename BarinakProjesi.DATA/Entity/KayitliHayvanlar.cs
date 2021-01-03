using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BarinakProjesi.DATA.Context
{
    public class KayitliHayvanlar
    {
        [Key]
        public int id { get; set; }

        [Display(Name = "Adı")]
        public string adi { get; set; }

        [Display(Name = "Yaş (Ay Cinsinden)")]
        public int yas_ay { get; set; }

        [Display(Name = "Hakkında")]
        public string hakkinda { get; set; }

        [Display(Name = "Sahiplenebilirlik Durumu")]
        public bool sahiplenebilirlik_durumu { get; set; }

        [Display(Name = "Sağlık Durumu")]
        public bool saglik_durumu { get; set; }

        [Display(Name = "Cinsiyeti")]
        public int cinsiyet_id { get; set; }

        [Display(Name = "Cinsi")]
        public int cins_id { get; set; }

        [Display(Name = "Beslenme Programı")]
        public int beslenme_programi_id { get; set; }

        [ForeignKey("cins_id")]
        public virtual HayvanCinsleri cinsi { get; set; }

        [ForeignKey("cinsiyet_id")]
        public virtual Cinsiyet cinsiyeti { get; set; }

        [ForeignKey("beslenme_programi_id")]
        public virtual BeslenmeProgrami beslenme_programi { get; set; }
        public virtual List<SahiplenmeTalepleri> sahiplenme_basvurulari { get; set; }
        public virtual List<HayvanFotograflari> fotograflari { get; set; }
        public virtual List<Asi> asi { get; set; }
    }
}
