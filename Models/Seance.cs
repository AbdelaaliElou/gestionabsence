using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gestionabsence.Models
{
    public class Seance
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Number")]        
        public int ID_Seance { get; set; }

        [Required]
        [Display(Name = "Titre_Seance")]
         [StringLength(50, MinimumLength = 3)]
        public string title { get; set; }

        public int ID_salle { get; set; }
        public Salle Salle { get; set; }

        public ICollection<Matiere> List_matiere { get; set; }

         public ICollection<Pointeuse> List_Point { get; set; }

         public ICollection<Enseigne> List_Enseigne { get; set; }
    }
}