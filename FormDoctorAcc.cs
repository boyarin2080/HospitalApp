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

namespace WindowsFormsAppHospital
{
    public partial class FormDoctorAcc : Form
    {
        SqlConnection conn = new SqlConnection();
        public FormDoctorAcc()
        {
            InitializeComponent();
        }

        private void FormDoctorAcc_Load(object sender, EventArgs e)
        {
            //lbl_hello.Text += pv.username;
            //lbl_you_are.Text += roles[pv.role];
            //btn_doctor_func.Enabled = false;
            //btn_admin_func.Enabled = false;

            //if (pv.role == 2)
            //{
            //    btn_doctor_func.Enabled = true;
            //}
            //if (pv.role == 3)
            //{
            //    btn_admin_func.Enabled = true;
            //}

            //FillMyAppointments();
        }

        //private void FillMyAppointments()
        //{
        //    string query = $"SELECT * FROM vw_my_appointments WHERE patient_id = {pv.user_id}";
        //    SqlDataAdapter da = new SqlDataAdapter(query, conn);
        //    DataTable dt = new DataTable();
        //    da.Fill(dt);

        //    dgv_my_appointments.DataSource = dt;
        //}
    }
}
