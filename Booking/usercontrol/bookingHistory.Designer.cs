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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaElipsePanel1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.searchBooking_btn = new Guna.UI.WinForms.GunaButton();
            this.boatName_comboBox = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bookingHistoryDataGridView = new System.Windows.Forms.DataGridView();
            this.details_panel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.departureTime_comboBox = new System.Windows.Forms.ComboBox();
            this.gunaElipsePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookingHistoryDataGridView)).BeginInit();
            this.details_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.BaseColor = System.Drawing.Color.White;
            this.gunaElipsePanel1.Controls.Add(this.departureTime_comboBox);
            this.gunaElipsePanel1.Controls.Add(this.label3);
            this.gunaElipsePanel1.Controls.Add(this.searchBooking_btn);
            this.gunaElipsePanel1.Controls.Add(this.boatName_comboBox);
            this.gunaElipsePanel1.Controls.Add(this.dateTimePicker1);
            this.gunaElipsePanel1.Controls.Add(this.label2);
            this.gunaElipsePanel1.Controls.Add(this.label1);
            this.gunaElipsePanel1.Location = new System.Drawing.Point(32, 22);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Size = new System.Drawing.Size(1417, 100);
            this.gunaElipsePanel1.TabIndex = 0;
            // 
            // searchBooking_btn
            // 
            this.searchBooking_btn.AnimationHoverSpeed = 0.07F;
            this.searchBooking_btn.AnimationSpeed = 0.03F;
            this.searchBooking_btn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(171)))));
            this.searchBooking_btn.BorderColor = System.Drawing.Color.Black;
            this.searchBooking_btn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBooking_btn.ForeColor = System.Drawing.Color.White;
            this.searchBooking_btn.Image = ((System.Drawing.Image)(resources.GetObject("searchBooking_btn.Image")));
            this.searchBooking_btn.ImageOffsetX = 5;
            this.searchBooking_btn.ImageSize = new System.Drawing.Size(20, 20);
            this.searchBooking_btn.Location = new System.Drawing.Point(1123, 18);
            this.searchBooking_btn.Name = "searchBooking_btn";
            this.searchBooking_btn.OnHoverBaseColor = System.Drawing.Color.SlateGray;
            this.searchBooking_btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.searchBooking_btn.OnHoverForeColor = System.Drawing.Color.White;
            this.searchBooking_btn.OnHoverImage = null;
            this.searchBooking_btn.OnPressedColor = System.Drawing.Color.Black;
            this.searchBooking_btn.Size = new System.Drawing.Size(241, 53);
            this.searchBooking_btn.TabIndex = 4;
            this.searchBooking_btn.Text = "Search Bookings";
            this.searchBooking_btn.Click += new System.EventHandler(this.searchBooking_btn_Click);
            // 
            // boatName_comboBox
            // 
            this.boatName_comboBox.FormattingEnabled = true;
            this.boatName_comboBox.Location = new System.Drawing.Point(570, 35);
            this.boatName_comboBox.Name = "boatName_comboBox";
            this.boatName_comboBox.Size = new System.Drawing.Size(186, 28);
            this.boatName_comboBox.TabIndex = 3;
            this.boatName_comboBox.SelectedIndexChanged += new System.EventHandler(this.boatName_comboBox_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(196, 33);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(212, 26);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(449, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vessel Name : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select departure date : ";
            // 
            // bookingHistoryDataGridView
            // 
            this.bookingHistoryDataGridView.AllowUserToAddRows = false;
            this.bookingHistoryDataGridView.AllowUserToDeleteRows = false;
            this.bookingHistoryDataGridView.AllowUserToResizeColumns = false;
            this.bookingHistoryDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.bookingHistoryDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.bookingHistoryDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.bookingHistoryDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.bookingHistoryDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.bookingHistoryDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bookingHistoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bookingHistoryDataGridView.DefaultCellStyle = dataGridViewCellStyle8;
            this.bookingHistoryDataGridView.Location = new System.Drawing.Point(30, 0);
            this.bookingHistoryDataGridView.Name = "bookingHistoryDataGridView";
            this.bookingHistoryDataGridView.RowHeadersVisible = false;
            this.bookingHistoryDataGridView.RowHeadersWidth = 62;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            this.bookingHistoryDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.bookingHistoryDataGridView.RowTemplate.Height = 28;
            this.bookingHistoryDataGridView.Size = new System.Drawing.Size(1204, 764);
            this.bookingHistoryDataGridView.TabIndex = 0;
            // 
            // details_panel
            // 
            this.details_panel.Controls.Add(this.bookingHistoryDataGridView);
            this.details_panel.Location = new System.Drawing.Point(106, 168);
            this.details_panel.Name = "details_panel";
            this.details_panel.Size = new System.Drawing.Size(1274, 771);
            this.details_panel.TabIndex = 1;
            this.details_panel.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(778, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Departure Time : ";
            // 
            // departureTime_comboBox
            // 
            this.departureTime_comboBox.FormattingEnabled = true;
            this.departureTime_comboBox.Location = new System.Drawing.Point(915, 36);
            this.departureTime_comboBox.Name = "departureTime_comboBox";
            this.departureTime_comboBox.Size = new System.Drawing.Size(121, 28);
            this.departureTime_comboBox.TabIndex = 1;
            // 
            // bookingHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(236)))), ((int)(((byte)(247)))));
            this.Controls.Add(this.details_panel);
            this.Controls.Add(this.gunaElipsePanel1);
            this.Name = "bookingHistory";
            this.Size = new System.Drawing.Size(1463, 942);
            this.Load += new System.EventHandler(this.bookingHistory_Load);
            this.gunaElipsePanel1.ResumeLayout(false);
            this.gunaElipsePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookingHistoryDataGridView)).EndInit();
            this.details_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaButton searchBooking_btn;
        private System.Windows.Forms.ComboBox boatName_comboBox;
        private System.Windows.Forms.DataGridView bookingHistoryDataGridView;
        private System.Windows.Forms.Panel details_panel;
        private System.Windows.Forms.ComboBox departureTime_comboBox;
        private System.Windows.Forms.Label label3;
    }
}
