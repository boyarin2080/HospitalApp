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
    public partial class DoctorCard : UserControl
    {
        public DoctorCard()
        {
            InitializeComponent();
        }

        public DoctorCard(string txt)
        {
            InitializeComponent();
            label1.Text = txt;
        }



    }
}
