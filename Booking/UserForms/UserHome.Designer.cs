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
            this.dashboardMain_panel = new Guna.UI.WinForms.GunaPanel();
            this.exit_btn = new System.Windows.Forms.Button();
            this.minimize_btn = new System.Windows.Forms.Button();
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.logout_btn = new Guna.UI.WinForms.GunaGradiantButton();
            this.bookhistory_btn = new Guna.UI.WinForms.GunaGradiantButton();
            this.book_btn = new Guna.UI.WinForms.GunaGradiantButton();
            this.home_btn = new Guna.UI.WinForms.GunaGradiantButton();
            this.gunaSeparator1 = new Guna.UI.WinForms.GunaSeparator();
            this.current_user = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.gunaSeparator2 = new Guna.UI.WinForms.GunaSeparator();
            this.daily_sale = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.booking_number = new Guna.UI.WinForms.GunaLabel();
            this.gunaSeparator3 = new Guna.UI.WinForms.GunaSeparator();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaElipsePanel1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gunaElipsePanel2 = new Guna.UI.WinForms.GunaElipsePanel();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.gunaElipsePanel3 = new Guna.UI.WinForms.GunaElipsePanel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaElipsePanel4 = new Guna.UI.WinForms.GunaElipsePanel();
            this.oceanjet_avail = new System.Windows.Forms.Label();
            this.gunaTransfarantPictureBox1 = new Guna.UI.WinForms.GunaTransfarantPictureBox();
            this.gunaElipsePanel5 = new Guna.UI.WinForms.GunaElipsePanel();
            this.gunaTransfarantPictureBox2 = new Guna.UI.WinForms.GunaTransfarantPictureBox();
            this.seacat_avail = new System.Windows.Forms.Label();
            this.gunaElipsePanel6 = new Guna.UI.WinForms.GunaElipsePanel();
            this.gunaTransfarantPictureBox3 = new Guna.UI.WinForms.GunaTransfarantPictureBox();
            this.supercat_avail = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.gunaPanel1.SuspendLayout();
            this.gunaPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.gunaElipsePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gunaElipsePanel2.SuspendLayout();
            this.gunaElipsePanel3.SuspendLayout();
            this.gunaElipsePanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaTransfarantPictureBox1)).BeginInit();
            this.gunaElipsePanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaTransfarantPictureBox2)).BeginInit();
            this.gunaElipsePanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaTransfarantPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.LightGray;
            this.gunaPanel1.Controls.Add(this.dashboardMain_panel);
            this.gunaPanel1.Controls.Add(this.exit_btn);
            this.gunaPanel1.Controls.Add(this.minimize_btn);
            this.gunaPanel1.Location = new System.Drawing.Point(1, 1);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(1409, 47);
            this.gunaPanel1.TabIndex = 0;
            // 
            // dashboardMain_panel
            // 
            this.dashboardMain_panel.Location = new System.Drawing.Point(257, 56);
            this.dashboardMain_panel.Name = "dashboardMain_panel";
            this.dashboardMain_panel.Size = new System.Drawing.Size(897, 581);
            this.dashboardMain_panel.TabIndex = 2;
            // 
            // exit_btn
            // 
            this.exit_btn.FlatAppearance.BorderSize = 0;
            this.exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_btn.Location = new System.Drawing.Point(935, 0);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(71, 44);
            this.exit_btn.TabIndex = 5;
            this.exit_btn.Text = "X";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // minimize_btn
            // 
            this.minimize_btn.FlatAppearance.BorderSize = 0;
            this.minimize_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimize_btn.Location = new System.Drawing.Point(858, 0);
            this.minimize_btn.Name = "minimize_btn";
            this.minimize_btn.Size = new System.Drawing.Size(71, 44);
            this.minimize_btn.TabIndex = 4;
            this.minimize_btn.Text = "--------";
            this.minimize_btn.UseVisualStyleBackColor = true;
            this.minimize_btn.Click += new System.EventHandler(this.minimize_btn_Click);
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
            this.gunaPanel2.Size = new System.Drawing.Size(251, 683);
            this.gunaPanel2.TabIndex = 1;
            // 
            // logout_btn
            // 
            this.logout_btn.AnimationHoverSpeed = 0.07F;
            this.logout_btn.AnimationSpeed = 0.03F;
            this.logout_btn.BaseColor1 = System.Drawing.Color.Teal;
            this.logout_btn.BaseColor2 = System.Drawing.Color.White;
            this.logout_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.logout_btn.ForeColor = System.Drawing.Color.Black;
            this.logout_btn.Image = ((System.Drawing.Image)(resources.GetObject("logout_btn.Image")));
            this.logout_btn.ImageSize = new System.Drawing.Size(20, 20);
            this.logout_btn.Location = new System.Drawing.Point(12, 560);
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
            // bookhistory_btn
            // 
            this.bookhistory_btn.AnimationHoverSpeed = 0.07F;
            this.bookhistory_btn.AnimationSpeed = 0.03F;
            this.bookhistory_btn.BaseColor1 = System.Drawing.Color.MediumTurquoise;
            this.bookhistory_btn.BaseColor2 = System.Drawing.Color.White;
            this.bookhistory_btn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookhistory_btn.ForeColor = System.Drawing.Color.Black;
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
            this.bookhistory_btn.Text = "Bookings";
            this.bookhistory_btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // book_btn
            // 
            this.book_btn.AnimationHoverSpeed = 0.07F;
            this.book_btn.AnimationSpeed = 0.03F;
            this.book_btn.BaseColor1 = System.Drawing.Color.DarkTurquoise;
            this.book_btn.BaseColor2 = System.Drawing.Color.White;
            this.book_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.book_btn.ForeColor = System.Drawing.Color.Black;
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
            this.home_btn.BaseColor1 = System.Drawing.Color.LightSeaGreen;
            this.home_btn.BaseColor2 = System.Drawing.Color.White;
            this.home_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.home_btn.ForeColor = System.Drawing.Color.Black;
            this.home_btn.Image = ((System.Drawing.Image)(resources.GetObject("home_btn.Image")));
            this.home_btn.ImageSize = new System.Drawing.Size(20, 20);
            this.home_btn.Location = new System.Drawing.Point(12, 132);
            this.home_btn.Name = "home_btn";
            this.home_btn.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.home_btn.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.home_btn.OnHoverForeColor = System.Drawing.Color.Black;
            this.home_btn.OnHoverImage = null;
            this.home_btn.OnPressedColor = System.Drawing.Color.Black;
            this.home_btn.Radius = 10;
            this.home_btn.Size = new System.Drawing.Size(221, 50);
            this.home_btn.TabIndex = 6;
            this.home_btn.Text = "Dashboard";
            this.home_btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.home_btn.Click += new System.EventHandler(this.home_btn_Click);
            // 
            // gunaSeparator1
            // 
            this.gunaSeparator1.LineColor = System.Drawing.Color.Silver;
            this.gunaSeparator1.Location = new System.Drawing.Point(0, 103);
            this.gunaSeparator1.Name = "gunaSeparator1";
            this.gunaSeparator1.Size = new System.Drawing.Size(250, 10);
            this.gunaSeparator1.TabIndex = 3;
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
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe Script", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(137, 23);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(91, 33);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "Admin";
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
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // gunaSeparator2
            // 
            this.gunaSeparator2.LineColor = System.Drawing.Color.Silver;
            this.gunaSeparator2.Location = new System.Drawing.Point(0, 62);
            this.gunaSeparator2.Name = "gunaSeparator2";
            this.gunaSeparator2.Size = new System.Drawing.Size(306, 10);
            this.gunaSeparator2.TabIndex = 3;
            // 
            // daily_sale
            // 
            this.daily_sale.AutoSize = true;
            this.daily_sale.BackColor = System.Drawing.Color.White;
            this.daily_sale.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.daily_sale.ForeColor = System.Drawing.Color.DimGray;
            this.daily_sale.Location = new System.Drawing.Point(72, 98);
            this.daily_sale.Name = "daily_sale";
            this.daily_sale.Size = new System.Drawing.Size(422, 82);
            this.daily_sale.TabIndex = 1;
            this.daily_sale.Text = "gunaLabel3";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.BackColor = System.Drawing.Color.White;
            this.gunaLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(65, 20);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(198, 32);
            this.gunaLabel2.TabIndex = 0;
            this.gunaLabel2.Text = "Todays Sales";
            // 
            // booking_number
            // 
            this.booking_number.AutoSize = true;
            this.booking_number.BackColor = System.Drawing.Color.White;
            this.booking_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.booking_number.ForeColor = System.Drawing.Color.DimGray;
            this.booking_number.Location = new System.Drawing.Point(94, 98);
            this.booking_number.Name = "booking_number";
            this.booking_number.Size = new System.Drawing.Size(422, 82);
            this.booking_number.TabIndex = 1;
            this.booking_number.Text = "gunaLabel3";
            // 
            // gunaSeparator3
            // 
            this.gunaSeparator3.LineColor = System.Drawing.Color.Silver;
            this.gunaSeparator3.Location = new System.Drawing.Point(-3, 65);
            this.gunaSeparator3.Name = "gunaSeparator3";
            this.gunaSeparator3.Size = new System.Drawing.Size(306, 10);
            this.gunaSeparator3.TabIndex = 3;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.BackColor = System.Drawing.Color.White;
            this.gunaLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.Location = new System.Drawing.Point(42, 20);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(288, 32);
            this.gunaLabel4.TabIndex = 0;
            this.gunaLabel4.Text = "Number of Bookings";
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.BaseColor = System.Drawing.Color.White;
            this.gunaElipsePanel1.Controls.Add(this.gunaSeparator2);
            this.gunaElipsePanel1.Controls.Add(this.daily_sale);
            this.gunaElipsePanel1.Controls.Add(this.gunaLabel2);
            this.gunaElipsePanel1.Controls.Add(this.pictureBox1);
            this.gunaElipsePanel1.Location = new System.Drawing.Point(294, 78);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Size = new System.Drawing.Size(266, 180);
            this.gunaElipsePanel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::Booking.Properties.Resources.currency_peso_226x256;
            this.pictureBox1.Location = new System.Drawing.Point(16, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // gunaElipsePanel2
            // 
            this.gunaElipsePanel2.BaseColor = System.Drawing.Color.White;
            this.gunaElipsePanel2.Controls.Add(this.booking_number);
            this.gunaElipsePanel2.Controls.Add(this.gunaSeparator3);
            this.gunaElipsePanel2.Controls.Add(this.gunaLabel4);
            this.gunaElipsePanel2.Location = new System.Drawing.Point(291, 281);
            this.gunaElipsePanel2.Name = "gunaElipsePanel2";
            this.gunaElipsePanel2.Size = new System.Drawing.Size(266, 180);
            this.gunaElipsePanel2.TabIndex = 4;
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
            // gunaElipsePanel3
            // 
            this.gunaElipsePanel3.BaseColor = System.Drawing.Color.White;
            this.gunaElipsePanel3.Controls.Add(this.gunaLabel3);
            this.gunaElipsePanel3.Location = new System.Drawing.Point(606, 80);
            this.gunaElipsePanel3.Name = "gunaElipsePanel3";
            this.gunaElipsePanel3.Radius = 10;
            this.gunaElipsePanel3.Size = new System.Drawing.Size(348, 61);
            this.gunaElipsePanel3.TabIndex = 6;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.BackColor = System.Drawing.Color.White;
            this.gunaLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(12, 12);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(457, 32);
            this.gunaLabel3.TabIndex = 4;
            this.gunaLabel3.Text = "Number of Available Trips Today";
            // 
            // gunaElipsePanel4
            // 
            this.gunaElipsePanel4.BaseColor = System.Drawing.Color.White;
            this.gunaElipsePanel4.Controls.Add(this.gunaTransfarantPictureBox1);
            this.gunaElipsePanel4.Controls.Add(this.oceanjet_avail);
            this.gunaElipsePanel4.Location = new System.Drawing.Point(606, 237);
            this.gunaElipsePanel4.Name = "gunaElipsePanel4";
            this.gunaElipsePanel4.Radius = 10;
            this.gunaElipsePanel4.Size = new System.Drawing.Size(348, 61);
            this.gunaElipsePanel4.TabIndex = 7;
            // 
            // oceanjet_avail
            // 
            this.oceanjet_avail.AutoSize = true;
            this.oceanjet_avail.BackColor = System.Drawing.Color.White;
            this.oceanjet_avail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oceanjet_avail.ForeColor = System.Drawing.Color.DimGray;
            this.oceanjet_avail.Location = new System.Drawing.Point(210, 15);
            this.oceanjet_avail.Name = "oceanjet_avail";
            this.oceanjet_avail.Size = new System.Drawing.Size(98, 32);
            this.oceanjet_avail.TabIndex = 0;
            this.oceanjet_avail.Text = "label1";
            // 
            // gunaTransfarantPictureBox1
            // 
            this.gunaTransfarantPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaTransfarantPictureBox1.BaseColor = System.Drawing.Color.Black;
            this.gunaTransfarantPictureBox1.Image = global::Booking.Properties.Resources.oceanjet;
            this.gunaTransfarantPictureBox1.Location = new System.Drawing.Point(18, 15);
            this.gunaTransfarantPictureBox1.Name = "gunaTransfarantPictureBox1";
            this.gunaTransfarantPictureBox1.Size = new System.Drawing.Size(120, 31);
            this.gunaTransfarantPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaTransfarantPictureBox1.TabIndex = 1;
            this.gunaTransfarantPictureBox1.TabStop = false;
            // 
            // gunaElipsePanel5
            // 
            this.gunaElipsePanel5.BaseColor = System.Drawing.Color.White;
            this.gunaElipsePanel5.Controls.Add(this.gunaTransfarantPictureBox2);
            this.gunaElipsePanel5.Controls.Add(this.seacat_avail);
            this.gunaElipsePanel5.Location = new System.Drawing.Point(606, 161);
            this.gunaElipsePanel5.Name = "gunaElipsePanel5";
            this.gunaElipsePanel5.Radius = 10;
            this.gunaElipsePanel5.Size = new System.Drawing.Size(348, 61);
            this.gunaElipsePanel5.TabIndex = 8;
            // 
            // gunaTransfarantPictureBox2
            // 
            this.gunaTransfarantPictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.gunaTransfarantPictureBox2.BaseColor = System.Drawing.Color.Black;
            this.gunaTransfarantPictureBox2.Image = global::Booking.Properties.Resources.seacat;
            this.gunaTransfarantPictureBox2.Location = new System.Drawing.Point(18, 12);
            this.gunaTransfarantPictureBox2.Name = "gunaTransfarantPictureBox2";
            this.gunaTransfarantPictureBox2.Size = new System.Drawing.Size(120, 35);
            this.gunaTransfarantPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaTransfarantPictureBox2.TabIndex = 1;
            this.gunaTransfarantPictureBox2.TabStop = false;
            // 
            // seacat_avail
            // 
            this.seacat_avail.AutoSize = true;
            this.seacat_avail.BackColor = System.Drawing.Color.White;
            this.seacat_avail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seacat_avail.ForeColor = System.Drawing.Color.DimGray;
            this.seacat_avail.Location = new System.Drawing.Point(210, 15);
            this.seacat_avail.Name = "seacat_avail";
            this.seacat_avail.Size = new System.Drawing.Size(98, 32);
            this.seacat_avail.TabIndex = 0;
            this.seacat_avail.Text = "label1";
            // 
            // gunaElipsePanel6
            // 
            this.gunaElipsePanel6.BaseColor = System.Drawing.Color.White;
            this.gunaElipsePanel6.Controls.Add(this.gunaTransfarantPictureBox3);
            this.gunaElipsePanel6.Controls.Add(this.supercat_avail);
            this.gunaElipsePanel6.Location = new System.Drawing.Point(606, 315);
            this.gunaElipsePanel6.Name = "gunaElipsePanel6";
            this.gunaElipsePanel6.Radius = 10;
            this.gunaElipsePanel6.Size = new System.Drawing.Size(348, 61);
            this.gunaElipsePanel6.TabIndex = 9;
            // 
            // gunaTransfarantPictureBox3
            // 
            this.gunaTransfarantPictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.gunaTransfarantPictureBox3.BaseColor = System.Drawing.Color.Black;
            this.gunaTransfarantPictureBox3.Image = global::Booking.Properties.Resources.supercat;
            this.gunaTransfarantPictureBox3.Location = new System.Drawing.Point(18, 13);
            this.gunaTransfarantPictureBox3.Name = "gunaTransfarantPictureBox3";
            this.gunaTransfarantPictureBox3.Size = new System.Drawing.Size(120, 32);
            this.gunaTransfarantPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaTransfarantPictureBox3.TabIndex = 1;
            this.gunaTransfarantPictureBox3.TabStop = false;
            // 
            // supercat_avail
            // 
            this.supercat_avail.AutoSize = true;
            this.supercat_avail.BackColor = System.Drawing.Color.White;
            this.supercat_avail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supercat_avail.ForeColor = System.Drawing.Color.DimGray;
            this.supercat_avail.Location = new System.Drawing.Point(210, 13);
            this.supercat_avail.Name = "supercat_avail";
            this.supercat_avail.Size = new System.Drawing.Size(98, 32);
            this.supercat_avail.TabIndex = 0;
            this.supercat_avail.Text = "label1";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Image = global::Booking.Properties.Resources._1523;
            this.pictureBox3.Location = new System.Drawing.Point(240, 519);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(767, 133);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            // 
            // UserHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(236)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.gunaElipsePanel6);
            this.Controls.Add(this.gunaElipsePanel5);
            this.Controls.Add(this.gunaElipsePanel4);
            this.Controls.Add(this.gunaElipsePanel3);
            this.Controls.Add(this.gunaElipsePanel2);
            this.Controls.Add(this.gunaElipsePanel1);
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
            this.gunaElipsePanel1.ResumeLayout(false);
            this.gunaElipsePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gunaElipsePanel2.ResumeLayout(false);
            this.gunaElipsePanel2.PerformLayout();
            this.gunaElipsePanel3.ResumeLayout(false);
            this.gunaElipsePanel3.PerformLayout();
            this.gunaElipsePanel4.ResumeLayout(false);
            this.gunaElipsePanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaTransfarantPictureBox1)).EndInit();
            this.gunaElipsePanel5.ResumeLayout(false);
            this.gunaElipsePanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaTransfarantPictureBox2)).EndInit();
            this.gunaElipsePanel6.ResumeLayout(false);
            this.gunaElipsePanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaTransfarantPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
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
        private Guna.UI.WinForms.GunaGradiantButton logout_btn;
        private System.Windows.Forms.Button exit_btn;
        private Guna.UI.WinForms.GunaPanel dashboardMain_panel;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaLabel daily_sale;
        private Guna.UI.WinForms.GunaSeparator gunaSeparator2;
        private Guna.UI.WinForms.GunaLabel booking_number;
        private Guna.UI.WinForms.GunaSeparator gunaSeparator3;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel2;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel4;
        private Guna.UI.WinForms.GunaTransfarantPictureBox gunaTransfarantPictureBox1;
        private System.Windows.Forms.Label oceanjet_avail;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel5;
        private Guna.UI.WinForms.GunaTransfarantPictureBox gunaTransfarantPictureBox2;
        private System.Windows.Forms.Label seacat_avail;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel6;
        private Guna.UI.WinForms.GunaTransfarantPictureBox gunaTransfarantPictureBox3;
        private System.Windows.Forms.Label supercat_avail;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}