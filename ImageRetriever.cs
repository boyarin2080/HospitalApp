using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;

namespace WindowsFormsAppHospital
{
    internal class ImageRetriever
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.shamin_hospitalConnectionString);

        public ImageRetriever()
        {
            
        }

        public void Retrieve(PictureBox pictureBox, int id)
        {
 
            using (var command = conn.CreateCommand())
            {
                command.CommandText = "SELECT imagedata FROM Images WHERE user_id = @uid";
                command.Parameters.AddWithValue("@uid", id);
                conn.Open();
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        var imageData = (byte[])reader["imagedata"];
                        using (var memoryStream = new MemoryStream(imageData))
                        {
                            pictureBox.Image = Image.FromStream(memoryStream);
                            conn.Close();
                        }
                    }
                }
            }
        }

         public int GetDoctorUiD(int doctor_id)
        {
            int temp=-1;
            try
            {
                using (var command = conn.CreateCommand())
                {
                    command.CommandText = "SELECT user_id FROM doctors WHERE doctor_id = @doc_id";
                    command.Parameters.AddWithValue("@doc_id", doctor_id);
                    conn.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            temp = reader.GetInt32(0);
                            conn.Close();  
                        }
                    }
                }
            }
            catch(Exception Ex) 
            {
                MessageBox.Show(Convert.ToString(Ex));
            }

            return temp;
        }

        public int GetDoctorByUiD(int uid)
        {
            int temp = -1;
            try
            {
                using (var command = conn.CreateCommand())
                {
                    command.CommandText = "SELECT doctor_id FROM doctors WHERE user_id = @user_id";
                    command.Parameters.AddWithValue("@user_id", uid);
                    conn.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            temp = reader.GetInt32(0);
                            conn.Close();
                        }
                    }
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Convert.ToString(Ex), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return temp;
        }
    }
}
