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
    public partial class MeniuExpert : Form
    {
        string numeExpert;
        string prenumeExpert;
        public MeniuExpert(string nume, string prenume)
        {
            InitializeComponent();

            numeExpert = nume;
            prenumeExpert = prenume;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }
    }
}
