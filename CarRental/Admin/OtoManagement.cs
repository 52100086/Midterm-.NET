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
	public partial class OtoManagement : Form
	{

		private readonly BUS_XeOto _busXeOto = new BUS_XeOto();

		public OtoManagement()
		{
			InitializeComponent();
			//materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
			//materialSkinManager.EnforceBackcolorOnAllComponents = true;
			//materialSkinManager.AddFormToManage(this);
			//materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
			//materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
			
		}

		private void btn_add_Click(object sender, EventArgs e)
		{
			Form addOto = new FormAddOto(_busXeOto); addOto.ShowDialog();
		}

		private async void OtoManagement_Load(object sender, EventArgs e)
		{
			var xeOtos = await _busXeOto.GetAllXeOtosAsync();

			if (xeOtos != null && xeOtos.Count > 0)
			{
				dgv_car.DataSource = xeOtos;
				var data = xeOtos.Select(x => new
				{
					x.XeOtoId,
					x.TrangThai,
					x.GiaThue,
					x.LoaiXe.TenLoaiXe,
					x.HangXe.TenHangXe,
					x.MauXe.TenMauXe
				}).ToList();
				dgv_car.DataSource = data;
				dgv_car.Refresh();
			}
			else
			{
				MessageBox.Show("No data to display");
			}
		}

		private void btn_delete_Click(object sender, EventArgs e)
		{
			// Kiểm tra xem có một hàng được chọn trong DataGridView hay không
			if (dgv_car.SelectedRows.Count > 0)
			{
				// Lấy hàng được chọn
				DataGridViewRow selectedRow = dgv_car.SelectedRows[0];

				// Lấy giá trị của cột XeOtoId trong hàng được chọn
				int xeOtoId = Convert.ToInt32(selectedRow.Cells["XeOtoId"].Value);

				// Gọi phương thức xóa xe ô tô
				_busXeOto.DeleteXeOto(xeOtoId);

				MessageBox.Show("Xóa xe ô tô thành công");

				// Refresh DataGridView để cập nhật danh sách sau khi xóa
				dgv_car.Refresh();
			}
			else
			{
				MessageBox.Show("Vui lòng chọn một xe ô tô để xóa");
			}
		}

		private void btn_update_Click(object sender, EventArgs e)
		{
			if (dgv_car.SelectedRows.Count > 0)
			{
				// Lấy hàng được chọn
				DataGridViewRow selectedRow = dgv_car.SelectedRows[0];

				// Lấy giá trị của cột XeOtoId trong hàng được chọn
				int xeOtoId = Convert.ToInt32(selectedRow.Cells["XeOtoId"].Value);
				FormUpdateOto formUpdateOto = new FormUpdateOto(xeOtoId);
				formUpdateOto.ShowDialog();

				// Refresh DataGridView để cập nhật danh sách sau khi xóa
				dgv_car.Refresh();
			}
			else
			{
				MessageBox.Show("Vui lòng chọn một xe ô tô để cap nhat");
			}
		}
	}
}
