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
        int user_id;
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.shamin_hospitalConnectionString);
        public FormLogin()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
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
                user_id = Convert.ToInt32(reader["user_id"].ToString());
                string db_username = reader["name"].ToString();
                public_vars pv = new public_vars();
                pv.user_id = user_id;
                pv.role = role;
                pv.username = db_username;

                FormAccount form = new FormAccount(pv);

                //MessageBox.Show($"{pv.user_id} and uid: {user_id}");
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

        private void linkLb_reg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormReg form = new FormReg();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }
    }
}
