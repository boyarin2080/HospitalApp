using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppHospital
{
    class ImageUploader
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.shamin_hospitalConnectionString);

        public ImageUploader()
        {
          
        }

        public void Upload(PictureBox pictureBox, int user_id)
        {
                var image = new Bitmap(pictureBox.Image);
            using (var memoryStream = new MemoryStream())
            {
                image.Save(memoryStream, ImageFormat.Jpeg);
                memoryStream.Position = 0;

                byte[] imgdata = memoryStream.ToArray();
                SqlCommand cmd = new SqlCommand("UploadImage", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@uid", user_id);
                cmd.Parameters.AddWithValue("@imagedata", imgdata);

                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                reader.Read();

                if (reader.HasRows) 
                {
                    MessageBox.Show("Фото успешно добавлено!!!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                conn.Close();
            }              
        } 
    }
}

