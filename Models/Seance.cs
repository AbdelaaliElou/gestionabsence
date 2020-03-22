namespace gestionabsence.Models
{
    public class Seance
    {
        public int ID_Seance { get; set; }

        public string title { get; set; }

        public Salle salle { get; set; }
    }
}