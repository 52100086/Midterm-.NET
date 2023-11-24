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
            panel1.Size = new Size(1061, 411);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(dgv_car);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 96);
            panel3.Name = "panel3";
            panel3.Size = new Size(1061, 315);
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
            dgv_car.Size = new Size(1061, 315);
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
            panel2.Size = new Size(1061, 96);
            panel2.TabIndex = 1;
            // 
            // import_excel
            // 
            import_excel.BackColor = SystemColors.Highlight;
            import_excel.FlatStyle = FlatStyle.Flat;
            import_excel.IconChar = FontAwesome.Sharp.IconChar.FileImport;
            import_excel.IconColor = Color.DeepSkyBlue;
            import_excel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            import_excel.IconSize = 20;
            import_excel.ImageAlign = ContentAlignment.MiddleRight;
            import_excel.Location = new Point(837, 12);
            import_excel.Name = "import_excel";
            import_excel.Size = new Size(125, 35);
            import_excel.TabIndex = 7;
            import_excel.Text = "Nhập Excel";
            import_excel.UseVisualStyleBackColor = false;
            import_excel.Click += import_excel_Click;
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
            btn_export.Location = new Point(837, 53);
            btn_export.Name = "btn_export";
            btn_export.Size = new Size(125, 33);
            btn_export.TabIndex = 6;
            btn_export.Text = "Xuất Excel";
            btn_export.UseVisualStyleBackColor = false;
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
            btn_search.BackColor = SystemColors.Highlight;
            btn_search.FlatStyle = FlatStyle.Flat;
            btn_search.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            btn_search.IconColor = Color.DeepSkyBlue;
            btn_search.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_search.IconSize = 30;
            btn_search.ImageAlign = ContentAlignment.MiddleRight;
            btn_search.Location = new Point(293, 27);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(129, 50);
            btn_search.TabIndex = 4;
            btn_search.Text = "Tìm kiếm";
            btn_search.UseVisualStyleBackColor = false;
            btn_search.Click += btn_search_Click;
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
            btn_update.Location = new Point(580, 27);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(123, 50);
            btn_update.TabIndex = 3;
            btn_update.Text = "Cập nhật";
            btn_update.UseVisualStyleBackColor = false;
            btn_update.Click += btn_update_Click;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = SystemColors.Highlight;
            btn_delete.FlatStyle = FlatStyle.Flat;
            btn_delete.IconChar = FontAwesome.Sharp.IconChar.Backspace;
            btn_delete.IconColor = Color.DeepSkyBlue;
            btn_delete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_delete.IconSize = 30;
            btn_delete.ImageAlign = ContentAlignment.MiddleRight;
            btn_delete.Location = new Point(718, 27);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(113, 50);
            btn_delete.TabIndex = 2;
            btn_delete.Text = "Xóa xe";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_add
            // 
            btn_add.BackColor = SystemColors.Highlight;
            btn_add.FlatStyle = FlatStyle.Flat;
            btn_add.IconChar = FontAwesome.Sharp.IconChar.Add;
            btn_add.IconColor = Color.DeepSkyBlue;
            btn_add.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_add.IconSize = 30;
            btn_add.ImageAlign = ContentAlignment.MiddleRight;
            btn_add.Location = new Point(437, 27);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(127, 50);
            btn_add.TabIndex = 1;
            btn_add.Text = "Thêm xe";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // OtoManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1061, 411);
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