﻿namespace Booking.usercontrol
{
    partial class passengerDetails
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(passengerDetails));
            this.label1 = new System.Windows.Forms.Label();
            this.tripDetail_panel = new Guna.UI.WinForms.GunaShadowPanel();
            this.shipLogo = new System.Windows.Forms.PictureBox();
            this.boat_name = new System.Windows.Forms.Label();
            this.departure_date = new System.Windows.Forms.Label();
            this.origin_txt = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.destination_txt = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.accom_price = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.ticket_amount = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.pass_email = new Booking.usercontrol.CustomTextBox();
            this.pass_contactNumber = new Booking.usercontrol.CustomTextBox();
            this.pass_age = new Booking.usercontrol.CustomTextBox();
            this.pass_lname = new Booking.usercontrol.CustomTextBox();
            this.pass_fname = new Booking.usercontrol.CustomTextBox();
            this.tripDetail_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shipLogo)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Passenger Details";
            // 
            // tripDetail_panel
            // 
            this.tripDetail_panel.BackColor = System.Drawing.Color.AliceBlue;
            this.tripDetail_panel.BaseColor = System.Drawing.Color.LightSteelBlue;
            this.tripDetail_panel.Controls.Add(this.destination_txt);
            this.tripDetail_panel.Controls.Add(this.label3);
            this.tripDetail_panel.Controls.Add(this.origin_txt);
            this.tripDetail_panel.Controls.Add(this.departure_date);
            this.tripDetail_panel.Controls.Add(this.boat_name);
            this.tripDetail_panel.Controls.Add(this.shipLogo);
            this.tripDetail_panel.Location = new System.Drawing.Point(226, 3);
            this.tripDetail_panel.Name = "tripDetail_panel";
            this.tripDetail_panel.ShadowColor = System.Drawing.Color.LightSteelBlue;
            this.tripDetail_panel.ShadowShift = 15;
            this.tripDetail_panel.ShadowStyle = Guna.UI.WinForms.ShadowMode.ForwardDiagonal;
            this.tripDetail_panel.Size = new System.Drawing.Size(1038, 172);
            this.tripDetail_panel.TabIndex = 1;
            // 
            // shipLogo
            // 
            this.shipLogo.BackColor = System.Drawing.Color.LightSteelBlue;
            this.shipLogo.Location = new System.Drawing.Point(71, 39);
            this.shipLogo.Name = "shipLogo";
            this.shipLogo.Size = new System.Drawing.Size(100, 52);
            this.shipLogo.TabIndex = 0;
            this.shipLogo.TabStop = false;
            // 
            // boat_name
            // 
            this.boat_name.AutoSize = true;
            this.boat_name.BackColor = System.Drawing.Color.LightSteelBlue;
            this.boat_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boat_name.Location = new System.Drawing.Point(224, 58);
            this.boat_name.Name = "boat_name";
            this.boat_name.Size = new System.Drawing.Size(58, 22);
            this.boat_name.TabIndex = 1;
            this.boat_name.Text = "label2";
            // 
            // departure_date
            // 
            this.departure_date.AutoSize = true;
            this.departure_date.BackColor = System.Drawing.Color.LightSteelBlue;
            this.departure_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departure_date.Location = new System.Drawing.Point(423, 58);
            this.departure_date.Name = "departure_date";
            this.departure_date.Size = new System.Drawing.Size(58, 22);
            this.departure_date.TabIndex = 2;
            this.departure_date.Text = "label3";
            // 
            // origin_txt
            // 
            this.origin_txt.AutoSize = true;
            this.origin_txt.BackColor = System.Drawing.Color.LightSteelBlue;
            this.origin_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.origin_txt.Location = new System.Drawing.Point(793, 58);
            this.origin_txt.Name = "origin_txt";
            this.origin_txt.Size = new System.Drawing.Size(58, 22);
            this.origin_txt.TabIndex = 3;
            this.origin_txt.Text = "label3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(889, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "-";
            // 
            // destination_txt
            // 
            this.destination_txt.AutoSize = true;
            this.destination_txt.BackColor = System.Drawing.Color.LightSteelBlue;
            this.destination_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.destination_txt.Location = new System.Drawing.Point(931, 58);
            this.destination_txt.Name = "destination_txt";
            this.destination_txt.Size = new System.Drawing.Size(58, 22);
            this.destination_txt.TabIndex = 4;
            this.destination_txt.Text = "label3";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.ticket_amount);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.accom_price);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.pass_email);
            this.panel1.Controls.Add(this.pass_contactNumber);
            this.panel1.Controls.Add(this.pass_age);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.pass_lname);
            this.panel1.Controls.Add(this.pass_fname);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(322, 280);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(810, 584);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(584, 199);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(309, 51);
            this.panel2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "First Name : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Last Name : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Age : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Contact Number : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(56, 294);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Email Address : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(57, 363);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Accommodation : ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(214, 355);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(292, 28);
            this.comboBox1.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(521, 358);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 20);
            this.label9.TabIndex = 12;
            this.label9.Text = "Price :  ";
            // 
            // accom_price
            // 
            this.accom_price.AutoSize = true;
            this.accom_price.Location = new System.Drawing.Point(612, 358);
            this.accom_price.Name = "accom_price";
            this.accom_price.Size = new System.Drawing.Size(60, 20);
            this.accom_price.TabIndex = 13;
            this.accom_price.Text = "label10";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(65, 426);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 20);
            this.label10.TabIndex = 14;
            this.label10.Text = "Discount Type";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(215, 423);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(295, 28);
            this.comboBox2.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(186, 481);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 20);
            this.label11.TabIndex = 16;
            this.label11.Text = "Net Payment: ";
            // 
            // ticket_amount
            // 
            this.ticket_amount.AutoSize = true;
            this.ticket_amount.Location = new System.Drawing.Point(314, 481);
            this.ticket_amount.Name = "ticket_amount";
            this.ticket_amount.Size = new System.Drawing.Size(60, 20);
            this.ticket_amount.TabIndex = 17;
            this.ticket_amount.Text = "label12";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(139, 539);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(495, 20);
            this.label12.TabIndex = 18;
            this.label12.Text = "(Note : Please make sure all details are correct before pressing Book)";
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BaseColor = System.Drawing.Color.Gray;
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.BorderSize = 1;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton1.Image")));
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(938, 885);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Radius = 10;
            this.gunaButton1.Size = new System.Drawing.Size(160, 52);
            this.gunaButton1.TabIndex = 4;
            this.gunaButton1.Text = "    Book";
            // 
            // pass_email
            // 
            this.pass_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pass_email.BottomBorderColor = System.Drawing.Color.Black;
            this.pass_email.BottomBorderOnFocusColor = System.Drawing.Color.Blue;
            this.pass_email.Location = new System.Drawing.Point(214, 294);
            this.pass_email.Name = "pass_email";
            this.pass_email.Size = new System.Drawing.Size(292, 26);
            this.pass_email.TabIndex = 9;
            // 
            // pass_contactNumber
            // 
            this.pass_contactNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pass_contactNumber.BottomBorderColor = System.Drawing.Color.Black;
            this.pass_contactNumber.BottomBorderOnFocusColor = System.Drawing.Color.Blue;
            this.pass_contactNumber.Location = new System.Drawing.Point(215, 222);
            this.pass_contactNumber.Name = "pass_contactNumber";
            this.pass_contactNumber.Size = new System.Drawing.Size(292, 26);
            this.pass_contactNumber.TabIndex = 8;
            // 
            // pass_age
            // 
            this.pass_age.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pass_age.BottomBorderColor = System.Drawing.Color.Black;
            this.pass_age.BottomBorderOnFocusColor = System.Drawing.Color.Blue;
            this.pass_age.Location = new System.Drawing.Point(214, 162);
            this.pass_age.Name = "pass_age";
            this.pass_age.Size = new System.Drawing.Size(292, 26);
            this.pass_age.TabIndex = 7;
            // 
            // pass_lname
            // 
            this.pass_lname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pass_lname.BottomBorderColor = System.Drawing.Color.Black;
            this.pass_lname.BottomBorderOnFocusColor = System.Drawing.Color.Blue;
            this.pass_lname.Location = new System.Drawing.Point(214, 108);
            this.pass_lname.Name = "pass_lname";
            this.pass_lname.Size = new System.Drawing.Size(292, 26);
            this.pass_lname.TabIndex = 3;
            // 
            // pass_fname
            // 
            this.pass_fname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pass_fname.BottomBorderColor = System.Drawing.Color.Black;
            this.pass_fname.BottomBorderOnFocusColor = System.Drawing.Color.Blue;
            this.pass_fname.Location = new System.Drawing.Point(214, 53);
            this.pass_fname.Name = "pass_fname";
            this.pass_fname.Size = new System.Drawing.Size(294, 26);
            this.pass_fname.TabIndex = 2;
            // 
            // passengerDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(236)))), ((int)(((byte)(247)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.gunaButton1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tripDetail_panel);
            this.Name = "passengerDetails";
            this.Size = new System.Drawing.Size(1448, 960);
            this.tripDetail_panel.ResumeLayout(false);
            this.tripDetail_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shipLogo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaShadowPanel tripDetail_panel;
        private System.Windows.Forms.Label origin_txt;
        private System.Windows.Forms.Label departure_date;
        private System.Windows.Forms.Label boat_name;
        private System.Windows.Forms.PictureBox shipLogo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label destination_txt;
        private System.Windows.Forms.Panel panel1;
        private CustomTextBox pass_lname;
        private CustomTextBox pass_fname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label accom_price;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label8;
        private CustomTextBox pass_email;
        private CustomTextBox pass_contactNumber;
        private CustomTextBox pass_age;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label ticket_amount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label10;
        private Guna.UI.WinForms.GunaButton gunaButton1;
    }
}
