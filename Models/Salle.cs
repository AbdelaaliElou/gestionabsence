using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gestionabsence.Models
{
    public class Salle
    {
        [Key]
        public int ID_Salle { get; set; }

        [ForeignKey("Prefesseur")]
         public int? ID_Prefesseur { get; set; }

        public ICollection <Seance> List_Seance { get; set; }
    }
}