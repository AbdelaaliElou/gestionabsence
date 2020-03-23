using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gestionabsence.Models
{
    public class Etudiant
    {
        
        [Key]
        public int ID_Etudiant { get; set; }

        [Required]
        [StringLength(50)]
        [Column("LastName")]
        [Display(Name = "Last Name")]
        public string Nom_Etudiant { get; set; }
        
        [Required]
        [StringLength(50, ErrorMessage = "First name cannot be longer than 50 characters.")]
        [Column("FirstName")]
        [Display(Name = "First Name")]        
        public string Prenom_Etudiant { get; set; }

        public Filiere filiere { get; set; }


         public ICollection<Pointeuse> List_Point { get; set; }
    }
}