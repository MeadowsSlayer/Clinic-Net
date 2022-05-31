using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Npgsql;

namespace Clinic_Net
{
    public partial class Main : Form
    {
        public string user_lvl = "";

        public Main()
        {
            
            InitializeComponent();

            password.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool access = false;
            try
            {
                String str = "Host=localhost;Username=postgres;Password=CEOofHimbos333;Database=postgres";
                string query = $"SELECT password FROM Поликлиника.staff WHERE login = '{login.Text}'";
                string query2 = $"SELECT rights_lvl FROM Поликлиника.staff WHERE login = '{login.Text}'";

                NpgsqlConnection con = new NpgsqlConnection(str);

                con.Open();

                NpgsqlCommand cmd = new NpgsqlCommand(query, con);
                NpgsqlDataReader reader = cmd.ExecuteReader();
                string pass = "";

                while (reader.Read())
                {
                    pass = reader.GetValue(0).ToString();                 
                }

                if (pass == password.Text)
                {
                    access = true;
                }
                else
                {
                    MessageBox.Show("Неправильный пароль.");
                }

                reader.Close();

                NpgsqlCommand cmd2 = new NpgsqlCommand(query2, con);
                NpgsqlDataReader lvl = cmd2.ExecuteReader();

                while (lvl.Read())
                {
                    user_lvl = lvl.GetValue(0).ToString();
                }

                con.Close();
            }
            catch (Exception es)
            {
                MessageBox.Show("Неправильные логин или пароль.");
            }

            if (access == true)
            {
                SearchTable Table = new SearchTable(user_lvl);
                this.Hide();
                Table.ShowDialog();
                this.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
