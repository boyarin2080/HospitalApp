using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsAppHospital.Properties;

namespace WindowsFormsAppHospital
{
    internal class db_conn_class
    {
        public (SqlConnection conn, SqlCommand cmd) get_conn_procedure(string prcd_name)
        {
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.shamin_hospitalConnectionString);
            SqlCommand cmd = new SqlCommand(prcd_name, conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            return (conn, cmd);
        }
    }
}
