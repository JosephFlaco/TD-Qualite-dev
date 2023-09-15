namespace LibraryData.Code.Medias;
public class Media
{
    public String Titre { get; set; }

    public int NumeroDeReference { get; set; }
    
    public int NombreExemplairesDisponibles { get; set; }

    public Media()
    {
        Titre = string.Empty;
        NumeroDeReference = 0;
        NombreExemplairesDisponibles = 0;
        
    }
    
    public static Media operator +(Media media, int nombreAjout)
    {
        // Vérifiez que le nombre d'ajout est positif
        if (nombreAjout < 0)
        {
            throw new ArgumentException("Le nombre d'ajout doit être positif ou nul.");
        }

        // Mettez à jour le nombre d'exemplaires disponibles
        media.NombreExemplairesDisponibles += nombreAjout;

        return media;
    }
    
    public static Media operator -(Media media, int nombreRetrait)
    {
        // Vérifiez que le nombre de retrait est positif
        if (nombreRetrait < 0)
        {
            throw new ArgumentException("Le nombre de retrait doit être positif ou nul.");
        }

        // Vérifiez si le nombre de retrait est supérieur au nombre d'exemplaires disponibles
        if (nombreRetrait > media.NombreExemplairesDisponibles)
        {
            throw new InvalidOperationException("Le nombre de retrait est supérieur au nombre d'exemplaires disponibles.");
        }

        // Mettez à jour le nombre d'exemplaires disponibles
        media.NombreExemplairesDisponibles -= nombreRetrait;

        return media;
    }


    
    // Constructeur surchargé pour initialiser les propriétés lors de la création d'un objet Media
    public Media(string titre, int numeroReference, int nombreExemplairesDisponibles)
    {
        Titre = titre;
        NumeroDeReference = numeroReference;
        NombreExemplairesDisponibles = nombreExemplairesDisponibles;
    }

    








}
