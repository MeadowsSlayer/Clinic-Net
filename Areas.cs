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
    public partial class Areas : Form
    {
        public string userright_lvl = "";
        public Areas(string user_lvl)
        {
            InitializeComponent();
            userright_lvl = user_lvl;

            String str = "Host=localhost;Username=postgres;Password=CEOofHimbos333;Database=postgres";

            NpgsqlConnection con = new NpgsqlConnection(str);

            con.Open();

            NpgsqlCommand cmd = new NpgsqlCommand("SELECT Поликлиника.address.id, Поликлиника.address.address, Поликлиника.area.area FROM Поликлиника.area JOIN Поликлиника.address ON Поликлиника.address.area_id = Поликлиника.area.id ORDER BY Поликлиника.area.id", con);

            NpgsqlDataReader counter = cmd.ExecuteReader();

            int count = 0;
            while (counter.Read())
            {
                count++;
            }

            counter.Close();

            object[] rows = new object[count];
            int i = 0;

            NpgsqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string[] resultArr = new string[3];
                resultArr[0] = reader.GetValue(0).ToString();
                resultArr[1] = reader.GetValue(1).ToString();
                resultArr[2] = reader.GetValue(2).ToString();

                rows[i] = resultArr;
                i += 1;
            }

            con.Close();

            foreach (string[] rowArray in rows)
            {
                table.Rows.Add(rowArray);
            }

            if (user_lvl != "0")
            {
                delete.Hide();
                create.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Doctors Doc_Table = new Doctors(userright_lvl);
            this.Hide();
            Doc_Table.ShowDialog();
            this.Close();
        }

        private void patients_Click(object sender, EventArgs e)
        {
            SearchTable Patient_Table = new SearchTable(userright_lvl);
            this.Hide();
            Patient_Table.ShowDialog();
            this.Close();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (search.Text != "")
            {
                table.Rows.Clear();
                string search_query = "";
                int n;
                var words = search.Text.Split(' ');
                String str = "Host=localhost;Username=postgres;Password=CEOofHimbos333;Database=postgres";
                NpgsqlConnection con_search = new NpgsqlConnection(str);
                con_search.Open();

                foreach (string i in words)
                {
                    if (int.TryParse(i, out n) == true)
                    {
                        search_query = $"SELECT Поликлиника.address.id, Поликлиника.address.address, Поликлиника.area.area FROM Поликлиника.area JOIN Поликлиника.address ON Поликлиника.address.area_id = Поликлиника.area.id WHERE Поликлиника.address.address = '{i}' OR Поликлиника.area.area = '{i}' OR Поликлиника.area.id = {int.Parse(i)} ORDER BY Поликлиника.area.id";
                    }
                    else
                    {
                        search_query = $"SELECT Поликлиника.address.id, Поликлиника.address.address, Поликлиника.area.area FROM Поликлиника.area JOIN Поликлиника.address ON Поликлиника.address.area_id = Поликлиника.area.id WHERE Поликлиника.address.address = '{i}' OR Поликлиника.area.area = '{i}' ORDER BY Поликлиника.area.id";
                    }
                    NpgsqlCommand cmd = new NpgsqlCommand(search_query, con_search);

                    NpgsqlDataReader search_res = cmd.ExecuteReader();

                    while (search_res.Read())
                    {
                        string[] resultArr = new string[3];
                        resultArr[0] = search_res.GetValue(0).ToString();
                        resultArr[1] = search_res.GetValue(1).ToString();
                        resultArr[2] = search_res.GetValue(2).ToString();
                        table.Rows.Add(resultArr);
                    }
                    search_res.Close();
                }
                con_search.Close();
            }
            else
            {
                table.Rows.Clear();

                String str = "Host=localhost;Username=postgres;Password=CEOofHimbos333;Database=postgres";

                NpgsqlConnection con = new NpgsqlConnection(str);

                con.Open();

                NpgsqlCommand cmd = new NpgsqlCommand("SELECT Поликлиника.address.id, Поликлиника.address.address, Поликлиника.area.area FROM Поликлиника.area JOIN Поликлиника.address ON Поликлиника.address.area_id = Поликлиника.area.id ORDER BY Поликлиника.area.id", con);

                NpgsqlDataReader counter = cmd.ExecuteReader();

                int count = 0;
                while (counter.Read())
                {
                    count++;
                }

                counter.Close();

                object[] rows = new object[count];
                int i = 0;

                NpgsqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string[] resultArr = new string[3];
                    resultArr[0] = reader.GetValue(0).ToString();
                    resultArr[1] = reader.GetValue(1).ToString();
                    resultArr[2] = reader.GetValue(2).ToString();

                    rows[i] = resultArr;
                    i += 1;
                }

                con.Close();

                foreach (string[] rowArray in rows)
                {
                    table.Rows.Add(rowArray);
                }
            }
        }

        private void Change_Click(object sender, EventArgs e)
        {
            EditAddress EditAddrss = new EditAddress(userright_lvl, int.Parse(table.Rows[table.CurrentCell.RowIndex].Cells[0].Value.ToString()));
            this.Hide();
            EditAddrss.ShowDialog();
            this.Close();
        }

        private void more_Click(object sender, EventArgs e)
        {
            MoreAboutArea MoreAbout = new MoreAboutArea(userright_lvl, int.Parse(table.Rows[table.CurrentCell.RowIndex].Cells[0].Value.ToString()));
            MoreAbout.ShowDialog();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            DeleteAddress Del = new DeleteAddress(userright_lvl, int.Parse(table.Rows[table.CurrentCell.RowIndex].Cells[0].Value.ToString()));
            this.Hide();
            Del.ShowDialog();
            this.Close();
        }

        private void create_Click(object sender, EventArgs e)
        {
            AddAddress AddAddd = new AddAddress(userright_lvl);
            this.Hide();
            AddAddd.ShowDialog();
            this.Close();
        }
    }
}
