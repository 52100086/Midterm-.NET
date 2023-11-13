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

namespace CarRental.Admin
{
	public partial class FormCarRentalOrder : MaterialForm
	{
		readonly MaterialSkin.MaterialSkinManager materialSkinManager;
		private int xeOtoId;
		private readonly BUS_KhachHang _busKhachHang = new BUS_KhachHang();
		private readonly BUS_DonDatXe _busDonDatXe = new BUS_DonDatXe();

		public FormCarRentalOrder(int xeOtoId)
		{
			InitializeComponent();
			materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
			materialSkinManager.EnforceBackcolorOnAllComponents = true;
			materialSkinManager.AddFormToManage(this);
			materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
			materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
			this.xeOtoId = xeOtoId;
		}

		private void btn_add_Click(object sender, EventArgs e)
		{
			var khachHang = new KhachHang
			{
				Ten = txt_hoten.Text,
				Email = txt_email.Text,
				DiaChi = txt_diachi.Text,
				SoDienThoai = txt_sdt.Text
			};
			
			var createKH = _busKhachHang.CreateKhachHangAsync(khachHang);
			if (createKH != null)
			{
				MessageBox.Show("thanh cong");
			}
			var donDatXe = new DonDatXe
			{
				KhachHangId = khachHang.KhachHangId,
				XeOtoId = xeOtoId,
				NgayLap = DateTime.Today,
				TrangThai = "Chưa thanh toán",
				Thue = 0.08
			};
			
			Dictionary<int, bool> tinhNangXeValues = new Dictionary<int, bool>
			{
				{ 1, cb_bando.Checked },
				{ 2, cb_bluetooth.Checked },
				{ 3, cb_cameralui.Checked },
				{ 4, cb_cameracaple.Checked },
				{ 5, cb_camerahanhtrinh.Checked },
				{ 6, cb_canhbaotocdo.Checked },
				{ 7, cb_cambienlop.Checked },
				{8, cb_cambienvacham.Checked },
				{9, cb_cuasotroi.Checked },
				{10, cb_dinhvigps.Checked },
				{11, cb_khecamusb.Checked },
				{12, cb_lopduphong.Checked },
				{13, cb_napthungxebantai.Checked },
				{14, cb_camera360.Checked }
			};
			if (rb_xang.Checked)
			{
				donDatXe.NhienLieuId = 1;
			}
			else if (rb_dien.Checked)
			{
				donDatXe.NhienLieuId = 2;
			}
			else if (rb_dau.Checked)
			{
				donDatXe.NhienLieuId = 3;
			}
			_busDonDatXe.AddDonDatXe(donDatXe);
			foreach (var tinhNangXe in tinhNangXeValues)
			{
				if (tinhNangXe.Value)
				{
					_busDonDatXe.AddDonDatXe_TinhNang(donDatXe.DonDatXeId, tinhNangXe.Key);
				}
			}
			MessageBox.Show("Thêm hóa đơn thành công");
			this.Close();
		}
	}
}
