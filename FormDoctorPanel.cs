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
    public partial class FormDoctorPanel : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.shamin_hospitalConnectionString);
        public_vars _pv;
        public FormDoctorPanel(public_vars pv)
        {
            InitializeComponent();
            _pv = pv;
        }

        private void FormDoctorAcc_Load(object sender, EventArgs e)
        {
            //lbl_hello.Text += pv.username;
            //lbl_you_are.Text += roles[pv.role];
            //btn_doctor_func.Enabled = false;
            //btn_admin_func.Enabled = false;

            //if (pv.role == 2)
            //{
            //    btn_doctor_func.Enabled = true;
            //}
            //if (pv.role == 3)
            //{
            //    btn_admin_func.Enabled = true;
            //}

            //FillMyAppointments();
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
            var uploader = new ImageUploader(_pv);
            uploader.Upload(pb_set, _pv.user_id);

        }


        //private void FillMyAppointments()
        //{
        //    string query = $"SELECT * FROM vw_my_appointments WHERE patient_id = {pv.user_id}";
        //    SqlDataAdapter da = new SqlDataAdapter(query, conn);
        //    DataTable dt = new DataTable();
        //    da.Fill(dt);

        //    dgv_my_appointments.DataSource = dt;
        //}
    }
}
