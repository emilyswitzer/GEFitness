using GE_FitnessClasses.Database_Layer;
using System;
using System.Data;
using System.Windows.Forms;

namespace GE_FitnessClasses
{
    public partial class frmCancelMembership : Form
    {
        frmHome parent;
        public frmCancelMembership(frmHome Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {

            if (txtMemID.Text.Trim() == string.Empty || txtAreaReason.Text.Trim() == string.Empty)
            {
                MessageBox.Show("All fields must be entered!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                DataSet ds1;
                int id = Convert.ToInt32(txtMemID.Text);
                ds1 = Databases.CheckIfActive(id);
                int i = ds1.Tables["Active"].Rows.Count;
                if (i < 1)
                {

                    MessageBox.Show("Member must be active!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {

                    DataSet ds2;
                    ds2 = Databases.ValidUser(id);
                    int r = ds2.Tables["Members"].Rows.Count;
                    if (r < 1)
                    {

                        MessageBox.Show("MemberID not valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtMemID.ResetText();
                    }
                    else
                    {
                        Databases member = new Databases();
                        char status = 'D';

                        member.CancelMembership(id);

                        member.UpdateMember(id, status);

                        MessageBox.Show("Membership cancelled!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        parent.Visible = true;
                    }
                }
            }
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


        private void txtMemID_KeyPress(object sender, KeyPressEventArgs e)
        {
            
                if (!char.IsDigit(e.KeyChar)) e.Handled = true;         //Just Digits
                if (e.KeyChar == (char)8) e.Handled = false;            //Allow Backspace


            
        }

        
    }
}
