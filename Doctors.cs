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
    public partial class Doctors : Form
    {
        public string user_rights;
        public Doctors(string user_lvl)
        {
            InitializeComponent();
            user_rights = user_lvl;

            String str = "Host=localhost;Username=postgres;Password=CEOofHimbos333;Database=postgres";

            NpgsqlConnection con = new NpgsqlConnection(str);

            con.Open();

            NpgsqlCommand cmd = new NpgsqlCommand("SELECT Поликлиника.doctor.id, Поликлиника.doctor.name, Поликлиника.doctor.surname, Поликлиника.doctor.fathername, Поликлиника.doctorspec.speciality, Поликлиника.time.time, Поликлиника.area.area FROM Поликлиника.doctor JOIN Поликлиника.doctorspec ON Поликлиника.doctorspec.id = Поликлиника.doctor.spec_id JOIN Поликлиника.time ON Поликлиника.doctor.time_id = Поликлиника.time.id JOIN Поликлиника.area ON Поликлиника.doctor.area_id = Поликлиника.area.id ORDER BY Поликлиника.doctor.id", con);

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
                string[] resultArr = new string[7];
                resultArr[0] = reader.GetValue(0).ToString();
                resultArr[1] = reader.GetValue(1).ToString();
                resultArr[2] = reader.GetValue(2).ToString();
                resultArr[3] = reader.GetValue(3).ToString();
                resultArr[4] = reader.GetValue(4).ToString();
                resultArr[5] = reader.GetValue(5).ToString();
                resultArr[6] = reader.GetValue(6).ToString();

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

        private void patients_Click(object sender, EventArgs e)
        {
            SearchTable Patient_Table = new SearchTable(user_rights);
            this.Hide();
            Patient_Table.ShowDialog();
            this.Close();
        }

        private void Change_Click(object sender, EventArgs e)
        {
            EditDoctor Edit_Doc_Table = new EditDoctor(user_rights, int.Parse(table.Rows[table.CurrentCell.RowIndex].Cells[0].Value.ToString()));
            this.Hide();
            Edit_Doc_Table.ShowDialog();
            this.Close();
        }

        private void create_Click(object sender, EventArgs e)
        {
            AddDoctor AddDoc = new AddDoctor(user_rights);
            this.Hide();
            AddDoc.ShowDialog();
            this.Close();
        }

        private void more_Click(object sender, EventArgs e)
        {
            MoreAboutDoctor MoreAboutDoc = new MoreAboutDoctor(user_rights, int.Parse(table.Rows[table.CurrentCell.RowIndex].Cells[0].Value.ToString()));
            MoreAboutDoc.ShowDialog();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            DeleteDoctor DeleteDoc = new DeleteDoctor(user_rights, int.Parse(table.Rows[table.CurrentCell.RowIndex].Cells[0].Value.ToString()));
            this.Hide();
            DeleteDoc.ShowDialog();
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
                        search_query = $"SELECT Поликлиника.doctor.id, Поликлиника.doctor.name, Поликлиника.doctor.surname, Поликлиника.doctor.fathername, Поликлиника.doctorspec.speciality, Поликлиника.time.time, Поликлиника.area.area FROM Поликлиника.doctor JOIN Поликлиника.doctorspec ON Поликлиника.doctorspec.id = Поликлиника.doctor.spec_id JOIN Поликлиника.time ON Поликлиника.doctor.time_id = Поликлиника.time.id JOIN Поликлиника.area ON Поликлиника.doctor.area_id = Поликлиника.area.id WHERE Поликлиника.doctor.surname = '{i}' OR Поликлиника.doctor.name = '{i}' OR Поликлиника.doctor.id = {int.Parse(i)} OR Поликлиника.doctor.fathername = '{i}' OR Поликлиника.doctor.spec_id = (SELECT id FROM Поликлиника.doctorspec WHERE speciality = '{i}') OR Поликлиника.doctor.area_id = (SELECT id FROM Поликлиника.area WHERE area = '{i}') OR Поликлиника.doctor.time_id = (SELECT id FROM Поликлиника.time WHERE time = '{i}') ORDER BY Поликлиника.doctor.id";
                    }
                    else
                    {
                        search_query = $"SELECT Поликлиника.doctor.id, Поликлиника.doctor.name, Поликлиника.doctor.surname, Поликлиника.doctor.fathername, Поликлиника.doctorspec.speciality, Поликлиника.time.time, Поликлиника.area.area FROM Поликлиника.doctor JOIN Поликлиника.doctorspec ON Поликлиника.doctorspec.id = Поликлиника.doctor.spec_id JOIN Поликлиника.time ON Поликлиника.doctor.time_id = Поликлиника.time.id JOIN Поликлиника.area ON Поликлиника.doctor.area_id = Поликлиника.area.id WHERE Поликлиника.doctor.surname = '{i}' OR Поликлиника.doctor.name = '{i}' OR Поликлиника.doctor.fathername = '{i}' OR Поликлиника.doctor.spec_id = (SELECT id FROM Поликлиника.doctorspec WHERE speciality = '{i}') OR Поликлиника.doctor.area_id = (SELECT id FROM Поликлиника.area WHERE area = '{i}') OR Поликлиника.doctor.time_id = (SELECT id FROM Поликлиника.time WHERE time = '{i}') ORDER BY Поликлиника.doctor.id";
                    }
                    NpgsqlCommand cmd = new NpgsqlCommand(search_query, con_search);

                    NpgsqlDataReader search_res = cmd.ExecuteReader();

                    while (search_res.Read())
                    {
                        string[] resultArr = new string[7];
                        resultArr[0] = search_res.GetValue(0).ToString();
                        resultArr[1] = search_res.GetValue(1).ToString();
                        resultArr[2] = search_res.GetValue(2).ToString();
                        resultArr[3] = search_res.GetValue(3).ToString();
                        resultArr[4] = search_res.GetValue(4).ToString();
                        resultArr[5] = search_res.GetValue(5).ToString();
                        resultArr[6] = search_res.GetValue(6).ToString();
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

                NpgsqlCommand cmd = new NpgsqlCommand("SELECT Поликлиника.doctor.id, Поликлиника.doctor.name, Поликлиника.doctor.surname, Поликлиника.doctor.fathername, Поликлиника.doctorspec.speciality, Поликлиника.time.time, Поликлиника.area.area FROM Поликлиника.doctor JOIN Поликлиника.doctorspec ON Поликлиника.doctorspec.id = Поликлиника.doctor.spec_id JOIN Поликлиника.time ON Поликлиника.doctor.time_id = Поликлиника.time.id JOIN Поликлиника.area ON Поликлиника.doctor.area_id = Поликлиника.area.id ORDER BY Поликлиника.doctor.id", con);

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
                    string[] resultArr = new string[7];
                    resultArr[0] = reader.GetValue(0).ToString();
                    resultArr[1] = reader.GetValue(1).ToString();
                    resultArr[2] = reader.GetValue(2).ToString();
                    resultArr[3] = reader.GetValue(3).ToString();
                    resultArr[4] = reader.GetValue(4).ToString();
                    resultArr[5] = reader.GetValue(5).ToString();
                    resultArr[6] = reader.GetValue(6).ToString();

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

        private void areas_Click(object sender, EventArgs e)
        {
            Areas Area = new Areas(user_rights);
            this.Hide();
            Area.ShowDialog();
            this.Close();
        }
    }
}
