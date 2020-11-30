using GE_FitnessClasses.Database_Layer;
using System;
using System.Data;
using System.Windows.Forms;

namespace GE_FitnessClasses
{
    public partial class frmRenewMembership : Form
    {
        frmHome parent;
        public frmRenewMembership(frmHome Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            //dispose of this form
            this.Close();

            //show hidden home page
            parent.Visible = true;
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmRenewMembership_Load(object sender, EventArgs e)
        {
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

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (txtMemID.Text.Trim() == string.Empty || cmbMembership.SelectedItem == null || cmbPayment.SelectedItem == null)
            {
                MessageBox.Show("All fields must be entered!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                int memID = Convert.ToInt32(txtMemID.Text);
                DataSet ds;
                ds = Databases.ValidUser(memID);

                int i = ds.Tables["Members"].Rows.Count;
                if (i < 1)
                {
                    MessageBox.Show("MemberID not valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMemID.ResetText();
                }
                else
                {
                    int membershipID = Int32.Parse(cmbMembership.SelectedItem.ToString().Substring(0, 3));
                    DateTime start = dateStartBox.Value;

                    Databases member = new Databases();
                    member.GetAMember(memID);
                    member.MakeActiveMembership(membershipID, memID, start);
                    member.UpdateMember(memID, 'A');
                }
            }
        }

        private void txtMemID_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Only allow numeric characters
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtMemID.Clear();
            cmbMembership.SelectedIndex=-1;
            cmbPayment.SelectedIndex = -1;
        }

    }
}
