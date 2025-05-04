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
    public partial class Gestion : Form
    {
        public Gestion()
        {
            InitializeComponent();
        }

        private void gestion_Load(object sender, EventArgs e)
        {

        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            Accueil accueil = new Accueil();
            accueil.Show();
            this.Close();
        }

        private void btnModif_Click(object sender, EventArgs e)
        {
            Gestion_modification modif = new Gestion_modification();
            modif.Show();
            this.Close();
        }

        private void btnSupp_Click(object sender, EventArgs e)
        {
            SuppressionWindow suppression = new SuppressionWindow();
            suppression.Show();
            this.Close();
        }
    }
}
