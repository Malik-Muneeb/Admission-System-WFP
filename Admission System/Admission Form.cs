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
    public partial class Admission_Form : Form
    {
        bool insertion = true;
        int updateProg_ID = 1;
        int updateAdd_ID = 1;
        int updateC_ID = 1;
        int updateHafizMarks = 0;

        public Admission_Form(string PK, bool isUG)
        {
            InitializeComponent();
            if (PK == "")
            {
                lblNumber.Text = getPrimaryKey("NO");
                insertion = true;
            }
            else
            {
                insertion = false;
                lblNumber.Text = PK;
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\Study\Projects 4\Admission System\Admission System\Admission System.mdf;Integrated Security=True");                DataTable dt = new DataTable();
                SqlDataAdapter da;
                if (isUG)
                {
                    radUGraduate.Checked = true;
                    radGradate.Visible = false;
                    
                    da = new SqlDataAdapter("SELECT * FROM UG_CANDIDATE WHERE UG_FORM_NO = '" + PK + "'", con);
                    da.Fill(dt);
                    
                }
                else
                {
                    radGradate.Checked = true;
                    radUGraduate.Visible = false;
                    getCGPAMarksBox.Visible = true;
                    getInterviewMarksBox.Visible = true;
                    lblCGPA.Visible = true;
                    lblInterview.Visible = true;
                    radSE.Visible = false;
                    
                    da = new SqlDataAdapter("SELECT * FROM G_CANDIDATE WHERE G_FORM_NO = '" + PK + "'", con);
                    da.Fill(dt);
                    
                }
                getCNameBox.Text = dt.Rows[0][1].ToString();
                getCNICBox.Text = dt.Rows[0][2].ToString();
                getFatherNameBox.Text = dt.Rows[0][3].ToString();
                getFatherCNICBox.Text = dt.Rows[0][4].ToString();
                getDOBBox.Text = dt.Rows[0][5].ToString();
                getMatricMarksBox.Text = dt.Rows[0][6].ToString();
                getInterMarksBox.Text = dt.Rows[0][7].ToString();
                getTestMarksBox.Text = dt.Rows[0][8].ToString();
                if (Int32.Parse(dt.Rows[0][9].ToString()) == 0)
                {
                    radNo.Checked = true;
                    updateHafizMarks = 0;
                }
                else
                {
                    radYes.Checked = true;
                    updateHafizMarks = 20;
                }
                getSchoolBox.Text = dt.Rows[0][10].ToString();
                getSchoolBoard.Text = dt.Rows[0][11].ToString();
                getCollegeBox.Text = dt.Rows[0][12].ToString();
                getCollegeBoard.Text = dt.Rows[0][13].ToString();
                int index = 15;
                if (isUG == false)
                {
                    getCGPAMarksBox.Text = dt.Rows[0][15].ToString();
                    getInterviewMarksBox.Text = dt.Rows[0][16].ToString();
                    index = 17;
                }

                con.Open();
                da = new SqlDataAdapter("SELECT * FROM PROGRAMME WHERE PROG_ID = '" + dt.Rows[0][index].ToString() + "'", con);
                dt = new DataTable();
                da.Fill(dt);
                if (isUG)
                {
                    if (Int32.Parse(dt.Rows[0][0].ToString()) == 1)
                        radCS.Checked = true;
                    else if (Int32.Parse(dt.Rows[0][0].ToString()) == 2)
                        radIT.Checked = true;
                    else
                        radSE.Checked = true;
                }
                else
                {
                    if (Int32.Parse(dt.Rows[0][0].ToString()) == 4)
                        radCS.Checked = true;
                    else if (Int32.Parse(dt.Rows[0][0].ToString()) == 5)
                        radIT.Checked = true;
                }
                updateProg_ID = Int32.Parse(dt.Rows[0][0].ToString());
                con.Close();

                con.Open();
                if (isUG)
                    da = new SqlDataAdapter("SELECT * FROM UG_CANDIDATE WHERE UG_FORM_NO = '" + PK + "'", con);
                else
                    da = new SqlDataAdapter("SELECT * FROM G_CANDIDATE WHERE G_FORM_NO = '" + PK + "'", con);
                dt = new DataTable();
                da.Fill(dt);
                index++;
                da = new SqlDataAdapter("SELECT * FROM ADDRESS WHERE ADD_ID = '" + dt.Rows[0][index].ToString() + "'", con);
                dt = new DataTable();
                da.Fill(dt);
                updateAdd_ID = Int32.Parse(dt.Rows[0][0].ToString());
                tbHouse.Text = dt.Rows[0][1].ToString();
                tbStreet.Text = dt.Rows[0][2].ToString();
                tbCity.Text = dt.Rows[0][3].ToString();
                cbProvince.Text = dt.Rows[0][4].ToString();
                tbPostalCode.Text = dt.Rows[0][5].ToString();
                getAreaBox.Text = dt.Rows[0][6].ToString();
                con.Close();

                con.Open();
                if (isUG)
                    da = new SqlDataAdapter("SELECT * FROM UG_CANDIDATE WHERE UG_FORM_NO = '" + PK + "'", con);
                else
                    da = new SqlDataAdapter("SELECT * FROM G_CANDIDATE WHERE G_FORM_NO = '" + PK + "'", con);
                dt = new DataTable();
                da.Fill(dt);
                index++;
                da = new SqlDataAdapter("SELECT * FROM CONTACT WHERE C_ID = '" + dt.Rows[0][index].ToString() + "'", con);
                dt = new DataTable();
                da.Fill(dt);
                updateC_ID = Int32.Parse(dt.Rows[0][0].ToString());
                tbPhone.Text = dt.Rows[0][1].ToString();
                tbMobile.Text = dt.Rows[0][2].ToString();
                tbEmail.Text = dt.Rows[0][3].ToString();
                con.Close();

            }
        }

        private void Admission_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
        }

        private string getPrimaryKey(string graduate)
        {
            if (graduate == "YES")
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT MAX( CONVERT(INT, SUBSTRING(G_FORM_NO,2,10)) ) FROM G_CANDIDATE", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                int index;
                string PK = dt.Rows[0][0].ToString();
                if (PK == "")
                    index = 1;
                else
                {

                    index = Int32.Parse(PK);
                    index++;
                }
                PK = "G" + index.ToString();
                con.Close();
                return PK;
            }
            else
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT MAX( CONVERT(INT, SUBSTRING(UG_FORM_NO,3,10)) ) FROM UG_CANDIDATE", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                int index;
                string PK = dt.Rows[0][0].ToString();
                if (PK == "")
                    index = 1;
                else
                {

                    index = PK.IndexOf('G');
                    PK = PK.Substring(index + 1);
                    index = Int32.Parse(PK);
                    index++;
                }
                PK = "UG" + index.ToString();
                con.Close();
                return PK;
            }
        }

        private void set_UG_Stars()
        {
            lblFNameStar1.Visible = true;
            lblFNameStar2.Visible = true;
            lblFNameStar3.Visible = true;
            lblFNameStar4.Visible = true;
            lblFNameStar5.Visible = true;
            lblFNameStar6.Visible = true;
            lblFNameStar7.Visible = true;
            lblFNameStar8.Visible = true;
            lblFNameStar9.Visible = true;
            lblFNameStar10.Visible = true;
            lblFNameStar11.Visible = true;
            lblFNameStar14.Visible = true;
            lblStar1.Visible = true;
            lblStar2.Visible = true;
            lblStar3.Visible = true;
            lblStar4.Visible = true;
            lblStar5.Visible = true;
            lblStar6.Visible = true;
            lblStar7.Visible = true;
            lblStar8.Visible = true;
            MessageBox.Show("Enter all mandatory fields with * on them !", "Oops! ");
        }

        private void set_G_Stars()
        {
            lblFNameStar1.Visible = true;
            lblFNameStar2.Visible = true;
            lblFNameStar3.Visible = true;
            lblFNameStar4.Visible = true;
            lblFNameStar5.Visible = true;
            lblFNameStar6.Visible = true;
            lblFNameStar7.Visible = true;
            lblFNameStar8.Visible = true;
            lblFNameStar9.Visible = true;
            lblFNameStar10.Visible = true;
            lblFNameStar11.Visible = true;
            lblFNameStar12.Visible = true;
            lblFNameStar13.Visible = true;
            lblStar1.Visible = true;
            lblStar2.Visible = true;
            lblStar3.Visible = true;
            lblStar4.Visible = true;
            lblStar5.Visible = true;
            lblStar6.Visible = true;
            lblStar7.Visible = true;
            lblStar8.Visible = true;
            MessageBox.Show("Enter all mandatory fields with * on them !", "Oops! ");
        }

        private void radGradate_CheckedChanged(object sender, EventArgs e)
        {
            if (insertion && radGradate.Checked)
            {
                getCGPAMarksBox.Visible = true;
                getInterviewMarksBox.Visible = true;
                lblCGPA.Visible = true;
                lblInterview.Visible = true;
                radSE.Visible = false;
                lblNumber.Text = getPrimaryKey("YES");
            }
        }

        private void radUGraduate_CheckedChanged(object sender, EventArgs e)
        {
            if (insertion && radUGraduate.Checked)
            {
                getCGPAMarksBox.Visible = false;
                getInterviewMarksBox.Visible = false;
                lblCGPA.Visible = false;
                lblInterview.Visible = false;
                radSE.Visible = true;
                lblNumber.Text = getPrimaryKey("NO");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Hide();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\Study\Projects 4\Admission System\Admission System\Admission System.mdf;Integrated Security=True");
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to continue ? ", "Alert!", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                bool recordEntry = false;
                bool validation = true;
                if (getCNameBox.Text == "" && validation && radUGraduate.Checked)
                {
                    set_UG_Stars();
                    validation = false;
                }
                else if (getCNameBox.Text.Length > 50 && validation && radUGraduate.Checked)
                {
                    MessageBox.Show("Candidate Name Length exceeded than 50!", "Alert!");
                    validation = false;
                }
                else if (getCNICBox.Text == "" && validation && radUGraduate.Checked)
                {
                    set_UG_Stars();
                    validation = false;
                }
                else if (getCNICBox.Text.Length <= 14 && validation && radUGraduate.Checked)
                {
                    MessageBox.Show("Enter CNIC in Correct Format!","Alert!");
                    validation = false;
                }
                else if (insertion && getCNICBox.Text.Length == 15 && validation && radUGraduate.Checked)
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM UG_CANDIDATE WHERE UG_CCNIC = '" + getCNICBox.Text.ToUpper() + "'", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("Record already exist against CNIC # " + getCNICBox.Text + " !", "Oops!");
                        validation = false;
                    }
                    con.Close();
                }
                if (getFatherNameBox.Text == "" && validation && radUGraduate.Checked)
                {
                    set_UG_Stars();
                    validation = false;
                }
                else if (getFatherNameBox.Text.Length > 50 && validation && radUGraduate.Checked)
                {
                    MessageBox.Show("Candidate's Father Name Length exceeded than 50!", "Alert!");
                    validation = false;
                }
                else if (getFatherCNICBox.Text == "" && validation && radUGraduate.Checked)
                {
                    set_UG_Stars();
                    validation = false;
                }
                else if (getFatherCNICBox.Text.Length <= 14 && validation && radUGraduate.Checked)
                {
                    MessageBox.Show("Enter Father CNIC in Correct Format!", "Alert!");
                    validation = false;
                }
                else if (tbHouse.Text == "" && validation && radUGraduate.Checked)
                {
                    set_UG_Stars();
                    validation = false;
                }
                else if (tbHouse.Text.Length > 50 && validation && radUGraduate.Checked)
                {
                    MessageBox.Show("House # or Name Length exceeded than 50!", "Alert!");
                    validation = false;
                }
                else if (tbStreet.Text == "" && validation && radUGraduate.Checked)
                {
                    set_UG_Stars();
                    validation = false;
                }
                else if (tbStreet.Text.Length > 50 && validation && radUGraduate.Checked)
                {
                    MessageBox.Show("Street # or Name Length exceeded than 50!", "Alert!");
                    validation = false;
                }
                else if (getAreaBox.Text == "" && validation && radUGraduate.Checked)
                {
                    set_UG_Stars();
                    validation = false;
                }
                else if (getAreaBox.Text.Length > 100 && validation && radUGraduate.Checked)
                {
                    MessageBox.Show("Area Field Length exceeded than 100!", "Alert!");
                    validation = false;
                }
                else if (tbCity.Text == "" && validation && radUGraduate.Checked)
                {
                    set_UG_Stars();
                    validation = false;
                }
                else if (tbCity.Text.Length > 50 && validation && radUGraduate.Checked)
                {
                    MessageBox.Show("City Name Length exceeded than 50!", "Alert!");
                    validation = false;
                }
                else if (cbProvince.Text == "" && validation && radUGraduate.Checked)
                {
                    set_UG_Stars();
                    validation = false;
                }
                else if (cbProvince.Text.Length > 50 && validation && radUGraduate.Checked)
                {
                    MessageBox.Show("Province Length exceeded than 50!", "Alert!");
                    validation = false;
                }
                else if (tbPostalCode.Text == "" && validation && radUGraduate.Checked)
                {
                    set_UG_Stars();
                    validation = false;
                }
                else if (tbPostalCode.Text.Length > 6 && validation && radUGraduate.Checked)
                {
                    MessageBox.Show("Postal Length exceeded than 6!", "Alert!");
                    validation = false;
                }
                else if (tbPostalCode.Text != "" && validation && radUGraduate.Checked)
                {
                    string pCode = tbPostalCode.Text.ToString();
                    bool flag = true;
                    for (int i = 0; i < pCode.Length && flag; i++)
                    {
                        if (pCode[i] < '0' || pCode[i] > '9')
                            flag = false;
                    }
                    if (!flag)
                    {
                        MessageBox.Show("Postal Code must not include characters other than digits!", "Alert!");
                        validation = false;
                    }
                }
                if (tbPhone.Text == "" && validation && radUGraduate.Checked)
                {
                    set_UG_Stars();
                    validation = false;
                }
                else if (tbPhone.Text.Length < 13 && validation && radUGraduate.Checked)
                {
                    MessageBox.Show("Invalid Phone Number!", "Alert!");
                    validation = false;
                }
                else if (tbMobile.Text == "" && validation && radUGraduate.Checked)
                {
                    set_UG_Stars();
                    validation = false;
                }
                else if (tbMobile.Text.Length < 12 && validation && radUGraduate.Checked)
                {
                    MessageBox.Show("Invalid Mobile Number!", "Alert!");
                    validation = false;
                }
                else if (tbEmail.Text == "" && validation && radUGraduate.Checked)
                {
                    set_UG_Stars();
                    validation = false;
                }
                else if (tbEmail.Text.Length > 50 && validation && radUGraduate.Checked)
                {
                    MessageBox.Show("Email Length exceeded than 50!", "Alert!");
                    validation = false;
                }
                else if (getMatricMarksBox.Text == "" && validation && radUGraduate.Checked)
                {
                    set_UG_Stars();
                    validation = false;
                }

                else if (getMatricMarksBox.Text != "" && validation && radUGraduate.Checked)
                {
                    string marks = getMatricMarksBox.Text.ToString();
                    bool flag = true;
                    for (int i = 0; i < marks.Length && flag; i++)
                    {
                        if (marks[i] < '0' || marks[i] > '9')
                            flag = false;
                    }
                    if (!flag)
                    {
                        MessageBox.Show("Matric Marks must not include characters other than digits!", "Alert!");
                        validation = false;
                    }
                }
                if (validation && radUGraduate.Checked && (getMatricMarksBox.Text.Length > 4 || (Int32.Parse(getMatricMarksBox.Text) < 0 || Int32.Parse(getMatricMarksBox.Text) > 1100)))
                {
                    MessageBox.Show("Matric marks must be between 0 and 1100!", "Oops! ");
                    validation = false;
                }
                else if (getSchoolBoard.Text == "" && validation && radUGraduate.Checked)
                {
                    set_UG_Stars();
                    validation = false;
                }
                else if (getSchoolBox.Text.Length > 50 && validation && radUGraduate.Checked)
                {
                    MessageBox.Show("School Name Length exceeded than 50!", "Alert! ");
                    validation = false;
                }
                else if (getSchoolBoard.Text.Length > 50 && validation && radUGraduate.Checked)
                {
                    MessageBox.Show("School Board Length exceeded than 50!", "Alert! ");
                    validation = false;
                }
                else if (getInterMarksBox.Text == "" && validation && radUGraduate.Checked)
                {
                    set_UG_Stars();
                    validation = false;
                }
                else if (getInterMarksBox.Text != "" && validation && radUGraduate.Checked)
                {
                    string marks = getInterMarksBox.Text.ToString();
                    bool flag = true;
                    for (int i = 0; i < marks.Length && flag; i++)
                    {
                        if (marks[i] < '0' || marks[i] > '9')
                            flag = false;
                    }
                    if (!flag)
                    {
                        MessageBox.Show("Inter Marks must not include characters other than digits!", "Alert! ");
                        validation = false;
                    }
                }
                if (validation && radUGraduate.Checked && (getInterMarksBox.Text.Length > 4 || (Int32.Parse(getInterMarksBox.Text) < 0 || Int32.Parse(getInterMarksBox.Text) > 1100)))
                {
                    MessageBox.Show("Inter marks must be between 0 and 1100!", "Oops! ");
                    validation = false;
                }
                else if (getCollegeBox.Text.Length > 50 && validation && radUGraduate.Checked)
                {
                    MessageBox.Show("College Name Length exceeded than 50!", "Alert!");
                    validation = false;
                }
                else if (getCollegeBoard.Text == "" && validation && radUGraduate.Checked)
                {
                    set_UG_Stars();
                    validation = false;
                }
                else if (getCollegeBoard.Text.Length > 50 && validation && radUGraduate.Checked)
                {
                    MessageBox.Show("College Board Length exceeded than 50!", "Alert!");
                    validation = false;
                }
                else if (getTestMarksBox.Text == "" && validation && radUGraduate.Checked)
                {
                    set_UG_Stars();
                    validation = false;
                }

                else if (getTestMarksBox.Text != "" && validation && radUGraduate.Checked)
                {
                    string marks = getTestMarksBox.Text.ToString();
                    bool flag = true;
                    for (int i = 0; i < marks.Length && flag; i++)
                    {
                        if (marks[i] < '0' || marks[i] > '9')
                            flag = false;
                    }
                    if (!flag)
                    {
                        MessageBox.Show("Test Marks must not include characters other than digits!", "Alert!");
                        validation = false;
                    }
                }
                if (validation && radUGraduate.Checked && (getTestMarksBox.Text.Length > 2 || (Int32.Parse(getTestMarksBox.Text) < 0 || Int32.Parse(getTestMarksBox.Text) > 60)))
                {
                    MessageBox.Show("Entry Test marks must be between 0 and 60!", "Oops!");
                    validation = false;
                }
                else if (radYes.Checked == false && radNo.Checked == false && validation)
                {
                    set_UG_Stars();
                    validation = false;
                }

                if (insertion)
                {
                    if (radUGraduate.Checked) // For UnderGraduate Student
                    {
                        radSE.Visible = true;
                        if (validation == true) // Store data int database now
                        {
                            SqlDataAdapter cmd = new SqlDataAdapter("SELECT ADD_ID FROM ADDRESS WHERE HOUSE_NO='" + tbHouse.Text.ToString().ToUpper() + "'and STREET_NO='" + tbStreet.Text.ToString().ToUpper() + "'and CITY='" + tbCity.Text.ToString().ToUpper() + "'and PROVINCE='" + cbProvince.Text.ToString().ToUpper() + "'and POSTAL_CODE='" + Int32.Parse(tbPostalCode.Text.ToString()) + "'and AREA='" + getAreaBox.Text.ToString().ToUpper() + "'", con);
                            DataTable dt = new DataTable();

                            SqlDataAdapter insertData = new SqlDataAdapter();
                            int add_id;
                            cmd.Fill(dt);
                            if (dt.Rows.Count == 0)
                            {
                                con.Open();
                                cmd = new SqlDataAdapter("SELECT MAX(ADD_ID) FROM ADDRESS", con);
                                dt = new DataTable();
                                cmd.Fill(dt);

                                if (dt.Rows.Count > 0 && dt.Rows[0][0].ToString() != "")
                                    add_id = Int32.Parse(dt.Rows[0][0].ToString()) + 1;
                                else
                                    add_id = 1;

                                con.Close();

                                con.Open();
                                insertData = new SqlDataAdapter();
                                insertData.InsertCommand = new SqlCommand("Insert ADDRESS values (@ADD_ID,@HOUSE_NO,@STREET_NO, @CITY, @PROVINCE, @POSTAL_CODE,@AREA)", con);
                                insertData.InsertCommand.Parameters.Add("@ADD_ID", SqlDbType.Int).Value = add_id;
                                insertData.InsertCommand.Parameters.Add("@HOUSE_NO", SqlDbType.VarChar).Value = tbHouse.Text.ToString().ToUpper();
                                insertData.InsertCommand.Parameters.Add("@STREET_NO", SqlDbType.VarChar).Value = tbStreet.Text.ToString().ToUpper();
                                insertData.InsertCommand.Parameters.Add("@CITY", SqlDbType.VarChar).Value = tbCity.Text.ToString().ToUpper();
                                insertData.InsertCommand.Parameters.Add("@PROVINCE", SqlDbType.VarChar).Value = cbProvince.Text.ToString().ToUpper();
                                insertData.InsertCommand.Parameters.Add("@POSTAL_CODE", SqlDbType.Int).Value = Int32.Parse(tbPostalCode.Text.ToString());
                                insertData.InsertCommand.Parameters.Add("@AREA", SqlDbType.VarChar).Value = getAreaBox.Text.ToString().ToUpper();
                                con.Close();

                                con.Open();
                                insertData.InsertCommand.ExecuteNonQuery();
                                con.Close();
                            }
                            else
                                add_id = Int32.Parse(dt.Rows[0][0].ToString());

                            cmd = new SqlDataAdapter("SELECT C_ID FROM CONTACT WHERE PHONE_NO= '" + tbPhone.Text.ToString() + "'and MOBILE_NO='" + tbMobile.Text.ToString() + "'and EMAIL='" + tbEmail.Text.ToString().ToUpper() + "'", con);
                            dt = new DataTable();
                            int c_id;
                            cmd.Fill(dt);

                            if (dt.Rows.Count == 0)
                            {
                                con.Open();
                                cmd = new SqlDataAdapter("SELECT MAX(C_ID) FROM CONTACT", con);
                                dt = new DataTable();
                                cmd.Fill(dt);

                                if (dt.Rows.Count > 0 && dt.Rows[0][0].ToString() != "")
                                    c_id = Int32.Parse(dt.Rows[0][0].ToString()) + 1;
                                else
                                    c_id = 1;

                                con.Close();

                                con.Open();
                                insertData = new SqlDataAdapter();
                                insertData.InsertCommand = new SqlCommand("Insert CONTACT values (@C_ID,@PHONE_NO,@MOBILE_NO, @EMAIL)", con);
                                insertData.InsertCommand.Parameters.Add("@C_ID", SqlDbType.Int).Value = c_id;
                                insertData.InsertCommand.Parameters.Add("@PHONE_NO", SqlDbType.VarChar).Value = tbPhone.Text.ToString().ToUpper();
                                insertData.InsertCommand.Parameters.Add("@MOBILE_NO", SqlDbType.VarChar).Value = tbMobile.Text.ToString().ToUpper();
                                insertData.InsertCommand.Parameters.Add("@EMAIL", SqlDbType.VarChar).Value = tbEmail.Text.ToString().ToUpper();
                                con.Close();

                                con.Open();
                                insertData.InsertCommand.ExecuteNonQuery();
                                con.Close();
                            }
                            else
                                c_id = Int32.Parse(dt.Rows[0][0].ToString());

                            con.Open();
                            insertData.InsertCommand = new SqlCommand("Insert UG_CANDIDATE values (@UG_FORM_NO,@UG_CNAME,@UG_CCNIC,@UG_FNAME,@UG_FCNIC,@UG_CDOB,@UG_CMATRIC,@UG_CINTER,@UG_CTEST,@UG_CHAFIZ,@UG_SCHOOL,@UG_SHLBOARD,@UG_COLLEGE,@UG_CLGBOARD,@UG_DOA,@PROG_ID,@ADD_ID,@C_ID,@UG_STATUS)", con);
                            con.Close();
                            insertData.InsertCommand.Parameters.Add("@UG_FORM_NO", SqlDbType.Char).Value = getPrimaryKey("NO");
                            con.Open();
                            insertData.InsertCommand.Parameters.Add("@UG_CNAME", SqlDbType.VarChar).Value = getCNameBox.Text.ToString().ToUpper();
                            insertData.InsertCommand.Parameters.Add("@UG_CCNIC", SqlDbType.VarChar).Value = getCNICBox.Text.ToString().ToUpper();
                            insertData.InsertCommand.Parameters.Add("@UG_FNAME", SqlDbType.VarChar).Value = getFatherNameBox.Text.ToString().ToUpper();
                            insertData.InsertCommand.Parameters.Add("@UG_FCNIC", SqlDbType.VarChar).Value = getFatherCNICBox.Text.ToString().ToUpper();
                            insertData.InsertCommand.Parameters.Add("@UG_CDOB", SqlDbType.Date).Value = getDOBBox.Text.ToString().ToUpper();
                            insertData.InsertCommand.Parameters.Add("@UG_CMATRIC", SqlDbType.Int).Value = Int32.Parse(getMatricMarksBox.Text);
                            insertData.InsertCommand.Parameters.Add("@UG_CINTER", SqlDbType.Int).Value = Int32.Parse(getInterMarksBox.Text);
                            insertData.InsertCommand.Parameters.Add("@UG_CTEST", SqlDbType.Int).Value = Int32.Parse(getTestMarksBox.Text);
                            if (radYes.Checked == true)
                                insertData.InsertCommand.Parameters.Add("@UG_CHAFIZ", SqlDbType.Char).Value = 20;
                            else
                                insertData.InsertCommand.Parameters.Add("@UG_CHAFIZ", SqlDbType.Char).Value = 0;
                            insertData.InsertCommand.Parameters.Add("@UG_SCHOOL", SqlDbType.VarChar).Value = getSchoolBox.Text.ToString().ToUpper();
                            insertData.InsertCommand.Parameters.Add("@UG_SHLBOARD", SqlDbType.VarChar).Value = getSchoolBoard.Text.ToString().ToUpper();
                            insertData.InsertCommand.Parameters.Add("@UG_COLLEGE", SqlDbType.VarChar).Value = getCollegeBox.Text.ToString().ToUpper();
                            insertData.InsertCommand.Parameters.Add("@UG_CLGBOARD", SqlDbType.VarChar).Value = getCollegeBoard.Text.ToString().ToUpper();
                            insertData.InsertCommand.Parameters.Add("@UG_DOA", SqlDbType.Date).Value = DateTime.Now;
                            insertData.InsertCommand.Parameters.Add("@ADD_ID", SqlDbType.Int).Value = add_id;
                            insertData.InsertCommand.Parameters.Add("@C_ID", SqlDbType.Int).Value = c_id;
                            if (radCS.Checked)
                                insertData.InsertCommand.Parameters.Add("@PROG_ID", SqlDbType.Int).Value = 1;
                            else if (radIT.Checked)
                                insertData.InsertCommand.Parameters.Add("@PROG_ID", SqlDbType.Int).Value = 2;
                            else
                                insertData.InsertCommand.Parameters.Add("@PROG_ID", SqlDbType.Int).Value = 3;
                            string status = "N/A";
                            insertData.InsertCommand.Parameters.Add("@UG_STATUS", SqlDbType.VarChar).Value = status;
                            con.Close();
                            con.Open();
                            insertData.InsertCommand.ExecuteNonQuery();
                            con.Close();

                            recordEntry = true;
                            // Record is entered and if further to be entered, 
                            // proceed from previous form
                            this.Owner.Show();
                            this.Hide();
                        }
                    }

                    else // For Graduate Student
                    {
                        radSE.Visible = false;
                        validation = true;
                        if (getCNameBox.Text == "" && validation)
                        {
                            set_G_Stars();
                            validation = false;
                        }
                        else if (getCNameBox.Text.Length > 50 && validation)
                        {
                            MessageBox.Show("Candidate Name Length exceeded than 50!", "Alert!");
                            validation = false;
                        }
                        else if (getCNICBox.Text == "" && validation)
                        {
                            set_G_Stars();
                            validation = false;
                        }
                        else if (getCNICBox.Text.Length <= 14 && validation)
                        {
                            MessageBox.Show("Enter CNIC in Correct Format!", "Alert!");
                            validation = false;
                        }
                        if (insertion && getCNICBox.Text.Length == 15 && validation)
                        {
                            con.Open();
                            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM G_CANDIDATE WHERE G_CCNIC = '" + getCNICBox.Text.ToUpper() + "'", con);
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            if (dt.Rows.Count > 0)
                            {
                                MessageBox.Show("Record already exist against CNIC # " + getCNICBox.Text + " !", "Oops!");
                                validation = false;
                            }
                            con.Close();
                        }
                        if (getFatherNameBox.Text == "" && validation)
                        {
                            set_G_Stars();
                            validation = false;
                        }
                        else if (getFatherNameBox.Text.Length > 50 && validation)
                        {
                            MessageBox.Show("Candidate's Father Name Length exceeded than 50!", "Alert!");
                            validation = false;
                        }
                        else if (getFatherCNICBox.Text == "" && validation)
                        {
                            set_G_Stars();
                            validation = false;
                        }
                        else if (getFatherCNICBox.Text.Length <= 14 && validation)
                        {
                            MessageBox.Show("Enter Father CNIC in Correct Format!", "Alert!");
                            validation = false;
                        }
                        else if (tbHouse.Text == "" && validation)
                        {
                            set_G_Stars();
                            validation = false;
                        }
                        else if (tbHouse.Text.Length > 50 && validation)
                        {
                            MessageBox.Show("House # or Name Length exceeded than 50!", "Alert! ");
                            validation = false;
                        }
                        else if (tbStreet.Text == "" && validation)
                        {
                            set_G_Stars();
                            validation = false;
                        }
                        else if (tbStreet.Text.Length > 50 && validation)
                        {
                            MessageBox.Show("Street # or Name Length exceeded than 50!", "Alert! ");
                            validation = false;
                        }
                        else if (getAreaBox.Text == "" && validation)
                        {
                            set_G_Stars();
                            validation = false;
                        }
                        else if (getAreaBox.Text.Length > 100 && validation)
                        {
                            MessageBox.Show("Address Field Length exceeded than 100!", "Alert! ");
                            validation = false;
                        }
                        else if (tbCity.Text == "" && validation)
                        {
                            set_G_Stars();
                            validation = false;
                        }
                        else if (tbCity.Text.Length > 50 && validation)
                        {
                            MessageBox.Show("City Name Length exceeded than 50!", "Alert! ");
                            validation = false;
                        }
                        else if (cbProvince.Text == "" && validation)
                        {
                            set_G_Stars();
                            validation = false;
                        }
                        else if (cbProvince.Text.Length > 50 && validation)
                        {
                            MessageBox.Show("Province Length exceeded than 50!", "Alert!");
                            validation = false;
                        }
                        else if (tbPostalCode.Text == "" && validation)
                        {
                            set_G_Stars();
                            validation = false;
                        }
                        else if (tbPostalCode.Text.Length > 6 && validation)
                        {
                            MessageBox.Show("Postal Length exceeded than 6!", "Alert!");
                            validation = false;
                        }
                        else if (tbPostalCode.Text != "" && validation)
                        {
                            string pCode = tbPostalCode.Text.ToString();
                            bool flag = true;
                            for (int i = 0; i < pCode.Length && flag; i++)
                            {
                                if (pCode[i] < '0' || pCode[i] > '9')
                                    flag = false;
                            }
                            if (!flag)
                            {
                                MessageBox.Show("Postal Code must not include characters other than digits!", "Alert!");
                                validation = false;
                            }
                        }

                        if (tbPhone.Text == "" && validation)
                        {
                            set_G_Stars();
                            validation = false;
                        }
                        else if (tbPhone.Text.Length < 11 && validation)
                        {
                            MessageBox.Show("Invalid Phone Number!", "Alert!");
                            validation = false;
                        }
                        else if (tbMobile.Text == "" && validation)
                        {
                            set_G_Stars();
                            validation = false;
                        }
                        else if (tbMobile.Text.Length < 11 && validation)
                        {
                            MessageBox.Show("Invalid Mobile Number!", "Alert!");
                            validation = false;
                        }
                        else if (tbEmail.Text == "" && validation)
                        {
                            set_G_Stars();
                            validation = false;
                        }
                        else if (tbEmail.Text.Length > 50 && validation)
                        {
                            MessageBox.Show("Email Length exceeded than 50!", "Alert!");
                            validation = false;
                        }
                        else if (getMatricMarksBox.Text == "" && validation)
                        {
                            set_G_Stars();
                            validation = false;
                        }

                        else if (getMatricMarksBox.Text != "" && validation)
                        {
                            string marks = getMatricMarksBox.Text.ToString();
                            bool flag = true;
                            for (int i = 0; i < marks.Length && flag; i++)
                            {
                                if (marks[i] < '0' || marks[i] > '9')
                                    flag = false;
                            }
                            if (!flag)
                            {
                                MessageBox.Show("Matric Marks must not include characters other than digits!", "Alert!");
                                validation = false;
                            }
                        }
                        if (validation && (getMatricMarksBox.Text.Length > 4 || (Int32.Parse(getMatricMarksBox.Text) < 0 || Int32.Parse(getMatricMarksBox.Text) > 1100)))
                        {
                            MessageBox.Show("Matric marks must be between 0 and 1100!", "Oops!");
                            validation = false;
                        }

                        else if (getSchoolBoard.Text == "" && validation)
                        {
                            set_G_Stars();
                            validation = false;
                        }
                        else if (getSchoolBox.Text.Length > 50 && validation)
                        {
                            MessageBox.Show("School Name Length exceeded than 50!", "Alert!");
                            validation = false;
                        }
                        else if (getSchoolBoard.Text.Length > 50 && validation)
                        {
                            MessageBox.Show("School Board Length exceeded than 50!", "Alert!");
                            validation = false;
                        }
                        else if (getInterMarksBox.Text == "" && validation)
                        {
                            set_G_Stars();
                            validation = false;
                        }
                        else if (getInterMarksBox.Text != "" && validation)
                        {
                            string marks = getInterMarksBox.Text.ToString();
                            bool flag = true;
                            for (int i = 0; i < marks.Length && flag; i++)
                            {
                                if (marks[i] < '0' || marks[i] > '9')
                                    flag = false;
                            }
                            if (!flag)
                            {
                                MessageBox.Show("Inter Marks must not include characters other than digits!", "Alert!");
                                validation = false;
                            }
                        }
                        if (validation && (getInterMarksBox.Text.Length > 4 || (Int32.Parse(getInterMarksBox.Text) < 0 || Int32.Parse(getInterMarksBox.Text) > 1100)))
                        {
                            MessageBox.Show("Inter marks must be between 0 and 1100!", "Oops!");
                            validation = false;
                        }
                        else if (getCollegeBox.Text.Length > 50 && validation)
                        {
                            MessageBox.Show("College Name Length exceeded than 50!", "Alert!");
                            validation = false;
                        }
                        else if (getCollegeBoard.Text == "" && validation)
                        {
                            set_G_Stars();
                            validation = false;
                        }
                        else if (getCollegeBoard.Text.Length > 50 && validation)
                        {
                            MessageBox.Show("College Board Length exceeded than 50!", "Alert!");
                            validation = false;
                        }
                        else if (getTestMarksBox.Text == "" && validation)
                        {
                            set_G_Stars();
                            validation = false;
                        }

                        else if (getTestMarksBox.Text != "" && validation)
                        {
                            string marks = getTestMarksBox.Text.ToString();
                            bool flag = true;
                            for (int i = 0; i < marks.Length && flag; i++)
                            {
                                if (marks[i] < '0' || marks[i] > '9')
                                    flag = false;
                            }
                            if (!flag)
                            {
                                MessageBox.Show("Test Marks must not include characters other than digits!", "Alert!");
                                validation = false;
                            }
                        }
                        if (validation && (getTestMarksBox.Text.Length > 2 || (Int32.Parse(getTestMarksBox.Text) < 0 || Int32.Parse(getTestMarksBox.Text) > 60)))
                        {
                            MessageBox.Show("Entry Test marks must be between 0 and 60!", "Oops!");
                            validation = false;
                        }
                        else if (radYes.Checked == false && radNo.Checked == false && validation)
                        {
                            set_G_Stars();
                            validation = false;
                        }
                        else if (getCGPAMarksBox.Text == "" && validation)
                        {
                            set_G_Stars();
                            validation = false;
                        }
                        else if (validation && getCGPAMarksBox.Text != "")
                        {
                            string cgpa = getCGPAMarksBox.Text.ToString();
                            int countPoints = 0;
                            bool flag = true;
                            if (cgpa[cgpa.Length - 1] == '.' || cgpa[0] == '.')
                                flag = false;
                            else
                            {
                                for (int i = 0; i < cgpa.Length && flag; i++)
                                {
                                    if (cgpa[i] < '0' || cgpa[i] > '9')
                                        flag = false;
                                    if (cgpa[i] == '.')
                                    {
                                        flag = true;
                                        countPoints++;
                                    }
                                }
                                if (countPoints > 1)
                                    flag = false;
                                else
                                    flag = true;
                            }
                            if (!flag)
                            {
                                MessageBox.Show("CGPA must not include characters other than digits and a single point only!", "Alert!");
                                validation = false;
                            }
                        }
                        if (validation && (getCGPAMarksBox.Text.Length > 4 || (float.Parse(getCGPAMarksBox.Text) < 0 || float.Parse(getCGPAMarksBox.Text) > 4.00)))
                        {
                            MessageBox.Show("CGPA must be between 0.00 and 4.00 insame format!", "Oops!");
                            validation = false;
                        }
                        else if (getInterviewMarksBox.Text == "" && validation)
                        {
                            set_G_Stars();
                            validation = false;
                        }
                        else if (getInterviewMarksBox.Text != "" && validation)
                        {
                            string marks = getInterviewMarksBox.Text.ToString();
                            bool flag = true;
                            for (int i = 0; i < marks.Length && flag; i++)
                            {
                                if (marks[i] < '0' || marks[i] > '9')
                                    flag = false;
                            }
                            if (!flag)
                            {
                                MessageBox.Show("Interview Marks must not include characters other than digits!", "Alert!");
                                validation = false;
                            }
                        }
                        if (validation && (getTestMarksBox.Text.Length > 2 || (Int32.Parse(getInterviewMarksBox.Text) < 0 || Int32.Parse(getInterviewMarksBox.Text) > 40)))
                        {
                            MessageBox.Show("Interview marks must be between 0 and 40!", "Oops!");
                            validation = false;
                        }
                        if (validation == true)    // Store data int database now
                        {
                            SqlDataAdapter cmd = new SqlDataAdapter("SELECT ADD_ID FROM ADDRESS WHERE HOUSE_NO='" + tbHouse.Text.ToString().ToUpper() + "'and STREET_NO='" + tbStreet.Text.ToString().ToUpper() + "'and CITY='" + tbCity.Text.ToString().ToUpper() + "'and PROVINCE='" + cbProvince.Text.ToString().ToUpper() + "'and POSTAL_CODE='" + Int32.Parse(tbPostalCode.Text.ToString()) + "'and AREA='" + getAreaBox.Text.ToString().ToUpper() + "'", con);
                            DataTable dt = new DataTable();

                            SqlDataAdapter insertData = new SqlDataAdapter();
                            int add_id;
                            cmd.Fill(dt);
                            if (dt.Rows.Count == 0)
                            {
                                con.Open();
                                cmd = new SqlDataAdapter("SELECT MAX(ADD_ID) FROM ADDRESS", con);
                                dt = new DataTable();
                                cmd.Fill(dt);

                                if (dt.Rows.Count > 0 && dt.Rows[0][0].ToString() != "")
                                    add_id = Int32.Parse(dt.Rows[0][0].ToString()) + 1;
                                else
                                    add_id = 1;
                                con.Close();

                                con.Open();
                                insertData = new SqlDataAdapter();
                                insertData.InsertCommand = new SqlCommand("Insert ADDRESS values (@ADD_ID,@HOUSE_NO,@STREET_NO, @CITY, @PROVINCE, @POSTAL_CODE,@AREA)", con);
                                insertData.InsertCommand.Parameters.Add("@ADD_ID", SqlDbType.Int).Value = add_id;
                                insertData.InsertCommand.Parameters.Add("@HOUSE_NO", SqlDbType.VarChar).Value = tbHouse.Text.ToString().ToUpper();
                                insertData.InsertCommand.Parameters.Add("@STREET_NO", SqlDbType.VarChar).Value = tbStreet.Text.ToString().ToUpper();
                                insertData.InsertCommand.Parameters.Add("@CITY", SqlDbType.VarChar).Value = tbCity.Text.ToString().ToUpper();
                                insertData.InsertCommand.Parameters.Add("@PROVINCE", SqlDbType.VarChar).Value = cbProvince.Text.ToString().ToUpper();
                                insertData.InsertCommand.Parameters.Add("@POSTAL_CODE", SqlDbType.Int).Value = Int32.Parse(tbPostalCode.Text.ToString());
                                insertData.InsertCommand.Parameters.Add("@AREA", SqlDbType.VarChar).Value = getAreaBox.Text.ToString().ToUpper();
                                con.Close();

                                con.Open();
                                insertData.InsertCommand.ExecuteNonQuery();
                                con.Close();
                            }
                            else
                                add_id = Int32.Parse(dt.Rows[0][0].ToString());

                            cmd = new SqlDataAdapter("SELECT C_ID FROM CONTACT WHERE PHONE_NO= '" + tbPhone.Text.ToString() + "'and MOBILE_NO='" + tbMobile.Text.ToString() + "'and EMAIL='" + tbEmail.Text.ToString().ToUpper() + "'", con);
                            dt = new DataTable();
                            int c_id;
                            cmd.Fill(dt);

                            if (dt.Rows.Count == 0)
                            {
                                con.Open();
                                cmd = new SqlDataAdapter("SELECT MAX(C_ID) FROM CONTACT", con);
                                dt = new DataTable();
                                cmd.Fill(dt);

                                if (dt.Rows.Count > 0 && dt.Rows[0][0].ToString() != "")
                                    c_id = Int32.Parse(dt.Rows[0][0].ToString()) + 1;
                                else
                                    c_id = 1;
                                con.Close();

                                con.Open();
                                insertData = new SqlDataAdapter();
                                insertData.InsertCommand = new SqlCommand("Insert CONTACT values (@C_ID,@PHONE_NO,@MOBILE_NO, @EMAIL)", con);
                                insertData.InsertCommand.Parameters.Add("@C_ID", SqlDbType.Int).Value = c_id;
                                insertData.InsertCommand.Parameters.Add("@PHONE_NO", SqlDbType.VarChar).Value = tbPhone.Text.ToString().ToUpper();
                                insertData.InsertCommand.Parameters.Add("@MOBILE_NO", SqlDbType.VarChar).Value = tbMobile.Text.ToString().ToUpper();
                                insertData.InsertCommand.Parameters.Add("@EMAIL", SqlDbType.VarChar).Value = tbEmail.Text.ToString().ToUpper();
                                con.Close();

                                con.Open();
                                insertData.InsertCommand.ExecuteNonQuery();
                                con.Close();
                            }
                            else
                                c_id = Int32.Parse(dt.Rows[0][0].ToString());

                            con.Open();
                            insertData.InsertCommand = new SqlCommand("Insert G_CANDIDATE values (@G_FORM_NO,@G_CNAME,@G_CCNIC,@G_FNAME,@G_FCNIC,@G_CDOB,@G_CMATRIC,@G_CINTER,@G_CTEST,@G_CHAFIZ,@G_SCHOOL,@G_SHLBOARD,@G_COLLEGE,@G_CLGBOARD,@G_DOA,@G_BS_CGPA,@G_INTERVIEW,@PROG_ID,@ADD_ID,@C_ID,@G_STATUS)", con);
                            con.Close();
                            insertData.InsertCommand.Parameters.Add("@G_FORM_NO", SqlDbType.Char).Value = getPrimaryKey("YES");
                            con.Open();
                            insertData.InsertCommand.Parameters.Add("@G_CNAME", SqlDbType.VarChar).Value = getCNameBox.Text.ToString().ToUpper();
                            insertData.InsertCommand.Parameters.Add("@G_CCNIC", SqlDbType.VarChar).Value = getCNICBox.Text.ToString().ToUpper();
                            insertData.InsertCommand.Parameters.Add("@G_FNAME", SqlDbType.VarChar).Value = getFatherNameBox.Text.ToString().ToUpper();
                            insertData.InsertCommand.Parameters.Add("@G_FCNIC", SqlDbType.VarChar).Value = getFatherCNICBox.Text.ToString().ToUpper();
                            insertData.InsertCommand.Parameters.Add("@G_CDOB", SqlDbType.Date).Value = getDOBBox.Text.ToString().ToUpper();
                            insertData.InsertCommand.Parameters.Add("@G_CMATRIC", SqlDbType.Int).Value = Int32.Parse(getMatricMarksBox.Text);
                            insertData.InsertCommand.Parameters.Add("@G_CINTER", SqlDbType.Int).Value = Int32.Parse(getInterMarksBox.Text);
                            insertData.InsertCommand.Parameters.Add("@G_CTEST", SqlDbType.Int).Value = Int32.Parse(getTestMarksBox.Text);
                            if (radYes.Checked == true)
                                insertData.InsertCommand.Parameters.Add("@G_CHAFIZ", SqlDbType.Char).Value = 20;
                            else
                                insertData.InsertCommand.Parameters.Add("@G_CHAFIZ", SqlDbType.Char).Value = 0;
                            insertData.InsertCommand.Parameters.Add("@G_SCHOOL", SqlDbType.VarChar).Value = getSchoolBox.Text.ToString().ToUpper();
                            insertData.InsertCommand.Parameters.Add("@G_SHLBOARD", SqlDbType.VarChar).Value = getSchoolBoard.Text.ToString().ToUpper();
                            insertData.InsertCommand.Parameters.Add("@G_COLLEGE", SqlDbType.VarChar).Value = getCollegeBox.Text.ToString().ToUpper();
                            insertData.InsertCommand.Parameters.Add("@G_CLGBOARD", SqlDbType.VarChar).Value = getCollegeBoard.Text.ToString().ToUpper();
                            insertData.InsertCommand.Parameters.Add("@G_DOA", SqlDbType.Date).Value = DateTime.Now;
                            insertData.InsertCommand.Parameters.Add("@G_BS_CGPA", SqlDbType.Real).Value = float.Parse(getCGPAMarksBox.Text);
                            insertData.InsertCommand.Parameters.Add("@G_INTERVIEW", SqlDbType.Int).Value = Int32.Parse(getInterviewMarksBox.Text);
                            insertData.InsertCommand.Parameters.Add("@ADD_ID", SqlDbType.Int).Value = add_id;
                            insertData.InsertCommand.Parameters.Add("@C_ID", SqlDbType.Int).Value = c_id;
                            if (radCS.Checked)  // CS
                                insertData.InsertCommand.Parameters.Add("@PROG_ID", SqlDbType.Int).Value = 4;
                            else  // IT
                                insertData.InsertCommand.Parameters.Add("@PROG_ID", SqlDbType.Int).Value = 5;
                            string status = "N/A";
                            insertData.InsertCommand.Parameters.Add("@G_STATUS", SqlDbType.VarChar).Value = status;
                            con.Close();
                            con.Open();
                            insertData.InsertCommand.ExecuteNonQuery();
                            con.Close();

                            recordEntry = true;
                            // Record is entered and if further to be entered, 
                            // proceed from previous form
                            this.Owner.Show();
                            this.Hide();
                        }
                    }
                    // After entering all information into the database
                    if (recordEntry)
                        MessageBox.Show("Registration Successful", "Congrats!");
                }
                // Updation of a record
                else if (validation)
                {
                    con.Open();
                    string querystr = "UPDATE ADDRESS SET HOUSE_NO='" + tbHouse.Text.ToString().ToUpper() + "',STREET_NO='" + tbStreet.Text.ToString().ToUpper() + "',CITY='" + tbCity.Text.ToString().ToUpper() + "',PROVINCE='" + cbProvince.Text.ToString().ToUpper() + "',POSTAL_CODE='" + Int32.Parse(tbPostalCode.Text.ToString()) + "',AREA='" + getAreaBox.Text.ToString().ToUpper() + "' WHERE ADD_ID= '" + updateAdd_ID + "'";
                    SqlCommand query = new SqlCommand(querystr, con);
                    query.ExecuteNonQuery();
                    con.Close();

                    con.Open();
                    querystr = "UPDATE CONTACT SET PHONE_NO='" + tbPhone.Text.ToString() + "',MOBILE_NO='" + tbMobile.Text.ToString() + "',EMAIL='" + tbEmail.Text.ToString().ToUpper() + "' WHERE C_ID= '" + updateC_ID + "'";
                    query = new SqlCommand(querystr, con);
                    query.ExecuteNonQuery();
                    con.Close();
                    if (radYes.Checked)
                        updateHafizMarks = 20;
                    else
                        updateHafizMarks = 0;

                    if (radUGraduate.Checked)
                    {
                        if (radCS.Checked)
                            updateProg_ID = 1;
                        else if (radIT.Checked)
                            updateProg_ID = 2;
                        else
                            updateProg_ID = 3;
                        con.Open();
                        DateTime date = DateTime.Parse(getDOBBox.Text.ToString());
                        querystr = "UPDATE UG_CANDIDATE SET UG_CNAME='" + getCNameBox.Text.ToString().ToUpper() + "',UG_CCNIC='" + getCNICBox.Text + "',UG_FNAME='" + getFatherNameBox.Text.ToString().ToUpper() + "',UG_FCNIC='" + getFatherCNICBox.Text + "',UG_CDOB='" + date + "',UG_CMATRIC='" + Int32.Parse(getMatricMarksBox.Text.ToString()) + "',UG_CINTER='" + Int32.Parse(getInterMarksBox.Text.ToString()) + "',UG_CTEST='" + Int32.Parse(getTestMarksBox.Text.ToString()) + "',UG_CHAFIZ='" + updateHafizMarks + "',UG_SCHOOL='" + getSchoolBox.Text.ToString().ToUpper() + "',UG_SHLBOARD='" + getSchoolBoard.Text.ToString().ToUpper() + "',UG_COLLEGE='" + getCollegeBox.Text.ToString().ToUpper() + "',UG_CLGBOARD='" + getCollegeBoard.Text.ToString().ToUpper() + "',PROG_ID='" + updateProg_ID + "',ADD_ID='" + updateAdd_ID + "',C_ID='" + updateC_ID + "' WHERE UG_FORM_NO='" + lblNumber.Text.ToString().ToUpper() + "'";
                        query = new SqlCommand(querystr, con);
                        query.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Updation Successful","Yahoooo!");
                        // Close the form now
                        this.Owner.Show();
                        this.Hide();
                    }
                    else if (radGradate.Checked)
                    {
                        radSE.Visible = false;
                        validation = true;
                        if (getCNameBox.Text == "" && validation)
                        {
                            set_G_Stars();
                            validation = false;
                        }
                        else if (getCNameBox.Text.Length > 50 && validation)
                        {
                            MessageBox.Show("Candidate Name Length exceeded than 50!", "Alert!");
                            validation = false;
                        }
                        else if (getCNICBox.Text == "" && validation)
                        {
                            set_G_Stars();
                            validation = false;
                        }
                        else if (getCNICBox.Text.Length <= 14 && validation)
                        {
                            MessageBox.Show("Enter CNIC in Correct Format!", "Alert!");
                            validation = false;
                        }
                        if (insertion && getCNICBox.Text.Length == 15 && validation)
                        {
                            con.Open();
                            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM G_CANDIDATE WHERE G_CCNIC = '" + getCNICBox.Text.ToUpper() + "'", con);
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            if (dt.Rows.Count > 0)
                            {
                                MessageBox.Show("Record already exist against CNIC # " + getCNICBox.Text + " !", "Alert!");
                                validation = false;
                            }
                            con.Close();
                        }
                        if (getFatherNameBox.Text == "" && validation)
                        {
                            set_G_Stars();
                            validation = false;
                        }
                        else if (getFatherNameBox.Text.Length > 50 && validation)
                        {
                            MessageBox.Show("Candidate's Father Name Length exceeded than 50!", "Alert!");
                            validation = false;
                        }
                        else if (getFatherCNICBox.Text == "" && validation)
                        {
                            set_G_Stars();
                            validation = false;
                        }
                        else if (getFatherCNICBox.Text.Length <= 14 && validation)
                        {
                            MessageBox.Show("Enter Father CNIC in Correct Format!", "Alert!");
                            validation = false;
                        }
                        else if (tbHouse.Text == "" && validation)
                        {
                            set_G_Stars();
                            validation = false;
                        }
                        else if (tbHouse.Text.Length > 50 && validation)
                        {
                            MessageBox.Show("House # or Name Length exceeded than 50!", "Alert!");
                            validation = false;
                        }
                        else if (tbStreet.Text == "" && validation)
                        {
                            set_G_Stars();
                            validation = false;
                        }
                        else if (tbStreet.Text.Length > 50 && validation)
                        {
                            MessageBox.Show("Street # or Name Length exceeded than 50!", "Alert!");
                            validation = false;
                        }
                        else if (getAreaBox.Text == "" && validation)
                        {
                            set_G_Stars();
                            validation = false;
                        }
                        else if (getAreaBox.Text.Length > 100 && validation)
                        {
                            MessageBox.Show("Alert! Address Field Length exceeded than 100!");
                            validation = false;
                        }
                        else if (tbCity.Text == "" && validation)
                        {
                            set_G_Stars();
                            validation = false;
                        }
                        else if (tbCity.Text.Length > 50 && validation)
                        {
                            MessageBox.Show("City Name Length exceeded than 50!", "Alert!");
                            validation = false;
                        }
                        else if (cbProvince.Text == "" && validation)
                        {
                            set_G_Stars();
                            validation = false;
                        }
                        else if (cbProvince.Text.Length > 50 && validation)
                        {
                            MessageBox.Show("Province Length exceeded than 50!", "Alert!");
                            validation = false;
                        }
                        else if (tbPostalCode.Text == "" && validation)
                        {
                            set_G_Stars();
                            validation = false;
                        }
                        else if (tbPostalCode.Text.Length > 6 && validation)
                        {
                            MessageBox.Show("Postal Length exceeded than 6!", "Alert!");
                            validation = false;
                        }
                        else if (tbPostalCode.Text != "" && validation)
                        {
                            string pCode = tbPostalCode.Text.ToString();
                            bool flag = true;
                            for (int i = 0; i < pCode.Length && flag; i++)
                            {
                                if (pCode[i] < '0' || pCode[i] > '9')
                                    flag = false;
                            }
                            if (!flag)
                            {
                                MessageBox.Show("Postal Code must not include characters other than digits!", "Alert!");
                                validation = false;
                            }
                        }

                        if (tbPhone.Text == "" && validation)
                        {
                            set_G_Stars();
                            validation = false;
                        }
                        else if (tbPhone.Text.Length < 11 && validation)
                        {
                            MessageBox.Show("Invalid Phone Number!", "Alert!");
                            validation = false;
                        }
                        else if (tbMobile.Text == "" && validation)
                        {
                            set_G_Stars();
                            validation = false;
                        }
                        else if (tbMobile.Text.Length < 11 && validation)
                        {
                            MessageBox.Show("Invalid Mobile Number!", "Alert!");
                            validation = false;
                        }
                        else if (tbEmail.Text == "" && validation)
                        {
                            set_G_Stars();
                            validation = false;
                        }
                        else if (tbEmail.Text.Length > 50 && validation)
                        {
                            MessageBox.Show("Email Length exceeded than 50!", "Alert!");
                            validation = false;
                        }
                        else if (getMatricMarksBox.Text == "" && validation)
                        {
                            set_G_Stars();
                            validation = false;
                        }

                        else if (getMatricMarksBox.Text != "" && validation)
                        {
                            string marks = getMatricMarksBox.Text.ToString();
                            bool flag = true;
                            for (int i = 0; i < marks.Length && flag; i++)
                            {
                                if (marks[i] < '0' || marks[i] > '9')
                                    flag = false;
                            }
                            if (!flag)
                            {
                                MessageBox.Show("Matric Marks must not include characters other than digits!", "Alert!");
                                validation = false;
                            }
                        }
                        if (validation && (getMatricMarksBox.Text.Length > 4 || (Int32.Parse(getMatricMarksBox.Text) < 0 || Int32.Parse(getMatricMarksBox.Text) > 1100)))
                        {
                            MessageBox.Show("Matric marks must be between 0 and 1100!", "Oops!");
                            validation = false;
                        }

                        else if (getSchoolBoard.Text == "" && validation)
                        {
                            set_G_Stars();
                            validation = false;
                        }
                        else if (getSchoolBox.Text.Length > 50 && validation)
                        {
                            MessageBox.Show("School Name Length exceeded than 50!", "Alert!");
                            validation = false;
                        }
                        else if (getSchoolBoard.Text.Length > 50 && validation)
                        {
                            MessageBox.Show("School Board Length exceeded than 50!", "Alert!");
                            validation = false;
                        }
                        else if (getInterMarksBox.Text == "" && validation)
                        {
                            set_G_Stars();
                            validation = false;
                        }
                        else if (getInterMarksBox.Text != "" && validation)
                        {
                            string marks = getInterMarksBox.Text.ToString();
                            bool flag = true;
                            for (int i = 0; i < marks.Length && flag; i++)
                            {
                                if (marks[i] < '0' || marks[i] > '9')
                                    flag = false;
                            }
                            if (!flag)
                            {
                                MessageBox.Show("Inter Marks must not include characters other than digits!", "Alert!");
                                validation = false;
                            }
                        }
                        if (validation && (getInterMarksBox.Text.Length > 4 || (Int32.Parse(getInterMarksBox.Text) < 0 || Int32.Parse(getInterMarksBox.Text) > 1100)))
                        {
                            MessageBox.Show("Inter marks must be between 0 and 1100!", "Oops!");
                            validation = false;
                        }
                        else if (getCollegeBox.Text.Length > 50 && validation)
                        {
                            MessageBox.Show("College Name Length exceeded than 50!", "Alert!");
                            validation = false;
                        }
                        else if (getCollegeBoard.Text == "" && validation)
                        {
                            set_G_Stars();
                            validation = false;
                        }
                        else if (getCollegeBoard.Text.Length > 50 && validation)
                        {
                            MessageBox.Show("College Board Length exceeded than 50!", "Alert!");
                            validation = false;
                        }
                        else if (getTestMarksBox.Text == "" && validation)
                        {
                            set_G_Stars();
                            validation = false;
                        }

                        else if (getTestMarksBox.Text != "" && validation)
                        {
                            string marks = getTestMarksBox.Text.ToString();
                            bool flag = true;
                            for (int i = 0; i < marks.Length && flag; i++)
                            {
                                if (marks[i] < '0' || marks[i] > '9')
                                    flag = false;
                            }
                            if (!flag)
                            {
                                MessageBox.Show("Test Marks must not include characters other than digits!", "Alert!");
                                validation = false;
                            }
                        }
                        if (validation && (getTestMarksBox.Text.Length > 2 || (Int32.Parse(getTestMarksBox.Text) < 0 || Int32.Parse(getTestMarksBox.Text) > 60)))
                        {
                            MessageBox.Show("Entry Test marks must be between 0 and 60!", "Alert!");
                            validation = false;
                        }
                        else if (radYes.Checked == false && radNo.Checked == false && validation)
                        {
                            set_G_Stars();
                            validation = false;
                        }
                        else if (getCGPAMarksBox.Text == "" && validation)
                        {
                            set_G_Stars();
                            validation = false;
                        }
                        else if (validation && getCGPAMarksBox.Text != "")
                        {
                            string cgpa = getCGPAMarksBox.Text.ToString();
                            int countPoints = 0;
                            bool flag = true;
                            if (cgpa[cgpa.Length - 1] == '.' || cgpa[0] == '.')
                                flag = false;
                            else
                            {
                                for (int i = 0; i < cgpa.Length && flag; i++)
                                {
                                    if (cgpa[i] < '0' || cgpa[i] > '9')
                                        flag = false;
                                    if (cgpa[i] == '.')
                                    {
                                        flag = true;
                                        countPoints++;
                                    }
                                }
                                if (countPoints > 1)
                                    flag = false;
                                else
                                    flag = true;
                            }
                            if (!flag)
                            {
                                MessageBox.Show("CGPA must not include characters other than digits and a single point only!", "Alert!");
                                validation = false;
                            }
                        }
                        if (validation && (getCGPAMarksBox.Text.Length > 4 || (float.Parse(getCGPAMarksBox.Text) < 0 || float.Parse(getCGPAMarksBox.Text) > 4)))
                        {
                            MessageBox.Show("CGPA must be between 0.00 and 4.00!", "Alert!");
                            validation = false;
                        }
                        else if (getInterviewMarksBox.Text == "" && validation)
                        {
                            set_G_Stars();
                            validation = false;
                        }
                        else if (getInterviewMarksBox.Text != "" && validation)
                        {
                            string marks = getInterviewMarksBox.Text.ToString();
                            bool flag = true;
                            for (int i = 0; i < marks.Length && flag; i++)
                            {
                                if (marks[i] < '0' || marks[i] > '9')
                                    flag = false;
                            }
                            if (!flag)
                            {
                                MessageBox.Show("Interview Marks must not include characters other than digits!", "Alert!");
                                validation = false;
                            }
                        }
                        if (validation && (getTestMarksBox.Text.Length > 2 || (Int32.Parse(getInterviewMarksBox.Text) < 0 || Int32.Parse(getInterviewMarksBox.Text) > 40)))
                        {
                            MessageBox.Show("Interview marks must be between 0 and 40!", "Oops!");
                            validation = false;
                        }
                        if (radCS.Checked)
                            updateProg_ID = 4;
                        else if (radIT.Checked)
                            updateProg_ID = 5;
                        con.Open();
                        DateTime date = DateTime.Parse(getDOBBox.Text.ToString());
                        querystr = "UPDATE G_CANDIDATE SET G_CNAME='" + getCNameBox.Text.ToString().ToUpper() + "',G_CCNIC='" + getCNICBox.Text + "',G_FNAME='" + getFatherNameBox.Text.ToString().ToUpper() + "',G_FCNIC='" + getFatherCNICBox.Text + "',G_CDOB='" + date + "',G_CMATRIC='" + Int32.Parse(getMatricMarksBox.Text.ToString()) + "',G_CINTER='" + Int32.Parse(getInterMarksBox.Text.ToString()) + "',G_CTEST='" + Int32.Parse(getTestMarksBox.Text.ToString()) + "',G_CHAFIZ='" + updateHafizMarks + "',G_SCHOOL='" + getSchoolBox.Text.ToString().ToUpper() + "',G_SHLBOARD='" + getSchoolBoard.Text.ToString().ToUpper() + "',G_COLLEGE='" + getCollegeBox.Text.ToString().ToUpper() + "',G_CLGBOARD='" + getCollegeBoard.Text.ToString().ToUpper() + "',G_BS_CGPA='" + float.Parse(getCGPAMarksBox.Text.ToString()) + "',G_INTERVIEW='" + Int32.Parse(getInterviewMarksBox.Text.ToString()) + "',PROG_ID='" + updateProg_ID + "',ADD_ID='" + updateAdd_ID + "',C_ID='" + updateC_ID + "' WHERE G_FORM_NO='" + lblNumber.Text.ToString().ToUpper() + "'";
                        query = new SqlCommand(querystr, con);
                        query.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Updation Successful","Yahoooo!");
                        // Close the form now
                        this.Owner.Show();
                        this.Hide();
                    }
                }
                else
                    MessageBox.Show("Something went wrong. Check again.", "Oops!");
            }
        }

        private void Admission_Form_FormClosing(object sender, FormClosingEventArgs e)
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