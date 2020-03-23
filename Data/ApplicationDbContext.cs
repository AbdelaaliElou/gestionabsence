using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace gestionabsence.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
         public DbSet<gestionabsence.Models.Etudiant> etudiant { get; set; }

         public DbSet<gestionabsence.Models.Enseigne> enseigne { get; set; }

         public DbSet<gestionabsence.Models.Filiere>  filiere { get; set; }

         public DbSet<gestionabsence.Models.Matiere> matiere { get; set; }

         public DbSet<gestionabsence.Models.Professeur> prefesseur { get; set; }

         public DbSet<gestionabsence.Models.Salle> salle { get; set; }

         public DbSet<gestionabsence.Models.Seance> seance { get; set; }

        public DbSet<gestionabsence.Models.Pointeuse> pointeuse { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
