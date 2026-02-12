using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsAppHospital
{
    public partial class FormReg : Form
    {
        public FormReg()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void btn_reg_Click(object sender, EventArgs e)
        {
            if (tb_pass.Text == tb_pass_2.Text)
            {
                db_conn_class db = new db_conn_class();
                var (conn, cmd) = db.get_conn_procedure(prcd_name: "AddUser");
                using (conn) using (cmd)
                {

                    cmd.Parameters.AddWithValue("@name", tb_name.Text);
                    cmd.Parameters.AddWithValue("@surname", tb_surname.Text);
                    cmd.Parameters.AddWithValue("@patronymic", tb_patronymic.Text);
                    cmd.Parameters.AddWithValue("@phone", tb_phone.Text);
                    cmd.Parameters.AddWithValue("@email", tb_email.Text);
                    cmd.Parameters.AddWithValue("@password", tb_pass.Text);
                    cmd.Parameters.AddWithValue("@date_of_birth", dTP_birth.Value);

                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    MessageBox.Show($"Пользователь добавлен. Строк затронуто: {rowsAffected}");
                    conn.Close();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show($"Введённые пароли не совпадают!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
