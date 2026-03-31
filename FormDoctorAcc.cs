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
using System.Drawing.Imaging;
using System.IO;

namespace WindowsFormsAppHospital
{
    public partial class FormDoctorAcc : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.shamin_hospitalConnectionString);
        public_vars _pv;
        public FormDoctorAcc(public_vars pv)
        {
            InitializeComponent();
            _pv = pv;
        }

        private void FormDoctorAcc_Load(object sender, EventArgs e)
        {

            var retriever = new ImageRetriever();
            retriever.Retrieve(pb_set, _pv.user_id);
        }

        private void btn_select_photo_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pb_set.Image = Image.FromFile(openFileDialog.FileName);
                }
            }
        }

        private void btn_add_photo_Click(object sender, EventArgs e)
        {
            var uploader = new ImageUploader();
            uploader.Upload(pb_set, _pv.user_id);
            
        }    
        
        private void FillMyAppointments(int doc_id)
        {
            dgv_my_appointments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_my_appointments.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            string query = $"SELECT * FROM vw_my_appointments WHERE doctor_id = {doc_id}";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgv_my_appointments.DataSource = dt;
        }

        private void UpdateExpiredAppointments()
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.UpdateExpiredAppointments", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();
                    cmd.ExecuteNonQuery();

                    conn.Close();
                }
            }
            catch(Exception ex) { MessageBox.Show(Convert.ToString(ex), 
                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }

        private void btn_upload_appointments_Click(object sender, EventArgs e)
        {
            UpdateExpiredAppointments();
            var retriever = new ImageRetriever();
            int doc_id = retriever.GetDoctorByUiD(_pv.user_id);
            FillMyAppointments(doc_id);

        }

        private void dgv_my_appointments_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                var mousePos = dgv_my_appointments.PointToClient(Cursor.Position);
                var hit = dgv_my_appointments.HitTest(mousePos.X, mousePos.Y);

                dgv_my_appointments.CurrentCell = dgv_my_appointments.Rows[hit.RowIndex].Cells[hit.ColumnIndex];

                if (e.Button == MouseButtons.Right)
                    if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                    {
                        cms_EditMyAppointments.Show(MousePosition);
                    }
            }
            catch (Exception ex) { MessageBox.Show(Convert.ToString(ex),
                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void завершитьЗаписьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
