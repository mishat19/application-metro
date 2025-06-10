using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionReseau
{
    /// <summary>
    /// Représente un horaire de départ d'une ligne de métro.
    /// </summary>
    public class HorairesLigne
    {
        // Identifiant unique de l'horaire
        private int _num;
        // Heure de départ de la ligne
        private TimeOnly _depart;
        // Numéro de la ligne associée à cet horaire
        private int _numLigne;

        /// <summary>
        /// Constructeur de la classe HorairesLigne.
        /// </summary>
        /// <param name="num">Identifiant de l'horaire</param>
        /// <param name="depart">Heure de départ</param>
        /// <param name="numLigne">Numéro de la ligne concernée</param>
        public HorairesLigne(int num, TimeOnly depart, int numLigne)
        {
            _num = num;
            _depart = depart;
            _numLigne = numLigne;
        }

        /// <summary>
        /// Retourne l'heure de départ.
        /// Le paramètre `num` est inutile ici : la méthode retourne toujours _depart.
        /// </summary>
        /// <returns>Heure de départ</returns>
        public TimeOnly HoraireDepart(int num) { 
            return _depart;
        }
    }
}
