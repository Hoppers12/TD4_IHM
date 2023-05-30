using System;
using System.Collections.Generic;
using System.Text;

namespace BibliothequeJeu
{
    public class Partie
    {
        //propriétés
        private Joueur[] _lesJoueurs = new Joueur[2]; //joueurs de la partie
        private List<Manche> _lesManches = new List<Manche>(); //liste des manches de la partie
        private bool _modeJeu; // false si Débutant - true si Classique
        private byte _nbManches; //nombre total des manches de la partie
        private byte _mancheEnCours; //numéro de la manche en cours

        //constructeur
        public Partie()
        {
            // Stockage infos par défaut partie
            _nbManches = 2;
            _modeJeu = true;
            _mancheEnCours = 1;
        }

        // getters et setters
        public byte mancheEnCours
        {
            get
            {
                return _mancheEnCours;
            }
        }

        public byte nbManches
        {
            get
            {
                return _nbManches;
            }
        }

        public string modeJeu
        {
            get
            {
                if (_modeJeu)
                    return "Niveau Classique";
                else
                    return "Niveau Débutant";
            }
        }

        public string roleJ1
        {
            get
            {
                return _lesJoueurs[0].role;
            }
        }

        public string roleJ2
        {
            get
            {
                return _lesJoueurs[1].role;
            }
        }

        public int pointsJ1
        {
            get
            {
                return _lesJoueurs[0].points;
            }
        }

        public int pointsJ2
        {
            get
            {
                return _lesJoueurs[1].points;
            }
        }

        //méthodes

        public void modifierPartie(string J1, string J2, bool ModeClassique, byte nbreManches, bool J1Codif)
        {
            // Stockage infos partie
            _nbManches = nbreManches;
            _modeJeu = ModeClassique;
            _mancheEnCours = 1;

            // Création des joueurs et de la 1ère manche
            if (J1Codif)
            {
                _lesJoueurs[0] = new Joueur(J1, "Codificateur");
                _lesJoueurs[1] = new Joueur(J2, "Decodeur");
                _lesManches.Add(new Manche(_mancheEnCours, _lesJoueurs[0], ModeClassique));
            }
            else
            {
                _lesJoueurs[0] = new Joueur(J1, "Decodeur");
                _lesJoueurs[1] = new Joueur(J2, "Codificateur");
                _lesManches.Add(new Manche(_mancheEnCours, _lesJoueurs[1], ModeClassique));
            }
        }
        public void mancheSuivante()
        {
            //termine la manche en cours, inverse les rôles des joueurs et créé la nouvelle manche

        }
    }
}
