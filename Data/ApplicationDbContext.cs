using System;
using System.Collections.Generic;
using System.Text;
using gestionabsence.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace gestionabsence.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {

         public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<gestionabsence.Models.Seance> Seances { get; set; }
        public DbSet<gestionabsence.Models.Pointeuse> Pointeuses { get; set; }  
         public DbSet<gestionabsence.Models.Etudiant> Etudiants { get; set; }
         public DbSet<gestionabsence.Models.Enseigne> Enseignes { get; set; }
         public DbSet<gestionabsence.Models.Filiere>  Filieres { get; set; }
         public DbSet<gestionabsence.Models.Matiere>  Matieres { get; set; }
         public DbSet<gestionabsence.Models.Professeur> Professeurs { get; set; }
         public DbSet<gestionabsence.Models.Salle> Salles { get; set; }

          protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
              base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Seance>().ToTable("Seance");
            modelBuilder.Entity<Pointeuse>().ToTable("Pointeuse");
            modelBuilder.Entity<Etudiant>().ToTable("Etudiant");
            modelBuilder.Entity<Salle>().ToTable("Salle");
            modelBuilder.Entity<Professeur>().ToTable("Professeur");
            modelBuilder.Entity<Filiere>().ToTable("Filiere");
            modelBuilder.Entity<Enseigne>().ToTable("Enseigne");
            modelBuilder.Entity<Matiere>().ToTable("Matiere");

            modelBuilder.Entity<Enseigne>()
                .HasKey(c => new { c.ID_Seance, c.ID_Prefesseur });
        }
         
    }
}
