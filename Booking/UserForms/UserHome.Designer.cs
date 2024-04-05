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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserHome));
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.exit_btn = new System.Windows.Forms.Button();
            this.minimize_btn = new System.Windows.Forms.Button();
            this.dashboardMain_panel = new Guna.UI.WinForms.GunaPanel();
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.logout_btn = new Guna.UI.WinForms.GunaGradiantButton();
            this.bookhistory_btn = new Guna.UI.WinForms.GunaGradiantButton();
            this.book_btn = new Guna.UI.WinForms.GunaGradiantButton();
            this.home_btn = new Guna.UI.WinForms.GunaGradiantButton();
            this.gunaSeparator1 = new Guna.UI.WinForms.GunaSeparator();
            this.current_user = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gunaCirclePictureBox1 = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.gunaPanel1.SuspendLayout();
            this.gunaPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.White;
            this.gunaPanel1.Controls.Add(this.exit_btn);
            this.gunaPanel1.Controls.Add(this.minimize_btn);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(1882, 72);
            this.gunaPanel1.TabIndex = 0;
            // 
            // exit_btn
            // 
            this.exit_btn.FlatAppearance.BorderSize = 0;
            this.exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_btn.Location = new System.Drawing.Point(1773, 0);
            this.exit_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(106, 68);
            this.exit_btn.TabIndex = 5;
            this.exit_btn.Text = "X";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // minimize_btn
            // 
            this.minimize_btn.FlatAppearance.BorderSize = 0;
            this.minimize_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimize_btn.Location = new System.Drawing.Point(1674, 0);
            this.minimize_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.minimize_btn.Name = "minimize_btn";
            this.minimize_btn.Size = new System.Drawing.Size(106, 68);
            this.minimize_btn.TabIndex = 4;
            this.minimize_btn.Text = "--------";
            this.minimize_btn.UseVisualStyleBackColor = true;
            this.minimize_btn.Click += new System.EventHandler(this.minimize_btn_Click);
            // 
            // dashboardMain_panel
            // 
            this.dashboardMain_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboardMain_panel.Location = new System.Drawing.Point(431, 72);
            this.dashboardMain_panel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dashboardMain_panel.Name = "dashboardMain_panel";
            this.dashboardMain_panel.Size = new System.Drawing.Size(1451, 940);
            this.dashboardMain_panel.TabIndex = 2;
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.BackColor = System.Drawing.Color.DarkBlue;
            this.gunaPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gunaPanel2.Controls.Add(this.logout_btn);
            this.gunaPanel2.Controls.Add(this.bookhistory_btn);
            this.gunaPanel2.Controls.Add(this.book_btn);
            this.gunaPanel2.Controls.Add(this.home_btn);
            this.gunaPanel2.Controls.Add(this.gunaSeparator1);
            this.gunaPanel2.Controls.Add(this.current_user);
            this.gunaPanel2.Controls.Add(this.gunaLabel1);
            this.gunaPanel2.Controls.Add(this.gunaPictureBox1);
            this.gunaPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaPanel2.Location = new System.Drawing.Point(0, 72);
            this.gunaPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gunaPanel2.Name = "gunaPanel2";
            this.gunaPanel2.Size = new System.Drawing.Size(431, 940);
            this.gunaPanel2.TabIndex = 1;
            // 
            // logout_btn
            // 
            this.logout_btn.AnimationHoverSpeed = 0.07F;
            this.logout_btn.AnimationSpeed = 0.03F;
            this.logout_btn.BaseColor1 = System.Drawing.Color.White;
            this.logout_btn.BaseColor2 = System.Drawing.Color.White;
            this.logout_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.logout_btn.ForeColor = System.Drawing.Color.Black;
            this.logout_btn.Image = ((System.Drawing.Image)(resources.GetObject("logout_btn.Image")));
            this.logout_btn.ImageSize = new System.Drawing.Size(20, 20);
            this.logout_btn.Location = new System.Drawing.Point(18, 848);
            this.logout_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.logout_btn.OnHoverBaseColor2 = System.Drawing.Color.SteelBlue;
            this.logout_btn.OnHoverForeColor = System.Drawing.Color.White;
            this.logout_btn.OnHoverImage = null;
            this.logout_btn.OnPressedColor = System.Drawing.Color.Black;
            this.logout_btn.Radius = 10;
            this.logout_btn.Size = new System.Drawing.Size(386, 77);
            this.logout_btn.TabIndex = 9;
            this.logout_btn.Text = "Logout";
            this.logout_btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // bookhistory_btn
            // 
            this.bookhistory_btn.AnimationHoverSpeed = 0.07F;
            this.bookhistory_btn.AnimationSpeed = 0.03F;
            this.bookhistory_btn.BaseColor1 = System.Drawing.Color.White;
            this.bookhistory_btn.BaseColor2 = System.Drawing.Color.White;
            this.bookhistory_btn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookhistory_btn.ForeColor = System.Drawing.Color.Black;
            this.bookhistory_btn.Image = ((System.Drawing.Image)(resources.GetObject("bookhistory_btn.Image")));
            this.bookhistory_btn.ImageSize = new System.Drawing.Size(20, 20);
            this.bookhistory_btn.Location = new System.Drawing.Point(18, 406);
            this.bookhistory_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bookhistory_btn.Name = "bookhistory_btn";
            this.bookhistory_btn.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.bookhistory_btn.OnHoverBaseColor2 = System.Drawing.Color.SteelBlue;
            this.bookhistory_btn.OnHoverForeColor = System.Drawing.Color.White;
            this.bookhistory_btn.OnHoverImage = null;
            this.bookhistory_btn.OnPressedColor = System.Drawing.Color.Black;
            this.bookhistory_btn.Radius = 10;
            this.bookhistory_btn.Size = new System.Drawing.Size(386, 65);
            this.bookhistory_btn.TabIndex = 8;
            this.bookhistory_btn.Text = "Bookings";
            this.bookhistory_btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // book_btn
            // 
            this.book_btn.AnimationHoverSpeed = 0.07F;
            this.book_btn.AnimationSpeed = 0.03F;
            this.book_btn.BaseColor1 = System.Drawing.Color.White;
            this.book_btn.BaseColor2 = System.Drawing.Color.White;
            this.book_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.book_btn.ForeColor = System.Drawing.Color.Black;
            this.book_btn.Image = ((System.Drawing.Image)(resources.GetObject("book_btn.Image")));
            this.book_btn.ImageSize = new System.Drawing.Size(20, 20);
            this.book_btn.Location = new System.Drawing.Point(18, 311);
            this.book_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.book_btn.Name = "book_btn";
            this.book_btn.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.book_btn.OnHoverBaseColor2 = System.Drawing.Color.SteelBlue;
            this.book_btn.OnHoverForeColor = System.Drawing.Color.White;
            this.book_btn.OnHoverImage = null;
            this.book_btn.OnPressedColor = System.Drawing.Color.Black;
            this.book_btn.Radius = 10;
            this.book_btn.Size = new System.Drawing.Size(386, 65);
            this.book_btn.TabIndex = 7;
            this.book_btn.Text = "Book";
            this.book_btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // home_btn
            // 
            this.home_btn.AnimationHoverSpeed = 0.07F;
            this.home_btn.AnimationSpeed = 0.03F;
            this.home_btn.BaseColor1 = System.Drawing.Color.White;
            this.home_btn.BaseColor2 = System.Drawing.Color.White;
            this.home_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.home_btn.ForeColor = System.Drawing.Color.Black;
            this.home_btn.Image = ((System.Drawing.Image)(resources.GetObject("home_btn.Image")));
            this.home_btn.ImageSize = new System.Drawing.Size(20, 20);
            this.home_btn.Location = new System.Drawing.Point(18, 203);
            this.home_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.home_btn.Name = "home_btn";
            this.home_btn.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.home_btn.OnHoverBaseColor2 = System.Drawing.Color.SteelBlue;
            this.home_btn.OnHoverForeColor = System.Drawing.Color.White;
            this.home_btn.OnHoverImage = null;
            this.home_btn.OnPressedColor = System.Drawing.Color.White;
            this.home_btn.Radius = 10;
            this.home_btn.Size = new System.Drawing.Size(386, 77);
            this.home_btn.TabIndex = 6;
            this.home_btn.Text = "Dashboard";
            this.home_btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.home_btn.Click += new System.EventHandler(this.home_btn_Click);
            // 
            // gunaSeparator1
            // 
            this.gunaSeparator1.LineColor = System.Drawing.Color.Silver;
            this.gunaSeparator1.Location = new System.Drawing.Point(0, 158);
            this.gunaSeparator1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gunaSeparator1.Name = "gunaSeparator1";
            this.gunaSeparator1.Size = new System.Drawing.Size(375, 15);
            this.gunaSeparator1.TabIndex = 3;
            // 
            // current_user
            // 
            this.current_user.AutoSize = true;
            this.current_user.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.current_user.ForeColor = System.Drawing.Color.White;
            this.current_user.Location = new System.Drawing.Point(177, 86);
            this.current_user.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.current_user.Name = "current_user";
            this.current_user.Size = new System.Drawing.Size(168, 38);
            this.current_user.TabIndex = 2;
            this.current_user.Text = "gunaLabel2";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe Script", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLabel1.Location = new System.Drawing.Point(206, 35);
            this.gunaLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(91, 33);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "Admin";
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = global::Booking.Properties.Resources.kisspng_computer_icons_user_profile_person_5abd85306ff7f7_0592226715223698404586;
            this.gunaPictureBox1.Location = new System.Drawing.Point(34, 45);
            this.gunaPictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(99, 95);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 0;
            this.gunaPictureBox1.TabStop = false;
            // 
            // gunaCirclePictureBox1
            // 
            this.gunaCirclePictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaCirclePictureBox1.Image = global::Booking.Properties.Resources.TicketEase;
            this.gunaCirclePictureBox1.Location = new System.Drawing.Point(1701, 855);
            this.gunaCirclePictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gunaCirclePictureBox1.Name = "gunaCirclePictureBox1";
            this.gunaCirclePictureBox1.Size = new System.Drawing.Size(180, 162);
            this.gunaCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaCirclePictureBox1.TabIndex = 18;
            this.gunaCirclePictureBox1.TabStop = false;
            this.gunaCirclePictureBox1.UseTransfarantBackground = false;
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
            // UserHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(236)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(1882, 1012);
            this.Controls.Add(this.dashboardMain_panel);
            this.Controls.Add(this.gunaCirclePictureBox1);
            this.Controls.Add(this.gunaPanel2);
            this.Controls.Add(this.gunaPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UserHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserHome";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.UserHome_Load);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel2.ResumeLayout(false);
            this.gunaPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).EndInit();
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
        private Guna.UI.WinForms.GunaGradiantButton bookhistory_btn;
        private System.Windows.Forms.Button minimize_btn;
        private Guna.UI.WinForms.GunaGradiantButton logout_btn;
        private System.Windows.Forms.Button exit_btn;
        private Guna.UI.WinForms.GunaPanel dashboardMain_panel;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI.WinForms.GunaCirclePictureBox gunaCirclePictureBox1;
        private Guna.UI.WinForms.GunaGradiantButton home_btn;
    }
}