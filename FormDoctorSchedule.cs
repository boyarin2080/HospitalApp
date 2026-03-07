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
    public partial class FormDoctorSchedule : Form
    {
        string doctor_spec;
        string doctor_hospital;
        int spec_Id;
        int hosp_Id;
        HashSet<DateTime> busyTimes;

        //для передачи в CreateAppointment
        public_vars pv;

        SqlConnection conn = new SqlConnection(Properties.Settings.Default.shamin_hospitalConnectionString);
        public FormDoctorSchedule(string speciality, string hospital, int spec_id, int hosp_id, public_vars pv)
        {
            InitializeComponent();
            doctor_spec = speciality;
            doctor_hospital = hospital;
            spec_Id = spec_id;
            hosp_Id = hosp_id;
            this.pv = pv;
        }
        public static class DaysOfWeek
        {
            public static Dictionary<string, int> Days { get; private set; } = new Dictionary<string, int>()
            {
                { "Monday", 1 },
                { "Tuesday", 2 },
                { "Wednesday", 3 },
                { "Thursday", 4 },
                { "Friday", 5 },
                { "Saturday", 6 },
                { "Sunday", 7 }
            };
        }

        private void Load_Doctors_list()
        {
            lbl_specandhosp.Text += $" {doctor_spec}, {doctor_hospital}";

            conn.Open();

            string query = $"SELECT doctor_id, CONCAT(doctor_surname, ' ', doctor_name, ' ', doctor_patronymic) AS doctor_fio  FROM vw_doctors WHERE doctor_spec = {spec_Id} AND hospital = {hosp_Id} ORDER BY doctor_surname";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            cb_doctor_fio.DataSource = dt;
            cb_doctor_fio.DisplayMember = "doctor_fio";
            cb_doctor_fio.ValueMember = "doctor_id";

            conn.Close();
        }

        public List<string> GenerateTimeSlots(TimeSpan startTime, TimeSpan endTime, int durationMinutes)
        {
            List<string> timeSlots = new List<string>();

            TimeSpan currentTime = startTime;

            while (currentTime < endTime)
            {
                timeSlots.Add(currentTime.ToString(@"hh\:mm"));
                currentTime = currentTime.Add(TimeSpan.FromMinutes(durationMinutes));
            }

            return timeSlots;
        }
        private HashSet<string> ConvertDateTimesToStrings(HashSet<DateTime> busyTimes)
        {
            var times = new HashSet<string>();

            if (busyTimes == null)
            {
                return times;
            }
                

            foreach (DateTime dt in busyTimes)
            {
                // Форматируем в строку времени (HH:mm) или полную дату по вашему выбору
                string timeString = dt.ToString("HH:mm"); // Только время
                                                          // string timeString = dt.ToString("dd.MM.yyyy HH:mm"); // Полная дата+время

                times.Add(timeString);
            }

            return times;
        }

        private void FillDGV(List<string> slots, string week_day)
        {
            HashSet<string> Times = ConvertDateTimesToStrings(busyTimes);
            string times = string.Join("\n", Times);
            //MessageBox.Show($"Занятые времена FILLDGV:\n{Convert.ToString(times)}");
            try
            {
                DataTable dtSlots = new DataTable();
                int maxPerRow = 10;
                int numRows = (int)Math.Ceiling((double)slots.Count / maxPerRow);

                // Создаём 10 столбцов
                for (int i = 0; i < maxPerRow; i++)
                {
                    dtSlots.Columns.Add($"TimeSlot {i + 1}", typeof(string));
                }

                // Заполняем построчно
                for (int rowIndex = 0; rowIndex < numRows; rowIndex++)
                {
                    object[] rowValues = new object[maxPerRow];
                    for (int colIndex = 0; colIndex < maxPerRow; colIndex++)
                    {
                        int slotIndex = rowIndex * maxPerRow + colIndex;
                        if (slotIndex < slots.Count)
                        {
                            rowValues[colIndex] = slots[slotIndex];
                        }
                        else
                        {
                            rowValues[colIndex] = DBNull.Value;
                        }
                    }
                    dtSlots.Rows.Add(rowValues);
                }

                // Привязываем к DGV
                dgv_doctor_schedule.DataSource = dtSlots;

                // Настройка отображения
                dgv_doctor_schedule.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgv_doctor_schedule.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dgv_doctor_schedule.RowHeadersVisible = false;
                dgv_doctor_schedule.ColumnHeadersVisible = false;
                dgv_doctor_schedule.AllowUserToAddRows = false;
                dgv_doctor_schedule.DefaultCellStyle.BackColor = Color.FromArgb(192, 255, 192);

                for (int rowIndex = 0; rowIndex < numRows; rowIndex++)
                {
                    for (int colIndex = 0; colIndex < maxPerRow; colIndex++)
                    {

                        if (Times.Contains(dgv_doctor_schedule.Rows[rowIndex].Cells[colIndex].Value.ToString()))
                        {
                            dgv_doctor_schedule.Rows[rowIndex].Cells[colIndex].Style.BackColor = Color.Red;
                            dgv_doctor_schedule.Rows[rowIndex].Cells[colIndex].ReadOnly = true;
                            dgv_doctor_schedule.Rows[rowIndex].Cells[colIndex].Selected = false;
                        }
                    }
                }
            }
            catch (Exception Ex)
            {
                string message = Ex.Message + "\n\nНажмите OK для копирования в буфер обмена";
                MessageBox.Show(message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Clipboard.SetText(Ex.Message); // Копирует только сообщение, без инструкции
            }
        }

        private void LoadSchedule()
        {
            string query = $"SELECT * FROM vw_doctorschedulegrid where doctor_id = {cb_doctor_fio.SelectedValue} and day_of_week = {DaysOfWeek.Days[Convert.ToString(dtp_schedule_date.Value.DayOfWeek)]}";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                var startTime = TimeSpan.Parse(row["start_time"].ToString());
                var endTime = TimeSpan.Parse(row["end_time"].ToString());
                var duration = Convert.ToInt32(row["slot_duration"]);
                string week_day = Convert.ToString(row["day_of_week"]);
                try
                {
                    var slots = GenerateTimeSlots(startTime, endTime, duration);
                    FillDGV(slots, week_day);
                }
                catch (Exception Ex)
                {
                    string message = Ex.Message + "\n\nНажмите OK для копирования в буфер обмена";
                    MessageBox.Show(message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Clipboard.SetText(Ex.Message); // Копирует только сообщение, без инструкции
                }
            }
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show($"Не найдено, doctor_id: {cb_doctor_fio.SelectedValue}");

            }


            dgv_doctor_schedule.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv_doctor_schedule.RowHeadersVisible = false;
        }

        private HashSet<DateTime> LoadAppointmentsByDay(DateTime selectedDate, int doctor_id)
        {
            HashSet<DateTime> busyTimes = new HashSet<DateTime>();
            {
                SqlCommand cmd = new SqlCommand("GetAppointmentsTimesByDay", conn);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@selectedDate", SqlDbType.Date).Value = selectedDate.Date;
                cmd.Parameters.Add("@doctor_id", SqlDbType.Int).Value = doctor_id;

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    busyTimes.Add((DateTime)reader["appointment_datetime"]);
                }
                reader.Close();
                conn.Close();
                string times = string.Join("\n", busyTimes.Select(t => t.ToString()));
               //MessageBox.Show($"Занятые времена:\n{times}");
            }

            return busyTimes;
        }

        private void FormDoctorSchedule_Load(object sender, EventArgs e)
        {
            Load_Doctors_list();
            //dtp_schedule_date.MinDate = DateTime.Now;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            pv.doctor_fio = cb_doctor_fio.Text;
            pv.doctor_id = Convert.ToInt32(cb_doctor_fio.SelectedValue);

            //Подгрузка записей которые уже есть у этого врача
            //string date_dots = dtp_schedule_date.Value.Date.ToString("dd.MM.yyyy 00:00:00");
            busyTimes = LoadAppointmentsByDay(dtp_schedule_date.Value.Date, pv.doctor_id);
            //Загрузка DGV
            LoadSchedule();
        }

        private void записатьсяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Form form = new FormCreateAppointment(pv))
            {
                form.ShowDialog();
            }

            btn_search_Click(sender, e);

        }

        private void dgv_doctor_schedule_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgv_doctor_schedule.CurrentCell.Style.BackColor == Color.Red)
            {
                MessageBox.Show("На это время уже есть запись!!! \nВыберите другое", "Время занято");
                return;
            }
            if (dgv_doctor_schedule.CurrentCell.Value == DBNull.Value)
            {
                MessageBox.Show("На это время невозможно записаться!!! \nВыберите другое");
                return;
            }
            if (e.Button == MouseButtons.Right)
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    cms_create_appointment.Show(MousePosition);
                }
            pv.appointment_datetime = dtp_schedule_date.Value.ToString("yyyy-MM-dd") + " " + dgv_doctor_schedule.CurrentCell.Value.ToString();


        }
    }
}