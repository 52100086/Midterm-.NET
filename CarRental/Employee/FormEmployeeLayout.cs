using CarRental.Admin;
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

namespace CarRental.Employee
{
	public partial class FormEmployeeLayout : MaterialForm
	{
		readonly MaterialSkin.MaterialSkinManager materialSkinManager;
		public FormEmployeeLayout()
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
			openForm(formCarType, tab_home);
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
			openForm(formListCarType, tab_home);
		}

		private void tab_control_employee_SelectedIndexChanged(object sender, EventArgs e)
		{
			switch (tab_control_employee.SelectedIndex)
			{
				case 0:
					Form form0 = new FormCarType();
					openForm(form0, tab_home);
					break;
				case 1:
					Form form1 = new FormListKhachHang();
					openForm(form1, tab_khachhang);
					break;
				case 2:
					Form form2 = new FormListSchedule();
					openForm(form2, tab_schedule);
					break;
				default:
					break;
			}
		}
	}
}
