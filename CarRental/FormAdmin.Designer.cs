namespace CarRental
{
    partial class FormAdmin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel_Nav = new Panel();
            btn_Employee = new FontAwesome.Sharp.IconButton();
            btn_Statistic_Report = new FontAwesome.Sharp.IconButton();
            btn_Schedule = new FontAwesome.Sharp.IconButton();
            btn_Orders = new FontAwesome.Sharp.IconButton();
            btn_Customer = new FontAwesome.Sharp.IconButton();
            btn_OtoManagement = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            img_Logo = new FontAwesome.Sharp.IconPictureBox();
            panel_Header = new Panel();
            lbl_Content = new MetroFramework.Controls.MetroLabel();
            img_Content = new FontAwesome.Sharp.IconPictureBox();
            btn_Exit = new FontAwesome.Sharp.IconPictureBox();
            btn_Maximize = new FontAwesome.Sharp.IconPictureBox();
            btn_Minimize = new FontAwesome.Sharp.IconPictureBox();
            panel_Main = new Panel();
            panel_Nav.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)img_Logo).BeginInit();
            panel_Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)img_Content).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_Exit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_Maximize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_Minimize).BeginInit();
            SuspendLayout();
            // 
            // panel_Nav
            // 
            panel_Nav.Controls.Add(btn_Employee);
            panel_Nav.Controls.Add(btn_Statistic_Report);
            panel_Nav.Controls.Add(btn_Schedule);
            panel_Nav.Controls.Add(btn_Orders);
            panel_Nav.Controls.Add(btn_Customer);
            panel_Nav.Controls.Add(btn_OtoManagement);
            panel_Nav.Controls.Add(panel1);
            panel_Nav.Dock = DockStyle.Left;
            panel_Nav.Location = new Point(0, 0);
            panel_Nav.Name = "panel_Nav";
            panel_Nav.Size = new Size(223, 745);
            panel_Nav.TabIndex = 2;
            // 
            // btn_Employee
            // 
            btn_Employee.Dock = DockStyle.Top;
            btn_Employee.IconChar = FontAwesome.Sharp.IconChar.Users;
            btn_Employee.IconColor = Color.Black;
            btn_Employee.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_Employee.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Employee.Location = new Point(0, 453);
            btn_Employee.Name = "btn_Employee";
            btn_Employee.Size = new Size(223, 74);
            btn_Employee.TabIndex = 0;
            btn_Employee.Text = "Quản lý nhân viên";
            btn_Employee.UseVisualStyleBackColor = true;
            btn_Employee.Click += btn_Employee_Click;
            // 
            // btn_Statistic_Report
            // 
            btn_Statistic_Report.Dock = DockStyle.Top;
            btn_Statistic_Report.IconChar = FontAwesome.Sharp.IconChar.BarChart;
            btn_Statistic_Report.IconColor = Color.Black;
            btn_Statistic_Report.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_Statistic_Report.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Statistic_Report.Location = new Point(0, 379);
            btn_Statistic_Report.Name = "btn_Statistic_Report";
            btn_Statistic_Report.Size = new Size(223, 74);
            btn_Statistic_Report.TabIndex = 2;
            btn_Statistic_Report.Text = "Báo cáo và thống kê";
            btn_Statistic_Report.UseVisualStyleBackColor = true;
            btn_Statistic_Report.Click += btn_Statistic_Report_Click;
            // 
            // btn_Schedule
            // 
            btn_Schedule.Dock = DockStyle.Top;
            btn_Schedule.IconChar = FontAwesome.Sharp.IconChar.LocationDot;
            btn_Schedule.IconColor = Color.Black;
            btn_Schedule.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_Schedule.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Schedule.Location = new Point(0, 305);
            btn_Schedule.Name = "btn_Schedule";
            btn_Schedule.Size = new Size(223, 74);
            btn_Schedule.TabIndex = 3;
            btn_Schedule.Text = "Quản lý lịch trình";
            btn_Schedule.UseVisualStyleBackColor = true;
            btn_Schedule.Click += btn_Schedule_Click;
            // 
            // btn_Orders
            // 
            btn_Orders.Dock = DockStyle.Top;
            btn_Orders.IconChar = FontAwesome.Sharp.IconChar.FileInvoice;
            btn_Orders.IconColor = Color.Black;
            btn_Orders.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_Orders.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Orders.Location = new Point(0, 231);
            btn_Orders.Name = "btn_Orders";
            btn_Orders.Size = new Size(223, 74);
            btn_Orders.TabIndex = 1;
            btn_Orders.Text = "Quản lý hóa đơn";
            btn_Orders.UseVisualStyleBackColor = true;
            btn_Orders.Click += btn_Orders_Click;
            // 
            // btn_Customer
            // 
            btn_Customer.Dock = DockStyle.Top;
            btn_Customer.IconChar = FontAwesome.Sharp.IconChar.Person;
            btn_Customer.IconColor = Color.Black;
            btn_Customer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_Customer.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Customer.Location = new Point(0, 157);
            btn_Customer.Name = "btn_Customer";
            btn_Customer.Size = new Size(223, 74);
            btn_Customer.TabIndex = 0;
            btn_Customer.Text = "Quản lý khách hàng";
            btn_Customer.UseVisualStyleBackColor = true;
            btn_Customer.Click += btn_Customer_Click;
            // 
            // btn_OtoManagement
            // 
            btn_OtoManagement.Dock = DockStyle.Top;
            btn_OtoManagement.IconChar = FontAwesome.Sharp.IconChar.Car;
            btn_OtoManagement.IconColor = Color.Black;
            btn_OtoManagement.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_OtoManagement.ImageAlign = ContentAlignment.MiddleLeft;
            btn_OtoManagement.Location = new Point(0, 83);
            btn_OtoManagement.Name = "btn_OtoManagement";
            btn_OtoManagement.Size = new Size(223, 74);
            btn_OtoManagement.TabIndex = 0;
            btn_OtoManagement.Text = "Quản lý xe ô tô";
            btn_OtoManagement.UseVisualStyleBackColor = true;
            btn_OtoManagement.Click += btn_OtoManagement_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(img_Logo);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(223, 83);
            panel1.TabIndex = 0;
            // 
            // img_Logo
            // 
            img_Logo.BackColor = SystemColors.Control;
            img_Logo.ForeColor = SystemColors.ControlText;
            img_Logo.IconChar = FontAwesome.Sharp.IconChar.None;
            img_Logo.IconColor = SystemColors.ControlText;
            img_Logo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            img_Logo.IconSize = 48;
            img_Logo.Location = new Point(35, 12);
            img_Logo.Name = "img_Logo";
            img_Logo.Size = new Size(53, 48);
            img_Logo.TabIndex = 0;
            img_Logo.TabStop = false;
            img_Logo.Click += img_Logo_Click;
            // 
            // panel_Header
            // 
            panel_Header.Controls.Add(lbl_Content);
            panel_Header.Controls.Add(img_Content);
            panel_Header.Controls.Add(btn_Exit);
            panel_Header.Controls.Add(btn_Maximize);
            panel_Header.Controls.Add(btn_Minimize);
            panel_Header.Dock = DockStyle.Top;
            panel_Header.Location = new Point(223, 0);
            panel_Header.Name = "panel_Header";
            panel_Header.Size = new Size(1048, 83);
            panel_Header.TabIndex = 3;
            panel_Header.MouseDown += panel_Header_MouseDown;
            // 
            // lbl_Content
            // 
            lbl_Content.AutoSize = true;
            lbl_Content.CustomBackground = false;
            lbl_Content.FontSize = MetroFramework.MetroLabelSize.Medium;
            lbl_Content.FontWeight = MetroFramework.MetroLabelWeight.Light;
            lbl_Content.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            lbl_Content.Location = new Point(72, 30);
            lbl_Content.Name = "lbl_Content";
            lbl_Content.Size = new Size(70, 20);
            lbl_Content.Style = MetroFramework.MetroColorStyle.Blue;
            lbl_Content.StyleManager = null;
            lbl_Content.TabIndex = 1;
            lbl_Content.Text = "Trang chủ";
            lbl_Content.Theme = MetroFramework.MetroThemeStyle.Light;
            lbl_Content.UseStyleColors = false;
            // 
            // img_Content
            // 
            img_Content.BackColor = SystemColors.Control;
            img_Content.ForeColor = SystemColors.ControlText;
            img_Content.IconChar = FontAwesome.Sharp.IconChar.House;
            img_Content.IconColor = SystemColors.ControlText;
            img_Content.IconFont = FontAwesome.Sharp.IconFont.Auto;
            img_Content.IconSize = 40;
            img_Content.Location = new Point(26, 20);
            img_Content.Name = "img_Content";
            img_Content.Size = new Size(40, 40);
            img_Content.TabIndex = 0;
            img_Content.TabStop = false;
            // 
            // btn_Exit
            // 
            btn_Exit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_Exit.BackColor = SystemColors.Control;
            btn_Exit.ForeColor = SystemColors.ControlText;
            btn_Exit.IconChar = FontAwesome.Sharp.IconChar.None;
            btn_Exit.IconColor = SystemColors.ControlText;
            btn_Exit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_Exit.IconSize = 40;
            btn_Exit.Location = new Point(916, 0);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(40, 40);
            btn_Exit.TabIndex = 4;
            btn_Exit.TabStop = false;
            btn_Exit.Click += btn_Exit_Click;
            // 
            // btn_Maximize
            // 
            btn_Maximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_Maximize.BackColor = SystemColors.Control;
            btn_Maximize.ForeColor = SystemColors.ControlText;
            btn_Maximize.IconChar = FontAwesome.Sharp.IconChar.None;
            btn_Maximize.IconColor = SystemColors.ControlText;
            btn_Maximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_Maximize.IconSize = 40;
            btn_Maximize.Location = new Point(962, 0);
            btn_Maximize.Name = "btn_Maximize";
            btn_Maximize.Size = new Size(40, 40);
            btn_Maximize.TabIndex = 3;
            btn_Maximize.TabStop = false;
            btn_Maximize.Click += btn_Maximize_Click;
            // 
            // btn_Minimize
            // 
            btn_Minimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_Minimize.BackColor = SystemColors.Control;
            btn_Minimize.ForeColor = SystemColors.ControlText;
            btn_Minimize.IconChar = FontAwesome.Sharp.IconChar.None;
            btn_Minimize.IconColor = SystemColors.ControlText;
            btn_Minimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_Minimize.IconSize = 40;
            btn_Minimize.Location = new Point(1008, 0);
            btn_Minimize.Name = "btn_Minimize";
            btn_Minimize.Size = new Size(40, 40);
            btn_Minimize.TabIndex = 2;
            btn_Minimize.TabStop = false;
            btn_Minimize.Click += btn_Minimize_Click;
            // 
            // panel_Main
            // 
            panel_Main.Dock = DockStyle.Fill;
            panel_Main.Location = new Point(223, 83);
            panel_Main.Name = "panel_Main";
            panel_Main.Size = new Size(1048, 662);
            panel_Main.TabIndex = 4;
            // 
            // FormAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1271, 745);
            Controls.Add(panel_Main);
            Controls.Add(panel_Header);
            Controls.Add(panel_Nav);
            Name = "FormAdmin";
            Resize += FormAdmin_Resize;
            panel_Nav.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)img_Logo).EndInit();
            panel_Header.ResumeLayout(false);
            panel_Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)img_Content).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_Exit).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_Maximize).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_Minimize).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel_Nav;
        private Panel panel_Header;
        private Panel panel_Main;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton btn_Employee;
        private FontAwesome.Sharp.IconButton btn_Statistic_Report;
        private FontAwesome.Sharp.IconButton btn_Schedule;
        private FontAwesome.Sharp.IconButton btn_Orders;
        private FontAwesome.Sharp.IconButton btn_Customer;
        private FontAwesome.Sharp.IconButton btn_OtoManagement;
        private FontAwesome.Sharp.IconPictureBox img_Logo;
        private FontAwesome.Sharp.IconPictureBox img_Content;
        private MetroFramework.Controls.MetroLabel lbl_Content;
        private FontAwesome.Sharp.IconPictureBox btn_Exit;
        private FontAwesome.Sharp.IconPictureBox btn_Maximize;
        private FontAwesome.Sharp.IconPictureBox btn_Minimize;
    }
}