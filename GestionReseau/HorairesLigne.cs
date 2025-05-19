using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionReseau
{
    public class HorairesLigne
    {
        private int _num;
        private TimeOnly _depart;
        private int _numLigne;

        //Constructeur
        public HorairesLigne(int num, TimeOnly depart, int numLigne)
        {
            _num = num;
            _depart = depart;
            _numLigne = numLigne;
        }

        public TimeOnly HoraireDepart(int num) { 
            return _depart;
        }
    }
}
