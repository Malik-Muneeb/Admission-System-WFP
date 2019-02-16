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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\Study\Projects 4\Admission System\Admission System\Admission System.mdf;Integrated Security=True");

        private void btnlogin_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT COUNT(*) FROM ACCOUNTS WHERE USERNAME ='" + getUserNameBox.Text + "' AND PASSWORD='" + getPassBox.Text+"'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                HomePage newForm = new HomePage();
                newForm.Owner = this;
                newForm.Show();
                getPassBox.Text = null;
                this.Hide();
            }

            else
            {
                LblInvalid.Visible = true;
                getPassBox.Text = null;
            }
        }


        private void btnRegister_Click(object sender, EventArgs e)
        {            
            Registration newForm = new Registration();
            newForm.Owner = this;
            getPassBox.Text = null;
            newForm.Show();
            this.Hide();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            if (MessageBox.Show("Are you sure you want to quit ?", "Close ? ??", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
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
            else
                e.Cancel = true;
        }        
    }
}
