using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BarinakProjesi.DATA.Context
{
    public class HayvanFotograflari
    {
        [Key]
        public int id { get; set; }

        [Display(Name ="Fotoğraf Adı")]
        public string fotograf_adi { get; set; }

        [Display(Name = "Kayıtlı Hayvan")]
        public int hayvan_id { get; set; }

        [ForeignKey("hayvan_id")]
        public virtual KayitliHayvanlar hayvan { get; set; }
    }
}
