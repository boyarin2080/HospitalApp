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
    public partial class FormLogin : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.shamin_hospitalConnectionString);
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string login = tb_login.Text;
            string password = tb_password.Text;

            int role;


            SqlCommand cmd = new SqlCommand("LoginProcedure", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@user_password", password);

            conn.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            reader.Read();

            if (reader.HasRows)
            {
                role = Convert.ToInt32(reader["role_id"].ToString());

                string db_username = reader["name"].ToString();
                FormDoctorList form = new FormDoctorList(role, db_username);
                this.Hide();
                form.ShowDialog();
                this.Close();

            }
            else
            {
                MessageBox.Show("Не удалось войти");
                tb_password.Clear();
            }

            conn.Close();
        }
    }
}
