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
    public partial class ChangePatientInfo : Form
    {
        public string userright_lvl = "";
        public int pat_id = 0;
        public ChangePatientInfo(string user_lvl, int id)
        {
            InitializeComponent();
            userright_lvl = user_lvl;
            pat_id = id;

            String str = "Host=localhost;Username=postgres;Password=CEOofHimbos333;Database=postgres";
            NpgsqlConnection con1 = new NpgsqlConnection(str);
            con1.Open();

            string doc_query = "SELECT initials FROM Поликлиника.doctor ORDER BY id";
            string diagnosis_query = "SELECT diagnosis FROM Поликлиника.diagnosis ORDER BY id";
            string query = $"SELECT Поликлиника.patient.name, Поликлиника.patient.surname, Поликлиника.patient.dateofbirth, Поликлиника.patient.chamber, Поликлиника.diagnosis.diagnosis, Поликлиника.doctor.initials, Поликлиника.medbooks.booklink FROM Поликлиника.patient JOIN Поликлиника.diagnosis ON Поликлиника.patient.diagnosis_id = Поликлиника.diagnosis.id JOIN Поликлиника.doctor ON Поликлиника.patient.doc_id = Поликлиника.doctor.id JOIN Поликлиника.medbooks ON Поликлиника.patient.medbook_id = Поликлиника.medbooks.id WHERE Поликлиника.patient.id = {id}";

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

            NpgsqlCommand data_cmd = new NpgsqlCommand(query, con1);
            NpgsqlDataReader data = data_cmd.ExecuteReader();
            while (data.Read())
            {
                name.Text = data.GetValue(0).ToString();
                sname.Text = data.GetValue(1).ToString();
                dateofbirth.Text = data.GetValue(2).ToString();
                chamber.Text = data.GetValue(3).ToString();
                diagnosis.Text = data.GetValue(4).ToString();
                doctor.Text = data.GetValue(5).ToString();
                medbook_link.Text = data.GetValue(6).ToString();
            }

            con1.Close();
        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void change_Click(object sender, EventArgs e)
        {
            if ((name.Text != null) && (sname.Text != null) && (chamber.Text != null) && (doctor.Text != null) && (dateofbirth.Value.Date != null) && (diagnosis.Text != null) && (medbook_link.Text != null))
            {
                try
                {
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
                        string insert_query_med = $"UPDATE Поликлиника.medbooks SET booklink = '{medbook_link.Text}' WHERE id = {medbookquery}";
                        NpgsqlCommand cmd_insert_med = new NpgsqlCommand(insert_query_med, con);
                        cmd_insert_med.ExecuteNonQuery();
                    }

                    string insert_query = $"UPDATE Поликлиника.patient SET surname = '{sname.Text}', dateofbirth = '{dateofbirth.Value.Date.ToShortDateString()}', doc_id = {doctor.SelectedIndex} + 1, diagnosis_id = {diagnosis.SelectedIndex} + 1, medbook_id = {medbookquery}, chamber = {chamber.Text}, name = '{name.Text}' WHERE id = {pat_id}";
                    NpgsqlCommand cmd_insert = new NpgsqlCommand(insert_query, con);
                    cmd_insert.ExecuteNonQuery();

                    con.Close();

                    SearchTable Table = new SearchTable(userright_lvl);
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

        private void cancel_Click(object sender, EventArgs e)
        {
            SearchTable Table = new SearchTable(userright_lvl);
            this.Hide();
            Table.ShowDialog();
            this.Close();
        }
    }
}
