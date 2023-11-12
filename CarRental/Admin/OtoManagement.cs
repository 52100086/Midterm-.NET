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
	public partial class OtoManagement : MaterialForm
	{
		readonly MaterialSkin.MaterialSkinManager materialSkinManager;
		private readonly BUS_XeOto _busXeOto;

		public OtoManagement(BUS_XeOto bus_XeOto)
		{
			InitializeComponent();
			materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
			materialSkinManager.EnforceBackcolorOnAllComponents = true;
			materialSkinManager.AddFormToManage(this);
			materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
			materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
			_busXeOto = bus_XeOto;
		}

		private void btn_add_Click(object sender, EventArgs e)
		{

		}
	}
}
