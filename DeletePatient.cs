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
    public partial class DeletePatient : Form
    {
        public string userright_lvl = "";
        public int pat_id = 0;

        public DeletePatient(string user_lvl, int id)
        {
            InitializeComponent();
            userright_lvl = user_lvl;
            pat_id = id;

            String str = "Host=localhost;Username=postgres;Password=CEOofHimbos333;Database=postgres";
            NpgsqlConnection con1 = new NpgsqlConnection(str);
            con1.Open();
            string query = $"SELECT Поликлиника.patient.name, Поликлиника.patient.surname, Поликлиника.patient.dateofbirth, Поликлиника.patient.chamber, Поликлиника.diagnosis.diagnosis, Поликлиника.doctor.initials, Поликлиника.medbooks.booklink FROM Поликлиника.patient JOIN Поликлиника.diagnosis ON Поликлиника.patient.diagnosis_id = Поликлиника.diagnosis.id JOIN Поликлиника.doctor ON Поликлиника.patient.doc_id = Поликлиника.doctor.id JOIN Поликлиника.medbooks ON Поликлиника.patient.medbook_id = Поликлиника.medbooks.id WHERE Поликлиника.patient.id = {id}";

            NpgsqlCommand data_cmd = new NpgsqlCommand(query, con1);
            NpgsqlDataReader data = data_cmd.ExecuteReader();
            while (data.Read())
            {
                name.Text = data.GetValue(0).ToString();
                sname.Text = data.GetValue(1).ToString();
                date.Text = data.GetValue(2).ToString();
                chamber.Text = data.GetValue(3).ToString();
                diagnosis.Text = data.GetValue(4).ToString();
                doctor.Text = data.GetValue(5).ToString();
                medbook_link.Text = data.GetValue(6).ToString();
            }

            con1.Close();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            SearchTable Table = new SearchTable(userright_lvl);
            this.Hide();
            Table.ShowDialog();
            this.Close();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            String str = "Host=localhost;Username=postgres;Password=CEOofHimbos333;Database=postgres";
            NpgsqlConnection con = new NpgsqlConnection(str);
            con.Open();
            string del_query = $"DELETE FROM Поликлиника.patient WHERE id = {pat_id}";

            NpgsqlCommand del_cmd = new NpgsqlCommand(del_query, con);
            del_cmd.ExecuteNonQuery();

            con.Close();

            SearchTable Table = new SearchTable(userright_lvl);
            this.Hide();
            Table.ShowDialog();
            this.Close();
        }
    }
}
