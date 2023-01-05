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
    public partial class MeniuAdmin : Form
    {
        string numeAdmin;
        string prenumeAdmin;
        public MeniuAdmin(string nume, string prenume)
        {
            InitializeComponent();

            numeAdmin = nume;
            prenumeAdmin = prenume;
        }
    }
}
