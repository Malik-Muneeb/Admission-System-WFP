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
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void Reports_Load(object sender, EventArgs e)
        {

        }
      
        private void btnGenerateList_Click(object sender, EventArgs e)
        {
            if (rbUndergraduate.Checked == true)
            {
                rwUndergraduate.Visible = true;
                rwGraduate.Visible = false;
                // TODO: This line of code loads data into the 'UGGeneralListDataSet.UG_Candidate' table. You can move, or remove it, as needed.
                this.UG_CandidateTableAdapter.Fill(this.UGGeneralListDataSet.UG_Candidate);
                this.rwUndergraduate.RefreshReport();
                
            }
            else if (rbGraduate.Checked == true)
            {
                rwUndergraduate.Visible = false;
                rwGraduate.Visible = true;
                // TODO: This line of code loads data into the 'GGeneralListDataSet.G_Candidate' table. You can move, or remove it, as needed.
                this.G_CandidateTableAdapter.Fill(this.GGeneralListDataSet.G_Candidate);

                this.rwGraduate.RefreshReport();
            }
            else
                MessageBox.Show("Select a Degree First", "Error");

        }

        private void Reports_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Hide();
        }


    }
}