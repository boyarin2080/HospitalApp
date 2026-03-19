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
    public partial class FormEditRole : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.shamin_hospitalConnectionString);
        string us_role;
        int edit_uid;
        public FormEditRole(string Us_role, int Edituid)
        {
            InitializeComponent();
            us_role = Us_role;
            edit_uid = Edituid;
        }

        private void btn_editrole_Click(object sender, EventArgs e)
        {
            string selectedValue = cb_SelectRole.Text;
            int newRole = cb_SelectRole.SelectedIndex + 1;
            if (selectedValue != us_role) //проверка на то что роль изменилась
            {
                try
                {
                    DialogResult result = MessageBox.Show($"Точно изменить роль пользователя с " +
                        $"{us_role} на {selectedValue}?", "Подтверждение", 
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.OK && newRole != 2)
                    {
                        SqlCommand cmd = new SqlCommand("UpdateUserRole", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@UserID", edit_uid);
                        cmd.Parameters.AddWithValue("@NewRole", newRole);

                        conn.Open();

                        SqlDataReader reader = cmd.ExecuteReader();
                        reader.Read();

                        if (reader.HasRows)
                        {
                            MessageBox.Show("Роль успешно изменена.");
                            conn.Close();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Не удалось");
                        }
                        conn.Close();
                    }
                    if (result == DialogResult.OK && newRole == 2)
                    {
                        using (FormAddDoctor frm = new FormAddDoctor(edit_uid))
                        {
                            frm.StartPosition = FormStartPosition.Manual;
                            frm.Location = Cursor.Position;  // Точно под курсором
                            frm.ShowDialog();
                        }
                        this.Close();
                    }
                    else { }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
            else { MessageBox.Show("Вы не изменили роль!!"); }
     
        }

        private void FormEditRole_Load(object sender, EventArgs e)
        {
            label1.Text += us_role;
            conn.Open();

            string query = $"SELECT * FROM roles";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            cb_SelectRole.DataSource = dt;
            cb_SelectRole.DisplayMember = "role";
            cb_SelectRole.ValueMember = "role_id";

            conn.Close();            
        }
    }
}
