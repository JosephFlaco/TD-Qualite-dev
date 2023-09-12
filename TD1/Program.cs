public class Media
{
    private String Titre { get; set; }

    private int NumeroDeReference { get; set; }
    
    private int NbExemplaireDisponible { get; set; }

    public Media()
    {
        Titre = string.Empty;
        NumeroDeReference = 0;
        NbExemplaireDisponible = 0;
        
    }
    
    // Constructeur surchargé pour initialiser les propriétés lors de la création d'un objet Media
    public Media(string titre, int numeroReference, int nombreExemplairesDisponibles)
    {
        Titre = titre;
        NumeroReference = numeroReference;
        NombreExemplairesDisponibles = nombreExemplairesDisponibles;
    }

    

}

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
}

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
}

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
}
