using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace Pet_Shelter_Management_System
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }
        int startpoint = 0;
        private void timer_Tick(object sender, EventArgs e)
        {
            startpoint += 5;
            myProgress.Value = startpoint;
            if (myProgress.Value == 100) 
            {
                myProgress.Value = 0;
                Login log = new Login();
                this.Hide();
                log.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Start();
        }
    }
}
