using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gestionabsence.Models
{
    public class Salle
    {
        
        [Key]
        public int ID_Salle { get; set; }

        [StringLength(50, MinimumLength = 3)]
        public string Name_Salle { get; set; }

         public int? ID_Prefesseur { get; set; }
         public Professeur Professeur { get; set; }

        public ICollection <Seance> List_Seance { get; set; }
    }
}