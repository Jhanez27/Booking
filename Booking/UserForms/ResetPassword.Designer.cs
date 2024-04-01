namespace Booking
{
    partial class ResetPassword
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
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Continue = new Booking.usercontrol.CustomButton3();
            this.res_email = new Booking.usercontrol.CustomTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.customButton41 = new Booking.usercontrol.CustomButton4();
            this.res_otp = new Booking.usercontrol.CustomTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel_change = new System.Windows.Forms.Panel();
            this.but_change = new Booking.usercontrol.CustomButton5();
            this.rescon_pass = new Booking.usercontrol.CustomTextBox();
            this.res_pas = new Booking.usercontrol.CustomTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.PictureBox();
            this.logo = new Booking.usercontrol.roundPictureeBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel_change.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Image = global::Booking.Properties.Resources._1523;
            this.pictureBox3.Location = new System.Drawing.Point(-3, 442);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(884, 274);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(316, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 26);
            this.label1.TabIndex = 17;
            this.label1.Text = "Forgot Password";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Continue);
            this.panel1.Controls.Add(this.res_email);
            this.panel1.Location = new System.Drawing.Point(194, 270);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(474, 225);
            this.panel1.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter Email Address";
            // 
            // Continue
            // 
            this.Continue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Continue.Angle = 237F;
            this.Continue.BorderRadius = 20;
            this.Continue.Color0 = System.Drawing.Color.Blue;
            this.Continue.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Continue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Continue.ForeColor = System.Drawing.Color.White;
            this.Continue.Location = new System.Drawing.Point(60, 132);
            this.Continue.Name = "Continue";
            this.Continue.Size = new System.Drawing.Size(336, 49);
            this.Continue.TabIndex = 1;
            this.Continue.Click += new System.EventHandler(this.customButton31_Click);
            // 
            // res_email
            // 
            this.res_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.res_email.BottomBorderColor = System.Drawing.Color.Black;
            this.res_email.BottomBorderOnFocusColor = System.Drawing.Color.Blue;
            this.res_email.Location = new System.Drawing.Point(60, 57);
            this.res_email.Name = "res_email";
            this.res_email.Size = new System.Drawing.Size(356, 26);
            this.res_email.TabIndex = 0;
            this.res_email.Text = "Enter Email Address";
            this.res_email.Enter += new System.EventHandler(this.res_email_Enter);
            this.res_email.Leave += new System.EventHandler(this.res_email_Leave);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Controls.Add(this.customButton41);
            this.panel2.Controls.Add(this.res_otp);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(191, 270);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(474, 222);
            this.panel2.TabIndex = 3;
            // 
            // customButton41
            // 
            this.customButton41.Angle = 242F;
            this.customButton41.BorderRadius = 20;
            this.customButton41.Color0 = System.Drawing.Color.Blue;
            this.customButton41.Color1 = System.Drawing.Color.Orange;
            this.customButton41.ForeColor = System.Drawing.Color.White;
            this.customButton41.Location = new System.Drawing.Point(50, 148);
            this.customButton41.Name = "customButton41";
            this.customButton41.Size = new System.Drawing.Size(369, 46);
            this.customButton41.TabIndex = 2;
            this.customButton41.Click += new System.EventHandler(this.customButton41_Click);
            // 
            // res_otp
            // 
            this.res_otp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.res_otp.BottomBorderColor = System.Drawing.Color.Black;
            this.res_otp.BottomBorderOnFocusColor = System.Drawing.Color.Blue;
            this.res_otp.Location = new System.Drawing.Point(208, 57);
            this.res_otp.Name = "res_otp";
            this.res_otp.Size = new System.Drawing.Size(100, 26);
            this.res_otp.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Enter Reset Otp : ";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(316, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(226, 26);
            this.label4.TabIndex = 19;
            this.label4.Text = "Code Verification";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(329, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 26);
            this.label5.TabIndex = 20;
            this.label5.Text = "New Password";
            // 
            // panel_change
            // 
            this.panel_change.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_change.Controls.Add(this.but_change);
            this.panel_change.Controls.Add(this.rescon_pass);
            this.panel_change.Controls.Add(this.res_pas);
            this.panel_change.Controls.Add(this.label7);
            this.panel_change.Controls.Add(this.label6);
            this.panel_change.Location = new System.Drawing.Point(188, 270);
            this.panel_change.Name = "panel_change";
            this.panel_change.Size = new System.Drawing.Size(474, 222);
            this.panel_change.TabIndex = 4;
            // 
            // but_change
            // 
            this.but_change.Angle = 66F;
            this.but_change.BorderRadius = 20;
            this.but_change.Color0 = System.Drawing.Color.Blue;
            this.but_change.Color1 = System.Drawing.Color.Navy;
            this.but_change.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_change.ForeColor = System.Drawing.Color.White;
            this.but_change.Location = new System.Drawing.Point(81, 145);
            this.but_change.Name = "but_change";
            this.but_change.Size = new System.Drawing.Size(315, 49);
            this.but_change.TabIndex = 4;
            this.but_change.Click += new System.EventHandler(this.but_change_Click);
            // 
            // rescon_pass
            // 
            this.rescon_pass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rescon_pass.BottomBorderColor = System.Drawing.Color.Black;
            this.rescon_pass.BottomBorderOnFocusColor = System.Drawing.Color.Blue;
            this.rescon_pass.Location = new System.Drawing.Point(193, 88);
            this.rescon_pass.Name = "rescon_pass";
            this.rescon_pass.PasswordChar = '●';
            this.rescon_pass.Size = new System.Drawing.Size(262, 26);
            this.rescon_pass.TabIndex = 3;
            // 
            // res_pas
            // 
            this.res_pas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.res_pas.BottomBorderColor = System.Drawing.Color.Black;
            this.res_pas.BottomBorderOnFocusColor = System.Drawing.Color.Blue;
            this.res_pas.Location = new System.Drawing.Point(184, 22);
            this.res_pas.Name = "res_pas";
            this.res_pas.PasswordChar = '●';
            this.res_pas.Size = new System.Drawing.Size(271, 26);
            this.res_pas.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(180, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Confirm New Password: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Enter New Password: ";
            // 
            // Back
            // 
            this.Back.Image = global::Booking.Properties.Resources.back_arrow_3545314;
            this.Back.Location = new System.Drawing.Point(-3, 2);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(88, 46);
            this.Back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Back.TabIndex = 40;
            this.Back.TabStop = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // logo
            // 
            this.logo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logo.Image = global::Booking.Properties.Resources.TicketEase;
            this.logo.Location = new System.Drawing.Point(286, 2);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(261, 155);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 12;
            this.logo.TabStop = false;
            // 
            // ResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(878, 1050);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.panel_change);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.logo);
            this.Name = "ResetPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ResetPassword";
            this.Load += new System.EventHandler(this.ResetPassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel_change.ResumeLayout(false);
            this.panel_change.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private usercontrol.roundPictureeBox logo;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private usercontrol.CustomTextBox res_email;
        private usercontrol.CustomButton3 Continue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private usercontrol.CustomTextBox res_otp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private usercontrol.CustomButton4 customButton41;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel_change;
        private usercontrol.CustomTextBox rescon_pass;
        private usercontrol.CustomTextBox res_pas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private usercontrol.CustomButton5 but_change;
        private System.Windows.Forms.PictureBox Back;
    }
}