using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Clinic_Net
{
    public partial class AddAddress : Form
    {
        public string userright_lvl = "";
        public AddAddress(string user_lvl)
        {
            InitializeComponent();
            userright_lvl = user_lvl;

            String str = "Host=localhost;Username=postgres;Password=CEOofHimbos333;Database=postgres";
            NpgsqlConnection con1 = new NpgsqlConnection(str);
            con1.Open();

            string area_query = "SELECT area FROM Поликлиника.area ORDER BY id";
            NpgsqlCommand area_cmd = new NpgsqlCommand(area_query, con1);
            NpgsqlDataReader areaget = area_cmd.ExecuteReader();
            while (areaget.Read())
            {
                area.Items.Add(areaget.GetValue(0).ToString());
            }
            areaget.Close();

            con1.Close();
        }

        private void change_Click(object sender, EventArgs e)
        {
            if ((area.Text != null) && (address.Text != null))
            {
                try
                {
                    String str = "Host=localhost;Username=postgres;Password=CEOofHimbos333;Database=postgres";

                    NpgsqlConnection con = new NpgsqlConnection(str);

                    con.Open();

                    string insert_query = $"INSERT INTO Поликлиника.address VALUES ((SELECT max(id) FROM Поликлиника.address) + 1,'{address.Text}', {area.SelectedIndex} + 1)";
                    NpgsqlCommand cmd_insert = new NpgsqlCommand(insert_query, con);
                    cmd_insert.ExecuteNonQuery();

                    con.Close();

                    Areas Area = new Areas(userright_lvl);
                    this.Hide();
                    Area.ShowDialog();
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Неправильно введены данные.");
                }
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Areas Area = new Areas(userright_lvl);
            this.Hide();
            Area.ShowDialog();
            this.Close();
        }
    }
}
