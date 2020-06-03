using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace OOP_lab_8_7_2
{
    static class Program
    {
        public static List<Weather> weather = new List<Weather>();

        [STAThread]
        static void Main()
        {
            new Input().Read();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
        }
    }
}
