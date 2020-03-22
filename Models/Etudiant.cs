namespace gestionabsence.Models
{
    public class Etudiant
    {
        public int ID_Etudiant { get; set; }

        public string Nom_Etudiant { get; set; }

        public string Prenom_Etudiant { get; set; }

        public Filiere filiere { get; set; }
    }
}