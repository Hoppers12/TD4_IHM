using System;
using System.Collections.Generic;
using System.Text;

namespace BibliothequeJeu
{
    public class Manche
    {
        //propriétés
        private byte _noManche; // numéro de la manche
        private string[] _code; // code à trouver
        private Joueur _codif;  // Joueur codificateur de la manche
        private List<Tentative> _lesTentatives = new List<Tentative>(); // Liste des tentatives jouées

        //constructeur        
        public Manche(byte numManche, Joueur Codificateur, bool ModeJeu)
        {
            //initialisation du joueur codificateur et du nbre de manches
            _codif = Codificateur;
            _noManche = numManche;

            // création du tableau pour le code et de la 1ère tentative
            if (ModeJeu) // ModeJeu vrai : mode classique
            {
                _code = new string[5];
                _lesTentatives.Add(new Tentative(5));
            }
            else // ModeJeu faux : mode débutant

            {
                _code = new string[4];
                _lesTentatives.Add(new Tentative(4));
            }
        }

        //méthodes
        public byte noTentatives()
        {
            //retourne le numéro de la tentative actuelle
            return (byte)_lesTentatives.Count;

        }

        public void finManche()
        {
            //attribue autant de points que de manches jouées au codificateur
            _codif.attribuerPoints(_lesTentatives.Count);
        }
    }
}
