using Policlinica.Functii;
using Policlinica.Informatii_angajati;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Policlinica.Meniuri
{
    public partial class MeniuInspector : Form
    {
        public MeniuInspector()
        {
            InitializeComponent();
        }

        private void Nume_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Orar secondWindow = new Orar();
            secondWindow.Show();
        }
    }
}
