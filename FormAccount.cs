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
using static WindowsFormsAppHospital.FormDoctorSchedule;

namespace WindowsFormsAppHospital
{
    public partial class FormAccount : Form
    {
        public_vars pv;
        Dictionary<int, string> roles = new Dictionary<int, string>()
        {
            [1] = "Пациент",
            [2] = "Доктор",
            [3] = "Администратор"
        };

        SqlConnection conn = new SqlConnection(Properties.Settings.Default.shamin_hospitalConnectionString);

        public FormAccount(public_vars pv)
        {
            InitializeComponent();
            this.pv = pv;
        }

        private void btn_zapis_na_priem_Click(object sender, EventArgs e)
        {
            FormSpecList form = new FormSpecList(pv);
            form.ShowDialog();
        }

        private void FormAccount_Load(object sender, EventArgs e)
        {
            lbl_hello.Text += pv.username;
            lbl_you_are.Text += roles[pv.role];
            btn_doctor_func.Enabled = false;
            btn_admin_func.Enabled = false;

            if (pv.role == 2)
            {
                btn_doctor_func.Enabled = true;
            }
            if (pv.role == 3)
            {
                btn_admin_func.Enabled = true;
            }

            FillMyAppointments();
        }

        private void FillMyAppointments()
        {
            string query = $"SELECT * FROM vw_my_appointments WHERE patient_id = {pv.user_id}";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgv_my_appointments.DataSource = dt;
        }

        private void btn_admin_func_Click(object sender, EventArgs e)
        {
            FormAdminPanel form = new FormAdminPanel();
            form.ShowDialog();
            this.Hide();
        }

        private void btn_doctor_func_Click(object sender, EventArgs e)
        {

        }

        private void btn_my_appointments_Click(object sender, EventArgs e)
        {
            FillMyAppointments();
        }

        private void llbl_edit_data_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
