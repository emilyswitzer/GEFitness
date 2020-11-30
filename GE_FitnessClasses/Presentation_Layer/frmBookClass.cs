using GE_FitnessClasses.Database_Layer;
using System;
using System.Data;
using System.Windows.Forms;


namespace GE_FitnessClasses
{
    public partial class frmBookClass : Form
    {
        frmHome parent;
        public frmBookClass(frmHome Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (txtMemID.Text.Trim() == string.Empty)
            {
                MessageBox.Show("MemberID must be entered!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            else
            {
                int classID = Int32.Parse(cmbClass.SelectedItem.ToString().Substring(0, 3));
                int capacity = Databases.GetCapacity(classID);
                Boolean valid = Databases.CheckIfFull(classID, capacity);
                if (!valid)
                {
                    MessageBox.Show("Class is full!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
                else
                {
                    int memID = Convert.ToInt32(txtMemID.Text);
                    Boolean available = Databases.CheckValidMember(classID, memID);
                    if (!available)
                    {
                        MessageBox.Show("You have already booked class!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        
                    }
                    else { 
                    int mem = Convert.ToInt32(txtMemID.Text);
                    DataSet ds2;
                    ds2 = Databases.ValidUser(mem);
                    int i = ds2.Tables["Members"].Rows.Count;
                        if (i < 1)
                        {

                            MessageBox.Show("MemberID not valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtMemID.ResetText();
                        }
                        else
                        {
                            Databases newBooking = new Databases();
                            int bookingID = Convert.ToInt32(txtBookingID.Text);

                            newBooking.MakeBooking(bookingID, classID, memID);

                            MessageBox.Show("Booking confirmed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                            parent.Visible = true;
                        }
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

        private void frmBookClass_Load(object sender, EventArgs e)
        {
            txtBookingID.Text = String.Format("{0:000}", Databases.GetNextBookingID());
            grdClasses.DataSource = Databases.GetClasses().Tables["Classes"];
            ///Load Classes
            DataSet ds1;
            ds1 = Databases.GetClasses();
            for (int i = 0; i < ds1.Tables["Classes"].Rows.Count; i++)
                cmbClass.Items.Add(ds1.Tables[0].Rows[i][0].ToString().PadLeft(3, '0') +
                "    " + ds1.Tables[0].Rows[i][1].ToString());

        }

        private void txtMemID_KeyPress(object sender, KeyPressEventArgs e)
        {
            
                if (!char.IsDigit(e.KeyChar)) e.Handled = true;         //Just Digits
                if (e.KeyChar == (char)8) e.Handled = false;            //Allow Backspace


            
        }
    }
}
