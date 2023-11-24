using BUS;
using ClosedXML.Excel;
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
                worksheet.Cell("B1").Value = "Tên";
                worksheet.Cell("C1").Value = "Số điện thoại";
                worksheet.Cell("D1").Value = "Email";
                worksheet.Cell("E1").Value = "Địa chỉ";

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
                string fileName = $"Export_KhachHang_{DateTime.Now.ToString("yyyyMMdd_HHmmss")}.xlsx";
                string filePath = Path.Combine(projectDirectory, fileName);

                // Lưu workbook vào file Excel
                workbook.SaveAs(filePath);
            }
        }
        private void btn_export_Click(object sender, EventArgs e)
        {
            ExportToExcel(dgv_khachhang);
        }
    }
}
