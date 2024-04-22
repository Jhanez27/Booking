namespace Booking
{
    partial class Home
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.forgot = new System.Windows.Forms.LinkLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.gunaCirclePictureBox1 = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.exit_btn = new System.Windows.Forms.Button();
            this.minimize_btn = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Login_Button = new Booking.usercontrol.CustomButton();
            this.pass = new Booking.usercontrol.CustomTextBox();
            this.username = new Booking.usercontrol.CustomTextBox();
            this.pass_Visibility = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(330, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome Clerk";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(238, 371);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(238, 503);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password";
            // 
            // forgot
            // 
            this.forgot.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.forgot.AutoSize = true;
            this.forgot.DisabledLinkColor = System.Drawing.Color.Black;
            this.forgot.ForeColor = System.Drawing.Color.Gray;
            this.forgot.LinkColor = System.Drawing.Color.Gray;
            this.forgot.Location = new System.Drawing.Point(447, 674);
            this.forgot.Name = "forgot";
            this.forgot.Size = new System.Drawing.Size(138, 20);
            this.forgot.TabIndex = 8;
            this.forgot.TabStop = true;
            this.forgot.Text = "Forgot Password?";
            this.forgot.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.forgot_LinkClicked);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::Booking.Properties.Resources.User_free_vector_icons_designed_by_Freepik;
            this.pictureBox1.Location = new System.Drawing.Point(244, 442);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = global::Booking.Properties.Resources.pngegg;
            this.pictureBox2.Location = new System.Drawing.Point(244, 568);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(44, 31);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // gunaCirclePictureBox1
            // 
            this.gunaCirclePictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaCirclePictureBox1.Image = global::Booking.Properties.Resources.TicketEase;
            this.gunaCirclePictureBox1.Location = new System.Drawing.Point(338, 88);
            this.gunaCirclePictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gunaCirclePictureBox1.Name = "gunaCirclePictureBox1";
            this.gunaCirclePictureBox1.Size = new System.Drawing.Size(180, 162);
            this.gunaCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaCirclePictureBox1.TabIndex = 17;
            this.gunaCirclePictureBox1.TabStop = false;
            this.gunaCirclePictureBox1.UseTransfarantBackground = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.exit_btn);
            this.panel1.Controls.Add(this.minimize_btn);
            this.panel1.Location = new System.Drawing.Point(-4, -3);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(882, 57);
            this.panel1.TabIndex = 18;
            // 
            // exit_btn
            // 
            this.exit_btn.BackColor = System.Drawing.Color.Gainsboro;
            this.exit_btn.FlatAppearance.BorderSize = 0;
            this.exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_btn.Location = new System.Drawing.Point(770, -2);
            this.exit_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(112, 58);
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
            this.minimize_btn.Location = new System.Drawing.Point(660, -2);
            this.minimize_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.minimize_btn.Name = "minimize_btn";
            this.minimize_btn.Size = new System.Drawing.Size(112, 58);
            this.minimize_btn.TabIndex = 0;
            this.minimize_btn.Text = "-----";
            this.minimize_btn.UseVisualStyleBackColor = false;
            this.minimize_btn.Click += new System.EventHandler(this.minimize_btn_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Image = global::Booking.Properties.Resources._1523;
            this.pictureBox3.Location = new System.Drawing.Point(-4, 768);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(884, 205);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // Login_Button
            // 
            this.Login_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Login_Button.Angle = 35F;
            this.Login_Button.BorderRadius = 20;
            this.Login_Button.Color0 = System.Drawing.Color.DarkBlue;
            this.Login_Button.Color1 = System.Drawing.Color.Magenta;
            this.Login_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_Button.ForeColor = System.Drawing.Color.White;
            this.Login_Button.Location = new System.Drawing.Point(275, 739);
            this.Login_Button.Name = "Login_Button";
            this.Login_Button.Size = new System.Drawing.Size(310, 58);
            this.Login_Button.TabIndex = 12;
            this.Login_Button.Click += new System.EventHandler(this.Login_Button_Click);
            // 
            // pass
            // 
            this.pass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pass.BottomBorderColor = System.Drawing.Color.Black;
            this.pass.BottomBorderOnFocusColor = System.Drawing.Color.Blue;
            this.pass.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.pass.Location = new System.Drawing.Point(314, 568);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(272, 31);
            this.pass.TabIndex = 10;
            this.pass.Text = "Type your password";
            this.pass.TextChanged += new System.EventHandler(this.pass_TextChange);
            this.pass.Enter += new System.EventHandler(this.pass_Enter);
            // 
            // username
            // 
            this.username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.username.BottomBorderColor = System.Drawing.Color.Black;
            this.username.BottomBorderOnFocusColor = System.Drawing.Color.Blue;
            this.username.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.username.Location = new System.Drawing.Point(314, 442);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(272, 31);
            this.username.TabIndex = 9;
            this.username.Text = "Type your username";
            this.username.Enter += new System.EventHandler(this.username_Enter);
            this.username.Leave += new System.EventHandler(this.username_Leave);
            // 
            // pass_Visibility
            // 
            this.pass_Visibility.AutoSize = true;
            this.pass_Visibility.Location = new System.Drawing.Point(314, 628);
            this.pass_Visibility.Name = "pass_Visibility";
            this.pass_Visibility.Size = new System.Drawing.Size(75, 24);
            this.pass_Visibility.TabIndex = 19;
            this.pass_Visibility.Text = "Show";
            this.pass_Visibility.UseVisualStyleBackColor = true;
            this.pass_Visibility.CheckedChanged += new System.EventHandler(this.pass_Visibility_CheckedChanged);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(878, 970);
            this.Controls.Add(this.pass_Visibility);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gunaCirclePictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Login_Button);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.username);
            this.Controls.Add(this.forgot);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel forgot;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private usercontrol.CustomTextBox username;
        private usercontrol.CustomTextBox pass;
        private usercontrol.CustomButton Login_Button;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaCirclePictureBox gunaCirclePictureBox1;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Button minimize_btn;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.CheckBox pass_Visibility;
    }
}

