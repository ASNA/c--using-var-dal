using System;
using System.Windows.Forms;

namespace FourWindsCustomerList
{
    public partial class Form1 : Form
    {
        // This class requires an explicit reference to these assemblies:
        // 
        // * ASNA.VisualRPG.Runtime
        // * FourWindows.Customer 

        // Declare global (to this form/class) class variables. 
        FourWinds.Customer.ListByName cl;
        ASNA.VisualRPG.Runtime.Database DGDB;

        // Set number of rows to read in the ListByName class. 
        const int ROWS_TO_READ = 12;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Use only the manually created DataGridView columns.                
            dgvCust.AutoGenerateColumns = false;

            // Instance a login form. 
            formLogin lf = new formLogin();
            // Show it and put its result in `dr`.
            DialogResult dr = lf.ShowDialog();
            // If OK, then...
            if (dr == DialogResult.OK)
            {
                // Instance a DataGate DB object. 
                DGDB = new ASNA.VisualRPG.Runtime.Database(Program.RUNTIME_DB_NAME);
                // Set its user and password to the values provided at login.
                DGDB.User = Program.UserName;
                DGDB.Password = Program.Password;
            
                // Instance the ListByName class. 
                cl = new FourWinds.Customer.ListByName(DGDB, ROWS_TO_READ);
                // Connect its database.
                cl.ConnectDB();
                // Open its files. 
                cl.OpenFiles();
                // Get the first page of customers.
                dgvCust.DataSource = cl.GetList();
            }
            else
            {
                // If the user canceled the login, then exit this app. 
                Application.Exit();
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Make the `cl` instance of ListByName is indeed instanced. 
            // (It won't be if the user canceled the login.)
            if (cl != null)
            {
                // Close files and disconnect the DB.
                cl.CloseFiles();
                cl.DisconnectDB();
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            // PositiontoNext returns true if it could find the 
            // the specified customer. 
            if (cl.PositionToNext(cl.LastCMName, cl.LastCMCustNo))
            {
                // Clear the list. 
                cl.ClearList();
                // Get the next page. 
                dgvCust.DataSource = cl.GetList();
                // Set buttonNext enabled status. 
                buttonNext.Enabled = cl.HasMoreRecords;
            }
            else
            {

            }
        }
       private void buttonPositionTo_Click(object sender, EventArgs e)
        {
            if (cl.PositionTo(textboxPositionTo.Text.Trim(), 0))
            {
                cl.ClearList();
                dgvCust.DataSource = cl.GetList();
                buttonNext.Enabled = cl.HasMoreRecords;
            }
            else
            {
                MessageBox.Show("Position-to value not found.");
            }
        }

        private void buttonGotoFirst_Click(object sender, EventArgs e)
        {
            cl.PositionToFirst();
            cl.ClearList();
            dgvCust.DataSource = cl.GetList();
            buttonNext.Enabled = cl.HasMoreRecords;
        }
    }
}
