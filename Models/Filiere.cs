namespace gestionabsence.Models
{
    public class Filiere
    {
        public int ID_Filiere { get; set; }

        public string Nom_Filiere { get; set; }


         public ICollection<Etudiant> List_Etudiants { get; set; }

         public ICollection<Etudiant> List_Professeurs { get; set; }
    }
}