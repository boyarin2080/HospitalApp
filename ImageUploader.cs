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
        private readonly SqlConnection _connectionString;

        public ImageUploader(SqlConnection conn, public_vars pv)
        {
            _connectionString = conn;
        }

        public void Upload(PictureBox pictureBox)
        {
            using (var connection = _connectionString)
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "INSERT INTO myTable (uid, image) VALUES (@uid, @image)";

                var image = new Bitmap(pictureBox.Image);
                using (var memoryStream = new MemoryStream())
                {
                    image.Save(memoryStream, ImageFormat.Jpeg);
                    memoryStream.Position = 0;

                    var sqlParameter = new SqlParameter("@image", SqlDbType.VarBinary, (int)memoryStream.Length)
                    {
                        Value = memoryStream.ToArray()
                    };

                }
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}

