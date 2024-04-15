namespace Booking.usercontrol
{
    partial class bookingHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bookingHistory));
            this.gunaElipsePanel1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.boatName_comboBox = new System.Windows.Forms.ComboBox();
            this.searchBooking_btn = new Guna.UI.WinForms.GunaButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gunaElipsePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.BaseColor = System.Drawing.Color.White;
            this.gunaElipsePanel1.Controls.Add(this.searchBooking_btn);
            this.gunaElipsePanel1.Controls.Add(this.boatName_comboBox);
            this.gunaElipsePanel1.Controls.Add(this.dateTimePicker1);
            this.gunaElipsePanel1.Controls.Add(this.label2);
            this.gunaElipsePanel1.Controls.Add(this.label1);
            this.gunaElipsePanel1.Location = new System.Drawing.Point(117, 22);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Size = new System.Drawing.Size(1241, 100);
            this.gunaElipsePanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(63, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select departure date : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(601, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vessel Name : ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(235, 32);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(303, 26);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // boatName_comboBox
            // 
            this.boatName_comboBox.FormattingEnabled = true;
            this.boatName_comboBox.Location = new System.Drawing.Point(722, 29);
            this.boatName_comboBox.Name = "boatName_comboBox";
            this.boatName_comboBox.Size = new System.Drawing.Size(186, 28);
            this.boatName_comboBox.TabIndex = 3;
            // 
            // searchBooking_btn
            // 
            this.searchBooking_btn.AnimationHoverSpeed = 0.07F;
            this.searchBooking_btn.AnimationSpeed = 0.03F;
            this.searchBooking_btn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.searchBooking_btn.BorderColor = System.Drawing.Color.Black;
            this.searchBooking_btn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBooking_btn.ForeColor = System.Drawing.Color.White;
            this.searchBooking_btn.Image = ((System.Drawing.Image)(resources.GetObject("searchBooking_btn.Image")));
            this.searchBooking_btn.ImageOffsetX = 5;
            this.searchBooking_btn.ImageSize = new System.Drawing.Size(20, 20);
            this.searchBooking_btn.Location = new System.Drawing.Point(934, 18);
            this.searchBooking_btn.Name = "searchBooking_btn";
            this.searchBooking_btn.OnHoverBaseColor = System.Drawing.Color.SlateGray;
            this.searchBooking_btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.searchBooking_btn.OnHoverForeColor = System.Drawing.Color.White;
            this.searchBooking_btn.OnHoverImage = null;
            this.searchBooking_btn.OnPressedColor = System.Drawing.Color.Black;
            this.searchBooking_btn.Size = new System.Drawing.Size(241, 53);
            this.searchBooking_btn.TabIndex = 4;
            this.searchBooking_btn.Text = "Search Bookings";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(117, 168);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1257, 771);
            this.panel1.TabIndex = 1;
            // 
            // bookingHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(236)))), ((int)(((byte)(247)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gunaElipsePanel1);
            this.Name = "bookingHistory";
            this.Size = new System.Drawing.Size(1463, 942);
            this.Load += new System.EventHandler(this.bookingHistory_Load);
            this.gunaElipsePanel1.ResumeLayout(false);
            this.gunaElipsePanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaButton searchBooking_btn;
        private System.Windows.Forms.ComboBox boatName_comboBox;
        private System.Windows.Forms.Panel panel1;
    }
}
