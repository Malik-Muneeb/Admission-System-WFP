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
    public partial class Merit_List : Form
    {
        public bool feeSubb1 = false, feeSubb2 = false;

        public Merit_List()
        {
            InitializeComponent();
        }       

        private void Merit_List_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Hide();
        }

        private void btnGeneral_Click(object sender, EventArgs e)
        {
            Reports newForm = new Reports();
            newForm.Owner = this;
            newForm.Show();
            this.Hide();
        }


        private void btnFirst_Click(object sender, EventArgs e)
        {
            _1stMeritList newForm = new _1stMeritList();
            newForm.Owner = this;
            newForm.Show();
            this.Hide();
        }


        private void btnFeeSub1_Click(object sender, EventArgs e)
        {
            Fee_Submission newForm = new Fee_Submission();
            newForm.Owner = this;
            if (!feeSubb1)
                feeSubb1 = true;
            else if (!feeSubb2)
                feeSubb2 = true;
            newForm.Show();
            this.Hide();
        }

        private void btnSecond_Click(object sender, EventArgs e)
        {
            if (feeSubb1)
            {
                _2ndMeritList newForm = new _2ndMeritList();
                newForm.Owner = this;
                newForm.Show();
                if (!feeSubb2)
                    feeSubb2 = true;
                this.Hide();
            }
            else
                MessageBox.Show("Wait till the Fee Submissions of First List", "Alert!");
        }

        private void btnThird_Click(object sender, EventArgs e)
        {
            if (feeSubb2)
            {
                //_2ndMeritList newForm = new _2ndMeritList();
                //newForm.Owner = this;
                //newForm.Show();
                //this.Hide();
            }
            else
                MessageBox.Show("Wait till the Fee Submissions of First List", "Alert!");

        }

        private void Merit_List_FormClosing(object sender, FormClosingEventArgs e)
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
