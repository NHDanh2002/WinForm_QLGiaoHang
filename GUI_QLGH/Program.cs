using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace GUI_QLGH
{
    static class Program
    {
        public static Thread th;
        public static Thread th1;
        [STAThread]
        static void Main()
        {
            th = new Thread(new ThreadStart(openform));
            th1 = new Thread(new ThreadStart(openform1));
            th1.SetApartmentState(ApartmentState.STA);
            th1.Start();
        }

        static void openform()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmTrangChu());
        }
        static void openform1()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());
        }
    }
}
