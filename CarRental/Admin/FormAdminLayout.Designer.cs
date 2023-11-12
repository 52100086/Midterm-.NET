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
			materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
			tab_Home = new TabPage();
			tab_Car = new TabPage();
			tab_Customer = new TabPage();
			tab_Order = new TabPage();
			tab_Schedule = new TabPage();
			tab_Chart = new TabPage();
			imageList1 = new ImageList(components);
			materialTabControl1.SuspendLayout();
			SuspendLayout();
			// 
			// materialTabControl1
			// 
			materialTabControl1.Controls.Add(tab_Home);
			materialTabControl1.Controls.Add(tab_Car);
			materialTabControl1.Controls.Add(tab_Customer);
			materialTabControl1.Controls.Add(tab_Order);
			materialTabControl1.Controls.Add(tab_Schedule);
			materialTabControl1.Controls.Add(tab_Chart);
			materialTabControl1.Depth = 0;
			materialTabControl1.Dock = DockStyle.Fill;
			materialTabControl1.ImageList = imageList1;
			materialTabControl1.Location = new Point(3, 64);
			materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
			materialTabControl1.Multiline = true;
			materialTabControl1.Name = "materialTabControl1";
			materialTabControl1.SelectedIndex = 0;
			materialTabControl1.Size = new Size(1086, 501);
			materialTabControl1.TabIndex = 1;
			// 
			// tab_Home
			// 
			tab_Home.BackColor = Color.White;
			tab_Home.ImageKey = "Home.png";
			tab_Home.Location = new Point(4, 29);
			tab_Home.Name = "tab_Home";
			tab_Home.Padding = new Padding(3);
			tab_Home.Size = new Size(1078, 468);
			tab_Home.TabIndex = 0;
			tab_Home.Text = "Trang chủ";
			// 
			// tab_Car
			// 
			tab_Car.BackColor = Color.White;
			tab_Car.ImageKey = "car.png";
			tab_Car.Location = new Point(4, 29);
			tab_Car.Name = "tab_Car";
			tab_Car.Padding = new Padding(3);
			tab_Car.Size = new Size(1078, 468);
			tab_Car.TabIndex = 1;
			tab_Car.Text = "Quản lý xe";
			// 
			// tab_Customer
			// 
			tab_Customer.BackColor = Color.White;
			tab_Customer.ImageKey = "Customer.png";
			tab_Customer.Location = new Point(4, 29);
			tab_Customer.Name = "tab_Customer";
			tab_Customer.Size = new Size(1078, 468);
			tab_Customer.TabIndex = 2;
			tab_Customer.Text = "Quản lý khách hàng";
			// 
			// tab_Order
			// 
			tab_Order.BackColor = Color.White;
			tab_Order.ImageKey = "Order.png";
			tab_Order.Location = new Point(4, 29);
			tab_Order.Name = "tab_Order";
			tab_Order.Size = new Size(1078, 468);
			tab_Order.TabIndex = 3;
			tab_Order.Text = "Quản lý đơn hàng";
			// 
			// tab_Schedule
			// 
			tab_Schedule.BackColor = Color.White;
			tab_Schedule.ImageKey = "schedule.png";
			tab_Schedule.Location = new Point(4, 29);
			tab_Schedule.Name = "tab_Schedule";
			tab_Schedule.Size = new Size(1078, 468);
			tab_Schedule.TabIndex = 4;
			tab_Schedule.Text = "Quản lý lịch trình";
			// 
			// tab_Chart
			// 
			tab_Chart.BackColor = Color.White;
			tab_Chart.ImageKey = "chartline.png";
			tab_Chart.Location = new Point(4, 29);
			tab_Chart.Name = "tab_Chart";
			tab_Chart.Size = new Size(1078, 468);
			tab_Chart.TabIndex = 5;
			tab_Chart.Text = "Thống kê";
			// 
			// imageList1
			// 
			imageList1.ColorDepth = ColorDepth.Depth32Bit;
			imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
			imageList1.TransparentColor = Color.Transparent;
			imageList1.Images.SetKeyName(0, "car.png");
			imageList1.Images.SetKeyName(1, "chartline.png");
			imageList1.Images.SetKeyName(2, "Customer.png");
			imageList1.Images.SetKeyName(3, "Home.png");
			imageList1.Images.SetKeyName(4, "Order.png");
			imageList1.Images.SetKeyName(5, "schedule.png");
			// 
			// FormAdminLayout
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1092, 568);
			Controls.Add(materialTabControl1);
			DrawerShowIconsWhenHidden = true;
			DrawerTabControl = materialTabControl1;
			Name = "FormAdminLayout";
			materialTabControl1.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
		private TabPage tab_Home;
		private TabPage tab_Car;
		private ImageList imageList1;
		private TabPage tab_Customer;
		private TabPage tab_Order;
		private TabPage tab_Schedule;
		private TabPage tab_Chart;
	}
}