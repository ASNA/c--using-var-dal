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

        FourWinds.Customer.ListByName cl;
        ASNA.VisualRPG.Runtime.Database DGDB;

        const int ROWS_TO_READ = 12;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvCust.AutoGenerateColumns = false;

            formLogin lf = new formLogin();
            DialogResult dr = lf.ShowDialog();
            if (dr == DialogResult.OK)
            {
                DGDB = new ASNA.VisualRPG.Runtime.Database(Program.RUNTIME_DB_NAME);
                //DGDB.User = Program.UserName;
                //DGDB.Password = Program.Password;
            
                cl = new FourWinds.Customer.ListByName(DGDB, ROWS_TO_READ);
                cl.ConnectDB();
                cl.OpenFiles();
                dgvCust.DataSource = cl.GetList();
            }
            else
            {
                Application.Exit();
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (cl != null)
            {
                cl.CloseFiles();
                cl.DisconnectDB();
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (cl.PositionToNext(cl.LastCMName, cl.LastCMCustNo))
            {
                cl.ClearList();
                dgvCust.DataSource = cl.GetList();
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
                bool hasMoreRecords = cl.HasMoreRecords;
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
        }
    }
}
