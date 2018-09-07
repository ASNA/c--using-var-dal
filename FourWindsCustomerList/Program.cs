
// <input action="action" onclick="window.history.go(-1); return false;" type="button" value="Back to members list" />
// ---
// This the entry point for the C# Windows application. It launches Form1. 
// It also provides static storage for all forms in the app. 
// ---

// Namespace declarations.
using System;
using System.Windows.Forms;

namespace FourWindsCustomerList
{
    static class Program
    {
        // Runtime database name. 
        public const string RUNTIME_DB_NAME = "*PUBLIC/Cypress";
        //- public const string RUNTIME_DB_NAME = "*PUBLIC/DG NET Local";
        // The user name and password are cached here during the life of this program.
        // (C#'s `static` keyword is the same as AVR's `Shared(*Yes)` keyword.)        
        public static string UserName;
        public static string Password;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Launch Form1.
            Application.Run(new Form1());
        }
    }
}
