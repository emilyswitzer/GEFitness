using GE_FitnessClasses.Database_Layer;
using System;
using System.Data;
using System.Windows.Forms;

namespace GE_FitnessClasses
{
    public partial class frmCancelBooking : Form
    {
        frmHome parent;
        public frmCancelBooking(frmHome Parent)
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

        private void mnuExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (txtMemID.Text.Trim() == string.Empty)
            {
                MessageBox.Show("MemberID must be entered!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                int memID = Convert.ToInt32(txtMemID.Text);
                DataSet ds1;
                ds1 = Databases.ValidUser(memID);
                int r = ds1.Tables["Members"].Rows.Count;
                if (r < 1)
                {

                    MessageBox.Show("MemberID not valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMemID.ResetText();
                }
                else
                {
                    //Display Confirm Dialog
                    DialogResult result = MessageBox.Show("Are you sure you want to cancel this booking?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result.Equals(DialogResult.Yes))
                    {
                        //Retrieve ConcertID in Column0 of the row selected
                        Databases booking = new Databases();
                        int id = Convert.ToInt32(grdBookedClasses.Rows[grdBookedClasses.CurrentCell.RowIndex].Cells[0].Value);
                        booking.GetABooking(id);

                        //Cancel Booking
                        booking.CancelBooking(id);

                        //Display Cancellation Message
                        MessageBox.Show("Booking has been cancelled!", "Cancellation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        grdBookedClasses.DataSource = Databases.GetMemberBookings(Convert.ToInt32(txtMemID.Text)).Tables["Bookings"];

                        this.Close();
                        parent.Visible = true;
                    }
                }
            }
        }

        private void txtMemID_TextChanged(object sender, EventArgs e)
        {            
            grdBookedClasses.DataSource = Databases.GetMemberBookings(Convert.ToInt32(txtMemID.Text)).Tables["Bookings"];
        }

        private void grdBookedClasses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Retrieve Booking for ID in Column0 of the row selected
            Databases booking = new Databases();
            int id = Convert.ToInt32(grdBookedClasses.Rows[grdBookedClasses.CurrentCell.RowIndex].Cells[0].Value);
            booking.GetABooking(id);

            //Display Confirm Button
            btnConfirm.Visible = true;
        }

        private void txtMemID_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Only allow numeric characters
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

       
    }
}