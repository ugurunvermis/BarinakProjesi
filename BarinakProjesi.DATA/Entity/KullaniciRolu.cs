using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BarinakProjesi.DATA.Context
{
    public class KullaniciRolu
    {
        [Key]
        public int id { get; set; }

        [Display(Name ="Kullanıcı Rolü")]
        public string rol { get; set; }
        public virtual List<Kullanicilar> kullanicilar { get; set; }
    }
}
