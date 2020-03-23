using System.ComponentModel.DataAnnotations;

namespace gestionabsence.Models
{
    public class Matiere
    {
        [Key]
        public int ID_Matiere { get; set; }

        [Required]
        [Display(Name = "Nom_Matiere")]
        [StringLength(50)]
        public string Nom_Matiere { get; set;}
    }
}