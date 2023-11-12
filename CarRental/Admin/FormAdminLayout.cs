using BUS;
using CarRental.Admin;
using DTO;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental
{
	public partial class FormAdminLayout : MaterialForm
	{
		readonly MaterialSkin.MaterialSkinManager materialSkinManager;
		private Dictionary<TabPage, Panel> tabPagePanels;
		private MaterialForm? childForm;
		private readonly BUS_XeOto _busXeOto;
		private readonly BUS_KhachHang _busKhachHang;

		public FormAdminLayout(BUS_XeOto bus_XeOto, BUS_KhachHang bus_KhachHang)
		{
			InitializeComponent();
			materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
			materialSkinManager.EnforceBackcolorOnAllComponents = true;
			materialSkinManager.AddFormToManage(this);
			materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
			materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
			_busXeOto = bus_XeOto;
			_busKhachHang = bus_KhachHang;
			tabPagePanels = new Dictionary<TabPage, Panel>();
			foreach (TabPage tabPage in materialTabControl1.TabPages)
			{
				tabPage.Click += TabPage_Click;
				Panel panelFormContainer = new Panel();
				panelFormContainer.Dock = DockStyle.Fill;
				tabPage.Controls.Add(panelFormContainer);
				tabPagePanels.Add(tabPage, panelFormContainer);
			}
		}

		private void openForm(MaterialForm form)
		{
			// Đóng và giải phóng form con hiện tại (nếu có)
			if (childForm != null && !childForm.IsDisposed)
			{
				childForm.Close();
				childForm.Dispose();
			}

			// Lấy TabPage hiện tại
			TabPage currentTabPage = materialTabControl1.SelectedTab;

			// Lấy Panel tương ứng với TabPage
			Panel panelFormContainer = tabPagePanels[currentTabPage];

			// Gán form con mới
			childForm = form;
			childForm.TopLevel = false;
			childForm.FormBorderStyle = FormBorderStyle.None;
			childForm.Dock = DockStyle.Fill;
			childForm.ControlBox = false;
			childForm.Text = "";

			// Xóa tất cả các control trong panel
			panelFormContainer.Controls.Clear();

			// Thêm form con vào panel
			panelFormContainer.Controls.Add(childForm);

			// Hiển thị form con
			childForm.Show();
		}

		private void TabPage_Click(object? sender, EventArgs e)
		{
			if (sender is TabPage clickedTabPage)
			{
				// Xử lý sự kiện khi TabPage được nhấp
				switch (clickedTabPage.Name)
				{
					case "tab_Car":
						openForm(new OtoManagement(_busXeOto));
						break;
					case "tab_Customer":
						openForm(new KhachHangManagement(_busKhachHang));
						break;
					case "tab_Order":
						openForm(new FormOrderManagement());
						break;
					case "tab_Schedule":
						openForm(new FormSchedulerManagement());
						break;
					case "tab_Chart":
						openForm(new FormChart());
						break;
					default:
						break;
				}
			}
		}

	}
}
