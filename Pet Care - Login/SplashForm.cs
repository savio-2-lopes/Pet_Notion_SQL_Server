using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pet_Care___Login
{
    public partial class SplashForm : Form
    {
        int startpoint = 0;
        public SplashForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 1;
            SplashBar.Value = startpoint;

            if(SplashBar.Value == 100)
            {
                SplashBar.Value = 0;
                timer1.Stop();
                Login Login = new Login();
                this.Hide();
                Login.Show();
            }
        }

        private void SplashForm_Load(object sender, EventArgs e)
        {
            this.timer1.Start();
        }
    }
}
