using BUS;
using ClosedXML.Excel;
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
	public partial class OtoManagement : Form
	{

		private readonly BUS_XeOto _busXeOto = new BUS_XeOto();

		public OtoManagement()
		{
			InitializeComponent();
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

		private void btn_search_Click(object sender, EventArgs e)
		{
			string keyword = txt_search.Text;
			var xeOtos = _busXeOto.SearchByHangXeOrMauXe(keyword);
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
		private void ExportToExcel(DataGridView dataGridView)
		{
			// Lấy đường dẫn thư mục gốc của dự án
			string projectDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;

			// Tạo một workbook mới
			using (var workbook = new XLWorkbook())
			{
				// Tạo một worksheet trong workbook
				var worksheet = workbook.Worksheets.Add("Danh sách Khách hàng");

				// Ghi dữ liệu vào worksheet
				worksheet.Cell("A1").Value = "ID";
				worksheet.Cell("B1").Value = "Trạng thái xe";
				worksheet.Cell("C1").Value = "Giá thuê";
				worksheet.Cell("D1").Value = "Loại xe";
				worksheet.Cell("E1").Value = "Hãng xe";
				worksheet.Cell("F1").Value = "Mẫu xe";


				// Ghi dữ liệu từ DataGridView vào worksheet
				for (int row = 0; row < dataGridView.Rows.Count; row++)
				{
					for (int col = 0; col < dataGridView.Columns.Count; col++)
					{
						// Ghi dữ liệu từ cell của DataGridView vào cell tương ứng của worksheet
						worksheet.Cell(row + 2, col + 1).Value = dataGridView.Rows[row].Cells[col].Value?.ToString();
					}
				}

				// Chỉnh đường dẫn và tên file Excel trong thư mục của dự án
				string fileName = $"Export_DanhsachOto_{DateTime.Now.ToString("yyyyMMdd_HHmmss")}.xlsx";
				string filePath = Path.Combine(projectDirectory, fileName);

				// Lưu workbook vào file Excel
				workbook.SaveAs(filePath);
			}
		}

		private void btn_export_Click(object sender, EventArgs e)
		{
			ExportToExcel(dgv_car);
		}
	}
}
