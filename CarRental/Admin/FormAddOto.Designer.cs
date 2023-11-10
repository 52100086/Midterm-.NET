namespace CarRental.Admin
{
    partial class FormAddOto
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
            panel1 = new Panel();
            panel2 = new Panel();
            grpbox_otoin4 = new GroupBox();
            cbx_HangXe = new ComboBox();
            panel3 = new Panel();
            btn_cancel = new FontAwesome.Sharp.IconButton();
            btn_Add = new FontAwesome.Sharp.IconButton();
            cbx_MauXe = new ComboBox();
            cbx_LoaiXe = new ComboBox();
            metroLabel6 = new MetroFramework.Controls.MetroLabel();
            metroLabel5 = new MetroFramework.Controls.MetroLabel();
            metroLabel4 = new MetroFramework.Controls.MetroLabel();
            metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            metroLabel3 = new MetroFramework.Controls.MetroLabel();
            metroLabel2 = new MetroFramework.Controls.MetroLabel();
            metroLabel1 = new MetroFramework.Controls.MetroLabel();
            txt_GiaThue = new MetroFramework.Controls.MetroTextBox();
            txt_TrangThai = new MetroFramework.Controls.MetroTextBox();
            panel2.SuspendLayout();
            grpbox_otoin4.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = Color.Coral;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(460, 78);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(grpbox_otoin4);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 78);
            panel2.Name = "panel2";
            panel2.Size = new Size(460, 441);
            panel2.TabIndex = 1;
            // 
            // grpbox_otoin4
            // 
            grpbox_otoin4.Controls.Add(cbx_HangXe);
            grpbox_otoin4.Controls.Add(panel3);
            grpbox_otoin4.Controls.Add(cbx_MauXe);
            grpbox_otoin4.Controls.Add(cbx_LoaiXe);
            grpbox_otoin4.Controls.Add(metroLabel6);
            grpbox_otoin4.Controls.Add(metroLabel5);
            grpbox_otoin4.Controls.Add(metroLabel4);
            grpbox_otoin4.Controls.Add(metroTextBox1);
            grpbox_otoin4.Controls.Add(metroLabel3);
            grpbox_otoin4.Controls.Add(metroLabel2);
            grpbox_otoin4.Controls.Add(metroLabel1);
            grpbox_otoin4.Controls.Add(txt_GiaThue);
            grpbox_otoin4.Controls.Add(txt_TrangThai);
            grpbox_otoin4.Location = new Point(56, 33);
            grpbox_otoin4.Name = "grpbox_otoin4";
            grpbox_otoin4.Size = new Size(349, 364);
            grpbox_otoin4.TabIndex = 1;
            grpbox_otoin4.TabStop = false;
            grpbox_otoin4.Text = "Thông tin xe";
            // 
            // cbx_HangXe
            // 
            cbx_HangXe.FormattingEnabled = true;
            cbx_HangXe.Location = new Point(141, 239);
            cbx_HangXe.Name = "cbx_HangXe";
            cbx_HangXe.Size = new Size(151, 28);
            cbx_HangXe.TabIndex = 11;
            // 
            // panel3
            // 
            panel3.Controls.Add(btn_cancel);
            panel3.Controls.Add(btn_Add);
            panel3.Location = new Point(36, 286);
            panel3.Name = "panel3";
            panel3.Size = new Size(256, 58);
            panel3.TabIndex = 0;
            // 
            // btn_cancel
            // 
            btn_cancel.IconChar = FontAwesome.Sharp.IconChar.None;
            btn_cancel.IconColor = Color.Black;
            btn_cancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_cancel.Location = new Point(14, 14);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(94, 29);
            btn_cancel.TabIndex = 1;
            btn_cancel.Text = "Hủy";
            btn_cancel.UseVisualStyleBackColor = true;
            // 
            // btn_Add
            // 
            btn_Add.IconChar = FontAwesome.Sharp.IconChar.None;
            btn_Add.IconColor = Color.Black;
            btn_Add.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_Add.Location = new Point(142, 14);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(94, 29);
            btn_Add.TabIndex = 0;
            btn_Add.Text = "Thêm";
            btn_Add.UseVisualStyleBackColor = true;
            btn_Add.Click += btn_Add_Click;
            // 
            // cbx_MauXe
            // 
            cbx_MauXe.FormattingEnabled = true;
            cbx_MauXe.Location = new Point(141, 171);
            cbx_MauXe.Name = "cbx_MauXe";
            cbx_MauXe.Size = new Size(151, 28);
            cbx_MauXe.TabIndex = 10;
            // 
            // cbx_LoaiXe
            // 
            cbx_LoaiXe.FormattingEnabled = true;
            cbx_LoaiXe.Location = new Point(141, 205);
            cbx_LoaiXe.Name = "cbx_LoaiXe";
            cbx_LoaiXe.Size = new Size(151, 28);
            cbx_LoaiXe.TabIndex = 9;
            // 
            // metroLabel6
            // 
            metroLabel6.AutoSize = true;
            metroLabel6.CustomBackground = false;
            metroLabel6.FontSize = MetroFramework.MetroLabelSize.Medium;
            metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Light;
            metroLabel6.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            metroLabel6.Location = new Point(36, 172);
            metroLabel6.Name = "metroLabel6";
            metroLabel6.Size = new Size(91, 20);
            metroLabel6.Style = MetroFramework.MetroColorStyle.Blue;
            metroLabel6.StyleManager = null;
            metroLabel6.TabIndex = 8;
            metroLabel6.Text = "Chọn mẫu xe";
            metroLabel6.Theme = MetroFramework.MetroThemeStyle.Light;
            metroLabel6.UseStyleColors = false;
            // 
            // metroLabel5
            // 
            metroLabel5.AutoSize = true;
            metroLabel5.CustomBackground = false;
            metroLabel5.FontSize = MetroFramework.MetroLabelSize.Medium;
            metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Light;
            metroLabel5.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            metroLabel5.Location = new Point(36, 208);
            metroLabel5.Name = "metroLabel5";
            metroLabel5.Size = new Size(85, 20);
            metroLabel5.Style = MetroFramework.MetroColorStyle.Blue;
            metroLabel5.StyleManager = null;
            metroLabel5.TabIndex = 7;
            metroLabel5.Text = "Chọn loại xe";
            metroLabel5.Theme = MetroFramework.MetroThemeStyle.Light;
            metroLabel5.UseStyleColors = false;
            // 
            // metroLabel4
            // 
            metroLabel4.AutoSize = true;
            metroLabel4.CustomBackground = false;
            metroLabel4.FontSize = MetroFramework.MetroLabelSize.Medium;
            metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Light;
            metroLabel4.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            metroLabel4.Location = new Point(36, 247);
            metroLabel4.Name = "metroLabel4";
            metroLabel4.Size = new Size(95, 20);
            metroLabel4.Style = MetroFramework.MetroColorStyle.Blue;
            metroLabel4.StyleManager = null;
            metroLabel4.TabIndex = 6;
            metroLabel4.Text = "Chọn hãng xe";
            metroLabel4.Theme = MetroFramework.MetroThemeStyle.Light;
            metroLabel4.UseStyleColors = false;
            // 
            // metroTextBox1
            // 
            metroTextBox1.FontSize = MetroFramework.MetroTextBoxSize.Small;
            metroTextBox1.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            metroTextBox1.Location = new Point(113, 28);
            metroTextBox1.Multiline = false;
            metroTextBox1.Name = "metroTextBox1";
            metroTextBox1.SelectedText = "";
            metroTextBox1.Size = new Size(179, 29);
            metroTextBox1.Style = MetroFramework.MetroColorStyle.Blue;
            metroTextBox1.StyleManager = null;
            metroTextBox1.TabIndex = 5;
            metroTextBox1.Theme = MetroFramework.MetroThemeStyle.Light;
            metroTextBox1.UseStyleColors = false;
            // 
            // metroLabel3
            // 
            metroLabel3.AutoSize = true;
            metroLabel3.CustomBackground = false;
            metroLabel3.FontSize = MetroFramework.MetroLabelSize.Medium;
            metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Light;
            metroLabel3.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            metroLabel3.Location = new Point(36, 37);
            metroLabel3.Name = "metroLabel3";
            metroLabel3.Size = new Size(42, 20);
            metroLabel3.Style = MetroFramework.MetroColorStyle.Blue;
            metroLabel3.StyleManager = null;
            metroLabel3.TabIndex = 4;
            metroLabel3.Text = "ID Xe";
            metroLabel3.Theme = MetroFramework.MetroThemeStyle.Light;
            metroLabel3.UseStyleColors = false;
            // 
            // metroLabel2
            // 
            metroLabel2.AutoSize = true;
            metroLabel2.CustomBackground = false;
            metroLabel2.FontSize = MetroFramework.MetroLabelSize.Medium;
            metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Light;
            metroLabel2.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            metroLabel2.Location = new Point(36, 128);
            metroLabel2.Name = "metroLabel2";
            metroLabel2.Size = new Size(61, 20);
            metroLabel2.Style = MetroFramework.MetroColorStyle.Blue;
            metroLabel2.StyleManager = null;
            metroLabel2.TabIndex = 3;
            metroLabel2.Text = "Giá thuê";
            metroLabel2.Theme = MetroFramework.MetroThemeStyle.Light;
            metroLabel2.UseStyleColors = false;
            // 
            // metroLabel1
            // 
            metroLabel1.AutoSize = true;
            metroLabel1.CustomBackground = false;
            metroLabel1.FontSize = MetroFramework.MetroLabelSize.Medium;
            metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Light;
            metroLabel1.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            metroLabel1.Location = new Point(38, 89);
            metroLabel1.Name = "metroLabel1";
            metroLabel1.Size = new Size(69, 20);
            metroLabel1.Style = MetroFramework.MetroColorStyle.Blue;
            metroLabel1.StyleManager = null;
            metroLabel1.TabIndex = 2;
            metroLabel1.Text = "Trạng thái";
            metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
            metroLabel1.UseStyleColors = false;
            // 
            // txt_GiaThue
            // 
            txt_GiaThue.FontSize = MetroFramework.MetroTextBoxSize.Small;
            txt_GiaThue.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            txt_GiaThue.Location = new Point(113, 128);
            txt_GiaThue.Multiline = false;
            txt_GiaThue.Name = "txt_GiaThue";
            txt_GiaThue.SelectedText = "";
            txt_GiaThue.Size = new Size(179, 29);
            txt_GiaThue.Style = MetroFramework.MetroColorStyle.Blue;
            txt_GiaThue.StyleManager = null;
            txt_GiaThue.TabIndex = 1;
            txt_GiaThue.Theme = MetroFramework.MetroThemeStyle.Light;
            txt_GiaThue.UseStyleColors = false;
            // 
            // txt_TrangThai
            // 
            txt_TrangThai.FontSize = MetroFramework.MetroTextBoxSize.Small;
            txt_TrangThai.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            txt_TrangThai.Location = new Point(113, 80);
            txt_TrangThai.Multiline = false;
            txt_TrangThai.Name = "txt_TrangThai";
            txt_TrangThai.SelectedText = "";
            txt_TrangThai.Size = new Size(179, 29);
            txt_TrangThai.Style = MetroFramework.MetroColorStyle.Blue;
            txt_TrangThai.StyleManager = null;
            txt_TrangThai.TabIndex = 0;
            txt_TrangThai.Theme = MetroFramework.MetroThemeStyle.Light;
            txt_TrangThai.UseStyleColors = false;
            // 
            // FormAddOto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 519);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormAddOto";
            Text = "FormAddOto";
            panel2.ResumeLayout(false);
            grpbox_otoin4.ResumeLayout(false);
            grpbox_otoin4.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private GroupBox grpbox_otoin4;
        private Panel panel3;
        private FontAwesome.Sharp.IconButton btn_cancel;
        private FontAwesome.Sharp.IconButton btn_Add;
        private ComboBox cbx_HangXe;
        private ComboBox cbx_MauXe;
        private ComboBox cbx_LoaiXe;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txt_GiaThue;
        private MetroFramework.Controls.MetroTextBox txt_TrangThai;
    }
}