using BUS;
using DAL;
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
	public partial class FormOrderManagement : Form
	{
		private BUS_DonDatXe _busDonDatXe = new BUS_DonDatXe();
		public FormOrderManagement()
		{
			InitializeComponent();
		}

		private async void FormOrderManagement_Load(object sender, EventArgs e)
		{

            dgv_order.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            var dondatxes = await _busDonDatXe.GetAllDonDatXe();

			if (dondatxes != null && dondatxes.Count > 0)
			{
				dgv_order.DataSource = dondatxes;
				var data = dondatxes.Select(x => new
				{
					x.DonDatXeId,
					x.KhachHang.Ten,
					x.GiaThue,
					x.Thue,
					x.TongCong,
					x.NhienLieu.NhienLieuName,
					x.ThoiGianThue,
					x.NgayLap,
					x.NgayThanhToan,
					x.TrangThai
				}).ToList();

				dgv_order.DataSource = data;
				dgv_order.Refresh();
			}
			else
			{
				MessageBox.Show("No data to display");
			}
		}

		private void btn_update_Click(object sender, EventArgs e)
		{

		}

		private void btn_chitiet_Click(object sender, EventArgs e)
		{
			if (dgv_order.SelectedRows.Count > 0)
			{
				// Lấy hàng được chọn
				DataGridViewRow selectedRow = dgv_order.SelectedRows[0];

				// Lấy giá trị của cột KhachHangId trong hàng được chọn
				int DonDatXeId = Convert.ToInt32(selectedRow.Cells["DonDatXeId"].Value);
				var DonDatXe = _busDonDatXe.GetDonDatXeById(DonDatXeId);
				FormCarRentalOrder formCarRentalOrder = new FormCarRentalOrder(DonDatXe);
				formCarRentalOrder.ShowDialog();
				dgv_order.Refresh();
			}
			else
			{
				MessageBox.Show("Vui lòng chọn một đơn đặt xe để cap nhat");
			}
		}
	}
}
