using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gestionabsence.Models
{
    public class Professeur
    {
        [Key]
        public int ID_Prefesseur { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        [StringLength(50)]
        public string Nom_Professeur { get; set; }
        
        [Required]
        [Column("FirstName")]
        [Display(Name = "First Name")]
        [StringLength(50)]
        public string Prenom_Professeur { get; set; }

        public ICollection<Enseigne> List_Enseigne { get; set; }
    }
}