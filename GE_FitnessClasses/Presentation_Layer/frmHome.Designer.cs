namespace GE_FitnessClasses
{
    partial class frmHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mnuCurrentHome = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBookings = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBookClass = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCancelBooking = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMembership = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRenewMembership = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCancelMembership = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPurchaseMembership = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTimetable = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHome = new System.Windows.Forms.MenuStrip();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mnuHome.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.mnuMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuCurrentHome
            // 
            this.mnuCurrentHome.AutoSize = false;
            this.mnuCurrentHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(111)))), ((int)(((byte)(81)))));
            this.mnuCurrentHome.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuCurrentHome.ForeColor = System.Drawing.Color.Snow;
            this.mnuCurrentHome.Name = "mnuCurrentHome";
            this.mnuCurrentHome.Padding = new System.Windows.Forms.Padding(0, 2, 4, 0);
            this.mnuCurrentHome.Size = new System.Drawing.Size(175, 60);
            this.mnuCurrentHome.Text = "Home            ";
            // 
            // mnuBookings
            // 
            this.mnuBookings.AutoSize = false;
            this.mnuBookings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(204)))), ((int)(((byte)(143)))));
            this.mnuBookings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBookClass,
            this.mnuCancelBooking});
            this.mnuBookings.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuBookings.ForeColor = System.Drawing.Color.White;
            this.mnuBookings.Name = "mnuBookings";
            this.mnuBookings.Padding = new System.Windows.Forms.Padding(6, 0, 4, 0);
            this.mnuBookings.Size = new System.Drawing.Size(175, 60);
            this.mnuBookings.Text = "Bookings          ";
            // 
            // mnuBookClass
            // 
            this.mnuBookClass.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mnuBookClass.Name = "mnuBookClass";
            this.mnuBookClass.Size = new System.Drawing.Size(212, 28);
            this.mnuBookClass.Text = "Make Booking";
            this.mnuBookClass.Click += new System.EventHandler(this.mnuBookClass_Click);
            // 
            // mnuCancelBooking
            // 
            this.mnuCancelBooking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.mnuCancelBooking.Name = "mnuCancelBooking";
            this.mnuCancelBooking.Size = new System.Drawing.Size(212, 28);
            this.mnuCancelBooking.Text = "Cancel Booking";
            this.mnuCancelBooking.Click += new System.EventHandler(this.mnuCancelBooking_Click);
            // 
            // mnuMembership
            // 
            this.mnuMembership.AutoSize = false;
            this.mnuMembership.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(162)))), ((int)(((byte)(97)))));
            this.mnuMembership.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRenewMembership,
            this.mnuCancelMembership,
            this.mnuPurchaseMembership});
            this.mnuMembership.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuMembership.ForeColor = System.Drawing.Color.White;
            this.mnuMembership.Name = "mnuMembership";
            this.mnuMembership.Padding = new System.Windows.Forms.Padding(6, 0, 4, 0);
            this.mnuMembership.Size = new System.Drawing.Size(175, 60);
            this.mnuMembership.Text = "Membership     ";
            // 
            // mnuRenewMembership
            // 
            this.mnuRenewMembership.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mnuRenewMembership.Name = "mnuRenewMembership";
            this.mnuRenewMembership.Size = new System.Drawing.Size(263, 28);
            this.mnuRenewMembership.Text = "Renew Membership";
            this.mnuRenewMembership.Click += new System.EventHandler(this.mnuRenewMembership_Click);
            // 
            // mnuCancelMembership
            // 
            this.mnuCancelMembership.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.mnuCancelMembership.Name = "mnuCancelMembership";
            this.mnuCancelMembership.Size = new System.Drawing.Size(263, 28);
            this.mnuCancelMembership.Text = "Cancel Membership";
            this.mnuCancelMembership.Click += new System.EventHandler(this.mnuCancelMembership_Click);
            // 
            // mnuPurchaseMembership
            // 
            this.mnuPurchaseMembership.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mnuPurchaseMembership.Name = "mnuPurchaseMembership";
            this.mnuPurchaseMembership.Size = new System.Drawing.Size(263, 28);
            this.mnuPurchaseMembership.Text = "Purchase Membership";
            this.mnuPurchaseMembership.Click += new System.EventHandler(this.mnuPurchaseMembership_Click);
            // 
            // mnuTimetable
            // 
            this.mnuTimetable.AutoSize = false;
            this.mnuTimetable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(204)))), ((int)(((byte)(143)))));
            this.mnuTimetable.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuTimetable.ForeColor = System.Drawing.Color.White;
            this.mnuTimetable.Name = "mnuTimetable";
            this.mnuTimetable.Padding = new System.Windows.Forms.Padding(6, 0, 4, 0);
            this.mnuTimetable.Size = new System.Drawing.Size(175, 60);
            this.mnuTimetable.Text = "Timetable          ";
            this.mnuTimetable.Click += new System.EventHandler(this.mnuTimetable_Click);
            // 
            // mnuLogout
            // 
            this.mnuLogout.AutoSize = false;
            this.mnuLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(162)))), ((int)(((byte)(97)))));
            this.mnuLogout.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuLogout.ForeColor = System.Drawing.Color.White;
            this.mnuLogout.Name = "mnuLogout";
            this.mnuLogout.Padding = new System.Windows.Forms.Padding(6, 0, 4, 0);
            this.mnuLogout.Size = new System.Drawing.Size(175, 60);
            this.mnuLogout.Text = "Logout             ";
            this.mnuLogout.Click += new System.EventHandler(this.mnuLogout_Click);
            // 
            // mnuHome
            // 
            this.mnuHome.AutoSize = false;
            this.mnuHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(193)))), ((int)(((byte)(179)))));
            this.mnuHome.Dock = System.Windows.Forms.DockStyle.Left;
            this.mnuHome.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuHome.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuHome.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCurrentHome,
            this.mnuBookings,
            this.mnuMembership,
            this.mnuTimetable,
            this.mnuLogout});
            this.mnuHome.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.mnuHome.Location = new System.Drawing.Point(0, 31);
            this.mnuHome.MaximumSize = new System.Drawing.Size(169, 0);
            this.mnuHome.Name = "mnuHome";
            this.mnuHome.Padding = new System.Windows.Forms.Padding(7, 110, 0, 2);
            this.mnuHome.Size = new System.Drawing.Size(169, 572);
            this.mnuHome.TabIndex = 7;
            this.mnuHome.Text = "menuStrip1";
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(193)))), ((int)(((byte)(179)))));
            this.pnlLogo.Controls.Add(this.picLogo);
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(169, 144);
            this.pnlLogo.TabIndex = 8;
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.BackgroundImage = global::GE_FitnessClasses.Properties.Resources.G_ELOGO__5_;
            this.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picLogo.ErrorImage = null;
            this.picLogo.Location = new System.Drawing.Point(-59, 18);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(225, 123);
            this.picLogo.TabIndex = 1;
            this.picLogo.TabStop = false;
            // 
            // mnuMain
            // 
            this.mnuMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(193)))), ((int)(((byte)(179)))));
            this.mnuMain.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExit});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mnuMain.Size = new System.Drawing.Size(786, 31);
            this.mnuMain.TabIndex = 6;
            // 
            // mnuExit
            // 
            this.mnuExit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(51, 27);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::GE_FitnessClasses.Properties.Resources.GEFitnessBG;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(169, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(633, 582);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 603);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnlLogo);
            this.Controls.Add(this.mnuHome);
            this.Controls.Add(this.mnuMain);
            this.Name = "frmHome";
            this.Text = "Home";
            this.mnuHome.ResumeLayout(false);
            this.mnuHome.PerformLayout();
            this.pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem mnuCurrentHome;
        private System.Windows.Forms.ToolStripMenuItem mnuBookings;
        private System.Windows.Forms.ToolStripMenuItem mnuMembership;
        private System.Windows.Forms.ToolStripMenuItem mnuTimetable;
        private System.Windows.Forms.ToolStripMenuItem mnuLogout;
        private System.Windows.Forms.MenuStrip mnuHome;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.ToolStripMenuItem mnuBookClass;
        private System.Windows.Forms.ToolStripMenuItem mnuCancelBooking;
        private System.Windows.Forms.ToolStripMenuItem mnuRenewMembership;
        private System.Windows.Forms.ToolStripMenuItem mnuCancelMembership;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuPurchaseMembership;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

