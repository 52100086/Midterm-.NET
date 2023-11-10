namespace CarRental.Admin
{
    partial class AdminCustomerManagement
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
            metroPanel1 = new MetroFramework.Controls.MetroPanel();
            btn_Search = new FontAwesome.Sharp.IconButton();
            txt_Search = new MetroFramework.Controls.MetroTextBox();
            btn_Update = new FontAwesome.Sharp.IconButton();
            btn_Delete = new FontAwesome.Sharp.IconButton();
            btn_Add = new FontAwesome.Sharp.IconButton();
            metroPanel2 = new MetroFramework.Controls.MetroPanel();
            dataGridView1 = new DataGridView();
            metroPanel1.SuspendLayout();
            metroPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // metroPanel1
            // 
            metroPanel1.Controls.Add(btn_Search);
            metroPanel1.Controls.Add(txt_Search);
            metroPanel1.Controls.Add(btn_Update);
            metroPanel1.Controls.Add(btn_Delete);
            metroPanel1.Controls.Add(btn_Add);
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
            metroPanel1.TabIndex = 0;
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
            btn_Search.Location = new Point(850, 43);
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
            txt_Search.Location = new Point(709, 43);
            txt_Search.Multiline = false;
            txt_Search.Name = "txt_Search";
            txt_Search.SelectedText = "";
            txt_Search.Size = new Size(94, 29);
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
            btn_Update.Location = new Point(574, 37);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(94, 29);
            btn_Update.TabIndex = 4;
            btn_Update.Text = "Cập nhật";
            btn_Update.UseVisualStyleBackColor = true;
            // 
            // btn_Delete
            // 
            btn_Delete.IconChar = FontAwesome.Sharp.IconChar.None;
            btn_Delete.IconColor = Color.Black;
            btn_Delete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_Delete.Location = new Point(432, 37);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(94, 29);
            btn_Delete.TabIndex = 3;
            btn_Delete.Text = "Xóa";
            btn_Delete.UseVisualStyleBackColor = true;
            // 
            // btn_Add
            // 
            btn_Add.IconChar = FontAwesome.Sharp.IconChar.None;
            btn_Add.IconColor = Color.Black;
            btn_Add.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_Add.Location = new Point(290, 37);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(94, 29);
            btn_Add.TabIndex = 2;
            btn_Add.Text = "Thêm";
            btn_Add.UseVisualStyleBackColor = true;
            // 
            // metroPanel2
            // 
            metroPanel2.Controls.Add(dataGridView1);
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
            metroPanel2.TabIndex = 1;
            metroPanel2.Theme = MetroFramework.MetroThemeStyle.Light;
            metroPanel2.VerticalScrollbar = false;
            metroPanel2.VerticalScrollbarBarColor = true;
            metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            metroPanel2.VerticalScrollbarSize = 10;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(982, 354);
            dataGridView1.TabIndex = 2;
            // 
            // AdminCustomerManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 479);
            Controls.Add(metroPanel2);
            Controls.Add(metroPanel1);
            Name = "AdminCustomerManagement";
            Text = "AdminCustomerManagement";
            metroPanel1.ResumeLayout(false);
            metroPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private FontAwesome.Sharp.IconButton btn_Update;
        private FontAwesome.Sharp.IconButton btn_Delete;
        private FontAwesome.Sharp.IconButton btn_Add;
        private DataGridView dataGridView1;
        private FontAwesome.Sharp.IconButton btn_Search;
        private MetroFramework.Controls.MetroTextBox txt_Search;
    }
}