namespace gestionabsence.Models
{
    public class Pointeuse
    {
        public int ID_Pointeuse { get; set; }

        public Seance seance { get; set; }

        public Etudiant etudiant { get; set; }
    }
}