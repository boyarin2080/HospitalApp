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
    public partial class FormDoctorList : Form
    {
        int role;
        string username;

        public FormDoctorList(int role_id, string db_username)
        {
            InitializeComponent();
            role = role_id;
            username = db_username;
        }

        private void FormDoctorList_Load(object sender, EventArgs e)
        {
            lb_hello.Text += username;
        }
    }
}
