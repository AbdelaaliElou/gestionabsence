namespace gestionabsence.Models
{
    public class Salle
    {
        public int ID_Salle { get; set; }


        public Professeur professeur { get; set; }

        public ICollection <Seance> MyProperty { get; set; }
    }
}