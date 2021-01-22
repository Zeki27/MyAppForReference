using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace MyApp
{
    class FormOpenClose
    {
        private static Thread th;

        public static void OpenMainForm()
        {
            th = new Thread(OpenMainWindow);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private static void OpenMainWindow(object obj)
        {
            Application.Run(new frmMain());
        }

        public static void OpenSqlModifyForm()
        {
            th = new Thread(OpenSqlModifyWindow);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private static void OpenSqlModifyWindow (object obj)
        {
            Application.Run(new frmModifySQLConn());
        }
    }
}
