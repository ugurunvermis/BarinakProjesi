using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BarinakProjesi.DATA.Context
{
    public class BarinakBilgileri
    {
        [Key]
        public int id { get; set; }

        [Display(Name = "Barınak Adı")]
        public string barinak_adi { get; set; }

        [Display(Name = "Barınak Hakkında")]
        public string barinak_hakkinda { get; set; }

        [Display(Name = "E-Posta Adresi")]
        public string eposta { get; set; }

        [Display(Name = "Telefon Numarası")]
        public string telefon_numarasi { get; set; }

        [Display(Name = "İl")]
        public string il { get; set; }

        [Display(Name = "İlçe")]
        public string ilce { get; set; }

        [Display(Name = "Mahalle")]
        public string mahalle { get; set; }

        [Display(Name = "Adres")]
        public string adres { get; set; }
        public virtual List<CalismaSaatleri> calisma_saatleri { get; set; }
    }
}
