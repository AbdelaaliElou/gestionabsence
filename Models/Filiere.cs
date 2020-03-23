using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace gestionabsence.Models
{
    public class Filiere
    {
        [Key]
        public int ID_Filiere { get; set; }

         [Required]
        [Display(Name = "Nom_Filiere")]
        [StringLength(50)]
        public string Nom_Filiere { get; set; }


         public ICollection<Etudiant> List_Etudiants { get; set; }

         public ICollection<Professeur> List_Professeurs { get; set; }
    }
}