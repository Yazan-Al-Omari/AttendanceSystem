using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SW_attendance_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Time_label_Click(object sender, EventArgs e)
        {
          
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Time_label.Text = DateTime.Now.ToString();
        }
    }
}
