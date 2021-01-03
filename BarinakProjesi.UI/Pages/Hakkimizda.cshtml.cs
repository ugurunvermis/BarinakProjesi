using BarinakProjesi.DAL.Context;
using BarinakProjesi.DATA.Context;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq;

namespace BarinakProjesi.UI.Pages
{
    public class HakkimizdaModel : PageModel
    {
        private readonly BarinakDbContext _context;

        public HakkimizdaModel(BarinakDbContext context)
        {
            _context = context;
        }

        public BarinakBilgileri BarinakBilgileri { get; set; }
        public List<CalismaSaatleri> CalismaSaatleri { get; set; }

        public void OnGet()
        {
            BarinakBilgileri = _context.BarinakBilgileri.Where(b => b.id == 1).FirstOrDefault();
            CalismaSaatleri = _context.CalismaSaatleri.Where(b => b.barinak_id == 1).ToList();
        }
    }
}
