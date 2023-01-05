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
    public partial class MeniuSuperAdmin : Form
    {
        string numeSuperAdmin;
        string prenumeSuperAdmin;
        public MeniuSuperAdmin(string nume, string prenume)
        {
            InitializeComponent();

            numeSuperAdmin = nume;
            prenumeSuperAdmin = prenume;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }
    }
}
