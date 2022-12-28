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
    public partial class LoginMenu : Form
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
        public LoginMenu()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            //conn = new MySqlConnection("Server=127.0.0.1;Database=policlinica;Uid='root';Pwd='Sincopa2*';");
            //conn.Open();
            //SetInvisibleControls();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*if (listBox1.Text == "Administrator")
            {
                conn = new MySqlConnection("Server=127.0.0.1;Database=policlinica;Uid='administrator';Pwd='cristinadariusbd10*';");
                conn.Open();

                MeniuAdmin secondWindow = new MeniuAdmin();
                secondWindow.Show();
            }

            if (listBox1.Text == "Super-Administrator")
            {
                conn = new MySqlConnection("Server=127.0.0.1;Database=policlinica;Uid='super-administrator';Pwd='cristinadariusbd10*';");
                conn.Open();

                MeniuSuperAdmin secondWindow = new MeniuSuperAdmin();
                secondWindow.Show();
            }

            if (listBox1.Text == "Inspector Resurse Umane")
            {
                conn = new MySqlConnection("Server=127.0.0.1;Database=policlinica;Uid='angajat';Pwd='cristinadariusbd10*';");
                conn.Open();

                MeniuInspector secondWindow = new MeniuInspector();
                this.Hide();
                secondWindow.Show();
                this.Close();
            }

            if (listBox1.Text == "Expert Financiar-Contabil")
            {
                conn = new MySqlConnection("Server=127.0.0.1;Database=policlinica;Uid='angajat';Pwd='cristinadariusbd10*';");
                conn.Open();

                MeniuExpert secondWindow = new MeniuExpert();
                secondWindow.Show();
            }

            if (listBox1.Text == "Receptioner")
            {
                conn = new MySqlConnection("Server=127.0.0.1;Database=policlinica;Uid='angajat';Pwd='cristinadariusbd10*';");
                conn.Open();

                MeniuReceptioner secondWindow = new MeniuReceptioner();
                secondWindow.Show();
            }

            if (listBox1.Text == "Asistent Medical")
            {
                conn = new MySqlConnection("Server=127.0.0.1;Database=policlinica;Uid='angajat';Pwd='cristinadariusbd10*';");
                conn.Open();

                MeniuAsistent secondWindow = new MeniuAsistent();
                secondWindow.Show();
            }

            if (listBox1.Text == "Medic")
            {
                conn = new MySqlConnection("Server=127.0.0.1;Database=policlinica;Uid='angajat';Pwd='cristinadariusbd10*';");
                conn.Open();

                MeniuMedic secondWindow = new MeniuMedic();
                secondWindow.Show();
            }*/
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.Text == "Administrator")
                if (string.Compare(textBox1.Text, "administrator") == 0)
                {
                    conn = new MySqlConnection("Server=127.0.0.1;Database=policlinica;Uid='administrator';Pwd='cristinadariusbd10*';");
                    conn.Open();

                    MeniuAdmin secondWindow = new MeniuAdmin();
                    secondWindow.Show();
                }

            if (listBox1.Text == "Super-Administrator")
                if (string.Compare(textBox1.Text, "super-administrator") == 0)
                {
                    conn = new MySqlConnection("Server=127.0.0.1;Database=policlinica;Uid='super-administrator';Pwd='cristinadariusbd10*';");
                    conn.Open();

                    MeniuSuperAdmin secondWindow = new MeniuSuperAdmin();
                    secondWindow.Show();
                }

            if (listBox1.Text == "Inspector Resurse Umane")
                if ((string.Compare(textBox1.Text, "angajat") == 0) &&
                    (string.Compare(textBox2.Text, "cristinadariusbd10*") == 0))
                {
                    conn = new MySqlConnection("Server=127.0.0.1;Database=policlinica;Uid='angajat';Pwd='cristinadariusbd10*';");
                    conn.Open();

                    MeniuInspector secondWindow = new MeniuInspector();
                    secondWindow.Show();
                }

            if (listBox1.Text == "Expert Financiar-Contabil")
                if ((string.Compare(textBox1.Text, "angajat") == 0) &&
                    (string.Compare(textBox2.Text, "cristinadariusbd10*") == 0))
                {
                    conn = new MySqlConnection("Server=127.0.0.1;Database=policlinica;Uid='angajat';Pwd='cristinadariusbd10*';");
                    conn.Open();

                    MeniuExpert secondWindow = new MeniuExpert();
                    secondWindow.Show();
                }

            if (listBox1.Text == "Receptioner")
                if ((string.Compare(textBox1.Text, "angajat") == 0) &&
                    (string.Compare(textBox2.Text, "cristinadariusbd10*") == 0))
                {
                    conn = new MySqlConnection("Server=127.0.0.1;Database=policlinica;Uid='angajat';Pwd='cristinadariusbd10*';");
                    conn.Open();

                    MeniuReceptioner secondWindow = new MeniuReceptioner();
                    secondWindow.Show();
                }

            if (listBox1.Text == "Asistent Medical")
                if ((string.Compare(textBox1.Text, "angajat") == 0) &&
                    (string.Compare(textBox2.Text, "cristinadariusbd10*") == 0))
                {
                    conn = new MySqlConnection("Server=127.0.0.1;Database=policlinica;Uid='angajat';Pwd='cristinadariusbd10*';");
                    conn.Open();

                    MeniuAsistent secondWindow = new MeniuAsistent();
                    secondWindow.Show();
                }

            if (listBox1.Text == "Medic")
                if ((string.Compare(textBox1.Text, "angajat") == 0) &&
                    (string.Compare(textBox2.Text, "cristinadariusbd10*") == 0))
                {
                    conn = new MySqlConnection("Server=127.0.0.1;Database=policlinica;Uid='angajat';Pwd='cristinadariusbd10*';");
                    conn.Open();

                    MeniuMedic secondWindow = new MeniuMedic();
                    secondWindow.Show();
                }
            
        }
    }
}
