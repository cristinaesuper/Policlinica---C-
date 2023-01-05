using MySql.Data.MySqlClient;
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
    public partial class MeniuAsistent : Form
    {
        string numeAsistent;
        string prenumeAsistent;
        public MeniuAsistent(string nume, string prenume)
        {
            InitializeComponent();

            numeAsistent = nume;
            prenumeAsistent = prenume;
        }

        string cmdString;
        MySqlDataAdapter daAdapter = null;
        DataSet ds = null;
        MySqlConnection conn = null;

        private void MeniuAsistent_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dateTimePicker2.Text == "")
            {
                MessageBox.Show("Alegeti o data calendaristica!");
            }
            else
            {
                conn = new MySqlConnection("Server=127.0.0.1;Database=policlinica;Uid='angajat';Pwd='cristinadariusbd10*';");
                conn.Open();

                string Tabel = "OrarAngajatiFaraMedici";
                cmdString = "SELECT oraInceput, oraSfarsit FROM OrarAngajatiFaraMedici" +
                    " WHERE OrarAngajatiFaraMedici.numeAngajat = '" + numeAsistent +
                    "' AND OrarAngajatiFaraMedici.prenumeAngajat = '" + prenumeAsistent + "';";
                daAdapter = new MySqlDataAdapter(cmdString, conn);
                ds = new DataSet();
                daAdapter.Fill(ds, Tabel);
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = Tabel;
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn = new MySqlConnection("Server=127.0.0.1;Database=policlinica;Uid='angajat';Pwd='cristinadariusbd10*';");
            conn.Open();

            string Tabel = "Concedii";
            cmdString = "SELECT dataInceput, dataSfarsit FROM Concedii" +
                " WHERE Concedii.numeAngajat = '" + numeAsistent +
                "' AND Concedii.prenumeAngajat = '" + prenumeAsistent + "';";
            daAdapter = new MySqlDataAdapter(cmdString, conn);
            ds = new DataSet();
            daAdapter.Fill(ds, Tabel);
            dataGridView2.DataSource = ds;
            dataGridView2.DataMember = Tabel;

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
