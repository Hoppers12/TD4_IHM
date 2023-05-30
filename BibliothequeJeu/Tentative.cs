using System;
using System.Collections.Generic;
using System.Text;

namespace BibliothequeJeu
{
    public class Tentative
    {
        //propriétés
        private string[] _combinaison; //combinaison proposée par le décodeur
        private string[] _marques; //N : Couleur bien placée - B : Couleur mal placée

        //constructeur
        public Tentative(byte nbPions)
        {
            //créé un tableau de chaines de caractères pour la combinaison et les marques
            //en fonction du nombre de pions passé en paramètre
            _combinaison = new string[nbPions];
            _marques = new string[nbPions];
        }

        // getters et setters
        public string[] combinaison
        {
            get
            {
                return _combinaison;
            }
        }

        public string[] marques
        {
            get
            {
                return _marques;
            }
        }
    }
}
