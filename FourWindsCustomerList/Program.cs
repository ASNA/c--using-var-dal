using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FourWindsCustomerList
{
    static class Program
    {
        //public const string RUNTIME_DB_NAME = "*PUBLIC/Cypress";
        public const string RUNTIME_DB_NAME = "*PUBLIC/DG NET Local";
        public static string UserName;
        public static string Password;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
