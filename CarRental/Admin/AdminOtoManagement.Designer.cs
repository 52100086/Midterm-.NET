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
            iconButton1 = new FontAwesome.Sharp.IconButton();
            metroPanel1 = new MetroFramework.Controls.MetroPanel();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            metroPanel2 = new MetroFramework.Controls.MetroPanel();
            dataGridView1 = new DataGridView();
            metroPanel1.SuspendLayout();
            metroPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // iconButton1
            // 
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.Location = new Point(239, 37);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(172, 34);
            iconButton1.TabIndex = 0;
            iconButton1.Text = "Thêm xe";
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            // 
            // metroPanel1
            // 
            metroPanel1.Controls.Add(iconButton1);
            metroPanel1.Controls.Add(iconButton4);
            metroPanel1.Controls.Add(metroTextBox1);
            metroPanel1.Controls.Add(iconButton3);
            metroPanel1.Controls.Add(iconButton2);
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
            // iconButton4
            // 
            iconButton4.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton4.IconColor = Color.Black;
            iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton4.Location = new Point(850, 43);
            iconButton4.Name = "iconButton4";
            iconButton4.Size = new Size(94, 29);
            iconButton4.TabIndex = 6;
            iconButton4.Text = "Tìm kiếm";
            iconButton4.UseVisualStyleBackColor = true;
            // 
            // metroTextBox1
            // 
            metroTextBox1.FontSize = MetroFramework.MetroTextBoxSize.Small;
            metroTextBox1.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            metroTextBox1.Location = new Point(709, 43);
            metroTextBox1.Multiline = false;
            metroTextBox1.Name = "metroTextBox1";
            metroTextBox1.SelectedText = "";
            metroTextBox1.Size = new Size(94, 29);
            metroTextBox1.Style = MetroFramework.MetroColorStyle.Blue;
            metroTextBox1.StyleManager = null;
            metroTextBox1.TabIndex = 5;
            metroTextBox1.Text = "metroTextBox1";
            metroTextBox1.Theme = MetroFramework.MetroThemeStyle.Light;
            metroTextBox1.UseStyleColors = false;
            // 
            // iconButton3
            // 
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton3.IconColor = Color.Black;
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.Location = new Point(574, 37);
            iconButton3.Name = "iconButton3";
            iconButton3.Size = new Size(94, 29);
            iconButton3.TabIndex = 4;
            iconButton3.Text = "Cập nhật";
            iconButton3.UseVisualStyleBackColor = true;
            // 
            // iconButton2
            // 
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton2.IconColor = Color.Black;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.Location = new Point(432, 37);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(94, 29);
            iconButton2.TabIndex = 3;
            iconButton2.Text = "Xóa";
            iconButton2.UseVisualStyleBackColor = true;
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
            metroPanel2.TabIndex = 3;
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
            // AdminOtoManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 479);
            Controls.Add(metroPanel2);
            Controls.Add(metroPanel1);
            Name = "AdminOtoManagement";
            Text = "AdminOtoManagement";
            metroPanel1.ResumeLayout(false);
            metroPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FontAwesome.Sharp.IconButton iconButton1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private FontAwesome.Sharp.IconButton iconButton4;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton2;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private DataGridView dataGridView1;
    }
}