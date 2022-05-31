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
    public partial class EditAddress : Form
    {
        public string userright_lvl = "";
        public int address_id = 0;
        public EditAddress(string user_lvl, int id)
        {
            InitializeComponent();
            userright_lvl = user_lvl;
            address_id = id;

            String str = "Host=localhost;Username=postgres;Password=CEOofHimbos333;Database=postgres";
            NpgsqlConnection con1 = new NpgsqlConnection(str);
            con1.Open();

            string area_query = "SELECT area FROM Поликлиника.area ORDER BY id";
            string query = $"SELECT Поликлиника.address.address, Поликлиника.area.area FROM Поликлиника.address JOIN Поликлиника.area ON Поликлиника.area.id = Поликлиника.address.area_id WHERE Поликлиника.address.id = {id}";

            NpgsqlCommand area_cmd = new NpgsqlCommand(area_query, con1);
            NpgsqlDataReader areaget = area_cmd.ExecuteReader();
            while (areaget.Read())
            {
                area.Items.Add(areaget.GetValue(0).ToString());
            }
            areaget.Close();

            NpgsqlCommand data_cmd = new NpgsqlCommand(query, con1);
            NpgsqlDataReader data = data_cmd.ExecuteReader();
            while (data.Read())
            {
                address.Text = data.GetValue(0).ToString();
                area.Text = data.GetValue(1).ToString();
            }

            con1.Close();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Areas Area = new Areas(userright_lvl);
            this.Hide();
            Area.ShowDialog();
            this.Close();
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

                    string insert_query = $"UPDATE Поликлиника.address SET address = '{address.Text}', area_id = {area.SelectedIndex} WHERE id = {address_id}";
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
    }
}
