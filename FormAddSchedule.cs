using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

            // Заголовки столбцов: дни недели (Пн–Вс)
            string[] days = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
            for (int i = 0; i < 7; i++)
            {
                dgv_selectschedule.Columns[i].HeaderText = days[i];
                dgv_selectschedule.Columns[i].Width = 100;  // Ширина столбца
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
    }
}
