namespace CarRental.Admin
{
    partial class FormEmployeeManagement
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
            panel3 = new Panel();
            btn_export = new FontAwesome.Sharp.IconButton();
            txt_searchKH = new MaterialSkin.Controls.MaterialTextBox();
            btn_searchNV = new FontAwesome.Sharp.IconButton();
            btn_updateNV = new FontAwesome.Sharp.IconButton();
            btn_deleteNV = new FontAwesome.Sharp.IconButton();
            btn_addNV = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            dgv_nhanvien = new DataGridView();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_nhanvien).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Controls.Add(btn_export);
            panel3.Controls.Add(txt_searchKH);
            panel3.Controls.Add(btn_searchNV);
            panel3.Controls.Add(btn_updateNV);
            panel3.Controls.Add(btn_deleteNV);
            panel3.Controls.Add(btn_addNV);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1245, 110);
            panel3.TabIndex = 5;
            // 
            // btn_export
            // 
            btn_export.BackColor = SystemColors.HotTrack;
            btn_export.FlatStyle = FlatStyle.Flat;
            btn_export.IconChar = FontAwesome.Sharp.IconChar.Table;
            btn_export.IconColor = Color.DeepSkyBlue;
            btn_export.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_export.IconSize = 30;
            btn_export.ImageAlign = ContentAlignment.MiddleRight;
            btn_export.Location = new Point(907, 38);
            btn_export.Name = "btn_export";
            btn_export.Size = new Size(136, 50);
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
            txt_searchKH.Location = new Point(475, 38);
            txt_searchKH.MaxLength = 50;
            txt_searchKH.MouseState = MaterialSkin.MouseState.OUT;
            txt_searchKH.Multiline = false;
            txt_searchKH.Name = "txt_searchKH";
            txt_searchKH.Size = new Size(266, 50);
            txt_searchKH.TabIndex = 5;
            txt_searchKH.Text = "";
            txt_searchKH.TrailingIcon = null;
            // 
            // btn_searchNV
            // 
            btn_searchNV.BackColor = SystemColors.HotTrack;
            btn_searchNV.FlatStyle = FlatStyle.Flat;
            btn_searchNV.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            btn_searchNV.IconColor = Color.DeepSkyBlue;
            btn_searchNV.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_searchNV.IconSize = 30;
            btn_searchNV.ImageAlign = ContentAlignment.MiddleRight;
            btn_searchNV.Location = new Point(764, 38);
            btn_searchNV.Name = "btn_searchNV";
            btn_searchNV.Size = new Size(126, 50);
            btn_searchNV.TabIndex = 4;
            btn_searchNV.Text = "Tìm kiếm";
            btn_searchNV.UseVisualStyleBackColor = false;
            // 
            // btn_updateNV
            // 
            btn_updateNV.BackColor = SystemColors.HotTrack;
            btn_updateNV.FlatStyle = FlatStyle.Flat;
            btn_updateNV.IconChar = FontAwesome.Sharp.IconChar.Pen;
            btn_updateNV.IconColor = Color.DeepSkyBlue;
            btn_updateNV.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_updateNV.IconSize = 30;
            btn_updateNV.ImageAlign = ContentAlignment.MiddleRight;
            btn_updateNV.Location = new Point(326, 38);
            btn_updateNV.Name = "btn_updateNV";
            btn_updateNV.Size = new Size(112, 50);
            btn_updateNV.TabIndex = 3;
            btn_updateNV.Text = "Cập nhật";
            btn_updateNV.UseVisualStyleBackColor = false;
            btn_updateNV.Click += btn_updateNV_Click;
            // 
            // btn_deleteNV
            // 
            btn_deleteNV.BackColor = SystemColors.HotTrack;
            btn_deleteNV.FlatStyle = FlatStyle.Flat;
            btn_deleteNV.IconChar = FontAwesome.Sharp.IconChar.Backspace;
            btn_deleteNV.IconColor = Color.DeepSkyBlue;
            btn_deleteNV.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_deleteNV.IconSize = 30;
            btn_deleteNV.ImageAlign = ContentAlignment.MiddleRight;
            btn_deleteNV.Location = new Point(210, 38);
            btn_deleteNV.Name = "btn_deleteNV";
            btn_deleteNV.Size = new Size(110, 50);
            btn_deleteNV.TabIndex = 2;
            btn_deleteNV.Text = "Xóa";
            btn_deleteNV.UseVisualStyleBackColor = false;
            btn_deleteNV.Click += btn_deleteNV_Click;
            // 
            // btn_addNV
            // 
            btn_addNV.BackColor = SystemColors.HotTrack;
            btn_addNV.FlatStyle = FlatStyle.Flat;
            btn_addNV.IconChar = FontAwesome.Sharp.IconChar.Add;
            btn_addNV.IconColor = Color.DeepSkyBlue;
            btn_addNV.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_addNV.IconSize = 30;
            btn_addNV.ImageAlign = ContentAlignment.MiddleRight;
            btn_addNV.Location = new Point(19, 38);
            btn_addNV.Name = "btn_addNV";
            btn_addNV.Size = new Size(185, 50);
            btn_addNV.TabIndex = 1;
            btn_addNV.Text = "Thêm khách hàng";
            btn_addNV.UseVisualStyleBackColor = false;
            btn_addNV.Click += btn_addNV_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(dgv_nhanvien);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1245, 633);
            panel1.TabIndex = 6;
            // 
            // dgv_nhanvien
            // 
            dgv_nhanvien.BackgroundColor = SystemColors.ActiveCaption;
            dgv_nhanvien.BorderStyle = BorderStyle.None;
            dgv_nhanvien.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_nhanvien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_nhanvien.ColumnHeadersHeight = 29;
            dgv_nhanvien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgv_nhanvien.EnableHeadersVisualStyles = false;
            dgv_nhanvien.GridColor = Color.DeepSkyBlue;
            dgv_nhanvien.ImeMode = ImeMode.NoControl;
            dgv_nhanvien.Location = new Point(0, 109);
            dgv_nhanvien.Name = "dgv_nhanvien";
            dgv_nhanvien.ReadOnly = true;
            dgv_nhanvien.RowHeadersVisible = false;
            dgv_nhanvien.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dgv_nhanvien.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgv_nhanvien.RowTemplate.Height = 29;
            dgv_nhanvien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_nhanvien.Size = new Size(1245, 524);
            dgv_nhanvien.TabIndex = 1;
            dgv_nhanvien.CellContentClick += dgv_nhanvien_CellContentClick;
            dgv_nhanvien.CellEndEdit += dgv_nhanvien_CellEndEdit;
            // 
            // FormEmployeeManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1245, 633);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "FormEmployeeManagement";
            Text = "FormEmployeeManagement";
            Load += FormEmployeeManagement_Load;
            panel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_nhanvien).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private FontAwesome.Sharp.IconButton btn_export;
        private MaterialSkin.Controls.MaterialTextBox txt_searchKH;
        private FontAwesome.Sharp.IconButton btn_searchNV;
        private FontAwesome.Sharp.IconButton btn_updateNV;
        private FontAwesome.Sharp.IconButton btn_deleteNV;
        private FontAwesome.Sharp.IconButton btn_addNV;
        private Panel panel1;
        private DataGridView dgv_nhanvien;
    }
}