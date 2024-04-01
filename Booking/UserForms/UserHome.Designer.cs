namespace Booking.UserForms
{
    partial class UserHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserHome));
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.current_user = new Guna.UI.WinForms.GunaLabel();
            this.gunaSeparator1 = new Guna.UI.WinForms.GunaSeparator();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.bookhistory_btn = new Guna.UI.WinForms.GunaGradiantButton();
            this.book_btn = new Guna.UI.WinForms.GunaGradiantButton();
            this.home_btn = new Guna.UI.WinForms.GunaGradiantButton();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.minimize_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logout_btn = new Guna.UI.WinForms.GunaGradiantButton();
            this.exit_btn = new System.Windows.Forms.Button();
            this.gunaPanel1.SuspendLayout();
            this.gunaPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.White;
            this.gunaPanel1.Controls.Add(this.exit_btn);
            this.gunaPanel1.Controls.Add(this.panel1);
            this.gunaPanel1.Controls.Add(this.minimize_btn);
            this.gunaPanel1.Location = new System.Drawing.Point(1, 1);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(1053, 47);
            this.gunaPanel1.TabIndex = 0;
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.BackColor = System.Drawing.Color.White;
            this.gunaPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gunaPanel2.Controls.Add(this.logout_btn);
            this.gunaPanel2.Controls.Add(this.bookhistory_btn);
            this.gunaPanel2.Controls.Add(this.book_btn);
            this.gunaPanel2.Controls.Add(this.home_btn);
            this.gunaPanel2.Controls.Add(this.gunaSeparator1);
            this.gunaPanel2.Controls.Add(this.current_user);
            this.gunaPanel2.Controls.Add(this.gunaLabel1);
            this.gunaPanel2.Controls.Add(this.gunaPictureBox1);
            this.gunaPanel2.Location = new System.Drawing.Point(1, 27);
            this.gunaPanel2.Name = "gunaPanel2";
            this.gunaPanel2.Size = new System.Drawing.Size(251, 622);
            this.gunaPanel2.TabIndex = 1;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe Script", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(137, 23);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(68, 33);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "Hello";
            // 
            // current_user
            // 
            this.current_user.AutoSize = true;
            this.current_user.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.current_user.Location = new System.Drawing.Point(118, 56);
            this.current_user.Name = "current_user";
            this.current_user.Size = new System.Drawing.Size(168, 38);
            this.current_user.TabIndex = 2;
            this.current_user.Text = "gunaLabel2";
            // 
            // gunaSeparator1
            // 
            this.gunaSeparator1.LineColor = System.Drawing.Color.Silver;
            this.gunaSeparator1.Location = new System.Drawing.Point(0, 103);
            this.gunaSeparator1.Name = "gunaSeparator1";
            this.gunaSeparator1.Size = new System.Drawing.Size(250, 10);
            this.gunaSeparator1.TabIndex = 3;
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // bookhistory_btn
            // 
            this.bookhistory_btn.AnimationHoverSpeed = 0.07F;
            this.bookhistory_btn.AnimationSpeed = 0.03F;
            this.bookhistory_btn.BaseColor1 = System.Drawing.Color.Goldenrod;
            this.bookhistory_btn.BaseColor2 = System.Drawing.Color.DarkSlateGray;
            this.bookhistory_btn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookhistory_btn.ForeColor = System.Drawing.Color.White;
            this.bookhistory_btn.Image = ((System.Drawing.Image)(resources.GetObject("bookhistory_btn.Image")));
            this.bookhistory_btn.ImageSize = new System.Drawing.Size(20, 20);
            this.bookhistory_btn.Location = new System.Drawing.Point(12, 264);
            this.bookhistory_btn.Name = "bookhistory_btn";
            this.bookhistory_btn.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.bookhistory_btn.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.bookhistory_btn.OnHoverForeColor = System.Drawing.Color.White;
            this.bookhistory_btn.OnHoverImage = null;
            this.bookhistory_btn.OnPressedColor = System.Drawing.Color.Black;
            this.bookhistory_btn.Radius = 10;
            this.bookhistory_btn.Size = new System.Drawing.Size(221, 42);
            this.bookhistory_btn.TabIndex = 8;
            this.bookhistory_btn.Text = "    Booking History";
            this.bookhistory_btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // book_btn
            // 
            this.book_btn.AnimationHoverSpeed = 0.07F;
            this.book_btn.AnimationSpeed = 0.03F;
            this.book_btn.BaseColor1 = System.Drawing.Color.DeepPink;
            this.book_btn.BaseColor2 = System.Drawing.Color.DarkSlateBlue;
            this.book_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.book_btn.ForeColor = System.Drawing.Color.White;
            this.book_btn.Image = ((System.Drawing.Image)(resources.GetObject("book_btn.Image")));
            this.book_btn.ImageSize = new System.Drawing.Size(20, 20);
            this.book_btn.Location = new System.Drawing.Point(12, 202);
            this.book_btn.Name = "book_btn";
            this.book_btn.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.book_btn.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.book_btn.OnHoverForeColor = System.Drawing.Color.White;
            this.book_btn.OnHoverImage = null;
            this.book_btn.OnPressedColor = System.Drawing.Color.Black;
            this.book_btn.Radius = 10;
            this.book_btn.Size = new System.Drawing.Size(221, 42);
            this.book_btn.TabIndex = 7;
            this.book_btn.Text = "Book";
            this.book_btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // home_btn
            // 
            this.home_btn.AnimationHoverSpeed = 0.07F;
            this.home_btn.AnimationSpeed = 0.03F;
            this.home_btn.BaseColor1 = System.Drawing.Color.SlateBlue;
            this.home_btn.BaseColor2 = System.Drawing.Color.Fuchsia;
            this.home_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.home_btn.ForeColor = System.Drawing.Color.White;
            this.home_btn.Image = ((System.Drawing.Image)(resources.GetObject("home_btn.Image")));
            this.home_btn.ImageSize = new System.Drawing.Size(20, 20);
            this.home_btn.Location = new System.Drawing.Point(12, 132);
            this.home_btn.Name = "home_btn";
            this.home_btn.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.home_btn.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.home_btn.OnHoverForeColor = System.Drawing.Color.White;
            this.home_btn.OnHoverImage = null;
            this.home_btn.OnPressedColor = System.Drawing.Color.Black;
            this.home_btn.Radius = 10;
            this.home_btn.Size = new System.Drawing.Size(221, 50);
            this.home_btn.TabIndex = 6;
            this.home_btn.Text = "Home";
            this.home_btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = global::Booking.Properties.Resources.kisspng_computer_icons_user_profile_person_5abd85306ff7f7_0592226715223698404586;
            this.gunaPictureBox1.Location = new System.Drawing.Point(23, 29);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(66, 62);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 0;
            this.gunaPictureBox1.TabStop = false;
            // 
            // gunaButton1
            // 
            this.gunaButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton1.Image")));
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(25, 143);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Size = new System.Drawing.Size(197, 67);
            this.gunaButton1.TabIndex = 2;
            this.gunaButton1.Text = "gunaButton1";
            // 
            // minimize_btn
            // 
            this.minimize_btn.FlatAppearance.BorderSize = 0;
            this.minimize_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimize_btn.Location = new System.Drawing.Point(928, 11);
            this.minimize_btn.Name = "minimize_btn";
            this.minimize_btn.Size = new System.Drawing.Size(71, 18);
            this.minimize_btn.TabIndex = 4;
            this.minimize_btn.Text = "--------";
            this.minimize_btn.UseVisualStyleBackColor = true;
            this.minimize_btn.Click += new System.EventHandler(this.minimize_btn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(236)))), ((int)(((byte)(247)))));
            this.panel1.Location = new System.Drawing.Point(1, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(251, 114);
            this.panel1.TabIndex = 2;
            // 
            // logout_btn
            // 
            this.logout_btn.AnimationHoverSpeed = 0.07F;
            this.logout_btn.AnimationSpeed = 0.03F;
            this.logout_btn.BaseColor1 = System.Drawing.Color.DodgerBlue;
            this.logout_btn.BaseColor2 = System.Drawing.Color.Indigo;
            this.logout_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.logout_btn.ForeColor = System.Drawing.Color.White;
            this.logout_btn.Image = ((System.Drawing.Image)(resources.GetObject("logout_btn.Image")));
            this.logout_btn.ImageSize = new System.Drawing.Size(20, 20);
            this.logout_btn.Location = new System.Drawing.Point(10, 550);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.logout_btn.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.logout_btn.OnHoverForeColor = System.Drawing.Color.White;
            this.logout_btn.OnHoverImage = null;
            this.logout_btn.OnPressedColor = System.Drawing.Color.Black;
            this.logout_btn.Radius = 10;
            this.logout_btn.Size = new System.Drawing.Size(221, 50);
            this.logout_btn.TabIndex = 9;
            this.logout_btn.Text = "Logout";
            this.logout_btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.FlatAppearance.BorderSize = 0;
            this.exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_btn.Location = new System.Drawing.Point(979, 11);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(71, 18);
            this.exit_btn.TabIndex = 5;
            this.exit_btn.Text = "X";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // UserHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(236)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(1054, 650);
            this.Controls.Add(this.gunaPanel2);
            this.Controls.Add(this.gunaPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserHome";
            this.Load += new System.EventHandler(this.UserHome_Load);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel2.ResumeLayout(false);
            this.gunaPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaPanel gunaPanel2;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaLabel current_user;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaSeparator gunaSeparator1;
        private Guna.UI.WinForms.GunaGradiantButton book_btn;
        private Guna.UI.WinForms.GunaGradiantButton home_btn;
        private Guna.UI.WinForms.GunaGradiantButton bookhistory_btn;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.Button minimize_btn;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaGradiantButton logout_btn;
        private System.Windows.Forms.Button exit_btn;
    }
}