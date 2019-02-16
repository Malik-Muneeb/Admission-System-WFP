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
    public partial class _2ndMeritList : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\Study\Projects 4\Admission System\Admission System\Admission System.mdf;Integrated Security=True");
        SqlDataAdapter sda;
        DataTable dt;
        public _2ndMeritList()
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
                    string query;
                    query = "SELECT PROG_ID FROM Programme WHERE PROG_NAME = '" + programme + "'";
                    con.Open();
                    sda = new SqlDataAdapter(query, con);
                    dt = new DataTable();
                    sda.Fill(dt);
                    con.Close();

                    int prog_id = Int32.Parse(dt.Rows[0][0].ToString());

                    query = "SELECT COUNT(*) FROM UG_CANDIDATE WHERE UG_STATUS = 'Selected' AND PROG_ID = "+prog_id;
                    con.Open();
                    sda = new SqlDataAdapter(query, con);
                    dt = new DataTable();
                    sda.Fill(dt);
                    con.Close();
                    int list1Student = Int32.Parse(dt.Rows[0][0].ToString());
                    query = "SELECT COUNT(*) FROM UG_CANDIDATE WHERE PROG_ID = "+prog_id;
                    con.Open();
                    sda = new SqlDataAdapter(query, con);
                    dt = new DataTable();
                    sda.Fill(dt);
                    con.Close();
                    int totalStudent = Int32.Parse(dt.Rows[0][0].ToString());

                    rwGraduate.Visible = false;
                    rwUndergraduate.Visible = true;
                    // TODO: This line of code loads data into the 'UGMeritList2DataSet.DataTable1' table. You can move, or remove it, as needed.
                    this.DataTable1TableAdapter.Fill(this.UGMeritList2DataSet.DataTable1, 5 - list1Student, totalStudent - list1Student, prog_id);
                    this.rwUndergraduate.RefreshReport();

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
                    con.Close();

                    int prog_id = Int32.Parse(dt.Rows[0][0].ToString());

                    query = "SELECT COUNT(*) FROM G_CANDIDATE WHERE G_STATUS = 'Selected' AND PROG_ID = " + prog_id;
                    con.Open();
                    sda = new SqlDataAdapter(query, con);
                    dt = new DataTable();
                    sda.Fill(dt);
                    con.Close();
                    int list1Student = Int32.Parse(dt.Rows[0][0].ToString());
                    query = "SELECT COUNT(*) FROM G_CANDIDATE WHERE PROG_ID = " + prog_id;
                    con.Open();
                    sda = new SqlDataAdapter(query, con);
                    dt = new DataTable();
                    sda.Fill(dt);
                    con.Close();
                    int totalStudent = Int32.Parse(dt.Rows[0][0].ToString());


                    rwGraduate.Visible = true;
                    rwUndergraduate.Visible = false;
                    // TODO: This line of code loads data into the 'UGMeritList2DataSet.DataTable2' table. You can move, or remove it, as needed.
                    this.DataTable2TableAdapter.Fill(this.UGMeritList2DataSet.DataTable2, 5 - list1Student, totalStudent - list1Student, prog_id);
                    this.rwGraduate.RefreshReport();
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
        

        private void _2ndMeritList_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Hide();
        }

        private void _2ndMeritList_FormClosing(object sender, FormClosingEventArgs e)
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
