namespace CarRental.Employee
{
    partial class FormListSchedule
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            dgv_schedule = new DataGridView();
            panel3 = new Panel();
            label1 = new Label();
            btn_update = new FontAwesome.Sharp.IconButton();
            btn_chitiet = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_schedule).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dgv_schedule);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 101);
            panel1.Name = "panel1";
            panel1.Size = new Size(1057, 345);
            panel1.TabIndex = 10;
            // 
            // dgv_schedule
            // 
            dgv_schedule.BackgroundColor = SystemColors.ActiveCaption;
            dgv_schedule.BorderStyle = BorderStyle.None;
            dgv_schedule.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_schedule.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_schedule.ColumnHeadersHeight = 29;
            dgv_schedule.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgv_schedule.Dock = DockStyle.Fill;
            dgv_schedule.EnableHeadersVisualStyles = false;
            dgv_schedule.GridColor = Color.DeepSkyBlue;
            dgv_schedule.Location = new Point(0, 0);
            dgv_schedule.Name = "dgv_schedule";
            dgv_schedule.RowHeadersVisible = false;
            dgv_schedule.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dgv_schedule.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgv_schedule.RowTemplate.Height = 29;
            dgv_schedule.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_schedule.Size = new Size(1057, 345);
            dgv_schedule.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(label1);
            panel3.Controls.Add(btn_update);
            panel3.Controls.Add(btn_chitiet);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1057, 101);
            panel3.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(412, 37);
            label1.Name = "label1";
            label1.Size = new Size(263, 41);
            label1.TabIndex = 7;
            label1.Text = "Lịch trình thuê xe";
            // 
            // btn_update
            // 
            btn_update.BackColor = SystemColors.Highlight;
            btn_update.FlatStyle = FlatStyle.Flat;
            btn_update.IconChar = FontAwesome.Sharp.IconChar.Pen;
            btn_update.IconColor = Color.DeepSkyBlue;
            btn_update.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_update.IconSize = 30;
            btn_update.ImageAlign = ContentAlignment.MiddleRight;
            btn_update.Location = new Point(210, 37);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(139, 51);
            btn_update.TabIndex = 3;
            btn_update.Text = "Cập nhật";
            btn_update.UseVisualStyleBackColor = false;
            // 
            // btn_chitiet
            // 
            btn_chitiet.BackColor = SystemColors.Highlight;
            btn_chitiet.FlatStyle = FlatStyle.Flat;
            btn_chitiet.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            btn_chitiet.IconColor = Color.DeepSkyBlue;
            btn_chitiet.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_chitiet.IconSize = 30;
            btn_chitiet.ImageAlign = ContentAlignment.MiddleRight;
            btn_chitiet.Location = new Point(19, 37);
            btn_chitiet.Name = "btn_chitiet";
            btn_chitiet.Size = new Size(146, 51);
            btn_chitiet.TabIndex = 1;
            btn_chitiet.Text = "Xem chi tiết";
            btn_chitiet.UseVisualStyleBackColor = false;
            btn_chitiet.Click += btn_chitiet_Click;
            // 
            // FormListSchedule
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1057, 446);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Name = "FormListSchedule";
            Load += FormListSchedule_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_schedule).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dgv_schedule;
        private Panel panel3;
        private FontAwesome.Sharp.IconButton btn_update;
        private FontAwesome.Sharp.IconButton btn_chitiet;
        private Label label1;
    }
}