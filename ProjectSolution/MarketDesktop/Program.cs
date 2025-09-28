using System;
using System.Windows.Forms;

namespace MarketDesktop
{
    static class Program
    {
        /// <summary>
        /// Điểm vào chính của ứng dụng.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
