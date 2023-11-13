using BUS;
using DTO;
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
	public partial class FormListCarType : Form
	{
		private readonly BUS_XeOto _busXeOto;
		private int loaixeId;
		public FormListCarType(BUS_XeOto bus_XeOto, int loaixeId)
		{
			InitializeComponent();
			_busXeOto = bus_XeOto;
			this.loaixeId = loaixeId;
		}

		private void FormListCarType_Load(object sender, EventArgs e)
		{
			materialTextBox1.Text = loaixeId.ToString();
			var xeOtos = _busXeOto.GetXeOtosByType(loaixeId);
			if (xeOtos != null && xeOtos.Count > 0)
			{
				var data = xeOtos
					.Where(x => x.TrangThai == "Sẵn sàng")
					.Select(x => new
					{
						x.XeOtoId,
						TrangThai = "Sẵn sàng",
						x.GiaThue,
						x.LoaiXe.TenLoaiXe,
						x.HangXe.TenHangXe,
						x.MauXe.TenMauXe
					})
					.ToList();

				dgv_cartype.DataSource = data;
				dgv_cartype.Refresh();
			}
			else
			{
				MessageBox.Show("No data to display");
			}
		}

		private void btn_addtoorder_Click(object sender, EventArgs e)
		{
			if (dgv_cartype.SelectedRows.Count > 0)
			{
				DataGridViewRow selectedRow = dgv_cartype.SelectedRows[0];
				int xeOtoId = Convert.ToInt32(selectedRow.Cells["XeOtoId"].Value);
				FormCarRentalOrder carDetailsForm = new FormCarRentalOrder(xeOtoId);

				// Hiển thị form CarDetailsForm
				carDetailsForm.Show();
			}
			else
			{
				MessageBox.Show("No row selected");
			}
		}
	}
}
