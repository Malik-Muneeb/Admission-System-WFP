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
    public partial class Statistics_Report : Form
    {
        public Statistics_Report()
        {
            InitializeComponent();
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\Study\Projects 4\Admission System\Admission System\Admission System.mdf;Integrated Security=True");
            SqlDataAdapter cmd;
            DataTable dt = new DataTable();
            string query;

            con.Open();
            query = "SELECT COUNT(*) FROM G_CANDIDATE";
            cmd = new SqlDataAdapter(query, con);
            dt = new DataTable();
            cmd.Fill(dt);
            getMSApp.Text = dt.Rows[0][0].ToString();

            query = "SELECT COUNT(*) FROM G_CANDIDATE WHERE PROG_ID=4";
            cmd = new SqlDataAdapter(query, con);
            dt = new DataTable();
            cmd.Fill(dt);
            getMSCSApp.Text = dt.Rows[0][0].ToString();

            query = "SELECT COUNT(*) FROM G_CANDIDATE WHERE PROG_ID=5";
            cmd = new SqlDataAdapter(query, con);
            dt = new DataTable();
            cmd.Fill(dt);
            getMSITApp.Text = dt.Rows[0][0].ToString();
            getMSTotalSeats.Text = "5";

            query = "SELECT COUNT(*) FROM G_CANDIDATE  WHERE UPPER(G_STATUS)='SELECTED'";
            cmd = new SqlDataAdapter(query, con);
            dt = new DataTable();
            cmd.Fill(dt);
            if (dt.Rows[0][0].ToString() == "")
            {
                getMSAvailabeSeats.Text = "0";
                getMSRevenue.Text = "0";
            }
            else
            {
                getMSAvailabeSeats.Text = (5 - Int32.Parse(dt.Rows[0][0].ToString())).ToString();
                getMSRevenue.Text = (25000 * (Int32.Parse(dt.Rows[0][0].ToString()))).ToString();
            }
            con.Close();


            con.Open();
            query = "SELECT COUNT(*) FROM UG_CANDIDATE";
            cmd = new SqlDataAdapter(query, con);
            dt = new DataTable();
            cmd.Fill(dt);
            getBSApp.Text = dt.Rows[0][0].ToString();


            query = "SELECT COUNT(*) FROM UG_CANDIDATE WHERE PROG_ID = 1";
            cmd = new SqlDataAdapter(query, con);
            dt = new DataTable();
            cmd.Fill(dt);
            getBSCSApp.Text = dt.Rows[0][0].ToString();

            query = "SELECT COUNT(*) FROM UG_CANDIDATE WHERE PROG_ID = 2";
            cmd = new SqlDataAdapter(query, con);
            dt = new DataTable();
            cmd.Fill(dt);
            getBSITApp.Text = dt.Rows[0][0].ToString();

            query = "SELECT COUNT(*) FROM UG_CANDIDATE WHERE PROG_ID = 3";
            cmd = new SqlDataAdapter(query, con);
            dt = new DataTable();
            cmd.Fill(dt);
            getBSSEApp.Text = dt.Rows[0][0].ToString();

            getBSTotalSeats.Text = "5";

            query = "SELECT COUNT(*) FROM UG_CANDIDATE WHERE UPPER(UG_STATUS)='SELECTED'";
            cmd = new SqlDataAdapter(query, con);
            dt = new DataTable();
            cmd.Fill(dt);
            if (dt.Rows[0][0].ToString() == "")
            {
                getBSAvailabeSeats.Text = "0";
                getBSRevenue.Text = "0";
            }
            else
            {
                getBSAvailabeSeats.Text = (5 - Int32.Parse(dt.Rows[0][0].ToString())).ToString();
                getBSRevenue.Text = (25000 * (Int32.Parse(dt.Rows[0][0].ToString()))).ToString();
            }
            getTotalRevenue.Text = (Int32.Parse(getMSRevenue.Text) + Int32.Parse(getBSRevenue.Text)).ToString();
            con.Close();



        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Hide();
        }

    }
}
