using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionReseau
{

    /// <summary>
    /// Représente une liste d'horaires de départ pour les lignes de métro.
    /// </summary>
    public class ListeHorairesLignes
    {
        // Liste contenant les objets HorairesLigne
        private List<HorairesLigne> _horaires = new List<HorairesLigne>();

        /// <summary>
        /// Constructeur par défaut. Initialise une liste vide d'horaires.
        /// </summary>
        public ListeHorairesLignes()
        {
            _horaires = new List<HorairesLigne>();
        }

        /// <summary>
        /// Propriété pour accéder à la liste des horaires.
        /// </summary>
        public List<HorairesLigne> horaires { get { return _horaires; } }


        /// <summary>
        /// Ajoute un horaire de départ à la liste.
        /// </summary>
        /// <param name="horaire">Horaire à ajouter</param>
        public void AjoutHoraireDepart(HorairesLigne horaire)
        {
            _horaires.Add(horaire);
        }
    }
}
