namespace TD1;

public class Emprunt
{
    public Media MediaEmprunte { get; set; }
    public string Utilisateur { get; set; }
    
    
    public Emprunt(Media media, string utilisateur)
    {
        MediaEmprunte = media;
        Utilisateur = utilisateur;
    }
}
