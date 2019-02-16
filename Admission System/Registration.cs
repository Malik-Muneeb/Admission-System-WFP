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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\Study\Projects 4\Admission System\Admission System\Admission System.mdf;Integrated Security=True");

        private void btnRegister_Click(object sender, EventArgs e)
        {
            bool registration = false;
            if (getFNameBox.Text == "")
            {
                lblFNameStar.Visible = true;
                MessageBox.Show("Must give First Name");
            }
            else
            {
                if (getLNameBox.Text == "")
                    getLNameBox.Text = "";
                else if (getUserNameBox.Text == "" || (getUserNameBox.Text[0] >= '1' && getUserNameBox.Text[0] <= '9'))
                {
                    lblUNameStar.Visible = true;
                    MessageBox.Show("Invalid Username");
                }
                else
                {
                    bool notFound = true;
                    if (getPassBox.Text == "")
                    {
                        lblPassStar.Visible = true;
                        MessageBox.Show("Must give Password");
                    }
                    else
                    {
                        notFound = true;
                        SqlDataAdapter da = new SqlDataAdapter("SELECT COUNT(*) FROM ACCOUNTS WHERE USERNAME = '" + getUserNameBox.Text + "'", con);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        if (dt.Rows.Count > 0 && dt.Rows[0][0].ToString() == "1")
                            notFound = false;
                        else
                            notFound = true;

                    }
                    if (notFound)
                    {

                        con.Open();
                        SqlDataAdapter insertData = new SqlDataAdapter();
                        try
                        {
                            insertData.InsertCommand = new SqlCommand("Insert accounts values (@FirstName,@LastName,@Username,@Password,@Gender)", con);
                            insertData.InsertCommand.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = getFNameBox.Text.ToString();
                            insertData.InsertCommand.Parameters.Add("@LastName", SqlDbType.VarChar).Value = getLNameBox.Text.ToString();
                            insertData.InsertCommand.Parameters.Add("@Username", SqlDbType.VarChar).Value = getUserNameBox.Text.ToString();
                            insertData.InsertCommand.Parameters.Add("@Password", SqlDbType.VarChar).Value = getPassBox.Text.ToString();
                            if (btnMale.Checked == true)
                                insertData.InsertCommand.Parameters.Add("@Gender", SqlDbType.Char).Value = "Male";
                            else if (btnFemale.Checked == true)
                                insertData.InsertCommand.Parameters.Add("@Gender", SqlDbType.Char).Value = "Female";
                            else if (btnOther.Checked == true)
                                insertData.InsertCommand.Parameters.Add("@Gender", SqlDbType.Char).Value = "Other";
                            else
                            {
                                lblGenderStar.Visible = true;
                                MessageBox.Show("Must choose gender!", "Alert!");
                            }
                            con.Close();
                            con.Open();
                            insertData.InsertCommand.ExecuteNonQuery();
                            con.Close();
                            registration = true;
                        }
                        catch (ConstraintException)
                        {
                            MessageBox.Show("Please enter valid values", "Alert!");
                            con.Close();
                        }
                    }
                    else
                        MessageBox.Show("Username already exist, Try another Username!", "Oops!");
                }
            }
            if (registration)
            {
                MessageBox.Show("Registration Successful");
                getFNameBox.Text = null;
                getPassBox.Text = null;
                getLNameBox.Text = null;
                getUserNameBox.Text = null;
            }
        }

        private void btnMale_CheckedChanged(object sender, EventArgs e)
        {
            if (btnMale.Checked)            
                LblGenderDesc.Text = "Male";            
        }

        private void btnFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (btnFemale.Checked)             
                LblGenderDesc.Text = "Female";                            
        }

        private void btnOther_CheckedChanged(object sender, EventArgs e)
        {
            if (btnOther.Checked)            
                LblGenderDesc.Text = "Other";            
        }       

        private void btnBackLogin_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Hide();
        }

        private void Registration_FormClosing(object sender, FormClosingEventArgs e)
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
