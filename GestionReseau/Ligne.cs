using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionReseau
{
    public class Ligne
    {
        // Numéro unique identifiant la ligne
        private int _numLigne;
        // Nom de la ligne (ex: "M1")
        private string _nom;
        // Couleur associée à la ligne (ex: "bleu", "rouge")
        private string _couleur;
        // Liste des ID des segments appartenant à cette ligne
        private List<int> _segments;
        // Liste des noms des stations desservies par cette ligne
        private List<string> _stations;

        /// <summary>
        /// Constructeur de la classe Ligne.
        /// </summary>
        /// <param name="num">Numéro de la ligne</param>
        /// <param name="nom">Nom de la ligne</param>
        /// <param name="couleur">Couleur de la ligne</param>
        /// <param name="segments">Liste des ID de segments</param>
        /// <param name="stations">Liste des noms de stations</param>
        // Propriétés en lecture seule (accès public, modification privée)
        public Ligne(int num, string nom, string couleur, List<int> segments, List<string> stations)
        {

            _numLigne = num;
            _nom = nom;
            _couleur = couleur;
            _segments = segments;
            _stations = stations;
        }


        /// <summary>Numéro de la ligne.</summary>
        public int num { get { return _numLigne; } }

        /// <summary>Nom de la ligne.</summary>
        public string nom { get { return _nom; } }

        /// <summary>Couleur de la ligne (code hexadécimal).</summary>
        public string couleur { get { return _couleur; } }

        /// <summary>Liste des identifiants de segments appartenant à la ligne.</summary>
        public List<int> segments { get { return _segments; } }

        /// <summary>Liste des noms des stations desservies par la ligne.</summary>
        public List<string> stations { get { return _stations; } }
    }
}
