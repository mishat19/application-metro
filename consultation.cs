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
    public partial class Consultation : Form
    {
        public Consultation()
        {
            InitializeComponent();
        }

        private void consultation_Load(object sender, EventArgs e)
        {

        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            Carte carte = new Carte();
            carte.Show();
            this.Close();
        }
    }
}
