using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Policlinica.Meniuri
{
    public partial class MeniuMedic : Form
    {
        string numeMedic;
        string prenumeMedic;
        public MeniuMedic(string nume, string prenume)
        {
            InitializeComponent();

            numeMedic = nume;
            prenumeMedic = prenume;
        }

        string cmdString;
        MySqlDataAdapter daAdapter = null;
        DataSet ds = null;
        MySqlConnection conn = null;

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn = new MySqlConnection("Server=127.0.0.1;Database=policlinica;Uid='angajat';Pwd='cristinadariusbd10*';");
            conn.Open();

            string Tabel = "Concedii";
            cmdString = "SELECT oraInceput, oraSfarsit FROM Concedii" +
                " WHERE Concedii.numeAngajat = '" + numeMedic +
                "' AND Concedii.prenumeAngajat = '" + prenumeMedic + "';";
            daAdapter = new MySqlDataAdapter(cmdString, conn);
            ds = new DataSet();
            daAdapter.Fill(ds, Tabel);
            dataGridView3.DataSource = ds;
            dataGridView3.DataMember = Tabel;
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
