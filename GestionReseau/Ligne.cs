using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionReseau
{
    public class Ligne
    {
        private int _numLigne;
        private string _nom;
        private string _couleur;
        private List<int> _segments;
        private List<string> _stations;

        //Constructeur
        public Ligne(int num, string nom, string couleur, List<int> segments, List<string> stations)
        {
            _numLigne = num;
            _nom = nom;
            _couleur = couleur;
            _segments = segments;
            _stations = stations;
        }

        //Accesseurs : rendent accessibles les attributs
        public int num { get { return _numLigne; } }
        public string nom { get { return _nom; } }
        public string couleur { get { return _couleur; } }
        public List<int> segments { get { return _segments; } }
        public List<string> stations { get { return _stations; } }
    }
}
