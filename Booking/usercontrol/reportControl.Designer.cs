namespace Booking.usercontrol
{
    partial class reportControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(reportControl));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.report_topPanel = new Guna.UI.WinForms.GunaElipsePanel();
            this.generate_reportbtn = new Guna.UI.WinForms.GunaButton();
            this.report_datePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.print_btn = new Guna.UI.WinForms.GunaButton();
            this.report_content = new Guna.UI.WinForms.GunaDataGridView();
            this.report_topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.report_content)).BeginInit();
            this.SuspendLayout();
            // 
            // report_topPanel
            // 
            this.report_topPanel.BaseColor = System.Drawing.Color.White;
            this.report_topPanel.Controls.Add(this.generate_reportbtn);
            this.report_topPanel.Controls.Add(this.print_btn);
            this.report_topPanel.Controls.Add(this.report_datePicker);
            this.report_topPanel.Controls.Add(this.label1);
            this.report_topPanel.Location = new System.Drawing.Point(22, 13);
            this.report_topPanel.Name = "report_topPanel";
            this.report_topPanel.Size = new System.Drawing.Size(1396, 103);
            this.report_topPanel.TabIndex = 1;
            // 
            // generate_reportbtn
            // 
            this.generate_reportbtn.AnimationHoverSpeed = 0.07F;
            this.generate_reportbtn.AnimationSpeed = 0.03F;
            this.generate_reportbtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(171)))));
            this.generate_reportbtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(171)))));
            this.generate_reportbtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generate_reportbtn.ForeColor = System.Drawing.Color.White;
            this.generate_reportbtn.Image = ((System.Drawing.Image)(resources.GetObject("generate_reportbtn.Image")));
            this.generate_reportbtn.ImageSize = new System.Drawing.Size(20, 20);
            this.generate_reportbtn.Location = new System.Drawing.Point(882, 14);
            this.generate_reportbtn.Name = "generate_reportbtn";
            this.generate_reportbtn.OnHoverBaseColor = System.Drawing.Color.SlateGray;
            this.generate_reportbtn.OnHoverBorderColor = System.Drawing.Color.SlateGray;
            this.generate_reportbtn.OnHoverForeColor = System.Drawing.Color.White;
            this.generate_reportbtn.OnHoverImage = null;
            this.generate_reportbtn.OnPressedColor = System.Drawing.Color.Black;
            this.generate_reportbtn.Size = new System.Drawing.Size(238, 61);
            this.generate_reportbtn.TabIndex = 2;
            this.generate_reportbtn.Text = "Generate Report";
            this.generate_reportbtn.Click += new System.EventHandler(this.generateReport_btn_Click);
            // 
            // report_datePicker
            // 
            this.report_datePicker.Location = new System.Drawing.Point(441, 32);
            this.report_datePicker.Name = "report_datePicker";
            this.report_datePicker.Size = new System.Drawing.Size(403, 26);
            this.report_datePicker.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Booking Date to Generate Report : ";
            // 
            // print_btn
            // 
            this.print_btn.AnimationHoverSpeed = 0.07F;
            this.print_btn.AnimationSpeed = 0.03F;
            this.print_btn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(171)))));
            this.print_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(171)))));
            this.print_btn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.print_btn.ForeColor = System.Drawing.Color.White;
            this.print_btn.Image = ((System.Drawing.Image)(resources.GetObject("print_btn.Image")));
            this.print_btn.ImageSize = new System.Drawing.Size(20, 20);
            this.print_btn.Location = new System.Drawing.Point(1182, 14);
            this.print_btn.Name = "print_btn";
            this.print_btn.OnHoverBaseColor = System.Drawing.Color.SlateGray;
            this.print_btn.OnHoverBorderColor = System.Drawing.Color.SlateGray;
            this.print_btn.OnHoverForeColor = System.Drawing.Color.White;
            this.print_btn.OnHoverImage = null;
            this.print_btn.OnPressedColor = System.Drawing.Color.Black;
            this.print_btn.Size = new System.Drawing.Size(176, 61);
            this.print_btn.TabIndex = 4;
            this.print_btn.Text = "Print Report";
            // 
            // report_content
            // 
            this.report_content.AllowUserToAddRows = false;
            this.report_content.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.report_content.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.report_content.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.report_content.BackgroundColor = System.Drawing.Color.White;
            this.report_content.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.report_content.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.report_content.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.report_content.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.report_content.ColumnHeadersHeight = 32;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.report_content.DefaultCellStyle = dataGridViewCellStyle3;
            this.report_content.EnableHeadersVisualStyles = false;
            this.report_content.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.report_content.Location = new System.Drawing.Point(22, 142);
            this.report_content.Name = "report_content";
            this.report_content.ReadOnly = true;
            this.report_content.RowHeadersVisible = false;
            this.report_content.RowHeadersWidth = 62;
            this.report_content.RowTemplate.Height = 28;
            this.report_content.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.report_content.Size = new System.Drawing.Size(1396, 765);
            this.report_content.TabIndex = 5;
            this.report_content.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.report_content.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.report_content.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.report_content.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.report_content.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.report_content.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.report_content.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.report_content.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.report_content.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.report_content.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.report_content.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.report_content.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.report_content.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.report_content.ThemeStyle.HeaderStyle.Height = 32;
            this.report_content.ThemeStyle.ReadOnly = true;
            this.report_content.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.report_content.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.report_content.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.report_content.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.report_content.ThemeStyle.RowsStyle.Height = 28;
            this.report_content.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.report_content.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // reportControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.report_content);
            this.Controls.Add(this.report_topPanel);
            this.Location = new System.Drawing.Point(15, 30);
            this.Name = "reportControl";
            this.Size = new System.Drawing.Size(1455, 964);
            this.report_topPanel.ResumeLayout(false);
            this.report_topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.report_content)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipsePanel report_topPanel;
        private System.Windows.Forms.DateTimePicker report_datePicker;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaButton generate_reportbtn;
        private Guna.UI.WinForms.GunaButton print_btn;
        private Guna.UI.WinForms.GunaDataGridView report_content;
    }
}
