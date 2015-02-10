using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AccountBox
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool isnotRunning = false;
            System.Threading.Mutex mutex = new System.Threading.Mutex(true, "AccountBoxRunning", out isnotRunning);

            if (isnotRunning)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Login log = new Login();
                log.ShowDialog();
                if (log.DialogResult == DialogResult.OK)
                {
                    Application.Run(new QueryForm());
                }
            }
            else
            {
                MessageBox.Show("程序已经在运行！");
            }
        }
    }
}
