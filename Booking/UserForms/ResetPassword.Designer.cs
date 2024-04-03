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
            this.Continue_btn = new Booking.usercontrol.CustomButton3();
            this.res_email = new Booking.usercontrol.CustomTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.otp_btn = new Booking.usercontrol.CustomButton4();
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.back_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.minimize_btn = new System.Windows.Forms.Button();
            this.gunaCirclePictureBox1 = new Guna.UI.WinForms.GunaCirclePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel_change.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Image = global::Booking.Properties.Resources._1523;
            this.pictureBox3.Location = new System.Drawing.Point(-2, 350);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(589, 132);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(176, 181);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 26);
            this.label1.TabIndex = 17;
            this.label1.Text = "Forgot Password";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Continue_btn);
            this.panel1.Controls.Add(this.res_email);
            this.panel1.Location = new System.Drawing.Point(132, 237);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(316, 146);
            this.panel1.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter Email Address";
            // 
            // Continue_btn
            // 
            this.Continue_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Continue_btn.Angle = 248F;
            this.Continue_btn.BorderRadius = 20;
            this.Continue_btn.Color0 = System.Drawing.Color.Blue;
            this.Continue_btn.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Continue_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Continue_btn.ForeColor = System.Drawing.Color.White;
            this.Continue_btn.Location = new System.Drawing.Point(40, 86);
            this.Continue_btn.Margin = new System.Windows.Forms.Padding(2);
            this.Continue_btn.Name = "Continue_btn";
            this.Continue_btn.Size = new System.Drawing.Size(224, 32);
            this.Continue_btn.TabIndex = 1;
            this.Continue_btn.Click += new System.EventHandler(this.Continue_btn_Click);
            // 
            // res_email
            // 
            this.res_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.res_email.BottomBorderColor = System.Drawing.Color.Black;
            this.res_email.BottomBorderOnFocusColor = System.Drawing.Color.Blue;
            this.res_email.Location = new System.Drawing.Point(40, 37);
            this.res_email.Margin = new System.Windows.Forms.Padding(2);
            this.res_email.Name = "res_email";
            this.res_email.Size = new System.Drawing.Size(237, 17);
            this.res_email.TabIndex = 0;
            this.res_email.Text = "Enter Email Address";
            this.res_email.Enter += new System.EventHandler(this.res_email_Enter);
            this.res_email.Leave += new System.EventHandler(this.res_email_Leave);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Controls.Add(this.otp_btn);
            this.panel2.Controls.Add(this.res_otp);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(135, 237);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(316, 144);
            this.panel2.TabIndex = 3;
            // 
            // otp_btn
            // 
            this.otp_btn.Angle = 105F;
            this.otp_btn.BorderRadius = 20;
            this.otp_btn.Color0 = System.Drawing.Color.Blue;
            this.otp_btn.Color1 = System.Drawing.Color.Orange;
            this.otp_btn.ForeColor = System.Drawing.Color.White;
            this.otp_btn.Location = new System.Drawing.Point(33, 96);
            this.otp_btn.Margin = new System.Windows.Forms.Padding(2);
            this.otp_btn.Name = "otp_btn";
            this.otp_btn.Size = new System.Drawing.Size(246, 30);
            this.otp_btn.TabIndex = 2;
            this.otp_btn.Click += new System.EventHandler(this.otp_btn_Click);
            // 
            // res_otp
            // 
            this.res_otp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.res_otp.BottomBorderColor = System.Drawing.Color.Black;
            this.res_otp.BottomBorderOnFocusColor = System.Drawing.Color.Blue;
            this.res_otp.Location = new System.Drawing.Point(139, 37);
            this.res_otp.Margin = new System.Windows.Forms.Padding(2);
            this.res_otp.Name = "res_otp";
            this.res_otp.Size = new System.Drawing.Size(67, 17);
            this.res_otp.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 41);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
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
            this.label4.Location = new System.Drawing.Point(186, 181);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
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
            this.label5.Location = new System.Drawing.Point(200, 181);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
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
            this.panel_change.Location = new System.Drawing.Point(130, 235);
            this.panel_change.Margin = new System.Windows.Forms.Padding(2);
            this.panel_change.Name = "panel_change";
            this.panel_change.Size = new System.Drawing.Size(316, 144);
            this.panel_change.TabIndex = 4;
            // 
            // but_change
            // 
            this.but_change.Angle = 78F;
            this.but_change.BorderRadius = 20;
            this.but_change.Color0 = System.Drawing.Color.Blue;
            this.but_change.Color1 = System.Drawing.Color.Navy;
            this.but_change.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_change.ForeColor = System.Drawing.Color.White;
            this.but_change.Location = new System.Drawing.Point(54, 94);
            this.but_change.Margin = new System.Windows.Forms.Padding(2);
            this.but_change.Name = "but_change";
            this.but_change.Size = new System.Drawing.Size(210, 32);
            this.but_change.TabIndex = 4;
            this.but_change.Click += new System.EventHandler(this.but_change_Click);
            // 
            // rescon_pass
            // 
            this.rescon_pass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rescon_pass.BottomBorderColor = System.Drawing.Color.Black;
            this.rescon_pass.BottomBorderOnFocusColor = System.Drawing.Color.Blue;
            this.rescon_pass.Location = new System.Drawing.Point(129, 57);
            this.rescon_pass.Margin = new System.Windows.Forms.Padding(2);
            this.rescon_pass.Name = "rescon_pass";
            this.rescon_pass.PasswordChar = '●';
            this.rescon_pass.Size = new System.Drawing.Size(175, 17);
            this.rescon_pass.TabIndex = 3;
            // 
            // res_pas
            // 
            this.res_pas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.res_pas.BottomBorderColor = System.Drawing.Color.Black;
            this.res_pas.BottomBorderOnFocusColor = System.Drawing.Color.Blue;
            this.res_pas.Location = new System.Drawing.Point(123, 14);
            this.res_pas.Margin = new System.Windows.Forms.Padding(2);
            this.res_pas.Name = "res_pas";
            this.res_pas.PasswordChar = '●';
            this.res_pas.Size = new System.Drawing.Size(181, 17);
            this.res_pas.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 56);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Confirm New Password: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 14);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Enter New Password: ";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.back_btn);
            this.panel3.Controls.Add(this.exit_btn);
            this.panel3.Controls.Add(this.minimize_btn);
            this.panel3.Location = new System.Drawing.Point(-2, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(589, 42);
            this.panel3.TabIndex = 51;
            // 
            // back_btn
            // 
            this.back_btn.BackColor = System.Drawing.Color.Gainsboro;
            this.back_btn.FlatAppearance.BorderSize = 0;
            this.back_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_btn.Location = new System.Drawing.Point(-1, -4);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(75, 50);
            this.back_btn.TabIndex = 2;
            this.back_btn.Text = "<-----";
            this.back_btn.UseVisualStyleBackColor = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.BackColor = System.Drawing.Color.Gainsboro;
            this.exit_btn.FlatAppearance.BorderSize = 0;
            this.exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_btn.Location = new System.Drawing.Point(513, -1);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(75, 47);
            this.exit_btn.TabIndex = 1;
            this.exit_btn.Text = "X";
            this.exit_btn.UseVisualStyleBackColor = false;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // minimize_btn
            // 
            this.minimize_btn.BackColor = System.Drawing.Color.Gainsboro;
            this.minimize_btn.FlatAppearance.BorderSize = 0;
            this.minimize_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimize_btn.Location = new System.Drawing.Point(440, -1);
            this.minimize_btn.Name = "minimize_btn";
            this.minimize_btn.Size = new System.Drawing.Size(75, 47);
            this.minimize_btn.TabIndex = 0;
            this.minimize_btn.Text = "-----";
            this.minimize_btn.UseVisualStyleBackColor = false;
            this.minimize_btn.Click += new System.EventHandler(this.minimize_btn_Click);
            // 
            // gunaCirclePictureBox1
            // 
            this.gunaCirclePictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaCirclePictureBox1.Image = global::Booking.Properties.Resources.TicketEase;
            this.gunaCirclePictureBox1.Location = new System.Drawing.Point(231, 48);
            this.gunaCirclePictureBox1.Name = "gunaCirclePictureBox1";
            this.gunaCirclePictureBox1.Size = new System.Drawing.Size(92, 95);
            this.gunaCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaCirclePictureBox1.TabIndex = 52;
            this.gunaCirclePictureBox1.TabStop = false;
            this.gunaCirclePictureBox1.UseTransfarantBackground = false;
            // 
            // ResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(585, 454);
            this.Controls.Add(this.gunaCirclePictureBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel_change);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
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
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

 
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private usercontrol.CustomTextBox res_email;
        private usercontrol.CustomButton3 Continue_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private usercontrol.CustomTextBox res_otp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private usercontrol.CustomButton4 otp_btn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel_change;
        private usercontrol.CustomTextBox rescon_pass;
        private usercontrol.CustomTextBox res_pas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private usercontrol.CustomButton5 but_change;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Button minimize_btn;
        private Guna.UI.WinForms.GunaCirclePictureBox gunaCirclePictureBox1;
    }
}