using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using gestionabsence.Data;
using gestionabsence.Models;

namespace gestionabsence.Pages.Etudiants
{
    public class IndexModel : PageModel
    {
        private readonly gestionabsence.Data.ApplicationDbContext _context;

        public IndexModel(gestionabsence.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Etudiant> Etudiant { get;set; }

        public async Task OnGetAsync()
        {
            Etudiant = await _context.Etudiants.ToListAsync();
        }
    }
}
