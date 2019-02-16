using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Admission_System
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void HomePage_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            Merit_List newForm = new Merit_List();
            newForm.Owner = this;
            newForm.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Hide();

        }

        private void btnStdRecord_Click(object sender, EventArgs e)
        {
            Student_Records newFrom = new Student_Records();
            newFrom.Owner = this;
            this.Hide();
            newFrom.Show();
        }
        
        private void btnReports_Click(object sender, EventArgs e)
        {
            Statistics_Report newForm = new Statistics_Report();
            newForm.Owner = this;
            this.Hide();
            newForm.Show();
        }

        private void HomePage_FormClosing(object sender, FormClosingEventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\Study\Projects 4\Admission System\Admission System\Admission System.mdf;Integrated Security=True");

            con.Open();
            string querystr = "UPDATE G_CANDIDATE SET G_STATUS = 'N/A'";
            SqlCommand query = new SqlCommand(querystr, con);
            query.ExecuteNonQuery();
            con.Close();

            con.Open();
            querystr = "UPDATE UG_CANDIDATE SET UG_STATUS = 'N/A'";
            query = new SqlCommand(querystr, con);
            query.ExecuteNonQuery();
            con.Close();

            Application.Exit();
        }
    }
}
