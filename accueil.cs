using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace application_metro
{
    public partial class Accueil : Form
    {
        //private Ouverture _ouverture;

        public Accueil()
        {
            InitializeComponent();
            //_ouverture = ouverture;
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
        }

        // Méthode publique pour mettre à jour le texte du bouton
        public void UpdateBtnRetourText(string newText)
        {
            btnRetour.Text = newText;
        }
    }
}