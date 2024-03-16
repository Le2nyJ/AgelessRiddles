using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerOfTheGame : MonoBehaviour
{

    [SerializeField] int CurrentQuest = 0;


    public String ShowHint()
    {
        //Liste des quetes, E = phase enfant, A = phase adulte
        //E trouver graine,E planter plante,A recupe clé,A ouvrir chambre ,A ouvrir pc,A recuperer code,E deverouiller pc,A ouvrir telephone,A se laver,E trouver produit de netoyage
        //E trouver clé produit menager,E netoyer salle de bain,A se laver, A Preparer chocolat, E trouver recette, A faire chocolat, A sortir et fin 
        switch (CurrentQuest)
        {
            case 0:
                return "En tant que enfant : Trouver une graine";
            case 1:
                return "En tant que enfant : Planter la graine";
            case 2:
                return "En tant qu'adulte : Récupérer la clé";
            case 3:
                return "En tant qu'adulte : Ouvrir la chambre";
            case 4:
                return "En tant qu'adulte : Ouvrir le pc";
            case 5:
                return "En tant qu'adulte : Récupérer le code";
            case 6:
                return "En tant qu'enfant : Déverouiller le pc";
            case 7:
                return "En tant qu'adulte : Ouvrir le téléphone";
            case 8:
                return "En tant qu'adulte : Se laver";
            case 9:
                return "En tant qu'enfant : Trouver un produit de nettoyage";
            case 10:
                return "En tant qu'enfant : Trouver la clé du produit ménager";
            case 11:
                return "En tant qu'enfant : Nettoyer la salle de bain";
            case 12:
                return "En tant qu'adulte : Se laver";
            case 13:
                return "En tant qu'adulte : Préparer du chocolat";
            case 14:
                return "En tant qu'enfant : Trouver la recette";
            case 15:
                return "En tant qu'adulte : Faire du chocolat";
            case 16:
                return "En tant qu'adulte : Sortir et finir le jeu";
            case 17:
                return "Vous avez fini le jeu";
            default:
                return "You have completed the game";
        }
    }
}
