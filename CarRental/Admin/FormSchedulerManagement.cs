using BUS;
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
	}
}
