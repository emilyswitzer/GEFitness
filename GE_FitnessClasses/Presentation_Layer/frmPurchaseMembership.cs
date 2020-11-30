using GE_FitnessClasses.Database_Layer;
using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace GE_FitnessClasses
{
   
    public partial class frmPurchaseMembership : Form
    {
        frmHome parent;
        
        public frmPurchaseMembership(frmHome Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void btnConfirmMemb_Click(object sender, EventArgs e)
        {
            //Validate Email
            Boolean t = Databases.ValidateEmail(txtEmail.Text);
            if (!t)
            {
                MessageBox.Show("Enter valid email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.ResetText();
                return;
            }

            //Validate DOB
            String dob = txtDOB.Text;
            DateTime dt;
            string[] formats = { "yyyy-MM-dd" };
            if (!DateTime.TryParseExact(dob, formats,
                            System.Globalization.CultureInfo.InvariantCulture,
                            DateTimeStyles.None, out dt))
            {
                MessageBox.Show("Please enter DOB in yyyy-MM-dd format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Validate Age
            int age = Databases.GetAge(dt);
            Boolean valid = Databases.ValidateAge(age);
            if (!valid)
            {
                MessageBox.Show("You must be over 18 to become a member", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Validate Phone
            if (txtPhone.Text.Length < 10)
            {
                MessageBox.Show("Please enter a valid mobile number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //All fields must be entered before you can add a member
            if (txtName.Text.Trim() == string.Empty || txtSurname.Text.Trim() == string.Empty || txtDOB.Text.Trim() == string.Empty ||
                txtEmail.Text.Trim() == string.Empty || txtPhone.Text.Trim() == string.Empty || cmbMembership.SelectedIndex < 0 || cmbPayment.SelectedIndex < 0)
            {
                MessageBox.Show("All fields must be entered!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Validate Member Email
            String emailMember = txtEmail.Text.ToString();
            DataSet emails;
            emails = Databases.CheckEmail(emailMember);
            int i = emails.Tables["emails"].Rows.Count;
            if (i > 0)
            {

                MessageBox.Show("Email already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.ResetText();
                return;
            }

            Databases newMember = new Databases();
            int id = Convert.ToInt32(txtMemID.Text);
            String name = txtName.Text.ToString();
            String surname = txtSurname.Text.ToString();
            int phone = Convert.ToInt32(txtPhone.Text);
            String email = txtSurname.Text.ToString();
            char status = 'A';

            newMember.AddMember(id, name, surname, dob, email, phone, status);

            DateTime start = dateStartBox.Value;

            int membershipID = Int32.Parse(cmbMembership.SelectedItem.ToString().Substring(0, 3));
            newMember.MakeActiveMembership(membershipID, id, start);

            MessageBox.Show("Membership complete!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            parent.Visible = true;
        }
        
        private void mnuBack_Click(object sender, EventArgs e)
        {
            //dispose of this form
            this.Close();
            parent.Visible = true;
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmPurchaseMembership_Load(object sender, EventArgs e)
        {
            txtMemID.Text = String.Format("{0:000}", Databases.GetNextMemID());

            dateStartBox.MinDate = DateTime.Today;

            ///Load Payments
            DataSet ds1;
            ds1 = Databases.GetPayments();
            for (int i = 0; i < ds1.Tables["Payments"].Rows.Count; i++)
                cmbPayment.Items.Add(ds1.Tables[0].Rows[i][0].ToString().PadLeft(3, '0') +
                "    " + ds1.Tables[0].Rows[i][1].ToString());

            //Load Memberships
            DataSet ds2;
            ds2 = Databases.GetMemberships();
            for (int i = 0; i < ds2.Tables["Memberships"].Rows.Count; i++)
                cmbMembership.Items.Add(ds2.Tables[0].Rows[i][0].ToString().PadLeft(3, '0') +
                "    " + ds2.Tables[0].Rows[i][1].ToString());
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtName.Text) && !System.Text.RegularExpressions.Regex.IsMatch(txtName.Text, "^[a-zA-Z ]+$"))
                {
                    MessageBox.Show("Enter Valid Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtName.ResetText();
                    txtName.Clear();
                    txtName.Focus();
                }
        }

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtSurname.Text) && !System.Text.RegularExpressions.Regex.IsMatch(txtSurname.Text, "^[a-zA-Z ]+$"))
                {
                    MessageBox.Show("Enter Valid Surname", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSurname.ResetText();
                    txtSurname.Clear();
                    txtSurname.Focus();
                }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            
                if (!char.IsDigit(e.KeyChar)) e.Handled = true;         //Just Digits
                if (e.KeyChar == (char)8) e.Handled = false;            //Allow Backspace


            
        }
    }
}
