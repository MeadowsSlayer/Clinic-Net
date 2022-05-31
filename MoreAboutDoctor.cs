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
    public partial class MoreAboutDoctor : Form
    {
        public string userright_lvl = "";
        public int doc_id = 0;

        public MoreAboutDoctor(string user_lvl, int id)
        {
            InitializeComponent();
            userright_lvl = user_lvl;
            doc_id = id;

            String str = "Host=localhost;Username=postgres;Password=CEOofHimbos333;Database=postgres";
            NpgsqlConnection con1 = new NpgsqlConnection(str);
            con1.Open();
            string query = $"SELECT Поликлиника.doctor.name, Поликлиника.doctor.surname, Поликлиника.doctor.fathername, Поликлиника.doctorspec.speciality, Поликлиника.time.time, Поликлиника.area.area FROM Поликлиника.doctor JOIN Поликлиника.doctorspec ON Поликлиника.doctorspec.id = Поликлиника.doctor.spec_id JOIN Поликлиника.time ON Поликлиника.doctor.time_id = Поликлиника.time.id JOIN Поликлиника.area ON Поликлиника.doctor.area_id = Поликлиника.area.id WHERE Поликлиника.doctor.id = {id}";

            NpgsqlCommand data_cmd = new NpgsqlCommand(query, con1);
            NpgsqlDataReader data = data_cmd.ExecuteReader();
            while (data.Read())
            {
                name.Text = data.GetValue(0).ToString();
                sname.Text = data.GetValue(1).ToString();
                fname.Text = data.GetValue(2).ToString();
                doc_spec.Text = data.GetValue(3).ToString();
                doc_time.Text = data.GetValue(4).ToString();
                doc_area.Text = data.GetValue(5).ToString();
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
