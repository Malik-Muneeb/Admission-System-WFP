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
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\Study\Projects 4\Admission System\Admission System\Admission System.mdf;Integrated Security=True");

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (getCNICSearchBox.Text.Length < 15 && getFormNoBox.Text == "")
                MessageBox.Show("Oops! Fill atleat one field correctly!");
            else
            {
                SqlDataAdapter da;
                DataTable dt = new DataTable();


                if (radioButton1.Checked)
                {
                    con.Open();
                    da = new SqlDataAdapter("SELECT UG_CNAME,UG_FNAME FROM UG_CANDIDATE WHERE UG_CCNIC = '" + getCNICSearchBox.Text.ToUpper() + "' OR UG_FORM_NO ='" + getFormNoBox.Text.ToString().ToUpper() + "'", con);
                    dt = new DataTable();
                    da.Fill(dt);
                    con.Close();
                    if (dt.Rows.Count > 0)
                    {
                        reportViewer1.Visible = true;
                        // TODO: This line of code loads data into the 'SearchDataSet.UG_Candidate' table. You can move, or remove it, as needed.
                        this.UG_CandidateTableAdapter.Fill(this.SearchDataSet.UG_Candidate, getFormNoBox.Text.ToString().ToUpper(), getCNICSearchBox.Text.ToUpper());

                        this.reportViewer1.RefreshReport();
                        reportViewer2.Visible = false;
                    }
                    else
                    {
                        reportViewer2.Visible = true;
                        // TODO: This line of code loads data into the 'SearchDataSet.UG_Candidate' table. You can move, or remove it, as needed.
                        this.UG_CandidateTableAdapter.Fill(this.SearchDataSet.UG_Candidate, "UG0", "0000000000000");

                        this.reportViewer1.RefreshReport();
                        reportViewer2.Visible = false;
                        MessageBox.Show("Sorry! No Record Found!", "Oops!");

                    }
                }
                else
                {
                    con.Open();
                    da = new SqlDataAdapter("SELECT G_CNAME,G_FNAME FROM G_CANDIDATE WHERE G_CCNIC = '" + getCNICSearchBox.Text.ToString().ToUpper() + "' OR G_FORM_NO ='" + getFormNoBox.Text.ToString().ToUpper() + "'", con);
                    dt = new DataTable();
                    da.Fill(dt);
                    con.Close();
                    if (dt.Rows.Count > 0)
                    {
                        reportViewer2.Visible = true;
                        // TODO: This line of code loads data into the 'GSearchDataSet.G_Candidate' table. You can move, or remove it, as needed.
                        this.G_CandidateTableAdapter.Fill(this.GSearchDataSet.G_Candidate, getFormNoBox.Text.ToUpper(), getCNICSearchBox.Text.ToString());

                        this.reportViewer2.RefreshReport();
                        reportViewer1.Visible = false;
                    }
                    else
                    {
                        reportViewer2.Visible = true;
                        // TODO: This line of code loads data into the 'GSearchDataSet.G_Candidate' table. You can move, or remove it, as needed.
                        this.G_CandidateTableAdapter.Fill(this.GSearchDataSet.G_Candidate, "G0", "0000000000000");

                        this.reportViewer2.RefreshReport();
                        reportViewer1.Visible = false;
                        MessageBox.Show("Sorry! No Record Found!", "Oops!");
                    }
                }
            }
        }

        //private void btnSearch_Click(object sender, EventArgs e)
        //{
        //    if (getCNICSearchBox.Text.Length == 14 && getFormNoBox.Text == "")
        //        MessageBox.Show("Oops! Fill atleat one field correctly!");
        //    else if (getCNICSearchBox.Text.Length < 14)
        //        MessageBox.Show("Oops! Invalid CNIC #!");
        //    else if (getCNICSearchBox.Text.Length == 15) // Search on base of CNIC 
        //    {
        //        bool Record = false;
        //        con.Open();
        //        SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM UG_CANDIDATE WHERE UG_CCNIC = '" + getCNICSearchBox.Text.ToUpper() + "'", con);
        //        DataTable dt = new DataTable();
        //        da.Fill(dt);
        //        if (dt.Rows.Count > 0)
        //            Record = true;

        //        if (!Record)
        //        {
        //            con.Open();
        //            da = new SqlDataAdapter("SELECT * FROM G_CANDIDATE WHERE G_CCNIC = '" + getCNICSearchBox.Text.ToUpper() + "'", con);
        //            dt = new DataTable();
        //            da.Fill(dt);
        //            if (dt.Rows.Count > 0)
        //                Record = true;
        //        }
        //        if (Record == false)
        //            MessageBox.Show("Oops! No Record Found!");
        //        else
        //        {
        //            if (dt.Rows.Count > 0 && dt.Rows[0][0].ToString() != "")
        //            {
        //                for (int i = 0; i < 10; i++)
        //                    MessageBox.Show(dt.Rows[0][i].ToString());
        //            }
        //            else
        //                MessageBox.Show("Oops! No Record Found!");
        //            con.Close();
        //        }
        //    }
        //    else // Search on base of Form No.
        //    {
        //        bool flag = true;
        //        string checkForm = getFormNoBox.Text.ToString().ToUpper();
        //        for (int i = 0; i < checkForm.Length; i++)
        //        {
        //            if (!(checkForm[i] >= '0' && checkForm[i] <= '9') && checkForm[i] != 'U' && checkForm[i] != 'G')
        //                flag = false;
        //        }
        //        if (flag)
        //        {
        //            string formNo = getFormNoBox.Text.ToString().ToUpper();
        //            string formNo1 = "", formNo2 = "";
        //            if (formNo.Length > 2)
        //                formNo1 = formNo.Substring(0, 2);
        //            if (formNo.Length > 1)
        //                formNo2 = formNo.Substring(0, 1);
        //            if (formNo1 == "UG" && formNo.Length > 2)
        //            {
        //                con.Open();
        //                SqlDataAdapter da = new SqlDataAdapter("SELECT UG_CNAME,UG_FNAME FROM UG_CANDIDATE WHERE UG_CCNIC = '" + getCNICSearchBox.Text.ToUpper() + "' OR UG_FORM_NO ='" + getFormNoBox.Text.ToString() + "'", con);
        //                DataTable dt = new DataTable();
        //                da.Fill(dt);
        //                con.Close();
        //                if (dt.Rows.Count > 0)
        //                {
        //                    lblDegree.Text = "Undergraduate Student: ";
        //                    reportViewer1.Visible = true;
        //                    // TODO: This line of code loads data into the 'SearchDataSet.UG_Candidate' table. You can move, or remove it, as needed.
        //                    this.UG_CandidateTableAdapter.Fill(this.SearchDataSet.UG_Candidate, getFormNoBox.Text.ToUpper(), getCNICSearchBox.Text.ToUpper());

        //                    this.reportViewer1.RefreshReport();
        //                    reportViewer2.Visible = false;
        //                }
        //                else
        //                {
        //                    lblDegree.Text = "Undergraduate Student: ";
        //                    reportViewer1.Visible = true;
        //                    // TODO: This line of code loads data into the 'SearchDataSet.UG_Candidate' table. You can move, or remove it, as needed.
        //                    this.UG_CandidateTableAdapter.Fill(this.SearchDataSet.UG_Candidate, "UG0", "0000000000000");

        //                    this.reportViewer1.RefreshReport();
        //                    reportViewer2.Visible = false;
        //                    MessageBox.Show("No Record Found ! ", "Alert !");
        //                }

        //            }
        //            else if (formNo2 == "G" && formNo.Length > 1)
        //            {
        //                con.Open();
        //                SqlDataAdapter da = new SqlDataAdapter("SELECT G_CNAME,G_FNAME FROM G_CANDIDATE WHERE G_CCNIC = '" + getCNICSearchBox.Text.ToUpper() + "' OR G_FORM_NO ='" + getFormNoBox.Text.ToString() + "'", con);
        //                DataTable dt = new DataTable();
        //                da.Fill(dt);
        //                con.Close();
        //                if (dt.Rows.Count > 0)
        //                {
        //                    lblDegree.Text = "Graduate Student: ";
        //                    reportViewer2.Visible = true;
        //                    // TODO: This line of code loads data into the 'GSearchDataSet.G_Candidate' table. You can move, or remove it, as needed.
        //                    this.G_CandidateTableAdapter.Fill(this.GSearchDataSet.G_Candidate, getFormNoBox.Text.ToUpper(), getCNICSearchBox.Text.ToString());

        //                    this.reportViewer2.RefreshReport();
        //                    reportViewer1.Visible = false;
        //                }
        //                else
        //                {
        //                    lblDegree.Text = "Graduate Student: ";
        //                    reportViewer2.Visible = true;
        //                    // TODO: This line of code loads data into the 'GSearchDataSet.G_Candidate' table. You can move, or remove it, as needed.
        //                    this.G_CandidateTableAdapter.Fill(this.GSearchDataSet.G_Candidate, "G0", "0000000000000");

        //                    this.reportViewer2.RefreshReport();
        //                    reportViewer1.Visible = false;
        //                    MessageBox.Show("No Record Found ! ", "Alert !");
        //                }
        //            }
        //            else
        //                MessageBox.Show("Oops! No Record Found!");
        //        }
        //        else
        //            MessageBox.Show("Oops! Invalid Form Number!");
        //    }
        //}

        private void Search_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
        }
      
        private void btnDelete_Click(object sender, EventArgs e)
        {
            deleteRow(getCNICSearchBox.Text.ToUpper(), getFormNoBox.Text.ToString());
            {
                reportViewer1.Visible = true;
                // TODO: This line of code loads data into the 'SearchDataSet.UG_Candidate' table. You can move, or remove it, as needed.
                this.UG_CandidateTableAdapter.Fill(this.SearchDataSet.UG_Candidate, "UG0", "000000000000");

                this.reportViewer1.RefreshReport();
                reportViewer2.Visible = false;
            }
        }

        public static void deleteRow(string CNIC, string FORM_NO)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\Study\Projects 4\Admission System\Admission System\Admission System.mdf;Integrated Security=True");
                con.Open();
                if (MessageBox.Show("Are you Sure ?", "Alert !", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    bool found = true;
                    if (found)
                    {
                        string sql = @"DELETE FROM UG_CANDIDATE WHERE UG_CCNIC = '" + CNIC + "' OR UG_FORM_NO = '" + FORM_NO + "'";
                        SqlCommand cmd = new SqlCommand(sql, con);
                        cmd.ExecuteNonQuery();
                    }
                    else
                        MessageBox.Show("Delete Successful!");
                }

                else
                {
                    MessageBox.Show("Delete Process Canelled!");
                }
                con.Close();

            }
            catch (SystemException ex)
            {
                MessageBox.Show(string.Format("An error occurred: {0}", ex.Message));

            }
        }

        private void Search_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Hide();
        }        
    }
}