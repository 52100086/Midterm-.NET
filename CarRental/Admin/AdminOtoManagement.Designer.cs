namespace CarRental.Admin
{
    partial class AdminOtoManagement
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
            btn_AddOto = new FontAwesome.Sharp.IconButton();
            metroPanel1 = new MetroFramework.Controls.MetroPanel();
            btn_Search = new FontAwesome.Sharp.IconButton();
            txt_Search = new MetroFramework.Controls.MetroTextBox();
            btn_Update = new FontAwesome.Sharp.IconButton();
            btn_Delete = new FontAwesome.Sharp.IconButton();
            metroPanel2 = new MetroFramework.Controls.MetroPanel();
            dgv_car = new DataGridView();
            metroPanel1.SuspendLayout();
            metroPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_car).BeginInit();
            SuspendLayout();
            // 
            // btn_AddOto
            // 
            btn_AddOto.IconChar = FontAwesome.Sharp.IconChar.None;
            btn_AddOto.IconColor = Color.Black;
            btn_AddOto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_AddOto.Location = new Point(239, 37);
            btn_AddOto.Name = "btn_AddOto";
            btn_AddOto.Size = new Size(172, 34);
            btn_AddOto.TabIndex = 0;
            btn_AddOto.Text = "Thêm xe";
            btn_AddOto.UseVisualStyleBackColor = true;
            btn_AddOto.Click += btn_AddOto_Click;
            // 
            // metroPanel1
            // 
            metroPanel1.Controls.Add(btn_AddOto);
            metroPanel1.Controls.Add(btn_Search);
            metroPanel1.Controls.Add(txt_Search);
            metroPanel1.Controls.Add(btn_Update);
            metroPanel1.Controls.Add(btn_Delete);
            metroPanel1.CustomBackground = false;
            metroPanel1.Dock = DockStyle.Top;
            metroPanel1.HorizontalScrollbar = false;
            metroPanel1.HorizontalScrollbarBarColor = true;
            metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            metroPanel1.HorizontalScrollbarSize = 10;
            metroPanel1.Location = new Point(0, 0);
            metroPanel1.Name = "metroPanel1";
            metroPanel1.Size = new Size(982, 125);
            metroPanel1.Style = MetroFramework.MetroColorStyle.Blue;
            metroPanel1.StyleManager = null;
            metroPanel1.TabIndex = 2;
            metroPanel1.Theme = MetroFramework.MetroThemeStyle.Light;
            metroPanel1.VerticalScrollbar = false;
            metroPanel1.VerticalScrollbarBarColor = true;
            metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btn_Search
            // 
            btn_Search.IconChar = FontAwesome.Sharp.IconChar.None;
            btn_Search.IconColor = Color.Black;
            btn_Search.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_Search.Location = new Point(859, 40);
            btn_Search.Name = "btn_Search";
            btn_Search.Size = new Size(94, 29);
            btn_Search.TabIndex = 6;
            btn_Search.Text = "Tìm kiếm";
            btn_Search.UseVisualStyleBackColor = true;
            // 
            // txt_Search
            // 
            txt_Search.FontSize = MetroFramework.MetroTextBoxSize.Small;
            txt_Search.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            txt_Search.Location = new Point(679, 40);
            txt_Search.Multiline = false;
            txt_Search.Name = "txt_Search";
            txt_Search.SelectedText = "";
            txt_Search.Size = new Size(154, 29);
            txt_Search.Style = MetroFramework.MetroColorStyle.Blue;
            txt_Search.StyleManager = null;
            txt_Search.TabIndex = 5;
            txt_Search.Theme = MetroFramework.MetroThemeStyle.Light;
            txt_Search.UseStyleColors = false;
            // 
            // btn_Update
            // 
            btn_Update.IconChar = FontAwesome.Sharp.IconChar.None;
            btn_Update.IconColor = Color.Black;
            btn_Update.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_Update.Location = new Point(550, 40);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(94, 29);
            btn_Update.TabIndex = 4;
            btn_Update.Text = "Cập nhật";
            btn_Update.UseVisualStyleBackColor = true;
            btn_Update.Click += btn_Update_Click;
            // 
            // btn_Delete
            // 
            btn_Delete.IconChar = FontAwesome.Sharp.IconChar.None;
            btn_Delete.IconColor = Color.Black;
            btn_Delete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_Delete.Location = new Point(434, 40);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(94, 29);
            btn_Delete.TabIndex = 3;
            btn_Delete.Text = "Xóa";
            btn_Delete.UseVisualStyleBackColor = true;
            btn_Delete.Click += btn_Delete_Click;
            // 
            // metroPanel2
            // 
            metroPanel2.Controls.Add(dgv_car);
            metroPanel2.CustomBackground = false;
            metroPanel2.Dock = DockStyle.Fill;
            metroPanel2.HorizontalScrollbar = false;
            metroPanel2.HorizontalScrollbarBarColor = true;
            metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            metroPanel2.HorizontalScrollbarSize = 10;
            metroPanel2.Location = new Point(0, 125);
            metroPanel2.Name = "metroPanel2";
            metroPanel2.Size = new Size(982, 354);
            metroPanel2.Style = MetroFramework.MetroColorStyle.Blue;
            metroPanel2.StyleManager = null;
            metroPanel2.TabIndex = 3;
            metroPanel2.Theme = MetroFramework.MetroThemeStyle.Light;
            metroPanel2.VerticalScrollbar = false;
            metroPanel2.VerticalScrollbarBarColor = true;
            metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            metroPanel2.VerticalScrollbarSize = 10;
            // 
            // dgv_car
            // 
            dgv_car.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_car.Dock = DockStyle.Fill;
            dgv_car.Location = new Point(0, 0);
            dgv_car.Name = "dgv_car";
            dgv_car.RowHeadersWidth = 51;
            dgv_car.RowTemplate.Height = 29;
            dgv_car.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_car.Size = new Size(982, 354);
            dgv_car.TabIndex = 2;
            // 
            // AdminOtoManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 479);
            Controls.Add(metroPanel2);
            Controls.Add(metroPanel1);
            Name = "AdminOtoManagement";
            Text = "AdminOtoManagement";
            Load += AdminOtoManagement_Load;
            metroPanel1.ResumeLayout(false);
            metroPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_car).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FontAwesome.Sharp.IconButton btn_AddOto;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private FontAwesome.Sharp.IconButton btn_Search;
        private MetroFramework.Controls.MetroTextBox txt_Search;
        private FontAwesome.Sharp.IconButton btn_Update;
        private FontAwesome.Sharp.IconButton btn_Delete;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private DataGridView dgv_car;
    }
}