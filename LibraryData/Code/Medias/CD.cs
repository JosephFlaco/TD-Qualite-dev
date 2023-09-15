using LibraryData.Code.Medias;

namespace LibraryData.Code.Medias;

public class CD : Media
{
    // Propriété spécifique aux CD
    public string Artiste { get; set; }

    // Constructeur surchargé pour les CD
    public CD(string titre, int numeroReference, int nombreExemplairesDisponibles, string artiste)
        : base(titre, numeroReference, nombreExemplairesDisponibles)
    {
        Artiste = artiste;
    }

    // Méthode polymorphique pour afficher les informations spécifiques aux CD
    public void AfficherInfos()
    {
        Console.WriteLine("Type de média : CD");
        Console.WriteLine("Titre : " + Titre);
        Console.WriteLine("Numéro de référence : " + NumeroDeReference);
        Console.WriteLine("Nombre d'exemplaires disponibles : " + NombreExemplairesDisponibles);
        Console.WriteLine("Artiste : " + Artiste);
    }
}