using System;

namespace BibliothequeJeu
{
    public class Joueur
    {
        //propriétés
        private string _nom; // nom du joueur
        private string _role; // rôle du joueur
        private int _points = 0; // points acquis par le joueur

        //constructeur
        public Joueur(string Nom, string Role)
        {
            // Création du joueur
            _nom = Nom;
            _role = Role;
        }

        // getters et setters
        public string nom
        {
            get
            {
                return _nom;
            }
        }

        public string role
        {
            get
            {
                return _role;
            }
        }

        public int points
        {
            get
            {
                return _points;
            }
        }

        //méthodes
        public void attribuerPoints(int nb)
        {
            // augmente le nb de pts du joueur
            _points += nb;
        }

        public void changerRole()
        {
            //change le rôle du joueur

            if (_role == "Codificateur")
                _role = "Décodeur";
            else
                _role = "Codificateur";
        }

    }
}
