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
	}
}
