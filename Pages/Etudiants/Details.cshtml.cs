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
    public class DetailsModel : PageModel
    {
        private readonly gestionabsence.Data.ApplicationDbContext _context;

        public DetailsModel(gestionabsence.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Etudiant Etudiant { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Etudiant = await _context.Etudiants.FirstOrDefaultAsync(m => m.ID_Etudiant == id);

            if (Etudiant == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
