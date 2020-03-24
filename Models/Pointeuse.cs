using System.ComponentModel.DataAnnotations;

namespace gestionabsence.Models
{
    public class Pointeuse
    {
        
        [Key]
        public int ID_Pointeuse { get; set; }

         public int ID_Seance { get; set; }
        public int ID_Etudiant { get; set; }

        public Seance seance { get; set; }

        public Etudiant Etudiant { get; set; }
    }
}