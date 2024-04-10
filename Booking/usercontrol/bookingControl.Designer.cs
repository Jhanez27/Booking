namespace Booking.usercontrol
{
    partial class bookingControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bookingControl));
            this.panel1 = new System.Windows.Forms.Panel();
            this.search_btn = new Guna.UI.WinForms.GunaButton();
            this.departure_datePicker = new System.Windows.Forms.DateTimePicker();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.destination_combo = new System.Windows.Forms.ComboBox();
            this.origin_combo = new System.Windows.Forms.ComboBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.tripPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.search_btn);
            this.panel1.Controls.Add(this.departure_datePicker);
            this.panel1.Controls.Add(this.gunaLabel3);
            this.panel1.Controls.Add(this.gunaLabel2);
            this.panel1.Controls.Add(this.destination_combo);
            this.panel1.Controls.Add(this.origin_combo);
            this.panel1.Controls.Add(this.gunaLabel1);
            this.panel1.Location = new System.Drawing.Point(33, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1411, 120);
            this.panel1.TabIndex = 0;
            // 
            // search_btn
            // 
            this.search_btn.AnimationHoverSpeed = 0.07F;
            this.search_btn.AnimationSpeed = 0.03F;
            this.search_btn.BackColor = System.Drawing.Color.Silver;
            this.search_btn.BaseColor = System.Drawing.Color.Gainsboro;
            this.search_btn.BorderColor = System.Drawing.Color.Gainsboro;
            this.search_btn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_btn.ForeColor = System.Drawing.Color.Black;
            this.search_btn.Image = ((System.Drawing.Image)(resources.GetObject("search_btn.Image")));
            this.search_btn.ImageSize = new System.Drawing.Size(10, 10);
            this.search_btn.Location = new System.Drawing.Point(1257, 29);
            this.search_btn.Name = "search_btn";
            this.search_btn.OnHoverBaseColor = System.Drawing.Color.LightSkyBlue;
            this.search_btn.OnHoverBorderColor = System.Drawing.Color.LightSkyBlue;
            this.search_btn.OnHoverForeColor = System.Drawing.Color.Black;
            this.search_btn.OnHoverImage = null;
            this.search_btn.OnPressedColor = System.Drawing.Color.Black;
            this.search_btn.Size = new System.Drawing.Size(137, 56);
            this.search_btn.TabIndex = 6;
            this.search_btn.Text = "  Search";
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // departure_datePicker
            // 
            this.departure_datePicker.Location = new System.Drawing.Point(916, 43);
            this.departure_datePicker.Name = "departure_datePicker";
            this.departure_datePicker.Size = new System.Drawing.Size(310, 26);
            this.departure_datePicker.TabIndex = 5;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.BackColor = System.Drawing.Color.White;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(744, 45);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(166, 29);
            this.gunaLabel3.TabIndex = 4;
            this.gunaLabel3.Text = "DEPARTURE DATE: ";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.BackColor = System.Drawing.Color.White;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(413, 45);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(52, 25);
            this.gunaLabel2.TabIndex = 3;
            this.gunaLabel2.Text = "TO : ";
            // 
            // destination_combo
            // 
            this.destination_combo.FormattingEnabled = true;
            this.destination_combo.Location = new System.Drawing.Point(471, 43);
            this.destination_combo.Name = "destination_combo";
            this.destination_combo.Size = new System.Drawing.Size(247, 28);
            this.destination_combo.TabIndex = 2;
            // 
            // origin_combo
            // 
            this.origin_combo.FormattingEnabled = true;
            this.origin_combo.Location = new System.Drawing.Point(108, 46);
            this.origin_combo.Name = "origin_combo";
            this.origin_combo.Size = new System.Drawing.Size(277, 28);
            this.origin_combo.TabIndex = 1;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.BackColor = System.Drawing.Color.White;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(16, 43);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(84, 28);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "FROM : ";
            // 
            // tripPanel
            // 
            this.tripPanel.AutoScroll = true;
            this.tripPanel.Location = new System.Drawing.Point(33, 188);
            this.tripPanel.Name = "tripPanel";
            this.tripPanel.Size = new System.Drawing.Size(1411, 734);
            this.tripPanel.TabIndex = 1;
            // 
            // bookingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(236)))), ((int)(((byte)(247)))));
            this.Controls.Add(this.tripPanel);
            this.Controls.Add(this.panel1);
            this.Name = "bookingControl";
            this.Size = new System.Drawing.Size(1463, 942);
            this.Load += new System.EventHandler(this.bookingControl_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private System.Windows.Forms.ComboBox destination_combo;
        private System.Windows.Forms.ComboBox origin_combo;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private System.Windows.Forms.DateTimePicker departure_datePicker;
        private Guna.UI.WinForms.GunaButton search_btn;
        private System.Windows.Forms.FlowLayoutPanel tripPanel;
    }
}
