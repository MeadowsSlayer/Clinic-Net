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
    public partial class MoreAboutPatient : Form
    {
        public int pat_id = 0;

        public MoreAboutPatient(int id)
        {
            InitializeComponent();
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
            this.Close();
        }
    }
}
