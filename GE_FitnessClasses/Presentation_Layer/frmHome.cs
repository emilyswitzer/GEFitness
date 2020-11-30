using System;
using System.Windows.Forms;

namespace GE_FitnessClasses
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void mnuBookClass_Click(object sender, EventArgs e)
        {
            this.Hide();

            //Display frmBookClass
            frmBookClass nextForm = new frmBookClass(this);
            nextForm.Show();

        }

        private void mnuCancelMembership_Click(object sender, EventArgs e)
        {
            this.Hide();

            //Display frmCancelMembership
            frmCancelMembership nextForm = new frmCancelMembership(this);
            nextForm.Show();
        }

        private void mnuCancelBooking_Click(object sender, EventArgs e)
        {
            this.Hide();

            //Display frmCancelBooking
            frmCancelBooking nextForm = new frmCancelBooking(this);
            nextForm.Show();
        }

        private void mnuRenewMembership_Click(object sender, EventArgs e)
        {
            this.Hide();

            //Display frmRenewMembership
            frmRenewMembership nextForm = new frmRenewMembership(this);
            nextForm.Show();
        }

        private void mnuTimetable_Click(object sender, EventArgs e)
        {
            this.Hide();

            //Display frmViewTimetable
            frmViewTimetable nextForm = new frmViewTimetable(this);
            nextForm.Show();
        }

        private void mnuLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuPurchaseMembership_Click(object sender, EventArgs e)
        {
            this.Hide();

            //Display frmPurchaseMembership
            frmPurchaseMembership nextForm = new frmPurchaseMembership(this);
            nextForm.Show();
        }
    }
}
