namespace CarRental.Employee
{
    partial class FormListKhachHang
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel1 = new Panel();
            dgv_khachhang = new DataGridView();
            panel3 = new Panel();
            btn_addKH = new FontAwesome.Sharp.IconButton();
            btn_addorder = new FontAwesome.Sharp.IconButton();
            btn_export = new FontAwesome.Sharp.IconButton();
            txt_searchKH = new MaterialSkin.Controls.MaterialTextBox();
            btn_searchKH = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_khachhang).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dgv_khachhang);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 101);
            panel1.Name = "panel1";
            panel1.Size = new Size(1057, 345);
            panel1.TabIndex = 6;
            // 
            // dgv_khachhang
            // 
            dgv_khachhang.BackgroundColor = SystemColors.ActiveCaption;
            dgv_khachhang.BorderStyle = BorderStyle.None;
            dgv_khachhang.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgv_khachhang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgv_khachhang.ColumnHeadersHeight = 29;
            dgv_khachhang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgv_khachhang.Dock = DockStyle.Fill;
            dgv_khachhang.EnableHeadersVisualStyles = false;
            dgv_khachhang.GridColor = Color.DeepSkyBlue;
            dgv_khachhang.Location = new Point(0, 0);
            dgv_khachhang.Name = "dgv_khachhang";
            dgv_khachhang.RowHeadersVisible = false;
            dgv_khachhang.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dgv_khachhang.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgv_khachhang.RowTemplate.Height = 29;
            dgv_khachhang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_khachhang.Size = new Size(1057, 345);
            dgv_khachhang.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(btn_addKH);
            panel3.Controls.Add(btn_addorder);
            panel3.Controls.Add(btn_export);
            panel3.Controls.Add(txt_searchKH);
            panel3.Controls.Add(btn_searchKH);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1057, 101);
            panel3.TabIndex = 5;
            // 
            // btn_addKH
            // 
            btn_addKH.BackColor = SystemColors.Highlight;
            btn_addKH.FlatStyle = FlatStyle.Flat;
            btn_addKH.IconChar = FontAwesome.Sharp.IconChar.Add;
            btn_addKH.IconColor = Color.DeepSkyBlue;
            btn_addKH.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_addKH.IconSize = 30;
            btn_addKH.ImageAlign = ContentAlignment.MiddleRight;
            btn_addKH.Location = new Point(76, 38);
            btn_addKH.Name = "btn_addKH";
            btn_addKH.Size = new Size(185, 50);
            btn_addKH.TabIndex = 8;
            btn_addKH.Text = "Thêm khách hàng";
            btn_addKH.UseVisualStyleBackColor = false;
            btn_addKH.Click += btn_addKH_Click;
            // 
            // btn_addorder
            // 
            btn_addorder.BackColor = SystemColors.Highlight;
            btn_addorder.FlatStyle = FlatStyle.Flat;
            btn_addorder.IconChar = FontAwesome.Sharp.IconChar.List;
            btn_addorder.IconColor = Color.DeepSkyBlue;
            btn_addorder.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_addorder.IconSize = 20;
            btn_addorder.ImageAlign = ContentAlignment.MiddleRight;
            btn_addorder.Location = new Point(797, 59);
            btn_addorder.Name = "btn_addorder";
            btn_addorder.Size = new Size(148, 29);
            btn_addorder.TabIndex = 7;
            btn_addorder.Text = "Thêm hóa đơn";
            btn_addorder.UseVisualStyleBackColor = false;
            btn_addorder.Click += btn_addorder_Click;
            // 
            // btn_export
            // 
            btn_export.BackColor = SystemColors.Highlight;
            btn_export.FlatStyle = FlatStyle.Flat;
            btn_export.IconChar = FontAwesome.Sharp.IconChar.Table;
            btn_export.IconColor = Color.DeepSkyBlue;
            btn_export.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_export.IconSize = 20;
            btn_export.ImageAlign = ContentAlignment.MiddleRight;
            btn_export.Location = new Point(797, 24);
            btn_export.Name = "btn_export";
            btn_export.Size = new Size(148, 29);
            btn_export.TabIndex = 6;
            btn_export.Text = "Xuất excel";
            btn_export.UseVisualStyleBackColor = false;
            btn_export.Click += btn_export_Click;
            // 
            // txt_searchKH
            // 
            txt_searchKH.AnimateReadOnly = false;
            txt_searchKH.BorderStyle = BorderStyle.None;
            txt_searchKH.Depth = 0;
            txt_searchKH.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txt_searchKH.LeadingIcon = null;
            txt_searchKH.Location = new Point(293, 38);
            txt_searchKH.MaxLength = 50;
            txt_searchKH.MouseState = MaterialSkin.MouseState.OUT;
            txt_searchKH.Multiline = false;
            txt_searchKH.Name = "txt_searchKH";
            txt_searchKH.Size = new Size(266, 50);
            txt_searchKH.TabIndex = 5;
            txt_searchKH.Text = "";
            txt_searchKH.TrailingIcon = null;
            // 
            // btn_searchKH
            // 
            btn_searchKH.BackColor = SystemColors.Highlight;
            btn_searchKH.FlatStyle = FlatStyle.Flat;
            btn_searchKH.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            btn_searchKH.IconColor = Color.DeepSkyBlue;
            btn_searchKH.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_searchKH.IconSize = 30;
            btn_searchKH.ImageAlign = ContentAlignment.MiddleRight;
            btn_searchKH.Location = new Point(582, 38);
            btn_searchKH.Name = "btn_searchKH";
            btn_searchKH.Size = new Size(135, 50);
            btn_searchKH.TabIndex = 4;
            btn_searchKH.Text = "Tìm kiếm";
            btn_searchKH.UseVisualStyleBackColor = false;
            btn_searchKH.Click += btn_searchKH_Click;
            // 
            // FormListKhachHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1057, 446);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Name = "FormListKhachHang";
            Load += FormListKhachHang_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_khachhang).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dgv_khachhang;
        private Panel panel3;
        private FontAwesome.Sharp.IconButton btn_addorder;
        private FontAwesome.Sharp.IconButton btn_export;
        private MaterialSkin.Controls.MaterialTextBox txt_searchKH;
        private FontAwesome.Sharp.IconButton btn_searchKH;
        private FontAwesome.Sharp.IconButton btn_addKH;
    }
}