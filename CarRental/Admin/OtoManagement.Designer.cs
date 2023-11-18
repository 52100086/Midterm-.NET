namespace CarRental.Admin
{
    partial class OtoManagement
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
            panel3 = new Panel();
            dgv_car = new DataGridView();
            panel2 = new Panel();
            import_excel = new FontAwesome.Sharp.IconButton();
            btn_export = new FontAwesome.Sharp.IconButton();
            txt_search = new MaterialSkin.Controls.MaterialTextBox();
            btn_search = new FontAwesome.Sharp.IconButton();
            btn_update = new FontAwesome.Sharp.IconButton();
            btn_delete = new FontAwesome.Sharp.IconButton();
            btn_add = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_car).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1051, 567);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(dgv_car);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 96);
            panel3.Name = "panel3";
            panel3.Size = new Size(1051, 471);
            panel3.TabIndex = 2;
            // 
            // dgv_car
            // 
            dgv_car.BackgroundColor = SystemColors.ActiveCaption;
            dgv_car.BorderStyle = BorderStyle.None;
            dgv_car.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_car.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_car.ColumnHeadersHeight = 29;
            dgv_car.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgv_car.Dock = DockStyle.Fill;
            dgv_car.EnableHeadersVisualStyles = false;
            dgv_car.GridColor = Color.DeepSkyBlue;
            dgv_car.Location = new Point(0, 0);
            dgv_car.Name = "dgv_car";
            dgv_car.RowHeadersVisible = false;
            dgv_car.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dgv_car.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgv_car.RowTemplate.Height = 29;
            dgv_car.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_car.Size = new Size(1051, 471);
            dgv_car.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(import_excel);
            panel2.Controls.Add(btn_export);
            panel2.Controls.Add(txt_search);
            panel2.Controls.Add(btn_search);
            panel2.Controls.Add(btn_update);
            panel2.Controls.Add(btn_delete);
            panel2.Controls.Add(btn_add);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1051, 96);
            panel2.TabIndex = 1;
            // 
            // import_excel
            // 
            import_excel.IconChar = FontAwesome.Sharp.IconChar.None;
            import_excel.IconColor = Color.Black;
            import_excel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            import_excel.Location = new Point(899, 48);
            import_excel.Name = "import_excel";
            import_excel.Size = new Size(94, 29);
            import_excel.TabIndex = 7;
            import_excel.Text = "Nhập Excel";
            import_excel.UseVisualStyleBackColor = true;
            import_excel.Click += import_excel_Click;
            // 
            // btn_export
            // 
            btn_export.IconChar = FontAwesome.Sharp.IconChar.None;
            btn_export.IconColor = Color.Black;
            btn_export.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_export.Location = new Point(899, 12);
            btn_export.Name = "btn_export";
            btn_export.Size = new Size(94, 29);
            btn_export.TabIndex = 6;
            btn_export.Text = "Xuất Excel";
            btn_export.UseVisualStyleBackColor = true;
            btn_export.Click += btn_export_Click;
            // 
            // txt_search
            // 
            txt_search.AnimateReadOnly = false;
            txt_search.BorderStyle = BorderStyle.None;
            txt_search.Depth = 0;
            txt_search.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txt_search.LeadingIcon = null;
            txt_search.Location = new Point(12, 27);
            txt_search.MaxLength = 50;
            txt_search.MouseState = MaterialSkin.MouseState.OUT;
            txt_search.Multiline = false;
            txt_search.Name = "txt_search";
            txt_search.Size = new Size(266, 50);
            txt_search.TabIndex = 5;
            txt_search.Text = "";
            txt_search.TrailingIcon = null;
            // 
            // btn_search
            // 
            btn_search.IconChar = FontAwesome.Sharp.IconChar.None;
            btn_search.IconColor = Color.Black;
            btn_search.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_search.Location = new Point(293, 37);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(94, 29);
            btn_search.TabIndex = 4;
            btn_search.Text = "Tìm kiếm";
            btn_search.UseVisualStyleBackColor = true;
            btn_search.Click += btn_search_Click;
            // 
            // btn_update
            // 
            btn_update.IconChar = FontAwesome.Sharp.IconChar.None;
            btn_update.IconColor = Color.Black;
            btn_update.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_update.Location = new Point(591, 37);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(94, 29);
            btn_update.TabIndex = 3;
            btn_update.Text = "Cập nhật";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // btn_delete
            // 
            btn_delete.IconChar = FontAwesome.Sharp.IconChar.None;
            btn_delete.IconColor = Color.Black;
            btn_delete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_delete.Location = new Point(706, 37);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(94, 29);
            btn_delete.TabIndex = 2;
            btn_delete.Text = "Xóa xe";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_add
            // 
            btn_add.IconChar = FontAwesome.Sharp.IconChar.None;
            btn_add.IconColor = Color.Black;
            btn_add.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_add.Location = new Point(477, 37);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(94, 29);
            btn_add.TabIndex = 1;
            btn_add.Text = "Thêm xe";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // OtoManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1051, 567);
            Controls.Add(panel1);
            Name = "OtoManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OtoManagement";
            Load += OtoManagement_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_car).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private MaterialSkin.Controls.MaterialTextBox txt_search;
        private FontAwesome.Sharp.IconButton btn_search;
        private FontAwesome.Sharp.IconButton btn_update;
        private FontAwesome.Sharp.IconButton btn_delete;
        private FontAwesome.Sharp.IconButton btn_add;
        private Panel panel3;
        private DataGridView dgv_car;
        private FontAwesome.Sharp.IconButton btn_export;
        private FontAwesome.Sharp.IconButton import_excel;
    }
}