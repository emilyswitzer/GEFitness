namespace GE_FitnessClasses
{
    partial class frmCancelBooking
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
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.txtMemID = new System.Windows.Forms.TextBox();
            this.lblMemID = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.grdBookedClasses = new System.Windows.Forms.DataGridView();
            this.mnuMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdBookedClasses)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(193)))), ((int)(((byte)(179)))));
            this.mnuMain.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExit,
            this.mnuBack});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mnuMain.Size = new System.Drawing.Size(449, 31);
            this.mnuMain.TabIndex = 8;
            // 
            // mnuExit
            // 
            this.mnuExit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(51, 27);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click_1);
            // 
            // mnuBack
            // 
            this.mnuBack.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.mnuBack.Name = "mnuBack";
            this.mnuBack.Size = new System.Drawing.Size(59, 27);
            this.mnuBack.Text = "Back";
            this.mnuBack.Click += new System.EventHandler(this.mnuBack_Click);
            // 
            // txtMemID
            // 
            this.txtMemID.Location = new System.Drawing.Point(202, 67);
            this.txtMemID.MaxLength = 10;
            this.txtMemID.Name = "txtMemID";
            this.txtMemID.Size = new System.Drawing.Size(127, 22);
            this.txtMemID.TabIndex = 60;
            this.txtMemID.TextChanged += new System.EventHandler(this.txtMemID_TextChanged);
            this.txtMemID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMemID_KeyPress);
            // 
            // lblMemID
            // 
            this.lblMemID.AutoSize = true;
            this.lblMemID.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemID.Location = new System.Drawing.Point(76, 68);
            this.lblMemID.Name = "lblMemID";
            this.lblMemID.Size = new System.Drawing.Size(97, 19);
            this.lblMemID.TabIndex = 59;
            this.lblMemID.Text = "Member ID:";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(184, 352);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(86, 34);
            this.btnConfirm.TabIndex = 64;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Visible = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // grdBookedClasses
            // 
            this.grdBookedClasses.BackgroundColor = System.Drawing.Color.Bisque;
            this.grdBookedClasses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBookedClasses.Location = new System.Drawing.Point(47, 123);
            this.grdBookedClasses.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grdBookedClasses.Name = "grdBookedClasses";
            this.grdBookedClasses.RowHeadersWidth = 62;
            this.grdBookedClasses.RowTemplate.Height = 28;
            this.grdBookedClasses.Size = new System.Drawing.Size(352, 196);
            this.grdBookedClasses.TabIndex = 65;
            this.grdBookedClasses.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdBookedClasses_CellContentClick);
            // 
            // frmCancelBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 414);
            this.Controls.Add(this.grdBookedClasses);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.txtMemID);
            this.Controls.Add(this.lblMemID);
            this.Controls.Add(this.mnuMain);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmCancelBooking";
            this.Text = "Cancel Booking";
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdBookedClasses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.TextBox txtMemID;
        private System.Windows.Forms.Label lblMemID;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.DataGridView grdBookedClasses;
    }
}