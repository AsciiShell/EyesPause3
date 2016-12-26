using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EyesPause3
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        public int Screen = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            labelTime.Text = "20";
            //Bounds = System.Windows.Forms.Screen.AllScreens[Screen].Bounds;
            labelTime.Location = new Point((panelMain.Width - panelMain.Location.X- labelTime.Width) / 2, (panelMain.Height - panelMain.Location.Y - labelTime.Height) / 2);

            labelInfo.Location = new Point((panelMain.Width - panelMain.Location.X - labelInfo.Width) / 2, (panelMain.Height - panelMain.Location.Y - labelInfo.Height) / 2 - 100);

        }

        private void buttonHide_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonTerminate_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            int time = Convert.ToInt32(labelTime.Text) - 1;
            if (time == 0)
            {
                timer.Stop();
                Close();
            }
            else
            {
                labelTime.Text = time.ToString();
            }
        }
    }
}
