using MySql.Data.MySqlClient;
using Policlinica.Functii;
using Policlinica.Informatii_angajati;
using System;
using System.Data;
using System.Data.Common;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Policlinica.Meniuri
{
    public partial class MeniuInspector : Form
    {
        string numeInspector;
        string prenumeInspector;
        public MeniuInspector(string nume, string prenume)
        {
            InitializeComponent();

            numeInspector = nume;
            prenumeInspector = prenume;
        }

        private void Nume_Click(object sender, EventArgs e)
        {

        }

        string cmdString;
        MySqlDataAdapter daAdapter = null;
        DataSet ds = null;
        MySqlConnection conn = null;
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || listBox1.Text == "")
            {
                MessageBox.Show("Completati toate campurile!");
            }
            else
            {
                conn = new MySqlConnection("Server=127.0.0.1;Database=policlinica;Uid='angajat';Pwd='cristinadariusbd10*';");
                conn.Open();

                string Tabel = "Orar";
                cmdString = "SELECT dataConsult, oraConsult, numePacient, prenumePacient" +
                    " FROM Orar WHERE Orar.numeMedic = '" + textBox1.Text  + "' AND Orar.prenumeMedic = '" + textBox2.Text  + "';";     
                daAdapter = new MySqlDataAdapter(cmdString, conn);
                ds = new DataSet();
                daAdapter.Fill(ds, Tabel);
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = Tabel;
            } 
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dateTimePicker1.Text == "")
            {
                MessageBox.Show("Alegeti o data calendaristica!");
            }
            else
            {
                conn = new MySqlConnection("Server=127.0.0.1;Database=policlinica;Uid='angajat';Pwd='cristinadariusbd10*';");
                conn.Open();

                string Tabel = "OrarAngajatiFaraMedici";
                cmdString = "SELECT oraInceput, oraSfarsit FROM OrarAngajatiFaraMedici" +
                    " WHERE OrarAngajatiFaraMedici.numeAngajat = '" + numeInspector +
                    "' AND OrarAngajatiFaraMedici.prenumeAngajat = '" + prenumeInspector + "';";
                daAdapter = new MySqlDataAdapter(cmdString, conn);
                ds = new DataSet();
                daAdapter.Fill(ds, Tabel);
                dataGridView2.DataSource = ds;
                dataGridView2.DataMember = Tabel;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conn = new MySqlConnection("Server=127.0.0.1;Database=policlinica;Uid='angajat';Pwd='cristinadariusbd10*';");
            conn.Open();

            string Tabel = "Concedii";
            cmdString = "SELECT oraInceput, oraSfarsit FROM Concedii" +
                " WHERE Concedii.numeAngajat = '" + numeInspector +
                "' AND Concedii.prenumeAngajat = '" + prenumeInspector + "';";
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
