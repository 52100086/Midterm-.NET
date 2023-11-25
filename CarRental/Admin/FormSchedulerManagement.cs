using BUS;
using ClosedXML.Excel;
using DAL;
using DocumentFormat.OpenXml.Wordprocessing;
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
            await BindDatatoDataGridView();
            foreach (DataGridViewColumn column in dgv_schedule.Columns)
            {
                if (column.Name == "DonDatXeId")
                {
                    column.HeaderText = "ID";
                }
                else if (column.Name == "Ten")
                {
                    column.HeaderText = "Tên khách hàng";
                }
                else if (column.Name == "GiaThue")
                {
                    column.HeaderText = "Giá thuê/ngày";
                }
                else if (column.Name == "Thue")
                {
                    column.HeaderText = "Thuế/ngày";
                }
                else if (column.Name == "TongCong")
                {
                    column.HeaderText = "Tổng tiền";
                }
                else if (column.Name == "ThoiGianThue")
                {
                    column.HeaderText = "Thời gian thuê";
                }
                else if (column.Name == "NgayLap")
                {
                    column.HeaderText = "Ngày thuê";
                }
                else if (column.Name == "NgayThanhToan")
                {
                    column.HeaderText = "Ngày thanh toán";
                }
            }
        }
        private async Task BindDatatoDataGridView()
        {

            var dondatxes = await _busDonDatXe.GetAllDonDatXe();

            if (dondatxes != null && dondatxes.Count > 0)
            {
                dgv_schedule.DataSource = dondatxes;
                var data = dondatxes
                    .Where(x => x.TrangThai == "Chưa thanh toán")
                    .Select(x => new
                    {
                        DonDatXeId = x.DonDatXeId,
                        TenKhachHang = x.KhachHang.Ten,
                        GiaThue = Math.Round(x.GiaThue, 2),
                        Thue = Math.Round(x.Thue),
                        TongCong = Math.Round(x.TongCong, 2),
                        ThoiGianThue = x.ThoiGianThue,
                        NgayLap = x.NgayLap,
                        NgayThanhToan = x.NgayThanhToan
                    }).ToList();

                dgv_schedule.DataSource = data;
                dgv_schedule.Refresh();
            }
            else
            {
                dgv_schedule.DataSource = null;
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

        private void btn_chitiet_Click(object sender, EventArgs e)
        {
            if (dgv_schedule.SelectedRows.Count > 0)
            {
                // Lấy hàng được chọn
                DataGridViewRow selectedRow = dgv_schedule.SelectedRows[0];

                // Lấy giá trị của cột KhachHangId trong hàng được chọn
                int DonDatXeId = Convert.ToInt32(selectedRow.Cells["DonDatXeId"].Value);
                var DonDatXe = _busDonDatXe.GetDonDatXeById(DonDatXeId);
                FormCarRentalOrder formCarRentalOrder = new FormCarRentalOrder(DonDatXe);
                formCarRentalOrder.ShowDialog();
                dgv_schedule.Refresh();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một đơn đặt xe để cap nhat");
            }
        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            ExportToExcel(dgv_schedule);
        }
        private void ExportToExcel(DataGridView dataGridView)
        {
            // Lấy đường dẫn thư mục gốc của dự án
            string projectDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;

            // Tạo một workbook mới
            using (var workbook = new XLWorkbook())
            {
                // Tạo một worksheet trong workbook
                var worksheet = workbook.Worksheets.Add("Danh sách Đơn đặt xe");

                // Ghi dữ liệu vào worksheet
                worksheet.Cell("A1").Value = "ID";
                worksheet.Cell("B1").Value = "Tên khách hàng";
                worksheet.Cell("C1").Value = "Giá thuê/ngày";
                worksheet.Cell("D1").Value = "Thuế/ngày";
                worksheet.Cell("E1").Value = "Tổng tiền";
                worksheet.Cell("F1").Value = "Thời gian thuê";
                worksheet.Cell("G1").Value = "Ngày thuê";
                worksheet.Cell("H1").Value = "Ngày thanh toán";
               
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
                string fileName = $"Export_LichTrinh_{DateTime.Now.ToString("yyyyMMdd_HHmmss")}.xlsx";
                string filePath = Path.Combine(projectDirectory, fileName);

                // Lưu workbook vào file Excel
                workbook.SaveAs(filePath);
            }
        }

    }
}
