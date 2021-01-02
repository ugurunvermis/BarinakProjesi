using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BarinakProjesi.DATA.Context
{
    public class CalismaSaatleri
    {
        [Key]
        public int id { get; set; }

        [Display(Name = "Gün")]
        public string gun { get; set; }

        [Display(Name = "Açık")]
        public bool durum { get; set; }

        [Display(Name = "Açılış Saati")]
        public string acilis_saati { get; set; }

        [Display(Name = "Kapanış Saait")]
        public string kapanis_saati { get; set; }

        [Display(Name = "Barınak")]
        public int barinak_id { get; set; }

        [ForeignKey("barinak_id")]
        public virtual BarinakBilgileri barinak { get; set; }
    }
}
