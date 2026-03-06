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
    public partial class FormAdminPanel : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.shamin_hospitalConnectionString);

        public FormAdminPanel()
        {
            InitializeComponent();
        }

        private void TSM_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_EditAppointments_Click(object sender, EventArgs e)
        {
            string query = $"SELECT * FROM vw_my_appointments";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgv_admin_utility.DataSource = dt;
        }

        private void btn_EditUser_Click(object sender, EventArgs e)
        {

        }
    }
}
