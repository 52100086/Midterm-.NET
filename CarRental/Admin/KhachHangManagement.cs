using BUS;
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

namespace CarRental.Admin
{
	public partial class KhachHangManagement : MaterialForm
	{
		readonly MaterialSkin.MaterialSkinManager materialSkinManager;
		private readonly BUS_KhachHang _busKhachHang;
		public KhachHangManagement(BUS_KhachHang bus_KhachHang)
		{
			InitializeComponent();
			materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
			materialSkinManager.EnforceBackcolorOnAllComponents = true;
			materialSkinManager.AddFormToManage(this);
			materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
			materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
			_busKhachHang = bus_KhachHang;
		}
	}
}
