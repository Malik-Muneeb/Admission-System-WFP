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
    public partial class Fee_Submission : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\Study\Projects 4\Admission System\Admission System\Admission System.mdf;Integrated Security=True");
        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        DataTable dt;
        public Fee_Submission()
        {
            InitializeComponent();
        }


        private void btnGenerate_Click(object sender, EventArgs e)
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
                    string query;
                    query = "SELECT PROG_ID FROM Programme WHERE PROG_NAME = '" + programme + "'";
                    con.Open();
                    sda = new SqlDataAdapter(query, con);
                    dt = new DataTable();
                    sda.Fill(dt);

                    int prog_id = Int32.Parse(dt.Rows[0][0].ToString());

                    con.Close();
                    query = "SELECT COUNT(*) FROM UG_CANDIDATE WHERE UPPER(UG_STATUS) = 'SELECTED'";
                    con.Open();
                    sda = new SqlDataAdapter(query, con);
                    dt = new DataTable();
                    sda.Fill(dt);
                    int pListStd = Int32.Parse(dt.Rows[0][0].ToString());
                    pListStd = 5 - pListStd;
                    con.Close();
                    query = "SELECT TOP  (" + pListStd + ") UG_FORM_NO AS 'Form Number',UG_CNAME AS Name,UG_FNAME AS 'Father Name', UG_CTEST AS 'Test Scores',ROUND((UG_CMATRIC / 4.0 + UG_CINTER + UG_CHAFIZ) / 1362.5 * 70 + 30 * (UG_CTEST / 60.0), 2) AS Merit,UG_STATUS AS Status FROM UG_CANDIDATE WHERE PROG_ID = " + prog_id + " AND UG_STATUS = 'N/A' ORDER BY Merit DESC";
                    con.Open();
                    sda = new SqlDataAdapter(query, con);
                    dt = new DataTable();
                    sda.Fill(dt);
                    con.Close();

                    if (dt.Rows.Count > 0)
                    {
                        dgvFeeSubmission.DataSource = dt;
                    }

                }
            }
            else if (rbGraduate.Checked == true)
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
                if (flag)
                {


                    string query;
                    query = "SELECT PROG_ID FROM Programme WHERE PROG_NAME = '" + programme + "'";
                    con.Open();
                    sda = new SqlDataAdapter(query, con);
                    dt = new DataTable();
                    sda.Fill(dt);

                    int prog_id = Int32.Parse(dt.Rows[0][0].ToString());

                    con.Close();
                    query = "SELECT COUNT(*) FROM G_CANDIDATE WHERE UPPER(G_STATUS) = 'SELECTED'";
                    con.Open();
                    sda = new SqlDataAdapter(query, con);
                    dt = new DataTable();
                    sda.Fill(dt);
                    int pListStd = Int32.Parse(dt.Rows[0][0].ToString());
                    pListStd = 5 - pListStd;
                    con.Close();
                    query = "SELECT TOP ("+pListStd+") G_FORM_NO AS 'Form Number',G_CNAME AS Name,G_FNAME AS 'Father Name', G_CTEST AS 'Test Scores',ROUND((G_CMATRIC / 4.0 + G_CINTER/5.0 +G_BS_CGPA + G_CHAFIZ) / 486.5 * 70 + 30 * (G_CTEST / 60.0), 2) AS Merit,G_STATUS AS Status FROM G_CANDIDATE WHERE PROG_ID = " + prog_id + "AND G_STATUS = 'N/A' ORDER BY Merit DESC";
                    con.Open();
                    sda = new SqlDataAdapter(query, con);
                    dt = new DataTable();
                    sda.Fill(dt);
                    con.Close();

                    if (dt.Rows.Count > 0)
                    {

                        dgvFeeSubmission.DataSource = dt;

                    }

                }
            }
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            scb = new SqlCommandBuilder(sda);
            sda.Update(dt);
        }

        private void rbGraduate_CheckedChanged(object sender, EventArgs e)
        {
            rbSE.Visible = false;
        }

        private void rbUndergraduate_CheckedChanged(object sender, EventArgs e)
        {
            rbSE.Visible = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Hide();
        }

        private void Fee_Submission_FormClosing(object sender, FormClosingEventArgs e)
        {
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
