using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BarinakProjesi.DATA.Context
{
    public class Asi
    {
        [Key]
        public int id { get; set; }

        [Display(Name = "Aşı Adı")]
        public string asi_adi { get; set; }

        [Display(Name = "Aşı Tarihi")]
        public DateTime asi_tarihi { get; set; }

        [Display(Name = "Durum")]
        public bool asi_durumu { get; set; }

        [Display(Name = "Hayvan")]
        public int hayvan_id { get; set; }

        [ForeignKey("hayvan_id")]
        public virtual KayitliHayvanlar hayvan { get; set; }
    }
}
