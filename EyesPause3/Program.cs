using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace EyesPause3
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            while (true)
            {
                System.Threading.Thread.Sleep(15 * 60 * 1000);
                System.Drawing.Point start, stop;
                start = new System.Drawing.Point(int.MaxValue, int.MaxValue);
                stop = new System.Drawing.Point(int.MinValue, int.MinValue);
                for (int i = 0; i < Screen.AllScreens.Length; i++)
                {
                    start.X = Math.Min(start.X, Screen.AllScreens[i].WorkingArea.X);
                    start.Y = Math.Min(start.Y, Screen.AllScreens[i].WorkingArea.Y);
                    stop.X = Math.Max(stop.X, Screen.AllScreens[i].WorkingArea.X + Screen.AllScreens[i].WorkingArea.Width);
                    stop.Y = Math.Max(stop.Y, Screen.AllScreens[i].WorkingArea.Y + Screen.AllScreens[i].WorkingArea.Height);
                }
                FormMain form = new FormMain();
                form.Location = start;
                form.Width = stop.X - start.X;
                form.Height = stop.Y - start.Y;
                Application.Run(form);
            }
        }
    }
}
