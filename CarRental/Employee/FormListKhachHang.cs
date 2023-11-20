using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental.Employee
{
	public partial class FormListKhachHang : Form
	{
		private readonly BUS_KhachHang _busKhachHang = new BUS_KhachHang();
		public FormListKhachHang()
		{
			InitializeComponent();
		}

		private async void FormListKhachHang_Load(object sender, EventArgs e)
		{
            dgv_khachhang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            await BindDataToDataGridview();
            foreach (DataGridViewColumn column in dgv_khachhang.Columns)
            {
                if (column.Name == "KhachHangId")
                {
                    column.HeaderText = "ID";
                }
                else if (column.Name == "Ten")
                {
                    column.HeaderText = "Tên khách hàng";
                }
                else if (column.Name == "SoDienThoai")
                {
                    column.HeaderText = "Số điện thoại";
                }
                else if (column.Name == "Email")
                {
                    column.HeaderText = "Email";
                }
                else if (column.Name == "DiaChi")
                {
                    column.HeaderText = "Địa chỉ";
                }
            }
        }
        private async Task BindDataToDataGridview()
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
                dgv_khachhang.DataSource = null;

            }
        }
        private void btn_addKH_Click(object sender, EventArgs e)
		{
			Form kh = new FormAddKH();
			kh.ShowDialog();
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

		private void btn_searchKH_Click(object sender, EventArgs e)
		{
			string keyword = txt_searchKH.Text;
			var khachHangs = _busKhachHang.SearchKhachHang(keyword);
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
	}
}
