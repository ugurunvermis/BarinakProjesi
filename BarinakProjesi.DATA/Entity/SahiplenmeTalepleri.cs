using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BarinakProjesi.DATA.Context
{
    public class SahiplenmeTalepleri
    {
        [Key]
        public int id { get; set; }

        [Display(Name ="Kullanıcı")]
        public int kullanici_id { get; set; }

        [Display(Name = "Başvuru Yapılan Hayvan")]
        public int kayitli_hayvan_id { get; set; }

        [Display(Name = "Başvuru Durumu")]
        public int basvuru_durum_id { get; set; }

        [ForeignKey("kullanici_id")]
        public virtual Kullanicilar basvuran_kullanici { get; set; }

        [ForeignKey("kayitli_hayvan_id")]
        public virtual KayitliHayvanlar basvurulan_hayvan { get; set; }

        [ForeignKey("basvuru_durum_id")]
        public virtual SahiplenmeBasvuruDurumlari basvuru_durumu { get; set; }
    }
}
