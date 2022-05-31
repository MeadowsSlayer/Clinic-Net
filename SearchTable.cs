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
    public partial class SearchTable : Form
    {
        public string userright_lvl = "";
        public SearchTable(string user_lvl)
        {
            InitializeComponent();
            userright_lvl = user_lvl;

            String str = "Host=localhost;Username=postgres;Password=CEOofHimbos333;Database=postgres";

            NpgsqlConnection con = new NpgsqlConnection(str);

            con.Open();

            NpgsqlCommand cmd = new NpgsqlCommand("SELECT Поликлиника.patient.id, Поликлиника.patient.name, Поликлиника.patient.surname, Поликлиника.patient.chamber, Поликлиника.diagnosis.diagnosis, Поликлиника.doctor.initials FROM Поликлиника.patient  JOIN Поликлиника.doctor ON Поликлиника.patient.doc_id = Поликлиника.doctor.id JOIN Поликлиника.diagnosis ON Поликлиника.patient.diagnosis_id = Поликлиника.diagnosis.id ORDER BY Поликлиника.patient.id", con);

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
                string[] resultArr = new string[6];
                resultArr[0] = reader.GetValue(0).ToString();
                resultArr[1] = reader.GetValue(1).ToString();
                resultArr[2] = reader.GetValue(2).ToString();
                resultArr[3] = reader.GetValue(3).ToString();
                resultArr[4] = reader.GetValue(4).ToString();
                resultArr[5] = reader.GetValue(5).ToString();

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

        private void SearchTable_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void list3_Click(object sender, EventArgs e)
        {
            Areas Area = new Areas(userright_lvl);
            this.Hide();
            Area.ShowDialog();
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
                        search_query = $"SELECT Поликлиника.patient.id, Поликлиника.patient.name, Поликлиника.patient.surname, Поликлиника.patient.chamber, Поликлиника.diagnosis.diagnosis, Поликлиника.doctor.initials FROM Поликлиника.patient  JOIN Поликлиника.doctor ON Поликлиника.patient.doc_id = Поликлиника.doctor.id JOIN Поликлиника.diagnosis ON Поликлиника.patient.diagnosis_id = Поликлиника.diagnosis.id WHERE Поликлиника.patient.surname = '{i}' OR Поликлиника.patient.name = '{i}' OR Поликлиника.patient.id = {int.Parse(i)} OR Поликлиника.patient.chamber = {int.Parse(i)} OR Поликлиника.patient.doc_id = (SELECT id FROM Поликлиника.doctor WHERE initials = '{i}') OR Поликлиника.patient.diagnosis_id = (SELECT id FROM Поликлиника.diagnosis WHERE diagnosis = '{i}') ORDER BY Поликлиника.patient.id";
                    }
                    else
                    {
                        search_query = $"SELECT Поликлиника.patient.id, Поликлиника.patient.name, Поликлиника.patient.surname, Поликлиника.patient.chamber, Поликлиника.diagnosis.diagnosis, Поликлиника.doctor.initials FROM Поликлиника.patient  JOIN Поликлиника.doctor ON Поликлиника.patient.doc_id = Поликлиника.doctor.id JOIN Поликлиника.diagnosis ON Поликлиника.patient.diagnosis_id = Поликлиника.diagnosis.id WHERE Поликлиника.patient.surname = '{i}' OR Поликлиника.patient.name = '{i}' OR Поликлиника.patient.doc_id = (SELECT id FROM Поликлиника.doctor WHERE initials = '{i}') OR Поликлиника.patient.diagnosis_id = (SELECT id FROM Поликлиника.diagnosis WHERE diagnosis = '{i}') ORDER BY Поликлиника.patient.id";
                    }
                    NpgsqlCommand cmd = new NpgsqlCommand(search_query, con_search);

                    NpgsqlDataReader search_res = cmd.ExecuteReader();

                    while (search_res.Read())
                    {
                        string[] resultArr = new string[6];
                        resultArr[0] = search_res.GetValue(0).ToString();
                        resultArr[1] = search_res.GetValue(1).ToString();
                        resultArr[2] = search_res.GetValue(2).ToString();
                        resultArr[3] = search_res.GetValue(3).ToString();
                        resultArr[4] = search_res.GetValue(4).ToString();
                        resultArr[5] = search_res.GetValue(5).ToString();
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

                NpgsqlCommand cmd = new NpgsqlCommand("SELECT Поликлиника.patient.id, Поликлиника.patient.name, Поликлиника.patient.surname, Поликлиника.patient.chamber, Поликлиника.diagnosis.diagnosis, Поликлиника.doctor.initials FROM Поликлиника.patient  JOIN Поликлиника.doctor ON Поликлиника.patient.doc_id = Поликлиника.doctor.id JOIN Поликлиника.diagnosis ON Поликлиника.patient.diagnosis_id = Поликлиника.diagnosis.id ORDER BY Поликлиника.petient.id", con);

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
                    string[] resultArr = new string[6];
                    resultArr[0] = reader.GetValue(0).ToString();
                    resultArr[1] = reader.GetValue(1).ToString();
                    resultArr[2] = reader.GetValue(2).ToString();
                    resultArr[3] = reader.GetValue(3).ToString();
                    resultArr[4] = reader.GetValue(4).ToString();
                    resultArr[5] = reader.GetValue(5).ToString();

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

        //Вывод Списка Пациентов
        private void list1_Click(object sender, EventArgs e)
        {
            table.Rows.Clear();

            String str = "Host=localhost;Username=postgres;Password=CEOofHimbos333;Database=postgres";

            NpgsqlConnection con = new NpgsqlConnection(str);

            con.Open();

            NpgsqlCommand cmd = new NpgsqlCommand("SELECT Поликлиника.patient.id, Поликлиника.patient.name, Поликлиника.patient.surname, Поликлиника.patient.chamber, Поликлиника.diagnosis.diagnosis, Поликлиника.doctor.initials FROM Поликлиника.patient  JOIN Поликлиника.doctor ON Поликлиника.patient.doc_id = Поликлиника.doctor.id JOIN Поликлиника.diagnosis ON Поликлиника.patient.diagnosis_id = Поликлиника.diagnosis.id", con);

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
                string[] resultArr = new string[6];
                resultArr[0] = reader.GetValue(0).ToString();
                resultArr[1] = reader.GetValue(1).ToString();
                resultArr[2] = reader.GetValue(2).ToString();
                resultArr[3] = reader.GetValue(3).ToString();
                resultArr[4] = reader.GetValue(4).ToString();
                resultArr[5] = reader.GetValue(5).ToString();

                rows[i] = resultArr;
                i += 1;
            }

            con.Close();

            foreach (string[] rowArray in rows)
            {
                table.Rows.Add(rowArray);
            }
        }

        private void admin_mod_Click(object sender, EventArgs e)
        {
            int pat_id = int.Parse(table.Rows[table.CurrentCell.RowIndex].Cells[0].Value.ToString());
            ChangePatientInfo editpatient = new ChangePatientInfo(userright_lvl, pat_id);
            this.Hide();
            editpatient.ShowDialog();
            this.Close();
        }

        private void create_Click(object sender, EventArgs e)
        {
            AddPatient newpatient = new AddPatient();
            this.Hide();
            newpatient.ShowDialog();
            this.Close();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            DeletePatient deletepat = new DeletePatient(userright_lvl, int.Parse(table.Rows[table.CurrentCell.RowIndex].Cells[0].Value.ToString()));
            this.Hide();
            deletepat.ShowDialog();
            this.Close();
        }

        private void more_Click(object sender, EventArgs e)
        {
            MoreAboutPatient info = new MoreAboutPatient(int.Parse(table.Rows[table.CurrentCell.RowIndex].Cells[0].Value.ToString()));
            info.ShowDialog();
        }

        private void doctors_Click(object sender, EventArgs e)
        {
            Doctors Doc_Table = new Doctors(userright_lvl);
            this.Hide();
            Doc_Table.ShowDialog();
            this.Close();
        }
    }
}
