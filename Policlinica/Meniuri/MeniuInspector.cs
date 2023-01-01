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
        public MeniuInspector()
        {
            InitializeComponent();
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
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Completati toate campurile!");
            }
            else
            {

                //Orar secondWindow = new Orar();
                //secondWindow.Show();

                conn = new MySqlConnection("Server=127.0.0.1;Database=policlinica;Uid='angajat';Pwd='cristinadariusbd10*';");
                conn.Open();

                string Tabel = "Utilizatori";
                cmdString = "select * from " + Tabel;                 //!!!!!! Nu merge cu where
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
    }
}
