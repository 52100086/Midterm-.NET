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
	public partial class FormSchedulerManagement : Form
	{
		private BUS_DonDatXe _busDonDatXe = new BUS_DonDatXe();
		public FormSchedulerManagement()
		{
			InitializeComponent();
		}

		private async void FormSchedulerManagement_Load(object sender, EventArgs e)
		{

            dgv_schedule.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            var dondatxes = await _busDonDatXe.GetAllDonDatXe();

			if (dondatxes != null && dondatxes.Count > 0)
			{
				dgv_schedule.DataSource = dondatxes;
				var data = dondatxes
					.Where(x => x.TrangThai == "Chưa thanh toán")
					.Select(x => new
					{
						x.DonDatXeId,
						x.KhachHang.Ten,
						x.GiaThue,
						x.Thue,
						x.TongCong,
						x.ThoiGianThue,
						x.NgayLap,
						x.NgayThanhToan
					}).ToList();

				dgv_schedule.DataSource = data;
				dgv_schedule.Refresh();
			}
			else
			{
				MessageBox.Show("No data to display");
			}
		}

		private void btn_update_Click(object sender, EventArgs e)
		{
			if (dgv_schedule.SelectedRows.Count > 0)
			{
				// Lấy hàng được chọn
				DataGridViewRow selectedRow = dgv_schedule.SelectedRows[0];

				// Lấy giá trị của cột KhachHangId trong hàng được chọn
				int donDatXeId = Convert.ToInt32(selectedRow.Cells["DonDatXeId"].Value);
				var DonDatXe = _busDonDatXe.GetDonDatXeById(donDatXeId);
				DonDatXe.TrangThai = "Đã thanh toán";
				DonDatXe.NgayThanhToan = DateTime.Today;
				var update = _busDonDatXe.UpdateDonDatXe(DonDatXe);
				if (update != null)
				{
					MessageBox.Show("thanh cong");
				}
				else
				{
					MessageBox.Show("that bai");
				}
				dgv_schedule.Refresh();
			}
			else
			{
				MessageBox.Show("Vui lòng chọn một khách hàng để cap nhat");
			}
		}
	}
}
