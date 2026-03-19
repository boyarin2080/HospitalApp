using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace WindowsFormsAppHospital
{
    public partial class FormAddDoctor : Form
    {
        int edituid;
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.shamin_hospitalConnectionString);
        public FormAddDoctor(int Edituid)
        {
            InitializeComponent();
            edituid = Edituid;
        }

        private void AddDoctor_Load(object sender, EventArgs e)
        {
            label1.Text += edituid;
            conn.Open();

            string hospquery = "SELECT hosp_id, name FROM vw_hospitals";
            SqlDataAdapter hospadapter = new SqlDataAdapter(hospquery, conn);
            DataTable hosp_dt = new DataTable();
            hospadapter.Fill(hosp_dt);

            cb_hospital_choose.DataSource = hosp_dt;
            cb_hospital_choose.DisplayMember = "name";  // отображаемое поле
            cb_hospital_choose.ValueMember = "hosp_id";

            string query = "SELECT spec_id, spec FROM vw_spec";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            cb_choose_spec.DataSource = dt;
            cb_choose_spec.DisplayMember = "spec";  // отображаемое поле
            cb_choose_spec.ValueMember = "spec_id";      // значение для SelectedValue

            conn.Close();
        }

        private void btn_AddDoctor_Click(object sender, EventArgs e)
        {
            int doc_spec = cb_choose_spec.SelectedIndex + 1;
            int hosp_id = cb_choose_spec.SelectedIndex + 1;
            //MessageBox.Show($"{doc_spec}, {hosp_id}");
            SqlCommand cmd = new SqlCommand("AddDoctor", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@UserId", edituid);
            cmd.Parameters.AddWithValue("@doctor_spec", doc_spec);
            cmd.Parameters.AddWithValue("@hosp_id", hosp_id);

            conn.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            //int newId = (int)cmd.ExecuteScalar();
            if (reader.HasRows)
            {
                MessageBox.Show("Врач добавлен");
                conn.Close();
                this.Close();
            }
            else {MessageBox.Show("Не удалось добавить врача");}
            reader.Close();
            conn.Close();
        }
    }
}
