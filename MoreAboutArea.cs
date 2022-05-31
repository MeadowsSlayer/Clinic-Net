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
    public partial class MoreAboutArea : Form
    {
        public string userright_lvl = "";
        public int address_id = 0;

        public MoreAboutArea(string user_lvl, int id)
        {
            InitializeComponent();
            userright_lvl = user_lvl;
            address_id = id;

            String str = "Host=localhost;Username=postgres;Password=CEOofHimbos333;Database=postgres";
            NpgsqlConnection con1 = new NpgsqlConnection(str);
            con1.Open();

            string doc_query = $"SELECT initials FROM Поликлиника.doctor WHERE area_id = (SELECT area_id FROM Поликлиника.address WHERE id = {id})";
            string query = $"SELECT Поликлиника.address.address, Поликлиника.area.area FROM Поликлиника.address JOIN Поликлиника.area ON Поликлиника.area.id = Поликлиника.address.area_id WHERE Поликлиника.address.id = {id}";
            
            NpgsqlCommand doc_cmd = new NpgsqlCommand(doc_query, con1);
            NpgsqlDataReader counter = doc_cmd.ExecuteReader();

            int count = 0;
            while (counter.Read())
            {
                count++;
            }

            counter.Close();

            object[] rows = new object[count];
            int i = 0;

            NpgsqlDataReader docget = doc_cmd.ExecuteReader();
            while (docget.Read())
            {
                string[] res = new string[1];
                res[0] = docget.GetValue(0).ToString();

                rows[i] = res;
                i++;
            }
            docget.Close();

            foreach (string[] rowArray in rows)
            {
                dataGridView1.Rows.Add(rowArray);
            }

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
            this.Hide();
            this.Close();
        }
    }
}
