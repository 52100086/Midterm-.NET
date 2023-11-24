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
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

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

            dgv_order.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            await BindDataToDataGridView();
            foreach (DataGridViewColumn column in dgv_order.Columns)
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
                else if (column.Name == "NhienLieuName")
                {
                    column.HeaderText = "Nhiên liệu";
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
                else if (column.Name == "TrangThai")
                {
                    column.HeaderText = "Trạng thái";
                }
            }


        }
        private async Task BindDataToDataGridView()
        {
            var dondatxes = await _busDonDatXe.GetAllDonDatXe();

            if (dondatxes != null && dondatxes.Count > 0)
            {
                dgv_order.DataSource = dondatxes;
                var data = dondatxes.Select(x => new
                {
                    DonDatXeId = x.DonDatXeId,
                    TenKhachHang = x.KhachHang.Ten,
                    GiaThue = Math.Round(x.GiaThue, 2),
                    Thue = Math.Round(x.Thue),
                    TongCong = Math.Round(x.TongCong,2),
                    NhienLieuName = x.NhienLieu.NhienLieuName,
                    ThoiGianThue = x.ThoiGianThue,
                    NgayLap = x.NgayLap,
                    NgayThanhToan = x.NgayThanhToan,
                    TrangThai = x.TrangThai
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
            if (dgv_order.SelectedRows.Count > 0)
            {
                // Lấy hàng được chọn
                DataGridViewRow selectedRow = dgv_order.SelectedRows[0];

                // Lấy giá trị của cột KhachHangId trong hàng được chọn
                int DonDatXeId = Convert.ToInt32(selectedRow.Cells["DonDatXeId"].Value);
                var DonDatXe = _busDonDatXe.GetDonDatXeById(DonDatXeId);
                DonDatXe.TrangThai = "Đã thanh toán";
                DonDatXe.NgayThanhToan = DateTime.Today;
                DonDatXe.XeOto.TrangThai = "Sẵn sàng";
                var update = _busDonDatXe.UpdateDonDatXe(DonDatXe);

                if (update != null)
                {
                    MessageBox.Show("XeOto is updated successfully");
                    dgv_order.Refresh();

                }
                else
                {
                    // Failed to create the XeOto object
                    MessageBox.Show("Failed to update XeOto");
                }

            }
            else
            {
                MessageBox.Show("Vui lòng chọn một đơn đặt xe để xem chi tiết");
            }
        }

        private void btn_chitiet_Click(object sender, EventArgs e)
        {
            if (dgv_order.SelectedRows.Count > 0)
            {
                // Lấy hàng được chọn
                DataGridViewRow selectedRow = dgv_order.SelectedRows[0];

                // Lấy giá trị của cột KhachHangId trong hàng được chọn
                int DonDatXeId = Convert.ToInt32(selectedRow.Cells["DonDatXeId"].Value);
                var DonDatXe = _busDonDatXe.GetDonDatXeById(DonDatXeId);
                FormCarRentalOrder formCarRentalOrder = new FormCarRentalOrder(DonDatXe);
                formCarRentalOrder.ShowDialog();
                dgv_order.Refresh();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một đơn đặt xe để xem chi tiết");
            }
        }

    }
}
