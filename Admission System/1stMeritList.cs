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
    public partial class _1stMeritList : Form
    {
        public _1stMeritList()
        {
            InitializeComponent();
        }

       
        private void btnGenerateList_Click(object sender, EventArgs e)
        {
                if (rbUndergraduate.Checked == true)
                {
                    bool flag = false;

                    string programme = "BS";
                    if (rbCS.Checked == true)
                    {
                        programme += rbCS.Text.ToUpper();
                        flag = true;
                    }
                    else if (rbSE.Checked == true)
                    {
                        programme += rbSE.Text.ToUpper();
                        flag = true;
                    }
                    else if (rbIT.Checked == true)
                    {
                        programme += rbIT.Text.ToUpper();
                        flag = true;
                    }
                    else
                        MessageBox.Show("Select a Degree Progrmme !");
                    if (flag)
                    {
                        rwGraduate.Visible = true;
                        // TODO: This line of code loads data into the 'MeritList1DataSet.UG_Candidate' table. You can move, or remove it, as needed.
                        this.UG_CandidateTableAdapter.Fill(this.MeritList1DataSet.UG_Candidate, programme);

                        this.rwGraduate.RefreshReport();
                        rwGraduateA.Visible = false;
                    }
                }
                else if(rbGraduate.Checked == true)
                {
                    bool flag = false;

                    string programme = "MS";
                    if (rbCS.Checked == true)
                    {
                        programme += rbCS.Text.ToUpper();
                        flag = true;
                    }
                    else if (rbIT.Checked == true)
                    {
                        programme += rbIT.Text.ToUpper();
                        flag = true;
                    }
                    else
                        MessageBox.Show("Select a Degree Progrmme !");
                    if(flag)
                    {

                        rwGraduate.Visible = false;
                        rwGraduateA.Visible = true;
                        // TODO: This line of code loads data into the 'GMeritList1DataSet.G_Candidate' table. You can move, or remove it, as needed.
                        this.G_CandidateTableAdapter.Fill(this.GMeritList1DataSet.G_Candidate,programme);

                        this.rwGraduateA.RefreshReport();
                    }
                }
        }

        private void rbUndergraduate_CheckedChanged(object sender, EventArgs e)
        {
            rbSE.Visible = true;
        }

        private void rbGraduate_CheckedChanged(object sender, EventArgs e)
        {
            rbSE.Visible = false;
        }

        private void _1stMeritList_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Hide();
        }

        private void _1stMeritList_FormClosing(object sender, FormClosingEventArgs e)
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
