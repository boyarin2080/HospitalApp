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
    public partial class FormCreateAppointment : Form
    {
        public_vars pv1;
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.shamin_hospitalConnectionString);
        public FormCreateAppointment(public_vars pv)
        {
            InitializeComponent();
            pv1 = pv;
        }

        private void btn_create_appointment_Click(object sender, EventArgs e)
        {

            string format = "yyyy-MM-dd HH:mm"; 
            if (DateTime.TryParseExact(pv1.appointment_datetime, format, null, System.Globalization.DateTimeStyles.None, out DateTime app_DT))
            {
                MessageBox.Show(app_DT.ToString());
            }
            else
            {
                MessageBox.Show("Неверный формат даты");
            }

            DialogResult result = MessageBox.Show($"Запись на время: {pv1.appointment_datetime} \nВрач: {pv1.doctor_fio} \n doctor_id = {pv1.doctor_id} ?", "Подтверждение записи", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                SqlCommand cmd = new SqlCommand("CreateAppointment", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                // Явно указываем типы и преобразуем значения
                cmd.Parameters.Add("@patient_id", SqlDbType.Int).Value = Convert.ToInt32(pv1.user_id);
                cmd.Parameters.Add("@doctor_id", SqlDbType.Int).Value = Convert.ToInt32(pv1.doctor_id);
                cmd.Parameters.Add("@appointment_datetime", SqlDbType.DateTime).Value = app_DT;
                cmd.Parameters.Add("@complaint", SqlDbType.NVarChar, 500).Value = richTextBox1.Text;

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                conn.Close();

                this.Close();
                MessageBox.Show("success");
            }
            else if (result == DialogResult.Cancel)
            {
                this.Close();
            }
        }
    }
}
