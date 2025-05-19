using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionReseau
{
    public class ListeHorairesLignes
    {
        private List<HorairesLigne> _horaires = new List<HorairesLigne>();

        //Constructeur
        public ListeHorairesLignes()
        {
            _horaires = new List<HorairesLigne>();
        }

        public List<HorairesLigne> horaires { get { return _horaires; } }

        public void AjoutHoraireDepart(HorairesLigne horaire)
        {
            _horaires.Add(horaire);
        }
    }
}
