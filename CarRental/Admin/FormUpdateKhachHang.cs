using BUS;
using DTO;
using MaterialSkin.Controls;
using MaterialSkin;
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
	public partial class FormUpdateKhachHang : MaterialForm
	{

		readonly MaterialSkin.MaterialSkinManager materialSkinManager;
		private readonly BUS_KhachHang _busKhachHang = new BUS_KhachHang();
		private int _khachHangId;
		public FormUpdateKhachHang(int khachHangId)
		{
			InitializeComponent();
			materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
			materialSkinManager.EnforceBackcolorOnAllComponents = true;
			materialSkinManager.AddFormToManage(this);
			materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
			materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
			_khachHangId = khachHangId;
		}

		private void btn_update_Click(object sender, EventArgs e)
		{
			var khachhang = new KhachHang
			{
				KhachHangId = _khachHangId,
				Ten = txt_hoten.Text,
				SoDienThoai = txt_sdt.Text,
				DiaChi = txt_diachi.Text,
				Email = txt_sdt.Text
			};
			var update = _busKhachHang.UpdateKhachHang(khachhang);
			if (update != null)
			{
				MessageBox.Show("Update khach hang successfully");
			}
			else
			{
				MessageBox.Show("Fail to update");
			}
			this.Close();
		}

		private void FormUpdateKhachHang_Load(object sender, EventArgs e)
		{
			var khachhang = _busKhachHang.GetKhachHangByIdAsync(_khachHangId);
			txt_hoten.Text = khachhang.Ten;
			txt_email.Text = khachhang.Email;
			txt_diachi.Text = khachhang.DiaChi;
			txt_sdt.Text = khachhang.SoDienThoai;
		}

		private void btn_cancel_Click(object sender, EventArgs e)
		{
			var khachhang = _busKhachHang.GetKhachHangByIdAsync(_khachHangId);
			txt_hoten.Text = khachhang.Ten;
			txt_email.Text = khachhang.Email;
			txt_diachi.Text = khachhang.DiaChi;
			txt_sdt.Text = khachhang.SoDienThoai;
		}
	}
}
