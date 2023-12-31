﻿namespace CarRental.Admin
{
    partial class FormOrderManagement
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
            dgv_order = new DataGridView();
            panel3 = new Panel();
            label1 = new Label();
            btn_export = new FontAwesome.Sharp.IconButton();
            btn_update = new FontAwesome.Sharp.IconButton();
            btn_chitiet = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_order).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dgv_order);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 101);
            panel1.Name = "panel1";
            panel1.Size = new Size(1061, 310);
            panel1.TabIndex = 6;
            // 
            // dgv_order
            // 
            dgv_order.BackgroundColor = SystemColors.ActiveCaption;
            dgv_order.BorderStyle = BorderStyle.None;
            dgv_order.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_order.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_order.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_order.Dock = DockStyle.Fill;
            dgv_order.EnableHeadersVisualStyles = false;
            dgv_order.GridColor = Color.DeepSkyBlue;
            dgv_order.Location = new Point(0, 0);
            dgv_order.Name = "dgv_order";
            dgv_order.RowHeadersVisible = false;
            dgv_order.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dgv_order.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgv_order.RowTemplate.Height = 29;
            dgv_order.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_order.Size = new Size(1061, 310);
            dgv_order.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(label1);
            panel3.Controls.Add(btn_export);
            panel3.Controls.Add(btn_update);
            panel3.Controls.Add(btn_chitiet);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1061, 101);
            panel3.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(476, 38);
            label1.Name = "label1";
            label1.Size = new Size(172, 41);
            label1.TabIndex = 7;
            label1.Text = "Đơn đặt xe";
            // 
            // btn_export
            // 
            btn_export.BackColor = SystemColors.Highlight;
            btn_export.FlatStyle = FlatStyle.Flat;
            btn_export.IconChar = FontAwesome.Sharp.IconChar.Table;
            btn_export.IconColor = Color.DeepSkyBlue;
            btn_export.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_export.IconSize = 30;
            btn_export.ImageAlign = ContentAlignment.MiddleRight;
            btn_export.Location = new Point(821, 38);
            btn_export.Name = "btn_export";
            btn_export.Size = new Size(140, 50);
            btn_export.TabIndex = 6;
            btn_export.Text = "Xuất excel";
            btn_export.UseVisualStyleBackColor = false;
            btn_export.Click += btn_export_Click;
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
            btn_update.Location = new Point(209, 38);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(135, 50);
            btn_update.TabIndex = 3;
            btn_update.Text = "Cập nhật";
            btn_update.UseVisualStyleBackColor = false;
            btn_update.Click += btn_update_Click;
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
            btn_chitiet.Location = new Point(19, 38);
            btn_chitiet.Name = "btn_chitiet";
            btn_chitiet.Size = new Size(156, 50);
            btn_chitiet.TabIndex = 1;
            btn_chitiet.Text = "Xem chi tiết";
            btn_chitiet.UseVisualStyleBackColor = false;
            btn_chitiet.Click += btn_chitiet_Click;
            // 
            // FormOrderManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1061, 411);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Name = "FormOrderManagement";
            Text = "FormOrderManagement";
            Load += FormOrderManagement_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_order).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dgv_order;
        private Panel panel3;
        private FontAwesome.Sharp.IconButton btn_export;
        private FontAwesome.Sharp.IconButton btn_update;
        private FontAwesome.Sharp.IconButton btn_chitiet;
        private Label label1;
    }
}