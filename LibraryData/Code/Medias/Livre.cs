using LibraryData.Code.Medias;

namespace LibraryData.Code.Medias;

public class Livre : Media
{
    // Propriété spécifique aux livres
    public string Auteur { get; set; }

    // Constructeur surchargé pour les livres
    public Livre(string titre, int numeroReference, int nombreExemplairesDisponibles, string auteur)
        : base(titre, numeroReference, nombreExemplairesDisponibles)
    {
        Auteur = auteur;
    }
    // Méthode polymorphique pour afficher les informations spécifiques aux livres
    public void AfficherInfos()
    {
        Console.WriteLine("Type de média : Livre");
        Console.WriteLine("Titre : " + Titre);
        Console.WriteLine("Numéro de référence : " + NumeroDeReference);
        Console.WriteLine("Nombre d'exemplaires disponibles : " + NombreExemplairesDisponibles);
        Console.WriteLine("Auteur : " + Auteur);
    }
}