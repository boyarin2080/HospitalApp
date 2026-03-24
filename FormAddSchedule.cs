using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public FormAddSchedule()
        {
            InitializeComponent();
        }

        private void FormAddSchedule_Load(object sender, EventArgs e)
        {
            dgv_Load();
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
                        //MessageBox.Show($"{starttime}");
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
                        //MessageBox.Show($"{endtime}");
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); return; }
                }


                if (startValue == null || endValue == null)
                {
                    MessageBox.Show($"На день {i} расписания нет!!!", "Не нашлось");
                }
                else
                {
                    DialogResult result = MessageBox.Show(
                        $"Для дня {i} " +
                        $"\nНачало приёма: {starttime}, " +
                        $"\nКонец приёма: {endtime}. " +
                        $"\nДобавить в БД?", "Подтверждение", 
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.OK) 
                    { 
                        //ТУТ ЗАПРОС В БД!!! можно вроде сначала добавить все тут в SQLCOMMAND а после цикла выполнить все команды
                    }

                }
            }
        }
    }
}
