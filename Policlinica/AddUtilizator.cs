using Policlinica.Functii;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Policlinica
{
    public partial class AddUtilizator : Form
    {
        public AddUtilizator()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.Text == "Administrator")
            {
                AddAdmin secondWindow = new AddAdmin();
                secondWindow.Show();
            }

            if (listBox1.Text == "Super-Administrator")
            {
                AddSuperAdmin secondWindow = new AddSuperAdmin();
                secondWindow.Show();
            }

            if (listBox1.Text == "Angajat")
            {
                AddAngajat secondWindow = new AddAngajat();
                secondWindow.Show();
            }
        }

        private void AddUtilizator_Load(object sender, EventArgs e)
        {

        }
    }
}
