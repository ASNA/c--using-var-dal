using System;
using System.Windows.Forms;

namespace FourWindsCustomerList
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }

        // Attempt login to DataGate DB with credentials provided. This login 
        // is purely for authenticating the user--this connection is then immediately 
        // closed. If authenticated, the user name and password are persisted at 
        // runtime in the UserName and Password static variables in the Program class
        // (which is the startup object). Other forms and classes in this project 
        // can then reference those values for other runtime connections.  
        private void buttonLogin_Click(object sender, EventArgs e)
        {

            // The runtime database name is provided as a static constant in the 
            // Program class. 
            ASNA.VisualRPG.Runtime.Database DGDB = 
                new ASNA.VisualRPG.Runtime.Database(Program.RUNTIME_DB_NAME);

            // Create an instance of an AVR class with a ConnectDB method. This instance
            // is only used for authenticating the user. 
            FourWinds.Customer.ListByName cl = 
                new FourWinds.Customer.ListByName(DGDB);
            // Override the runtime DatabaseName's User and Password properties with those 
            // provided by the user at runtime. 
            DGDB.User = textboxUser.Text.Trim();
            DGDB.Password = textboxPassword.Text.Trim();

            try
            {
                // Attempt DB connect.
                cl.ConnectDB();
                // Save user and password for use later. 
                Program.UserName = textboxUser.Text.Trim();
                Program.Password = textboxPassword.Text.Trim();
                // Disconnect DB. 
                cl.DisconnectDB();
            }
            catch (Exception ex)
            {
                // Show connectinon failed 
                string Message = ex.Message;
                MessageBox.Show("Unable to connect: " + Message);
                buttonLogin.DialogResult = DialogResult.Cancel;
            }
        }
    }
}
