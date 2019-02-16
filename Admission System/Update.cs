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
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\Study\Projects 4\Admission System\Admission System\Admission System.mdf;Integrated Security=True");
        private void btnEnter_Click(object sender, EventArgs e)
        {
           
            con.Open();
            string formNo = getFormNoBox.Text.ToString().ToUpper();
            string formNo1 = "", formNo2 = "";
            if (formNo.Length > 2)
                formNo1 = formNo.Substring(0, 2);
            if (formNo.Length > 1)
                formNo2 = formNo.Substring(0, 1);
            DataTable dt = new DataTable();
            bool found = true;
            bool isUG = true;
            if (formNo1 == "UG" && formNo.Length > 2)
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT UG_FORM_NO FROM UG_CANDIDATE WHERE UG_FORM_NO = '" + getFormNoBox.Text.ToUpper() + "'", con);                
                da.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No Record Found !", "Oops");
                    found = false;
                }
                else
                    isUG = true;
            }
            else if (formNo2 == "G" && formNo.Length > 1)
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT G_FORM_NO FROM G_CANDIDATE WHERE G_FORM_NO = '" + getFormNoBox.Text.ToUpper() + "'", con);
                da.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No Record Found !", "Oops");
                    found = false;
                }
                else
                    isUG = false;
            }    
            else
            {
                MessageBox.Show("No Record Found !", "Oops");
                found = false;
            }                
            if (found && dt.Rows.Count > 0 && dt.Rows[0][0].ToString() == getFormNoBox.Text.ToUpper())
            {
                Admission_Form newForm = new Admission_Form(getFormNoBox.Text.ToUpper(), isUG);
                newForm.Owner = this;
                newForm.Show();
                this.Hide();
            }
                            
            con.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Hide();
        }
       
        private void Update_FormClosing(object sender, FormClosingEventArgs e)
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
