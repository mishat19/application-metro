using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionReseau
{
    public class ListeLignes
    {
        private List<Ligne> _lignes = new List<Ligne>();

        public ListeLignes() {
            _lignes = new List<Ligne>();
        }

        public List<Ligne> lignes {  get { return _lignes; } }

        public void AjoutLigne(Ligne ligne) { 
            _lignes.Add(ligne);
        }
    }
}
