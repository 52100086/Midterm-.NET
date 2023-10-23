
using FontAwesome.Sharp;
using System.Windows.Forms;

namespace CarRental.Admin
{
    partial class FormAddOto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private void round(PictureBox pt)
        {
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, pt.Width - 1, pt.Height - 1);
            Region rg = new Region(gp);
            pt.Region = rg;
        }
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
            metroLabel1 = new MetroFramework.Controls.MetroLabel();
            btn_Add = new IconButton();
            btn_cancel = new IconButton();
            metroLabel2 = new MetroFramework.Controls.MetroLabel();
            metroCheckBox1 = new MetroFramework.Controls.MetroCheckBox();
            metroCheckBox2 = new MetroFramework.Controls.MetroCheckBox();
            metroCheckBox3 = new MetroFramework.Controls.MetroCheckBox();
            metroCheckBox4 = new MetroFramework.Controls.MetroCheckBox();
            metroCheckBox5 = new MetroFramework.Controls.MetroCheckBox();
            metroCheckBox6 = new MetroFramework.Controls.MetroCheckBox();
            metroCheckBox7 = new MetroFramework.Controls.MetroCheckBox();
            metroCheckBox8 = new MetroFramework.Controls.MetroCheckBox();
            metroCheckBox9 = new MetroFramework.Controls.MetroCheckBox();
            metroCheckBox10 = new MetroFramework.Controls.MetroCheckBox();
            metroCheckBox11 = new MetroFramework.Controls.MetroCheckBox();
            metroCheckBox12 = new MetroFramework.Controls.MetroCheckBox();
            metroRadioButton1 = new MetroFramework.Controls.MetroRadioButton();
            metroRadioButton2 = new MetroFramework.Controls.MetroRadioButton();
            metroRadioButton3 = new MetroFramework.Controls.MetroRadioButton();
            metroPanel2 = new MetroFramework.Controls.MetroPanel();
            iconButton1 = new IconButton();
            metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            metroComboBox3 = new MetroFramework.Controls.MetroComboBox();
            metroLabel3 = new MetroFramework.Controls.MetroLabel();
            metroRadioButton4 = new MetroFramework.Controls.MetroRadioButton();
            metroCheckBox13 = new MetroFramework.Controls.MetroCheckBox();
            metroCheckBox14 = new MetroFramework.Controls.MetroCheckBox();
            metroLabel4 = new MetroFramework.Controls.MetroLabel();
            metroLabel5 = new MetroFramework.Controls.MetroLabel();
            metroLabel6 = new MetroFramework.Controls.MetroLabel();
            metroLabel7 = new MetroFramework.Controls.MetroLabel();
            metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            metroComboBox2 = new MetroFramework.Controls.MetroComboBox();
            this.pic_6 = new PictureBox();
            this.pic_7 = new PictureBox();
            this.pic_4 = new PictureBox();
            this.pic_3 = new PictureBox();
            this.pic_2 = new PictureBox();
            this.pic_1 = new PictureBox();
            pic_5 = new PictureBox();
            metroPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.pic_6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.pic_7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.pic_4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.pic_3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.pic_2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.pic_1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_5).BeginInit();
            SuspendLayout();
            // 
            // metroPanel1
            // 
            metroPanel1.CustomBackground = false;
            metroPanel1.Dock = DockStyle.Top;
            metroPanel1.HorizontalScrollbar = false;
            metroPanel1.HorizontalScrollbarBarColor = true;
            metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            metroPanel1.HorizontalScrollbarSize = 10;
            metroPanel1.Location = new Point(0, 0);
            metroPanel1.Name = "metroPanel1";
            metroPanel1.Size = new Size(1000, 75);
            metroPanel1.Style = MetroFramework.MetroColorStyle.Blue;
            metroPanel1.StyleManager = null;
            metroPanel1.TabIndex = 7;
            metroPanel1.Theme = MetroFramework.MetroThemeStyle.Light;
            metroPanel1.VerticalScrollbar = false;
            metroPanel1.VerticalScrollbarBarColor = true;
            metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroLabel1
            // 
            metroLabel1.AutoSize = true;
            metroLabel1.CustomBackground = false;
            metroLabel1.FontSize = MetroFramework.MetroLabelSize.Medium;
            metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Light;
            metroLabel1.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            metroLabel1.Location = new Point(30, 90);
            metroLabel1.Name = "metroLabel1";
            metroLabel1.Size = new Size(85, 20);
            metroLabel1.Style = MetroFramework.MetroColorStyle.Blue;
            metroLabel1.StyleManager = null;
            metroLabel1.TabIndex = 11;
            metroLabel1.Text = "Chọn loại xe";
            metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
            metroLabel1.UseStyleColors = false;
            // 
            // btn_Add
            // 
            btn_Add.IconChar = IconChar.None;
            btn_Add.IconColor = Color.Black;
            btn_Add.IconFont = IconFont.Auto;
            btn_Add.Location = new Point(245, 18);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(108, 34);
            btn_Add.TabIndex = 13;
            btn_Add.Text = "Thêm";
            btn_Add.UseVisualStyleBackColor = true;
            // 
            // btn_cancel
            // 
            btn_cancel.IconChar = IconChar.None;
            btn_cancel.IconColor = Color.Black;
            btn_cancel.IconFont = IconFont.Auto;
            btn_cancel.Location = new Point(17, 18);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(108, 34);
            btn_cancel.TabIndex = 14;
            btn_cancel.Text = "Hủy";
            btn_cancel.UseVisualStyleBackColor = true;
            // 
            // metroLabel2
            // 
            metroLabel2.AutoSize = true;
            metroLabel2.CustomBackground = false;
            metroLabel2.FontSize = MetroFramework.MetroLabelSize.Medium;
            metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Light;
            metroLabel2.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            metroLabel2.Location = new Point(30, 376);
            metroLabel2.Name = "metroLabel2";
            metroLabel2.Size = new Size(104, 20);
            metroLabel2.Style = MetroFramework.MetroColorStyle.Blue;
            metroLabel2.StyleManager = null;
            metroLabel2.TabIndex = 15;
            metroLabel2.Text = "Chọn tính năng";
            metroLabel2.Theme = MetroFramework.MetroThemeStyle.Light;
            metroLabel2.UseStyleColors = false;
            // 
            // metroCheckBox1
            // 
            metroCheckBox1.AutoSize = true;
            metroCheckBox1.CustomBackground = false;
            metroCheckBox1.FontSize = MetroFramework.MetroLinkSize.Small;
            metroCheckBox1.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            metroCheckBox1.Location = new Point(30, 414);
            metroCheckBox1.Name = "metroCheckBox1";
            metroCheckBox1.Size = new Size(65, 17);
            metroCheckBox1.Style = MetroFramework.MetroColorStyle.Blue;
            metroCheckBox1.StyleManager = null;
            metroCheckBox1.TabIndex = 16;
            metroCheckBox1.Text = "Bản đồ";
            metroCheckBox1.Theme = MetroFramework.MetroThemeStyle.Light;
            metroCheckBox1.UseStyleColors = false;
            metroCheckBox1.UseVisualStyleBackColor = true;
            // 
            // metroCheckBox2
            // 
            metroCheckBox2.AutoSize = true;
            metroCheckBox2.CustomBackground = false;
            metroCheckBox2.FontSize = MetroFramework.MetroLinkSize.Small;
            metroCheckBox2.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            metroCheckBox2.Location = new Point(168, 491);
            metroCheckBox2.Name = "metroCheckBox2";
            metroCheckBox2.Size = new Size(90, 17);
            metroCheckBox2.Style = MetroFramework.MetroColorStyle.Blue;
            metroCheckBox2.StyleManager = null;
            metroCheckBox2.TabIndex = 17;
            metroCheckBox2.Text = "Định vị GPS";
            metroCheckBox2.Theme = MetroFramework.MetroThemeStyle.Light;
            metroCheckBox2.UseStyleColors = false;
            metroCheckBox2.UseVisualStyleBackColor = true;
            // 
            // metroCheckBox3
            // 
            metroCheckBox3.AutoSize = true;
            metroCheckBox3.CustomBackground = false;
            metroCheckBox3.FontSize = MetroFramework.MetroLinkSize.Small;
            metroCheckBox3.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            metroCheckBox3.Location = new Point(305, 414);
            metroCheckBox3.Name = "metroCheckBox3";
            metroCheckBox3.Size = new Size(102, 17);
            metroCheckBox3.Style = MetroFramework.MetroColorStyle.Blue;
            metroCheckBox3.StyleManager = null;
            metroCheckBox3.TabIndex = 18;
            metroCheckBox3.Text = "Cảm biến lốp";
            metroCheckBox3.Theme = MetroFramework.MetroThemeStyle.Light;
            metroCheckBox3.UseStyleColors = false;
            metroCheckBox3.UseVisualStyleBackColor = true;
            // 
            // metroCheckBox4
            // 
            metroCheckBox4.AutoSize = true;
            metroCheckBox4.CustomBackground = false;
            metroCheckBox4.FontSize = MetroFramework.MetroLinkSize.Small;
            metroCheckBox4.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            metroCheckBox4.Location = new Point(168, 414);
            metroCheckBox4.Name = "metroCheckBox4";
            metroCheckBox4.Size = new Size(108, 17);
            metroCheckBox4.Style = MetroFramework.MetroColorStyle.Blue;
            metroCheckBox4.StyleManager = null;
            metroCheckBox4.TabIndex = 19;
            metroCheckBox4.Text = "Camera cập lề";
            metroCheckBox4.Theme = MetroFramework.MetroThemeStyle.Light;
            metroCheckBox4.UseStyleColors = false;
            metroCheckBox4.UseVisualStyleBackColor = true;
            // 
            // metroCheckBox5
            // 
            metroCheckBox5.AutoSize = true;
            metroCheckBox5.CustomBackground = false;
            metroCheckBox5.FontSize = MetroFramework.MetroLinkSize.Small;
            metroCheckBox5.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            metroCheckBox5.Location = new Point(30, 491);
            metroCheckBox5.Name = "metroCheckBox5";
            metroCheckBox5.Size = new Size(131, 17);
            metroCheckBox5.Style = MetroFramework.MetroColorStyle.Blue;
            metroCheckBox5.StyleManager = null;
            metroCheckBox5.TabIndex = 20;
            metroCheckBox5.Text = "Cảm biến va chạm";
            metroCheckBox5.Theme = MetroFramework.MetroThemeStyle.Light;
            metroCheckBox5.UseStyleColors = false;
            metroCheckBox5.UseVisualStyleBackColor = true;
            // 
            // metroCheckBox6
            // 
            metroCheckBox6.AutoSize = true;
            metroCheckBox6.CustomBackground = false;
            metroCheckBox6.FontSize = MetroFramework.MetroLinkSize.Small;
            metroCheckBox6.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            metroCheckBox6.Location = new Point(305, 491);
            metroCheckBox6.Name = "metroCheckBox6";
            metroCheckBox6.Size = new Size(108, 17);
            metroCheckBox6.Style = MetroFramework.MetroColorStyle.Blue;
            metroCheckBox6.StyleManager = null;
            metroCheckBox6.TabIndex = 21;
            metroCheckBox6.Text = "Lốp dự phòng";
            metroCheckBox6.Theme = MetroFramework.MetroThemeStyle.Light;
            metroCheckBox6.UseStyleColors = false;
            metroCheckBox6.UseVisualStyleBackColor = true;
            // 
            // metroCheckBox7
            // 
            metroCheckBox7.AutoSize = true;
            metroCheckBox7.CustomBackground = false;
            metroCheckBox7.FontSize = MetroFramework.MetroLinkSize.Small;
            metroCheckBox7.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            metroCheckBox7.Location = new Point(442, 452);
            metroCheckBox7.Name = "metroCheckBox7";
            metroCheckBox7.Size = new Size(131, 17);
            metroCheckBox7.Style = MetroFramework.MetroColorStyle.Blue;
            metroCheckBox7.StyleManager = null;
            metroCheckBox7.TabIndex = 22;
            metroCheckBox7.Text = "Camera hành trình";
            metroCheckBox7.Theme = MetroFramework.MetroThemeStyle.Light;
            metroCheckBox7.UseStyleColors = false;
            metroCheckBox7.UseVisualStyleBackColor = true;
            // 
            // metroCheckBox8
            // 
            metroCheckBox8.AutoSize = true;
            metroCheckBox8.CustomBackground = false;
            metroCheckBox8.FontSize = MetroFramework.MetroLinkSize.Small;
            metroCheckBox8.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            metroCheckBox8.Location = new Point(30, 452);
            metroCheckBox8.Name = "metroCheckBox8";
            metroCheckBox8.Size = new Size(101, 17);
            metroCheckBox8.Style = MetroFramework.MetroColorStyle.Blue;
            metroCheckBox8.StyleManager = null;
            metroCheckBox8.TabIndex = 23;
            metroCheckBox8.Text = "Khe cắm USB";
            metroCheckBox8.Theme = MetroFramework.MetroThemeStyle.Light;
            metroCheckBox8.UseStyleColors = false;
            metroCheckBox8.UseVisualStyleBackColor = true;
            // 
            // metroCheckBox9
            // 
            metroCheckBox9.AutoSize = true;
            metroCheckBox9.CustomBackground = false;
            metroCheckBox9.FontSize = MetroFramework.MetroLinkSize.Small;
            metroCheckBox9.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            metroCheckBox9.Location = new Point(305, 452);
            metroCheckBox9.Name = "metroCheckBox9";
            metroCheckBox9.Size = new Size(79, 17);
            metroCheckBox9.Style = MetroFramework.MetroColorStyle.Blue;
            metroCheckBox9.StyleManager = null;
            metroCheckBox9.TabIndex = 24;
            metroCheckBox9.Text = "Bluetooth";
            metroCheckBox9.Theme = MetroFramework.MetroThemeStyle.Light;
            metroCheckBox9.UseStyleColors = false;
            metroCheckBox9.UseVisualStyleBackColor = true;
            // 
            // metroCheckBox10
            // 
            metroCheckBox10.AutoSize = true;
            metroCheckBox10.CustomBackground = false;
            metroCheckBox10.FontSize = MetroFramework.MetroLinkSize.Small;
            metroCheckBox10.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            metroCheckBox10.Location = new Point(592, 452);
            metroCheckBox10.Name = "metroCheckBox10";
            metroCheckBox10.Size = new Size(147, 17);
            metroCheckBox10.Style = MetroFramework.MetroColorStyle.Blue;
            metroCheckBox10.StyleManager = null;
            metroCheckBox10.TabIndex = 25;
            metroCheckBox10.Text = "Nắp thùng xe bán tải";
            metroCheckBox10.Theme = MetroFramework.MetroThemeStyle.Light;
            metroCheckBox10.UseStyleColors = false;
            metroCheckBox10.UseVisualStyleBackColor = true;
            // 
            // metroCheckBox11
            // 
            metroCheckBox11.AutoSize = true;
            metroCheckBox11.CustomBackground = false;
            metroCheckBox11.FontSize = MetroFramework.MetroLinkSize.Small;
            metroCheckBox11.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            metroCheckBox11.Location = new Point(442, 491);
            metroCheckBox11.Name = "metroCheckBox11";
            metroCheckBox11.Size = new Size(86, 17);
            metroCheckBox11.Style = MetroFramework.MetroColorStyle.Blue;
            metroCheckBox11.StyleManager = null;
            metroCheckBox11.TabIndex = 26;
            metroCheckBox11.Text = "Camera lùi";
            metroCheckBox11.Theme = MetroFramework.MetroThemeStyle.Light;
            metroCheckBox11.UseStyleColors = false;
            metroCheckBox11.UseVisualStyleBackColor = true;
            // 
            // metroCheckBox12
            // 
            metroCheckBox12.AutoSize = true;
            metroCheckBox12.CustomBackground = false;
            metroCheckBox12.FontSize = MetroFramework.MetroLinkSize.Small;
            metroCheckBox12.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            metroCheckBox12.Location = new Point(442, 414);
            metroCheckBox12.Name = "metroCheckBox12";
            metroCheckBox12.Size = new Size(89, 17);
            metroCheckBox12.Style = MetroFramework.MetroColorStyle.Blue;
            metroCheckBox12.StyleManager = null;
            metroCheckBox12.TabIndex = 27;
            metroCheckBox12.Text = "Cửa sổ trời";
            metroCheckBox12.Theme = MetroFramework.MetroThemeStyle.Light;
            metroCheckBox12.UseStyleColors = false;
            metroCheckBox12.UseVisualStyleBackColor = true;
            // 
            // metroRadioButton1
            // 
            metroRadioButton1.AutoSize = true;
            metroRadioButton1.CustomBackground = false;
            metroRadioButton1.FontSize = MetroFramework.MetroLinkSize.Small;
            metroRadioButton1.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            metroRadioButton1.Location = new Point(168, 560);
            metroRadioButton1.Name = "metroRadioButton1";
            metroRadioButton1.Size = new Size(54, 17);
            metroRadioButton1.Style = MetroFramework.MetroColorStyle.Blue;
            metroRadioButton1.StyleManager = null;
            metroRadioButton1.TabIndex = 28;
            metroRadioButton1.TabStop = true;
            metroRadioButton1.Text = "Xăng";
            metroRadioButton1.Theme = MetroFramework.MetroThemeStyle.Light;
            metroRadioButton1.UseStyleColors = false;
            metroRadioButton1.UseVisualStyleBackColor = true;
            // 
            // metroRadioButton2
            // 
            metroRadioButton2.AutoSize = true;
            metroRadioButton2.CustomBackground = false;
            metroRadioButton2.FontSize = MetroFramework.MetroLinkSize.Small;
            metroRadioButton2.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            metroRadioButton2.Location = new Point(30, 560);
            metroRadioButton2.Name = "metroRadioButton2";
            metroRadioButton2.Size = new Size(59, 17);
            metroRadioButton2.Style = MetroFramework.MetroColorStyle.Blue;
            metroRadioButton2.StyleManager = null;
            metroRadioButton2.TabIndex = 29;
            metroRadioButton2.TabStop = true;
            metroRadioButton2.Text = "Tất cả";
            metroRadioButton2.Theme = MetroFramework.MetroThemeStyle.Light;
            metroRadioButton2.UseStyleColors = false;
            metroRadioButton2.UseVisualStyleBackColor = true;
            // 
            // metroRadioButton3
            // 
            metroRadioButton3.AutoSize = true;
            metroRadioButton3.CustomBackground = false;
            metroRadioButton3.FontSize = MetroFramework.MetroLinkSize.Small;
            metroRadioButton3.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            metroRadioButton3.Location = new Point(305, 560);
            metroRadioButton3.Name = "metroRadioButton3";
            metroRadioButton3.Size = new Size(47, 17);
            metroRadioButton3.Style = MetroFramework.MetroColorStyle.Blue;
            metroRadioButton3.StyleManager = null;
            metroRadioButton3.TabIndex = 30;
            metroRadioButton3.TabStop = true;
            metroRadioButton3.Text = "Dầu";
            metroRadioButton3.Theme = MetroFramework.MetroThemeStyle.Light;
            metroRadioButton3.UseStyleColors = false;
            metroRadioButton3.UseVisualStyleBackColor = true;
            // 
            // metroPanel2
            // 
            metroPanel2.Controls.Add(iconButton1);
            metroPanel2.Controls.Add(btn_cancel);
            metroPanel2.Controls.Add(btn_Add);
            metroPanel2.CustomBackground = false;
            metroPanel2.HorizontalScrollbar = false;
            metroPanel2.HorizontalScrollbarBarColor = true;
            metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            metroPanel2.HorizontalScrollbarSize = 10;
            metroPanel2.Location = new Point(600, 537);
            metroPanel2.Name = "metroPanel2";
            metroPanel2.Size = new Size(367, 76);
            metroPanel2.Style = MetroFramework.MetroColorStyle.Blue;
            metroPanel2.StyleManager = null;
            metroPanel2.TabIndex = 31;
            metroPanel2.Theme = MetroFramework.MetroThemeStyle.Light;
            metroPanel2.VerticalScrollbar = false;
            metroPanel2.VerticalScrollbarBarColor = true;
            metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            metroPanel2.VerticalScrollbarSize = 10;
            // 
            // iconButton1
            // 
            iconButton1.IconChar = IconChar.None;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = IconFont.Auto;
            iconButton1.Location = new Point(131, 18);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(108, 34);
            iconButton1.TabIndex = 15;
            iconButton1.Text = "Sửa";
            iconButton1.UseVisualStyleBackColor = true;
            // 
            // metroComboBox1
            // 
            metroComboBox1.DrawMode = DrawMode.OwnerDrawFixed;
            metroComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            metroComboBox1.FontSize = MetroFramework.MetroLinkSize.Medium;
            metroComboBox1.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            metroComboBox1.FormattingEnabled = true;
            metroComboBox1.ItemHeight = 24;
            metroComboBox1.Location = new Point(708, 245);
            metroComboBox1.Name = "metroComboBox1";
            metroComboBox1.Size = new Size(177, 30);
            metroComboBox1.Style = MetroFramework.MetroColorStyle.Blue;
            metroComboBox1.StyleManager = null;
            metroComboBox1.TabIndex = 32;
            metroComboBox1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroComboBox3
            // 
            metroComboBox3.DrawMode = DrawMode.OwnerDrawFixed;
            metroComboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            metroComboBox3.FontSize = MetroFramework.MetroLinkSize.Medium;
            metroComboBox3.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            metroComboBox3.FormattingEnabled = true;
            metroComboBox3.ItemHeight = 24;
            metroComboBox3.Location = new Point(708, 189);
            metroComboBox3.Name = "metroComboBox3";
            metroComboBox3.Size = new Size(177, 30);
            metroComboBox3.Style = MetroFramework.MetroColorStyle.Blue;
            metroComboBox3.StyleManager = null;
            metroComboBox3.TabIndex = 34;
            metroComboBox3.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroLabel3
            // 
            metroLabel3.AutoSize = true;
            metroLabel3.CustomBackground = false;
            metroLabel3.FontSize = MetroFramework.MetroLabelSize.Medium;
            metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Light;
            metroLabel3.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            metroLabel3.Location = new Point(30, 523);
            metroLabel3.Name = "metroLabel3";
            metroLabel3.Size = new Size(107, 20);
            metroLabel3.Style = MetroFramework.MetroColorStyle.Blue;
            metroLabel3.StyleManager = null;
            metroLabel3.TabIndex = 35;
            metroLabel3.Text = "Chọn nhiên liệu";
            metroLabel3.Theme = MetroFramework.MetroThemeStyle.Light;
            metroLabel3.UseStyleColors = false;
            // 
            // metroRadioButton4
            // 
            metroRadioButton4.AutoSize = true;
            metroRadioButton4.CustomBackground = false;
            metroRadioButton4.FontSize = MetroFramework.MetroLinkSize.Small;
            metroRadioButton4.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            metroRadioButton4.Location = new Point(442, 560);
            metroRadioButton4.Name = "metroRadioButton4";
            metroRadioButton4.Size = new Size(50, 17);
            metroRadioButton4.Style = MetroFramework.MetroColorStyle.Blue;
            metroRadioButton4.StyleManager = null;
            metroRadioButton4.TabIndex = 36;
            metroRadioButton4.TabStop = true;
            metroRadioButton4.Text = "Điện";
            metroRadioButton4.Theme = MetroFramework.MetroThemeStyle.Light;
            metroRadioButton4.UseStyleColors = false;
            metroRadioButton4.UseVisualStyleBackColor = true;
            // 
            // metroCheckBox13
            // 
            metroCheckBox13.AutoSize = true;
            metroCheckBox13.CustomBackground = false;
            metroCheckBox13.FontSize = MetroFramework.MetroLinkSize.Small;
            metroCheckBox13.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            metroCheckBox13.Location = new Point(168, 452);
            metroCheckBox13.Name = "metroCheckBox13";
            metroCheckBox13.Size = new Size(94, 17);
            metroCheckBox13.Style = MetroFramework.MetroColorStyle.Blue;
            metroCheckBox13.StyleManager = null;
            metroCheckBox13.TabIndex = 37;
            metroCheckBox13.Text = "Camera 360";
            metroCheckBox13.Theme = MetroFramework.MetroThemeStyle.Light;
            metroCheckBox13.UseStyleColors = false;
            metroCheckBox13.UseVisualStyleBackColor = true;
            // 
            // metroCheckBox14
            // 
            metroCheckBox14.AutoSize = true;
            metroCheckBox14.CustomBackground = false;
            metroCheckBox14.FontSize = MetroFramework.MetroLinkSize.Small;
            metroCheckBox14.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            metroCheckBox14.Location = new Point(592, 414);
            metroCheckBox14.Name = "metroCheckBox14";
            metroCheckBox14.Size = new Size(122, 17);
            metroCheckBox14.Style = MetroFramework.MetroColorStyle.Blue;
            metroCheckBox14.StyleManager = null;
            metroCheckBox14.TabIndex = 38;
            metroCheckBox14.Text = "Cảnh báo tốc độ";
            metroCheckBox14.Theme = MetroFramework.MetroThemeStyle.Light;
            metroCheckBox14.UseStyleColors = false;
            metroCheckBox14.UseVisualStyleBackColor = true;
            // 
            // metroLabel4
            // 
            metroLabel4.AutoSize = true;
            metroLabel4.CustomBackground = false;
            metroLabel4.FontSize = MetroFramework.MetroLabelSize.Medium;
            metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Light;
            metroLabel4.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            metroLabel4.Location = new Point(591, 255);
            metroLabel4.Name = "metroLabel4";
            metroLabel4.Size = new Size(60, 20);
            metroLabel4.Style = MetroFramework.MetroColorStyle.Blue;
            metroLabel4.StyleManager = null;
            metroLabel4.TabIndex = 39;
            metroLabel4.Text = "Hãng xe";
            metroLabel4.Theme = MetroFramework.MetroThemeStyle.Light;
            metroLabel4.UseStyleColors = false;
            // 
            // metroLabel5
            // 
            metroLabel5.AutoSize = true;
            metroLabel5.CustomBackground = false;
            metroLabel5.FontSize = MetroFramework.MetroLabelSize.Medium;
            metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Light;
            metroLabel5.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            metroLabel5.Location = new Point(590, 327);
            metroLabel5.Name = "metroLabel5";
            metroLabel5.Size = new Size(61, 20);
            metroLabel5.Style = MetroFramework.MetroColorStyle.Blue;
            metroLabel5.StyleManager = null;
            metroLabel5.TabIndex = 40;
            metroLabel5.Text = "Giá thuê";
            metroLabel5.Theme = MetroFramework.MetroThemeStyle.Light;
            metroLabel5.UseStyleColors = false;
            // 
            // metroLabel6
            // 
            metroLabel6.AutoSize = true;
            metroLabel6.CustomBackground = false;
            metroLabel6.FontSize = MetroFramework.MetroLabelSize.Medium;
            metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Light;
            metroLabel6.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            metroLabel6.Location = new Point(591, 199);
            metroLabel6.Name = "metroLabel6";
            metroLabel6.Size = new Size(69, 20);
            metroLabel6.Style = MetroFramework.MetroColorStyle.Blue;
            metroLabel6.StyleManager = null;
            metroLabel6.TabIndex = 41;
            metroLabel6.Text = "Trạng thái";
            metroLabel6.Theme = MetroFramework.MetroThemeStyle.Light;
            metroLabel6.UseStyleColors = false;
            // 
            // metroLabel7
            // 
            metroLabel7.AutoSize = true;
            metroLabel7.CustomBackground = false;
            metroLabel7.FontSize = MetroFramework.MetroLabelSize.Medium;
            metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Light;
            metroLabel7.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            metroLabel7.Location = new Point(592, 127);
            metroLabel7.Name = "metroLabel7";
            metroLabel7.Size = new Size(48, 20);
            metroLabel7.Style = MetroFramework.MetroColorStyle.Blue;
            metroLabel7.StyleManager = null;
            metroLabel7.TabIndex = 42;
            metroLabel7.Text = "Model";
            metroLabel7.Theme = MetroFramework.MetroThemeStyle.Light;
            metroLabel7.UseStyleColors = false;
            // 
            // metroTextBox1
            // 
            metroTextBox1.FontSize = MetroFramework.MetroTextBoxSize.Small;
            metroTextBox1.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            metroTextBox1.Location = new Point(708, 318);
            metroTextBox1.Multiline = false;
            metroTextBox1.Name = "metroTextBox1";
            metroTextBox1.SelectedText = "";
            metroTextBox1.Size = new Size(177, 29);
            metroTextBox1.Style = MetroFramework.MetroColorStyle.Blue;
            metroTextBox1.StyleManager = null;
            metroTextBox1.TabIndex = 43;
            metroTextBox1.Text = "metroTextBox1";
            metroTextBox1.Theme = MetroFramework.MetroThemeStyle.Light;
            metroTextBox1.UseStyleColors = false;
            // 
            // metroComboBox2
            // 
            metroComboBox2.DrawMode = DrawMode.OwnerDrawFixed;
            metroComboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            metroComboBox2.FontSize = MetroFramework.MetroLinkSize.Medium;
            metroComboBox2.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            metroComboBox2.FormattingEnabled = true;
            metroComboBox2.ItemHeight = 24;
            metroComboBox2.Location = new Point(708, 127);
            metroComboBox2.Name = "metroComboBox2";
            metroComboBox2.Size = new Size(177, 30);
            metroComboBox2.Style = MetroFramework.MetroColorStyle.Blue;
            metroComboBox2.StyleManager = null;
            metroComboBox2.TabIndex = 44;
            metroComboBox2.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // pic_6
            // 
            this.pic_6.Image = Properties.Resources.mpv;
            this.pic_6.Location = new Point(168, 255);
            this.pic_6.Name = "pic_6";
            this.pic_6.Size = new Size(95, 92);
            this.pic_6.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pic_6.TabIndex = 45;
            this.pic_6.TabStop = false;
            // 
            // pic_7
            // 
            this.pic_7.Image = Properties.Resources.pickup_truck;
            this.pic_7.Location = new Point(305, 255);
            this.pic_7.Name = "pic_7";
            this.pic_7.Size = new Size(95, 92);
            this.pic_7.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pic_7.TabIndex = 46;
            this.pic_7.TabStop = false;
            // 
            // pic_4
            // 
            this.pic_4.Image = Properties.Resources.car_suv_5_seats;
            this.pic_4.Location = new Point(442, 127);
            this.pic_4.Name = "pic_4";
            this.pic_4.Size = new Size(95, 92);
            this.pic_4.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pic_4.TabIndex = 47;
            this.pic_4.TabStop = false;
            // 
            // pic_3
            // 
            this.pic_3.Image = Properties.Resources.car_sedan_4_seats;
            this.pic_3.Location = new Point(305, 127);
            this.pic_3.Name = "pic_3";
            this.pic_3.Size = new Size(95, 92);
            this.pic_3.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pic_3.TabIndex = 48;
            this.pic_3.TabStop = false;
            // 
            // pic_2
            // 
            this.pic_2.Image = Properties.Resources.car_hatchback_4_seats;
            this.pic_2.Location = new Point(168, 127);
            this.pic_2.Name = "pic_2";
            this.pic_2.Size = new Size(95, 92);
            this.pic_2.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pic_2.TabIndex = 49;
            this.pic_2.TabStop = false;
            // 
            // pic_1
            // 
            this.pic_1.Image = Properties.Resources.car_mini_4_seats;
            this.pic_1.Location = new Point(30, 127);
            this.pic_1.Name = "pic_1";
            this.pic_1.Size = new Size(95, 92);
            this.pic_1.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pic_1.TabIndex = 50;
            this.pic_1.TabStop = false;
            // 
            // pic_5
            // 
            pic_5.Image = Properties.Resources.car_cuv_5_seats;
            pic_5.Location = new Point(30, 255);
            pic_5.Name = "pic_5";
            pic_5.Size = new Size(95, 92);
            pic_5.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_5.TabIndex = 51;
            pic_5.TabStop = false;
            // 
            // FormAddOto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 642);
            Controls.Add(metroComboBox2);
            Controls.Add(metroTextBox1);
            Controls.Add(metroLabel7);
            Controls.Add(metroLabel6);
            Controls.Add(metroLabel5);
            Controls.Add(metroLabel4);
            Controls.Add(metroCheckBox14);
            Controls.Add(metroCheckBox13);
            Controls.Add(metroRadioButton4);
            Controls.Add(metroLabel3);
            Controls.Add(metroComboBox3);
            Controls.Add(metroComboBox1);
            Controls.Add(metroPanel2);
            Controls.Add(metroRadioButton3);
            Controls.Add(metroRadioButton2);
            Controls.Add(metroRadioButton1);
            Controls.Add(metroCheckBox12);
            Controls.Add(metroCheckBox11);
            Controls.Add(metroCheckBox10);
            Controls.Add(metroCheckBox9);
            Controls.Add(metroCheckBox8);
            Controls.Add(metroCheckBox7);
            Controls.Add(metroCheckBox6);
            Controls.Add(metroCheckBox5);
            Controls.Add(metroCheckBox4);
            Controls.Add(metroCheckBox3);
            Controls.Add(metroCheckBox2);
            Controls.Add(metroCheckBox1);
            Controls.Add(metroLabel2);
            Controls.Add(metroLabel1);
            Controls.Add(metroPanel1);
            Controls.Add(pic_5);
            Controls.Add(this.pic_1);
            Controls.Add(this.pic_2);
            Controls.Add(this.pic_3);
            Controls.Add(this.pic_4);
            Controls.Add(this.pic_7);
            Controls.Add(this.pic_6);
            Name = "FormAddOto";
            Text = "FormAddOto";
            metroPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)this.pic_6).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.pic_7).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.pic_4).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.pic_3).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.pic_2).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.pic_1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox oto_type_1;
        private FontAwesome.Sharp.IconPictureBox oto_type_2;
        private FontAwesome.Sharp.IconPictureBox oto_type_3;
        private FontAwesome.Sharp.IconPictureBox oto_type_4;
        private FontAwesome.Sharp.IconPictureBox oto_type_5;
        private FontAwesome.Sharp.IconPictureBox oto_type_6;
        private FontAwesome.Sharp.IconPictureBox oto_type_7;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private FontAwesome.Sharp.IconButton btn_Add;
        private FontAwesome.Sharp.IconButton btn_cancel;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox1;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox2;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox3;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox4;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox5;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox6;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox7;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox8;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox9;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox10;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox11;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox12;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton1;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton2;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton3;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroComboBox metroComboBox3;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton4;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox13;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox14;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroComboBox metroComboBox2;
        private PictureBox oto_ty_1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pic_5;
    }
}