namespace Booking.usercontrol
{
    partial class tripDetails
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
            this.icon = new System.Windows.Forms.PictureBox();
            this.boat_name = new System.Windows.Forms.Label();
            this.origin_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.destination_label = new System.Windows.Forms.Label();
            this.depart_time = new System.Windows.Forms.Label();
            this.tripId_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.shippingLine = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            this.SuspendLayout();
            // 
            // icon
            // 
            this.icon.Location = new System.Drawing.Point(184, 21);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(122, 81);
            this.icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.icon.TabIndex = 0;
            this.icon.TabStop = false;
            // 
            // boat_name
            // 
            this.boat_name.AutoSize = true;
            this.boat_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boat_name.Location = new System.Drawing.Point(397, 36);
            this.boat_name.Name = "boat_name";
            this.boat_name.Size = new System.Drawing.Size(64, 22);
            this.boat_name.TabIndex = 1;
            this.boat_name.Text = "Label1";
            // 
            // origin_label
            // 
            this.origin_label.AutoSize = true;
            this.origin_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.origin_label.Location = new System.Drawing.Point(835, 34);
            this.origin_label.Name = "origin_label";
            this.origin_label.Size = new System.Drawing.Size(64, 22);
            this.origin_label.TabIndex = 2;
            this.origin_label.Text = "Label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(975, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "-";
            // 
            // destination_label
            // 
            this.destination_label.AutoSize = true;
            this.destination_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.destination_label.Location = new System.Drawing.Point(1062, 36);
            this.destination_label.Name = "destination_label";
            this.destination_label.Size = new System.Drawing.Size(64, 22);
            this.destination_label.TabIndex = 4;
            this.destination_label.Text = "Label1";
            // 
            // depart_time
            // 
            this.depart_time.AutoSize = true;
            this.depart_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depart_time.Location = new System.Drawing.Point(635, 34);
            this.depart_time.Name = "depart_time";
            this.depart_time.Size = new System.Drawing.Size(64, 22);
            this.depart_time.TabIndex = 5;
            this.depart_time.Text = "Label1";
            // 
            // tripId_label
            // 
            this.tripId_label.AutoSize = true;
            this.tripId_label.Location = new System.Drawing.Point(835, 82);
            this.tripId_label.Name = "tripId_label";
            this.tripId_label.Size = new System.Drawing.Size(57, 20);
            this.tripId_label.TabIndex = 7;
            this.tripId_label.Text = "Label1";
            this.tripId_label.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(397, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "(3 Hours)";
            // 
            // shippingLine
            // 
            this.shippingLine.AutoSize = true;
            this.shippingLine.Location = new System.Drawing.Point(1069, 82);
            this.shippingLine.Name = "shippingLine";
            this.shippingLine.Size = new System.Drawing.Size(57, 20);
            this.shippingLine.TabIndex = 12;
            this.shippingLine.Text = "Label1";
            this.shippingLine.Visible = false;
            // 
            // tripDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.shippingLine);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tripId_label);
            this.Controls.Add(this.depart_time);
            this.Controls.Add(this.destination_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.origin_label);
            this.Controls.Add(this.boat_name);
            this.Controls.Add(this.icon);
            this.Name = "tripDetails";
            this.Size = new System.Drawing.Size(1411, 120);
            this.Click += new System.EventHandler(this.tripDetails_Click);
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox icon;
        private System.Windows.Forms.Label boat_name;
        private System.Windows.Forms.Label origin_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label destination_label;
        private System.Windows.Forms.Label depart_time;
        private System.Windows.Forms.Label tripId_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label shippingLine;
    }
}
