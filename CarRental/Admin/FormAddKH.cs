using BUS;
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
	public partial class FormAddKH : MaterialForm
	{

		readonly MaterialSkin.MaterialSkinManager materialSkinManager;
		private readonly BUS_KhachHang _busKhachHang = new BUS_KhachHang();
		public FormAddKH()
		{
			InitializeComponent();
			materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
			materialSkinManager.EnforceBackcolorOnAllComponents = true;
			materialSkinManager.AddFormToManage(this);
			materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
			materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

		}

		private void btn_add_Click(object sender, EventArgs e)
		{
			try
			{
				var new_KH = new KhachHang
				{
					Ten = txt_hoten.Text,
					SoDienThoai = txt_sdt.Text,
					Email = txt_email.Text,
					DiaChi = txt_diachi.Text
				};
				var createKH = _busKhachHang.CreateKhachHangAsync(new_KH);
				if (createKH != null)
				{
					MessageBox.Show("Khach hang created successfully");
				}
				else
				{
					// Failed to create the XeOto object
					MessageBox.Show("Failed to create Khach hang");
				}
			} 
			catch (Exception ex)
			{
				MessageBox.Show("An error occurred: " + ex.Message);
			}
			this.Close();
		}

		private void btn_cancel_Click(object sender, EventArgs e)
		{
			txt_hoten.Text = "";
			txt_email.Text = "";
			txt_diachi.Text = "";
			txt_sdt.Text = "";
		}
	}
}
