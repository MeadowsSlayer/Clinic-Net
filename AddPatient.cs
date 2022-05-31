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
    public partial class AddPatient : Form
    {
        public AddPatient()
        {
            InitializeComponent();

            String str = "Host=localhost;Username=postgres;Password=CEOofHimbos333;Database=postgres";
            NpgsqlConnection con1 = new NpgsqlConnection(str);
            con1.Open();

            string doc_query = "SELECT initials FROM Поликлиника.doctor";
            string diagnosis_query = "SELECT diagnosis FROM Поликлиника.diagnosis";

            NpgsqlCommand doc_cmd = new NpgsqlCommand(doc_query, con1);
            NpgsqlDataReader docget = doc_cmd.ExecuteReader();
            while (docget.Read())
            {
                doctor.Items.Add(docget.GetValue(0).ToString());
            }
            docget.Close();

            NpgsqlCommand diagnosis_cmd = new NpgsqlCommand(diagnosis_query, con1);
            NpgsqlDataReader diagnosisget = diagnosis_cmd.ExecuteReader();
            while (diagnosisget.Read())
            {
                diagnosis.Items.Add(diagnosisget.GetValue(0).ToString());
            }
            diagnosisget.Close();

            con1.Close();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            SearchTable Table = new SearchTable("0");
            this.Hide();
            Table.ShowDialog();
            this.Close();
        }

        private void create_Click(object sender, EventArgs e)
        {
            if ((name.Text != null) && (sname.Text != null) && (chamber.Text != null) && (doctor.Text != null) && (dateofbirth.Value.Date != null) && (diagnosis.Text != null) && (medbook_link.Text != null))
            {
                try {
                    String str = "Host=localhost;Username=postgres;Password=CEOofHimbos333;Database=postgres";
                    string bookid = "";
                    string medbookquery = "(SELECT max(id) FROM Поликлиника.medbooks)";
                    string query1 = $"SELECT id FROM Поликлиника.medbooks WHERE booklink = '{medbook_link.Text}'";

                    NpgsqlConnection con = new NpgsqlConnection(str);

                    con.Open();

                    NpgsqlCommand cmd2 = new NpgsqlCommand(query1, con);
                    NpgsqlDataReader medbookget = cmd2.ExecuteReader();
                    while (medbookget.Read())
                    {
                        bookid = medbookget.GetValue(0).ToString();
                    }
                    medbookget.Close();

                    if (bookid != "")
                    {
                        medbookquery = bookid.ToString();
                    }
                    else
                    {
                        string insert_query_med = $"INSERT INTO Поликлиника.medbooks VALUES ((SELECT max(id) FROM Поликлиника.medbooks) + 1, '{medbook_link.Text}')";
                        NpgsqlCommand cmd_insert_med = new NpgsqlCommand(insert_query_med, con);
                        cmd_insert_med.ExecuteNonQuery();
                    }

                    string insert_query = $"INSERT INTO Поликлиника.patient VALUES ((SELECT max(id) FROM Поликлиника.patient) + 1, '{sname.Text}', '{dateofbirth.Value.Date.ToShortDateString()}', {doctor.SelectedIndex} + 1, {diagnosis.SelectedIndex} + 1, {medbookquery}, {chamber.Text}, '{name.Text}')";
                    NpgsqlCommand cmd_insert = new NpgsqlCommand(insert_query, con);
                    cmd_insert.ExecuteNonQuery();

                    con.Close();

                    SearchTable Table = new SearchTable("0");
                    this.Hide();
                    Table.ShowDialog();
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
