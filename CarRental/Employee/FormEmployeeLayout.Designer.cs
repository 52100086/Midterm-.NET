namespace CarRental.Employee
{
	partial class FormEmployeeLayout
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmployeeLayout));
			imageList1 = new ImageList(components);
			tab_control_employee = new MaterialSkin.Controls.MaterialTabControl();
			tab_home = new TabPage();
			tab_khachhang = new TabPage();
			tab_schedule = new TabPage();
			tab_control_employee.SuspendLayout();
			SuspendLayout();
			// 
			// imageList1
			// 
			imageList1.ColorDepth = ColorDepth.Depth8Bit;
			imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
			imageList1.TransparentColor = Color.Transparent;
			imageList1.Images.SetKeyName(0, "403397993_2892235144247197_3839754847108211279_n.jpg");
			imageList1.Images.SetKeyName(1, "400032685_880565960359476_823304868121947014_n.jpg");
			imageList1.Images.SetKeyName(2, "403418157_362825939548321_5931514825756582264_n.jpg");
			// 
			// tab_control_employee
			// 
			tab_control_employee.Controls.Add(tab_home);
			tab_control_employee.Controls.Add(tab_khachhang);
			tab_control_employee.Controls.Add(tab_schedule);
			tab_control_employee.Depth = 0;
			tab_control_employee.Dock = DockStyle.Fill;
			tab_control_employee.ImageList = imageList1;
			tab_control_employee.Location = new Point(3, 64);
			tab_control_employee.MouseState = MaterialSkin.MouseState.HOVER;
			tab_control_employee.Multiline = true;
			tab_control_employee.Name = "tab_control_employee";
			tab_control_employee.SelectedIndex = 0;
			tab_control_employee.Size = new Size(864, 416);
			tab_control_employee.TabIndex = 0;
			tab_control_employee.SelectedIndexChanged += tab_control_employee_SelectedIndexChanged;
			// 
			// tab_home
			// 
			tab_home.BackColor = Color.White;
			tab_home.ImageKey = "403397993_2892235144247197_3839754847108211279_n.jpg";
			tab_home.Location = new Point(4, 39);
			tab_home.Name = "tab_home";
			tab_home.Padding = new Padding(3);
			tab_home.Size = new Size(856, 373);
			tab_home.TabIndex = 0;
			tab_home.Text = "Trang chủ";
			// 
			// tab_khachhang
			// 
			tab_khachhang.BackColor = Color.White;
			tab_khachhang.ImageKey = "400032685_880565960359476_823304868121947014_n.jpg";
			tab_khachhang.Location = new Point(4, 29);
			tab_khachhang.Name = "tab_khachhang";
			tab_khachhang.Padding = new Padding(3);
			tab_khachhang.Size = new Size(822, 383);
			tab_khachhang.TabIndex = 1;
			tab_khachhang.Text = "Khách hàng";
			// 
			// tab_schedule
			// 
			tab_schedule.BackColor = Color.White;
			tab_schedule.ImageKey = "403418157_362825939548321_5931514825756582264_n.jpg";
			tab_schedule.Location = new Point(4, 29);
			tab_schedule.Name = "tab_schedule";
			tab_schedule.Size = new Size(822, 383);
			tab_schedule.TabIndex = 2;
			tab_schedule.Text = "Lịch trình";
			// 
			// FormEmployeeLayout
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(870, 483);
			Controls.Add(tab_control_employee);
			DrawerShowIconsWhenHidden = true;
			DrawerTabControl = tab_control_employee;
			Name = "FormEmployeeLayout";
			Text = "FormEmployeeLayout";
			tab_control_employee.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private ImageList imageList1;
		private MaterialSkin.Controls.MaterialTabControl tab_control_employee;
		private TabPage tab_home;
		private TabPage tab_khachhang;
		private TabPage tab_schedule;
	}
}