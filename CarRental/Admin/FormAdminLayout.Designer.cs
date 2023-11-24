namespace CarRental
{
    partial class FormAdminLayout
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdminLayout));
            imageList = new ImageList(components);
            tabControl = new MaterialSkin.Controls.MaterialTabControl();
            tabPage_Home = new TabPage();
            tabPage_QLXe = new TabPage();
            tabPage_QLKhachHang = new TabPage();
            tabPage_QLDonHang = new TabPage();
            tabPage_QLLichTrinh = new TabPage();
            tabPage_ThongKe = new TabPage();
            tab_employee = new TabPage();
            tabControl.SuspendLayout();
            SuspendLayout();
            // 
            // imageList
            // 
            imageList.ColorDepth = ColorDepth.Depth32Bit;
            imageList.ImageStream = (ImageListStreamer)resources.GetObject("imageList.ImageStream");
            imageList.TransparentColor = Color.Transparent;
            imageList.Images.SetKeyName(0, "car.png");
            imageList.Images.SetKeyName(1, "chartline.png");
            imageList.Images.SetKeyName(2, "customer.png");
            imageList.Images.SetKeyName(3, "home.png");
            imageList.Images.SetKeyName(4, "order.png");
            imageList.Images.SetKeyName(5, "schedule.png");
            imageList.Images.SetKeyName(6, "Customer.png");
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPage_Home);
            tabControl.Controls.Add(tabPage_QLXe);
            tabControl.Controls.Add(tabPage_QLKhachHang);
            tabControl.Controls.Add(tabPage_QLDonHang);
            tabControl.Controls.Add(tabPage_QLLichTrinh);
            tabControl.Controls.Add(tabPage_ThongKe);
            tabControl.Controls.Add(tab_employee);
            tabControl.Depth = 0;
            tabControl.Dock = DockStyle.Fill;
            tabControl.ImageList = imageList;
            tabControl.Location = new Point(3, 64);
            tabControl.Margin = new Padding(3, 4, 3, 4);
            tabControl.MouseState = MaterialSkin.MouseState.HOVER;
            tabControl.Multiline = true;
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1087, 501);
            tabControl.TabIndex = 0;
            tabControl.SelectedIndexChanged += tabControl_SelectedIndexChanged;
            // 
            // tabPage_Home
            // 
            tabPage_Home.BackColor = Color.White;
            tabPage_Home.ImageKey = "home.png";
            tabPage_Home.Location = new Point(4, 39);
            tabPage_Home.Margin = new Padding(3, 4, 3, 4);
            tabPage_Home.Name = "tabPage_Home";
            tabPage_Home.Padding = new Padding(3, 4, 3, 4);
            tabPage_Home.Size = new Size(1079, 458);
            tabPage_Home.TabIndex = 0;
            tabPage_Home.Text = "Trang chủ";
            // 
            // tabPage_QLXe
            // 
            tabPage_QLXe.BackColor = Color.White;
            tabPage_QLXe.ImageKey = "car.png";
            tabPage_QLXe.Location = new Point(4, 39);
            tabPage_QLXe.Margin = new Padding(3, 4, 3, 4);
            tabPage_QLXe.Name = "tabPage_QLXe";
            tabPage_QLXe.Padding = new Padding(3, 4, 3, 4);
            tabPage_QLXe.Size = new Size(1079, 458);
            tabPage_QLXe.TabIndex = 1;
            tabPage_QLXe.Text = "Quản lý xe";
            // 
            // tabPage_QLKhachHang
            // 
            tabPage_QLKhachHang.BackColor = Color.White;
            tabPage_QLKhachHang.ImageKey = "customer.png";
            tabPage_QLKhachHang.Location = new Point(4, 39);
            tabPage_QLKhachHang.Margin = new Padding(3, 4, 3, 4);
            tabPage_QLKhachHang.Name = "tabPage_QLKhachHang";
            tabPage_QLKhachHang.Size = new Size(1079, 458);
            tabPage_QLKhachHang.TabIndex = 2;
            tabPage_QLKhachHang.Text = "Quản lý khách hàng";
            // 
            // tabPage_QLDonHang
            // 
            tabPage_QLDonHang.BackColor = Color.White;
            tabPage_QLDonHang.ImageKey = "order.png";
            tabPage_QLDonHang.Location = new Point(4, 39);
            tabPage_QLDonHang.Margin = new Padding(3, 4, 3, 4);
            tabPage_QLDonHang.Name = "tabPage_QLDonHang";
            tabPage_QLDonHang.Size = new Size(1079, 458);
            tabPage_QLDonHang.TabIndex = 3;
            tabPage_QLDonHang.Text = "Quản lý đơn hàng";
            // 
            // tabPage_QLLichTrinh
            // 
            tabPage_QLLichTrinh.BackColor = Color.White;
            tabPage_QLLichTrinh.ImageKey = "schedule.png";
            tabPage_QLLichTrinh.Location = new Point(4, 39);
            tabPage_QLLichTrinh.Margin = new Padding(3, 4, 3, 4);
            tabPage_QLLichTrinh.Name = "tabPage_QLLichTrinh";
            tabPage_QLLichTrinh.Size = new Size(1079, 458);
            tabPage_QLLichTrinh.TabIndex = 4;
            tabPage_QLLichTrinh.Text = "Quản lý lịch trình";
            // 
            // tabPage_ThongKe
            // 
            tabPage_ThongKe.BackColor = Color.White;
            tabPage_ThongKe.ImageKey = "chartline.png";
            tabPage_ThongKe.Location = new Point(4, 39);
            tabPage_ThongKe.Margin = new Padding(3, 4, 3, 4);
            tabPage_ThongKe.Name = "tabPage_ThongKe";
            tabPage_ThongKe.Size = new Size(1079, 458);
            tabPage_ThongKe.TabIndex = 5;
            tabPage_ThongKe.Text = "Thống kê";
            // 
            // tab_employee
            // 
            tab_employee.ImageKey = "Customer.png";
            tab_employee.Location = new Point(4, 39);
            tab_employee.Name = "tab_employee";
            tab_employee.Size = new Size(1079, 458);
            tab_employee.TabIndex = 6;
            tab_employee.Text = "Quản lý nhân viên";
            tab_employee.UseVisualStyleBackColor = true;
            // 
            // FormAdminLayout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1093, 568);
            Controls.Add(tabControl);
            DrawerShowIconsWhenHidden = true;
            DrawerTabControl = tabControl;
            Name = "FormAdminLayout";
            Load += FormAdminLayout_Load;
            tabControl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private TabPage tab_Home;
        private TabPage tab_Car;
        private ImageList imageList;
        private TabPage tab_Customer;
        private TabPage tab_Order;
        private TabPage tab_Schedule;
        private TabPage tab_Chart;
        private MaterialSkin.Controls.MaterialTabControl tabControl;
        private TabPage tabPage_Home;
        private TabPage tabPage_QLXe;
        private TabPage tabPage_QLKhachHang;
        private TabPage tabPage_QLDonHang;
        private TabPage tabPage_QLLichTrinh;
        private TabPage tabPage_ThongKe;
        private TabPage tab_employee;
    }
}