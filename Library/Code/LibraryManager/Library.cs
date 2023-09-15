using LibraryData.Code;
using LibraryData.Code.Medias;

namespace TD1.Code.LibraryManager;

using System;
using System.Collections.Generic;
using System.Linq;

public class Library
{
    private List<Media> medias;
    private List<Emprunt> emprunts;

    public Library()
    {
        medias = new List<Media>();
        emprunts = new List<Emprunt>();  
    }

    public void AjouterMedia(Media media)
    {
        medias.Add(media);
    }

    public void RetirerMedia(Media media)
    {
        medias.Remove(media);
    }

    public void AfficherTousLesMedias()
    {
        Console.WriteLine("Médias dans la bibliothèque :");
        foreach (var media in medias)
        {
            Console.WriteLine(media.Titre);
        }
    }

    // Indexeur pour accéder aux médias par leur numéro de référence
    public Media this[int numeroReference]
    {
        get
        {
            return medias.Find(media => media.NumeroDeReference == numeroReference);
        }
        
    }
    // Méthode pour emprunter un média de la bibliothèque
    public void EmprunterMedia(Media media, string utilisateur)
    {
        if (media.NombreExemplairesDisponibles > 0)
        {
            media.NombreExemplairesDisponibles--;
            Emprunt emprunt = new Emprunt(media, utilisateur);
                
           
            emprunts.Add(emprunt);
            Console.WriteLine($"Le média '{media.Titre}' a été emprunté par {utilisateur}.");
        }
        else
        {
            Console.WriteLine($"Désolé, le média '{media.Titre}' n'est pas disponible pour l'emprunt.");
        }
    }


    // Méthode pour retourner un média emprunté
    public void RetournerMedia(Media media, string utilisateur)
    {
        Emprunt emprunt = emprunts.Find(e => e.MediaEmprunte == media && e.Utilisateur == utilisateur);
        if (emprunt != null)
        {
            media.NombreExemplairesDisponibles++;
            emprunts.Remove(emprunt);
            Console.WriteLine($"Le média '{media.Titre}' a été retourné par {utilisateur}.");
        }
        else
        {
            Console.WriteLine($"Désolé, nous n'avons pas d'enregistrement d'emprunt pour le média '{media.Titre}' par {utilisateur}.");
        }
    }

    // Méthode pour rechercher un média par titre ou auteur
    public List<Media> RechercherMedia(string critere)
    {
        List<Media> resultats = new List<Media>();
        foreach (var media in medias)
        {
            if (media.Titre.Contains(critere) || (media is Livre livre && livre.Auteur.Contains(critere)))
            {
                resultats.Add(media);
            }
        }
        return resultats;
    }
    // Méthode pour lister les médias empruntés par un utilisateur
    public List<Media> ListerMediasEmpruntesParUtilisateur(string utilisateur)
    {
        List<Media> mediasEmpruntes = new List<Media>();
        foreach (var emprunt in emprunts)
        {
            if (emprunt.Utilisateur == utilisateur)
            {
                mediasEmpruntes.Add(emprunt.MediaEmprunte);
            }
        }
        return mediasEmpruntes;
    }

    public void AfficherStatistiques()
    {
        int nombreTotalMedias = medias.Count;
        int nombreTotalEmpruntes = emprunts.Count;
        int nombreTotalDisponibles = medias.Sum(media => media.NombreExemplairesDisponibles);

        Console.WriteLine("Statistiques de la bibliothèque :");
        Console.WriteLine($"Nombre total de médias : {nombreTotalMedias}");
        Console.WriteLine($"Nombre total d'exemplaires empruntés : {nombreTotalEmpruntes}");
        Console.WriteLine($"Nombre total d'exemplaires disponibles : {nombreTotalDisponibles}");
    }
}

