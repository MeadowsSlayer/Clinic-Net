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
    public partial class DeleteAddress : Form
    {
        public string userright_lvl = "";
        public int address_id = 0;

        public DeleteAddress(string user_lvl, int id)
        {
            InitializeComponent();
            userright_lvl = user_lvl;
            address_id = id;

            String str = "Host=localhost;Username=postgres;Password=CEOofHimbos333;Database=postgres";
            NpgsqlConnection con1 = new NpgsqlConnection(str);
            con1.Open();

            string query = $"SELECT Поликлиника.address.address, Поликлиника.area.area FROM Поликлиника.address JOIN Поликлиника.area ON Поликлиника.area.id = Поликлиника.address.area_id WHERE Поликлиника.address.id = {id}";

            NpgsqlCommand data_cmd = new NpgsqlCommand(query, con1);
            NpgsqlDataReader data = data_cmd.ExecuteReader();
            while (data.Read())
            {
                address.Text = data.GetValue(0).ToString();
                area.Text = data.GetValue(1).ToString();
            }

            con1.Close();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            String str = "Host=localhost;Username=postgres;Password=CEOofHimbos333;Database=postgres";
            NpgsqlConnection con = new NpgsqlConnection(str);
            con.Open();
            string del_query = $"DELETE FROM Поликлиника.address WHERE id = {address_id}";

            NpgsqlCommand del_cmd = new NpgsqlCommand(del_query, con);
            del_cmd.ExecuteNonQuery();

            con.Close();

            Areas Area = new Areas(userright_lvl);
            this.Hide();
            Area.ShowDialog();
            this.Close();
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
