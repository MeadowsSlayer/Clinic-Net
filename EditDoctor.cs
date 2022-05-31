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
    public partial class EditDoctor : Form
    {
        public string userright_lvl = "";
        public int doc_id = 0;
        public EditDoctor(string user_lvl, int id)
        {
            InitializeComponent();
            userright_lvl = user_lvl;
            doc_id = id;

            String str = "Host=localhost;Username=postgres;Password=CEOofHimbos333;Database=postgres";
            NpgsqlConnection con1 = new NpgsqlConnection(str);
            con1.Open();

            string area_query = "SELECT area FROM Поликлиника.area ORDER BY id";
            string time_query = "SELECT time FROM Поликлиника.time ORDER BY id";
            string spec_query = "SELECT speciality FROM Поликлиника.doctorspec ORDER BY id";
            string query = $"SELECT Поликлиника.doctor.name, Поликлиника.doctor.surname, Поликлиника.doctor.fathername, Поликлиника.doctorspec.speciality, Поликлиника.time.time, Поликлиника.area.area FROM Поликлиника.doctor JOIN Поликлиника.doctorspec ON Поликлиника.doctorspec.id = Поликлиника.doctor.spec_id JOIN Поликлиника.time ON Поликлиника.doctor.time_id = Поликлиника.time.id JOIN Поликлиника.area ON Поликлиника.doctor.area_id = Поликлиника.area.id WHERE Поликлиника.doctor.id = {id}";

            NpgsqlCommand area_cmd = new NpgsqlCommand(area_query, con1);
            NpgsqlDataReader areaget = area_cmd.ExecuteReader();
            while (areaget.Read())
            {
                doc_area.Items.Add(areaget.GetValue(0).ToString());
            }
            areaget.Close();

            NpgsqlCommand time_cmd = new NpgsqlCommand(time_query, con1);
            NpgsqlDataReader timeget = time_cmd.ExecuteReader();
            while (timeget.Read())
            {
                doc_time.Items.Add(timeget.GetValue(0).ToString());
            }
            timeget.Close();

            NpgsqlCommand spec_cmd = new NpgsqlCommand(spec_query, con1);
            NpgsqlDataReader specget = spec_cmd.ExecuteReader();
            while (specget.Read())
            {
                doc_spec.Items.Add(specget.GetValue(0).ToString());
            }
            specget.Close();

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
            Doctors Doc_Table = new Doctors(userright_lvl);
            this.Hide();
            Doc_Table.ShowDialog();
            this.Close();
        }

        private void change_Click(object sender, EventArgs e)
        {
            if ((name.Text != null) && (sname.Text != null) && (fname.Text != null) && (doc_spec.Text != null) && (doc_time.Text != null) && (doc_area.Text != null))
            {
                try
                {
                    string initials = sname.Text + " " + name.Text.Substring(0, 1) + "." + fname.Text.Substring(0, 1) + ".";
                    String str = "Host=localhost;Username=postgres;Password=CEOofHimbos333;Database=postgres";

                    NpgsqlConnection con = new NpgsqlConnection(str);

                    con.Open();

                    string insert_query = $"UPDATE Поликлиника.doctor SET surname = '{sname.Text}', name = '{name.Text}', fathername = '{fname.Text}', spec_id = {doc_spec.SelectedIndex} + 1, time_id = {doc_time.SelectedIndex}, area_id = {doc_area.SelectedIndex}, initials = '{initials}' WHERE id = {doc_id}";
                    NpgsqlCommand cmd_insert = new NpgsqlCommand(insert_query, con);
                    cmd_insert.ExecuteNonQuery();

                    con.Close();

                    Doctors Doc_Table = new Doctors(userright_lvl);
                    this.Hide();
                    Doc_Table.ShowDialog();
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
