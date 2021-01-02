using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BarinakProjesi.DATA.Context
{
    public class Kullanicilar
    {
        [Key]
        public int id { get; set; }

        [Display(Name = "Adı")]
        public string ad { get; set; }

        [Display(Name = "Soyadı")]
        public string soyad { get; set; }

        [Display(Name = "Telefon Numarası")]
        public string telefon { get; set; }

        [Display(Name = "E-Posta Adresi")]
        public string eposta { get; set; }

        [Display(Name = "Şifre")]
        public string sifre { get; set; }

        [Display(Name = "İl")]
        public string il { get; set; }

        [Display(Name = "İlçe")]
        public string ilce { get; set; }

        [Display(Name = "Mahalle")]
        public string mahalle { get; set; }

        [Display(Name = "Adres")]
        public string adres { get; set; }

        [Display(Name = "Kullanıcı Yetkisi")]
        public int kullanici_rol_id { get; set; }

        [ForeignKey("kullanici_rol_id")]
        public virtual KullaniciRolu kullanici_rolu { get; set; }
        public virtual List<SahiplenmeTalepleri> basvuru_talepleri { get; set; }
    }
}
