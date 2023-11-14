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
		//private readonly BUS_XeOto _busXeOto = new BUS_XeOto();

		public FormAdminLayout()
		{
			InitializeComponent();
			materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
			materialSkinManager.EnforceBackcolorOnAllComponents = true;
			materialSkinManager.AddFormToManage(this);
			materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
			materialSkinManager.ColorScheme = new ColorScheme(
				Primary.BlueGrey800,
				Primary.BlueGrey900,
				Primary.BlueGrey500,
				Accent.LightBlue200,
				TextShade.WHITE);
			FormCarType formCarType = new FormCarType();
			openForm(formCarType, tabPage_Home);
		}

		private void openForm(Form form, TabPage tab)
		{
			form.TopLevel = false;
			form.FormBorderStyle = FormBorderStyle.None;
			form.Dock = DockStyle.Fill;
			form.ControlBox = false;
			tab.Controls.Clear();

			tab.Controls.Add(form);

			form.Show();
		}
		public void startFormCarTypeList(int id)
		{
			FormListCarType formListCarType = new FormListCarType(id);
			openForm(formListCarType, tabPage_Home);
		}
		private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
		{
			switch (tabControl.SelectedIndex)
			{
				case 0:
					Form form0 = new FormCarType();
					openForm(form0, tabPage_Home);
					break;
				case 1:
					Form form1 = new OtoManagement();
					openForm(form1, tabPage_QLXe);
					break;
				case 2:
					Form form2 = new KhachHangManagement();
					openForm(form2, tabPage_QLKhachHang);
					break;
				case 3:
					Form form3 = new FormOrderManagement();
					openForm(form3, tabPage_QLDonHang);
					break;
				case 4:
					Form form4 = new FormSchedulerManagement();
					openForm(form4, tabPage_QLLichTrinh);
					break;
				case 5:
					Form form5 = new FormChart();
					openForm(form5, tabPage_ThongKe);
					break;
				default:
					break;
			}
		}

		private void FormAdminLayout_Load(object sender, EventArgs e)
		{

		}
	}
}
