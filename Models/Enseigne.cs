using System.ComponentModel.DataAnnotations;

namespace gestionabsence.Models
{
    public class Enseigne
    {
        
        [Key]
        public int ID_Enseigne { get; set; }
        public int ID_Seance { get; set; }
        public int ID_Prefesseur { get; set; }
        public Seance seance { get; set; }
    }
}