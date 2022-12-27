using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Policlinica;
using Policlinica.Functii;
using Policlinica.FunctiiAngajati;
using Policlinica.Meniuri;

namespace Policlinica
{
    public partial class Main : Form
    {
        MySqlConnection conn = null;
        MySqlCommand cmd = null;
        string cmdString = null;
        MySqlDataAdapter daAdapter = null;
        DataSet ds = null;

        AddAdmin admin;
        AddSuperAdmin superAdmin;
        AddAngajat angajat;

        AddMedic medic;
        AddAsistent asistent;
        AddExpert expert;
        AddInspector inspector;
        AddReceptioner receptioner;

        int IdS;
        DataGridViewRow row;
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            conn = new MySqlConnection("Server=127.0.0.1;Database=policlinica;Uid='root';Pwd='Sincopa2*';");
            conn.Open();
            //SetInvisibleControls();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.Text == "Administrator")
            {
                //conn = new MySqlConnection("Server=127.0.0.1;Database=policlinica;Uid='administrator';Pwd='cristinadariusbd10*';");
                //conn.Open();

                MeniuAdmin secondWindow = new MeniuAdmin();
                secondWindow.Show();
            }

            if (listBox1.Text == "Super-Administrator")
            {
                //conn = new MySqlConnection("Server=127.0.0.1;Database=policlinica;Uid='root';Pwd='Sincopa2*';");
                //conn.Open();

                MeniuSuperAdmin secondWindow = new MeniuSuperAdmin();
                secondWindow.Show();
            }

            if (listBox1.Text == "Inspector Resurse Umane")
            {
                //conn = new MySqlConnection("Server=127.0.0.1;Database=policlinica;Uid='root';Pwd='Sincopa2*';");
                //conn.Open();

                MeniuInspector secondWindow = new MeniuInspector();
                secondWindow.Show();
            }

            if (listBox1.Text == "Expert Financiar-Contabil")
            {
               // conn = new MySqlConnection("Server=127.0.0.1;Database=policlinica;Uid='root';Pwd='Sincopa2*';");
               // conn.Open();

                MeniuExpert secondWindow = new MeniuExpert();
                secondWindow.Show();
            }

            if (listBox1.Text == "Receptioner")
            {
               // conn = new MySqlConnection("Server=127.0.0.1;Database=policlinica;Uid='root';Pwd='Sincopa2*';");
               // conn.Open();

                MeniuReceptioner secondWindow = new MeniuReceptioner();
                secondWindow.Show();
            }

            if (listBox1.Text == "Asistent Medical")
            {
                MeniuAsistent secondWindow = new MeniuAsistent();
                secondWindow.Show();
            }

            if (listBox1.Text == "Medic")
            {
                MeniuMedic secondWindow = new MeniuMedic();
                secondWindow.Show();
            }
        }
    }
}
