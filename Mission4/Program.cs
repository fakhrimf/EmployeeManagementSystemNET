using Mission4.View;
using System;
using System.Windows.Forms;

namespace Mission4
{
    static class Program
    {
        /// <summary>
        /// Ini adalah titik masuk utama untuk aplikasi itu.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());
        }
    }
}
