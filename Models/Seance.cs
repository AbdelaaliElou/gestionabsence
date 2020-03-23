using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace gestionabsence.Models
{
    public class Seance
    {
        [Key]
        public int ID_Seance { get; set; }

        [Required]
        [Display(Name = "Titre_Seance")]
        [StringLength(50)]
        public string title { get; set; }

        public Salle salle { get; set; }

        public Matiere matiere { get; set; }

         public ICollection<Pointeuse> List_Point { get; set; }

         public ICollection<Enseigne> List_Enseigne { get; set; }
    }
}