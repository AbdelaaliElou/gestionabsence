using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using gestionabsence.Models;
using gestionabsence.Data;

namespace ContosoUniversity.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Etudiants.Any())
            {
                return;  
            }

            var etudiants = new Etudiant[]
            {
                new Etudiant { Prenom_Etudiant = "Carson",   Nom_Etudiant = "Alexander" },
                new Etudiant { Prenom_Etudiant = "Meredith", Nom_Etudiant = "Alonso"},
                new Etudiant { Prenom_Etudiant = "Arturo",   Nom_Etudiant = "Anand" },
                new Etudiant { Prenom_Etudiant = "Gytis",    Nom_Etudiant = "Barzdukas" },
                new Etudiant { Prenom_Etudiant = "Yan",      Nom_Etudiant = "Li"},
                new Etudiant { Prenom_Etudiant = "Peggy",    Nom_Etudiant = "Justice"},
                new Etudiant { Prenom_Etudiant = "Laura",    Nom_Etudiant = "Norman" },
                new Etudiant { Prenom_Etudiant = "Nino",     Nom_Etudiant = "Olivetto"}
            };

            foreach (Etudiant s in etudiants)
            {
                context.Etudiants.Add(s);
            }
            context.SaveChanges();

            var professeurs = new Professeur[]
            {
                new Professeur { Nom_Professeur = "Kim",Prenom_Professeur = "Abercrombie",
                    HireDate = DateTime.Parse("1995-03-11") },
                new Professeur { Nom_Professeur = "Fadi",    Prenom_Professeur = "Fakhouri",
                    HireDate = DateTime.Parse("2002-07-06") },
                new Professeur { Nom_Professeur = "Roger",   Prenom_Professeur = "Harui",
                    HireDate = DateTime.Parse("1998-07-01") },
                new Professeur { Nom_Professeur = "Candace", Prenom_Professeur = "Kapoor",
                    HireDate = DateTime.Parse("2001-01-15") },
                new Professeur { Nom_Professeur = "Roger",   Prenom_Professeur = "Zheng",
                    HireDate = DateTime.Parse("2004-02-12") }
            };

            foreach (Professeur i in professeurs)
            {
                context.Professeurs.Add(i);
            }
            context.SaveChanges();

            var salles = new Salle[]
            {
                new Salle { Name_Salle = "A1",
                    ID_Prefesseur  = professeurs.Single( i => i.Prenom_Professeur == "Abercrombie").ID_Prefesseur },
                new Salle { Name_Salle = "A2", 
                    ID_Prefesseur  = professeurs.Single( i => i.Prenom_Professeur == "Fakhouri").ID_Prefesseur },
                new Salle { Name_Salle = "C2",
                    ID_Prefesseur  = professeurs.Single( i => i.Prenom_Professeur == "Harui").ID_Prefesseur },
                new Salle { Name_Salle = "C1", 
                    ID_Prefesseur  = professeurs.Single( i => i.Prenom_Professeur == "Kapoor").ID_Prefesseur }
            };

            foreach (Salle d in salles)
            {
                context.Salles.Add(d);
            }
            context.SaveChanges();

            var seances = new Seance[]
            {
                new Seance {ID_Seance = 1050, title = "WEB",   
                    ID_salle = salles.Single( s => s.Name_Salle == "A1").ID_Salle
                },
                new Seance {ID_Seance = 4022, title = "SQL",
                    ID_salle = salles.Single( s => s.Name_Salle == "A2").ID_Salle
                },
                new Seance {ID_Seance = 4041, title = "JEE",
                    ID_salle = salles.Single( s => s.Name_Salle == "C1").ID_Salle
                },
                new Seance {ID_Seance = 1045, title = "BIGDATA",
                    ID_salle = salles.Single( s => s.Name_Salle == "C1").ID_Salle
                },
                new Seance {ID_Seance = 3141, title = "WINDOWS",
                    ID_salle = salles.Single( s => s.Name_Salle == "C2").ID_Salle
                },
                new Seance {ID_Seance = 2021, title = "DATAWAREHOUSE",
                    ID_salle = salles.Single( s => s.Name_Salle == "A2").ID_Salle
                },
                new Seance {ID_Seance = 2042, title = "CLOUD",
                    ID_salle = salles.Single( s => s.Name_Salle == "A1").ID_Salle
                },
            };

            foreach (Seance c in seances)
            {
                context.Seances.Add(c);
            }
            context.SaveChanges();

            var filieres = new Filiere[]
            {
                new Filiere {
                    ID_Professeur = professeurs.Single( i => i.Prenom_Professeur == "Fakhouri").ID_Prefesseur,
                     },
                new Filiere {
                    ID_Professeur = professeurs.Single( i => i.Prenom_Professeur == "Harui").ID_Prefesseur},
                new Filiere {
                    ID_Professeur = professeurs.Single( i => i.Prenom_Professeur == "Kapoor").ID_Prefesseur},
            };

            foreach (Filiere o in filieres)
            {
                context.Filieres.Add(o);
            }
            context.SaveChanges();

            var seanceProfesseur = new Enseigne[]
            {
                new Enseigne {
                    ID_Seance = seances.Single(c => c.title == "WEB" ).ID_Seance,
                    ID_Prefesseur = professeurs.Single(i => i.Prenom_Professeur == "Kapoor").ID_Prefesseur
                    },
                new Enseigne {
                    ID_Seance = seances.Single(c => c.title == "WEB" ).ID_Seance,
                    ID_Prefesseur = professeurs.Single(i => i.Prenom_Professeur == "Harui").ID_Prefesseur
                    },
                new Enseigne {
                    ID_Seance = seances.Single(c => c.title == "SQL" ).ID_Seance,
                    ID_Prefesseur = professeurs.Single(i => i.Prenom_Professeur == "Zheng").ID_Prefesseur
                    },
                new Enseigne {
                    ID_Seance = seances.Single(c => c.title == "SQL" ).ID_Seance,
                    ID_Prefesseur = professeurs.Single(i => i.Prenom_Professeur == "Zheng").ID_Prefesseur
                    },
                new Enseigne {
                    ID_Seance = seances.Single(c => c.title == "JEE" ).ID_Seance,
                    ID_Prefesseur = professeurs.Single(i => i.Prenom_Professeur == "Fakhouri").ID_Prefesseur
                    },
                new Enseigne {
                    ID_Seance = seances.Single(c => c.title == "Trigonometry" ).ID_Seance,
                    ID_Prefesseur = professeurs.Single(i => i.Prenom_Professeur == "Harui").ID_Prefesseur
                    },
                new Enseigne {
                    ID_Seance = seances.Single(c => c.title == "Composition" ).ID_Seance,
                    ID_Prefesseur = professeurs.Single(i => i.Prenom_Professeur == "Abercrombie").ID_Prefesseur
                    },
                new Enseigne {
                    ID_Seance = seances.Single(c => c.title == "Literature" ).ID_Seance,
                    ID_Prefesseur = professeurs.Single(i => i.Prenom_Professeur == "Abercrombie").ID_Prefesseur
                    },
            };

            foreach (Enseigne ci in seanceProfesseur)
            {
                context.Enseignes.Add(ci);
            }
            context.SaveChanges();

            var pointeusse = new Pointeuse[]
            {
                new Pointeuse {
                    ID_Etudiant = etudiants.Single(s => s.Nom_Etudiant == "Alexander").ID_Etudiant,
                    ID_Seance = seances.Single(c => c.title == "Chemistry" ).ID_Seance
                },
                    new Pointeuse {
                    ID_Etudiant = etudiants.Single(s => s.Nom_Etudiant == "Alexander").ID_Etudiant,
                    ID_Seance = seances.Single(c => c.title == "Microeconomics" ).ID_Seance
                    },
                    new Pointeuse {
                    ID_Etudiant = etudiants.Single(s => s.Nom_Etudiant == "Alexander").ID_Etudiant,
                    ID_Seance = seances.Single(c => c.title == "Macroeconomics" ).ID_Seance
                    },
                    new Pointeuse {
                    ID_Etudiant = etudiants.Single(s => s.Nom_Etudiant == "Alonso").ID_Etudiant,
                    ID_Seance = seances.Single(c => c.title == "Calculus" ).ID_Seance
                    },
                    new Pointeuse {
                    ID_Etudiant = etudiants.Single(s => s.Nom_Etudiant == "Alonso").ID_Etudiant,
                    ID_Seance = seances.Single(c => c.title == "Trigonometry" ).ID_Seance
                    },
                    new Pointeuse {
                    ID_Etudiant = etudiants.Single(s => s.Nom_Etudiant == "Alonso").ID_Etudiant,
                    ID_Seance = seances.Single(c => c.title == "Composition" ).ID_Seance
                    },
                    new Pointeuse {
                    ID_Etudiant = etudiants.Single(s => s.Nom_Etudiant == "Anand").ID_Etudiant,
                    ID_Seance = seances.Single(c => c.title == "Chemistry" ).ID_Seance
                    },
                    new Pointeuse {
                    ID_Etudiant = etudiants.Single(s => s.Nom_Etudiant == "Anand").ID_Etudiant,
                    ID_Seance = seances.Single(c => c.title == "Microeconomics").ID_Seance
                    },
                new Pointeuse {
                    ID_Etudiant = etudiants.Single(s => s.Nom_Etudiant == "Barzdukas").ID_Etudiant,
                    ID_Seance = seances.Single(c => c.title == "Chemistry").ID_Seance
                    },
                    new Pointeuse {
                    ID_Etudiant = etudiants.Single(s => s.Nom_Etudiant == "Li").ID_Etudiant,
                    ID_Seance = seances.Single(c => c.title == "Composition").ID_Seance
                    },
                    new Pointeuse {
                    ID_Etudiant = etudiants.Single(s => s.Nom_Etudiant == "Justice").ID_Etudiant,
                    ID_Seance = seances.Single(c => c.title == "Literature").ID_Seance
                    }
            };

            foreach (Pointeuse e in pointeusse)
            {
                var pointeuseendatabase = context.Pointeuses.Where(
                    s =>
                            s.Etudiant.ID_Etudiant == e.ID_Etudiant &&
                            s.seance.ID_Seance == e.ID_Seance).SingleOrDefault();
                if (pointeuseendatabase == null)
                {
                    context.Pointeuses.Add(e);
                }
            }
            context.SaveChanges();
        }
    }
}