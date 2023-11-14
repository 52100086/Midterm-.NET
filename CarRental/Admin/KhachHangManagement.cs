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
	public partial class KhachHangManagement : Form
	{
		private readonly BUS_KhachHang _busKhachHang = new BUS_KhachHang();
		public KhachHangManagement()
		{
			InitializeComponent();
		}

		private void btn_addKH_Click(object sender, EventArgs e)
		{
			Form kh = new FormAddKH();
			kh.ShowDialog();
		}

		private async void KhachHangManagement_Load(object sender, EventArgs e)
		{
			var khachHangs = await _busKhachHang.GetAllKhachHangsAsync();

			if (khachHangs != null && khachHangs.Count > 0)
			{
				dgv_khachhang.DataSource = khachHangs;
				var data = khachHangs.Select(x => new
				{
					x.KhachHangId,
					x.Ten,
					x.SoDienThoai,
					x.Email,
					x.DiaChi
				}).ToList();

				dgv_khachhang.DataSource = data;
				dgv_khachhang.Refresh();
			}
			else
			{
				MessageBox.Show("No data to display");
			}
		}

		private void btn_deleteKH_Click(object sender, EventArgs e)
		{
			if (dgv_khachhang.SelectedRows.Count > 0)
			{
				// Lấy hàng được chọn
				DataGridViewRow selectedRow = dgv_khachhang.SelectedRows[0];

				// Lấy giá trị của cột KhachHangId trong hàng được chọn
				int khachHangId = Convert.ToInt32(selectedRow.Cells["KhachHangId"].Value);

				// Gọi phương thức xóa khách hàng
				_busKhachHang.DeleteKhachHang(khachHangId);

				MessageBox.Show("Xóa khách hàng thành công");

				// Refresh DataGridView để cập nhật danh sách sau khi xóa
				dgv_khachhang.Refresh();
			}
			else
			{
				MessageBox.Show("Vui lòng chọn một khách hàng để xóa");
			}
		}

		private void btn_updateKH_Click(object sender, EventArgs e)
		{
			if (dgv_khachhang.SelectedRows.Count > 0)
			{
				// Lấy hàng được chọn
				DataGridViewRow selectedRow = dgv_khachhang.SelectedRows[0];

				// Lấy giá trị của cột KhachHangId trong hàng được chọn
				int khachHangId = Convert.ToInt32(selectedRow.Cells["KhachHangId"].Value);
				FormUpdateKhachHang updateKhachHang = new FormUpdateKhachHang(khachHangId);
				updateKhachHang.ShowDialog();
				dgv_khachhang.Refresh();
			}
			else
			{
				MessageBox.Show("Vui lòng chọn một khách hàng để cap nhat");
			}
		}

		private void btn_addorder_Click(object sender, EventArgs e)
		{
			if (dgv_khachhang.SelectedRows.Count > 0)
			{
				// Lấy hàng được chọn
				DataGridViewRow selectedRow = dgv_khachhang.SelectedRows[0];

				// Lấy giá trị của cột KhachHangId trong hàng được chọn
				int khachHangId = Convert.ToInt32(selectedRow.Cells["KhachHangId"].Value);
				FormCarType formCarType = new FormCarType(khachHangId);
				formCarType.ShowDialog();
				dgv_khachhang.Refresh();
			}
			else
			{
				MessageBox.Show("Vui lòng chọn một khách hàng để cap nhat");
			}
		}
	}
}
