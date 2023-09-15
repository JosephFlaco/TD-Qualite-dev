using LibraryData.Code.Medias;

namespace LibraryData.Code.Medias;

public class DVD : Media
{
    // Propriété spécifique aux DVD
    public int Duree { get; set; }

    // Constructeur surchargé pour les DVD
    public DVD(string titre, int numeroReference, int nombreExemplairesDisponibles, int duree)
        : base(titre, numeroReference, nombreExemplairesDisponibles)
    {
        Duree = duree;
    }
    
    
    
    // Méthode polymorphique pour afficher les informations spécifiques aux DVD
    public void AfficherInfos()
    {
        Console.WriteLine("Type de média : DVD");
        Console.WriteLine("Titre : " + Titre);
        Console.WriteLine("Numéro de référence : " + NumeroDeReference);
        Console.WriteLine("Nombre d'exemplaires disponibles : " + NombreExemplairesDisponibles);
        Console.WriteLine("Durée : " + Duree + " minutes");
    }
    
    
}