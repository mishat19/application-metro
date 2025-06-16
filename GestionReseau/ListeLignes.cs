using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionReseau
{
    /// <summary>
    /// Représente une collection de lignes de métro.
    /// </summary>
    public class ListeLignes
    {
        private List<Ligne> _lignes = new List<Ligne>();

        /// <summary>
        /// Constructeur initialisant la liste des lignes.
        /// </summary>
        public ListeLignes() {
            _lignes = new List<Ligne>();
        }

        /// <summary>
        /// Propriété pour accéder à la liste des lignes.
        /// </summary>
        public List<Ligne> lignes {  get { return _lignes; } }


        /// <summary>
        /// Ajoute une nouvelle ligne à la collection.
        /// </summary>
        /// <param name="ligne">Ligne à ajouter</param>
        public void AjoutLigne(Ligne ligne) { 
            _lignes.Add(ligne);
        }
    }
}
