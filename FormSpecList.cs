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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsAppHospital
{
    public partial class FormSpecList : Form
    {
        int role;
        string username;

        SqlConnection conn = new SqlConnection(Properties.Settings.Default.shamin_hospitalConnectionString);
        public FormSpecList(int role_id, string db_username)
        {
            InitializeComponent();
            role = role_id;
            username = db_username;
        }

        private void FormDoctorList_Load(object sender, EventArgs e)
        {
            lb_hello.Text += username;

            conn.Open();
            string query = "SELECT spec_id, spec FROM vw_spec";  // или напрямую "SELECT * FROM specs ORDER BY name"
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            cb_choose_spec.DataSource = dt;
            cb_choose_spec.DisplayMember = "spec";  // отображаемое поле
            cb_choose_spec.ValueMember = "spec_id";      // значение для SelectedValue


            string hospquery = "SELECT hosp_id, name FROM vw_hospitals";  // или напрямую "SELECT * FROM specs ORDER BY name"
            SqlDataAdapter hospadapter = new SqlDataAdapter(hospquery, conn);
            DataTable hosp_dt= new DataTable();
            hospadapter.Fill(hosp_dt);

            cb_hospital_choose.DataSource = hosp_dt;
            cb_hospital_choose.DisplayMember = "name";  // отображаемое поле
            cb_hospital_choose.ValueMember = "hosp_id";    

            conn.Close();
        }

        private void button_choose_doc_Click(object sender, EventArgs e)
        {

        }
    }
}
