using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppHospital
{
    public partial class FormAddSchedule : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.shamin_hospitalConnectionString);
        int doctor_id;
        public FormAddSchedule(int doctor_id    )
        {
            InitializeComponent();
            this.doctor_id = doctor_id;
        }

        private void FormAddSchedule_Load(object sender, EventArgs e)
        {
            dgv_Load();
            label1.Text += Convert.ToString(doctor_id);
        }
        private void dgv_Load()
        {
            dgv_selectschedule.RowHeadersVisible = true;  // Показать заголовки строк
            dgv_selectschedule.RowHeadersWidth = 130;
            dgv_selectschedule.ColumnCount = 7;
            dgv_selectschedule.RowCount = 3;  // 3 строки-заголовка (позже добавим данные)
            dgv_selectschedule.ReadOnly = false;

            // Заголовки столбцов: дни недели (Пн–Вс)
            string[] days = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
            for (int i = 0; i < 7; i++)
            {
                dgv_selectschedule.Columns[i].HeaderText = days[i];
                dgv_selectschedule.Columns[i].Width = 100;  // Ширина столбца
                if (i < 4)
                {
                    dgv_selectschedule.Rows[0].Cells[i].Value = "08:30";
                    dgv_selectschedule.Rows[1].Cells[i].Value = "16:00";
                }
                if (i == 4)
                {
                    dgv_selectschedule.Rows[0].Cells[i].Value = "08:30";
                    dgv_selectschedule.Rows[1].Cells[i].Value = "15:00";
                }
            }

            
            dgv_selectschedule.Rows[0].HeaderCell.Value = "День недели";  // Заголовок ряда
            dgv_selectschedule.Rows[0].Height = 50;

            dgv_selectschedule.Rows[1].HeaderCell.Value = "Время начала";  // Заголовок ряда
            dgv_selectschedule.Rows[1].Height = 50;

            dgv_selectschedule.Rows[2].HeaderCell.Value = "Время окончания";
            dgv_selectschedule.Rows[2].Height = 50;

            // Настройки вида
            dgv_selectschedule.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgv_selectschedule.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_selectschedule.AllowUserToAddRows = false;
            dgv_selectschedule.ReadOnly = false;  // Если заголовки только для просмотра
        }

        private void btn_addschedule_Click(object sender, EventArgs e)
        {
            conn.Open();
            using (SqlTransaction transaction = conn.BeginTransaction())
            {
                try
                {
                    for (int i = 0; i < 7; i++)
                    {
                        TimeSpan? starttime = null;
                        TimeSpan? endtime = null;

                        object startValue = dgv_selectschedule.Rows[0].Cells[i].Value;
                        object endValue = dgv_selectschedule.Rows[1].Cells[i].Value;

                        if (startValue != null && startValue != DBNull.Value)
                        {
                            try
                            {
                                TimeSpan temp;
                                string cellValuestr = Convert.ToString(startValue);
                                TimeSpan.TryParseExact(cellValuestr, @"h\:mm", CultureInfo.InvariantCulture, out temp);
                                starttime = temp;
                            }
                            catch (Exception ex) { MessageBox.Show(ex.Message); return; }
                        }
                        //Парсим endtime
                        if (endValue != null && startValue != DBNull.Value)
                        {
                            try
                            {
                                TimeSpan temp;
                                string cellValuestr = Convert.ToString(endValue);
                                TimeSpan.TryParseExact(cellValuestr, @"h\:mm", CultureInfo.InvariantCulture, out temp);
                                endtime = temp;
                            }
                            catch (Exception ex) { MessageBox.Show(ex.Message); return; }
                        }

                        //Проверка что ОБА значения не нулевые
                        if (startValue == null || endValue == null)
                        {
                            //MessageBox.Show($"На день {i} расписания нет!!!", "Не нашлось"); 
                            //^- тут отсеиваются либо выходные врача, либо суббота и воскресение

                        }
                        else
                        {
                            //DialogResult result = MessageBox.Show(
                            //    $"Для дня {i} " +
                            //    $"\nНачало приёма: {starttime}, " +
                            //    $"\nКонец приёма: {endtime}. " +
                            //    $"\nДобавить в БД?", "Подтверждение",
                            //    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                            //if (result == DialogResult.OK)
                            //{
                                int slotduration = Convert.ToInt32(numericUpDown_slotduration.Value);
                                DateTime valid_from = dtp_validfrom.Value;
                                DateTime valid_until = dtp_validuntil.Value;

                                //ТУТ ЗАПРОС В БД!!! можно вроде сначала добавить все тут в SQLCOMMAND а после цикла выполнить все команды
                                SqlCommand cmd = new SqlCommand("UploadWeeklySchedule", conn);
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Transaction = transaction;

                                cmd.Parameters.AddWithValue("@doctor_id", doctor_id);
                                cmd.Parameters.AddWithValue("@day_of_week", i + 1);
                                cmd.Parameters.AddWithValue("@startTime", starttime);
                                cmd.Parameters.AddWithValue("endTime", endtime);
                                cmd.Parameters.AddWithValue("@slotDuration", slotduration);
                                cmd.Parameters.AddWithValue("@valid_from", valid_from);
                                cmd.Parameters.AddWithValue("@valid_until", valid_until);
                                
                                cmd.ExecuteNonQuery();

                            //}
                        }
                    }
                    transaction.Commit();  // Все 7 вставок сохранены
                    MessageBox.Show("Транзакция завершена успешно");
                    
                }
                catch(Exception ex)
                {
                    MessageBox.Show($"Ошибка при транзакции: {ex}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    transaction.Rollback();  // Ни одна не сохранена
                    //throw; // <- здесь можем послать ошибку на уровень выше но тогда нужен ещё один trycatch
                }
                conn.Close();
            }
        }
    }
}
