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
            FourWinds.Customer.DBConnection DGDB;

            // The runtime database name is provided as a static constant in the 
            // Program class. 
            DGDB =  new FourWinds.Customer.DBConnection(Program.RUNTIME_DB_NAME, 
                                                            textboxUser.Text.Trim(), 
                                                            textboxPassword.Text.Trim());
            try
            {
                // Attempt DB connect.
                DGDB.ConnectDB();
                // Save user and password for use later. 
                Program.UserName = textboxUser.Text.Trim();
                Program.Password = textboxPassword.Text.Trim();
                // Disconnect DB. 
                DGDB.DisconnectDB();
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
