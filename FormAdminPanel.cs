using System;
using System.Collections;
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

        //Кнопка просмотра записей
        private void btn_EditAppointments_Click(object sender, EventArgs e)
        {
            try
            {
                dgv_AllUsers.Visible = false;
                dgv_AllAppointments.Visible = true;

                string query = $"SELECT * FROM vw_my_appointments  ORDER BY Aid";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgv_AllAppointments.DataSource = dt;
            }
            catch (Exception Ex)
            {
                string message = Ex.Message + "\n\nНажмите OK для копирования в буфер обмена";
                MessageBox.Show(message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Clipboard.SetText(Ex.Message); // Копирует только сообщение, без инструкции
            }
            
        }

        private void dgv_admin_utility_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    contextMenuStrip1.Show(MousePosition);
                }
        }

        //Редактировать запись
        private void cms_edit_Click(object sender, EventArgs e)
        {

        }
        //Удалить запись
        private void cms_remove_Click(object sender, EventArgs e)
        {
            int rowIndex;

            DataGridViewRow row = dgv_AllAppointments.CurrentRow;
            // Пример: получение значения первой ячейки
            rowIndex = Convert.ToInt32(row.Cells[0].Value);
            MessageBox.Show($"{rowIndex}");


            string sql = "DELETE FROM appointments WHERE appointment_id = @id";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@id", rowIndex);
                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    dgv_AllAppointments.Rows.RemoveAt(row.Index);
                    MessageBox.Show("Строка удалена из базы данных!");
                }
                else
                {
                    MessageBox.Show("Строка не найдена в базе данных!");
                }
            }
        }



        //Кнопка редактировать пользователей / выдача ролей
        private void btn_EditUser_Click(object sender, EventArgs e)
        {
            try
            {
                dgv_AllAppointments.Visible = false;
                dgv_AllUsers.Visible = true;

                string query = $"SELECT * FROM vw_AllUsers ORDER by uid";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgv_AllUsers.DataSource = dt;
            }
            catch (Exception Ex)
            {
                string message = Ex.Message + "\n\nНажмите OK для копирования в буфер обмена";
                MessageBox.Show(message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Clipboard.SetText(Ex.Message); // Копирует только сообщение, без инструкции
            }
        }

        private void FormAdminPanel_Load(object sender, EventArgs e)
        {
            dgv_AllUsers.Visible = false;
            dgv_AllAppointments.Visible = false;
        }
    }
}
