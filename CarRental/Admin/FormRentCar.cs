using BUS;
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
	public partial class FormRentCar : Form
	{
		readonly MaterialSkin.MaterialSkinManager materialSkinManager;
		private readonly BUS_XeOto _busXeOto;
		private readonly BUS_KhachHang _busKhachHang;
		//private readonly BUS_Accoun
		public FormRentCar()
		{
			InitializeComponent();
		}
	}
}
