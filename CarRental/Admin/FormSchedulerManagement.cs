using BUS;
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

        private void btn_search_Click(object sender, EventArgs e)
        {

        }
    }
}
