﻿using BarinakProjesi.DAL.Context;
using BarinakProjesi.DATA.Context;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Linq;

namespace BarinakProjesi.UI.Pages
{
    public class IndexModel : PageModel
    {
        private readonly BarinakDbContext _context;


        public IndexModel(BarinakDbContext context)
        {
            _context = context;
        }
        public BarinakBilgileri BarinakBilgileri { get; set; }

        public void OnGet()
        {
            BarinakBilgileri = _context.BarinakBilgileri.Where(b => b.id == 1).FirstOrDefault();
        }
    }
}
