using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace CarRental.Admin
{
    public partial class AdminOtoManagement : Form
    {
        private readonly BUS_XeOto _busXeOto;

        public AdminOtoManagement(BUS_XeOto busXeOto)
        {
            InitializeComponent();
            _busXeOto = busXeOto;
        }

        private async void AdminOtoManagement_Load(object sender, EventArgs e)
        {
            var xeOtos = await _busXeOto.GetAllXeOtosAsync();

            if (xeOtos != null && xeOtos.Count > 0)
            {
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

        private void btn_AddOto_Click(object sender, EventArgs e)
        {
            var addOtoForm = new FormAddOto(_busXeOto);

            // Show the form
            addOtoForm.Show();
        }

        private async void btn_Delete_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có hàng được chọn trong DataGridView không
            if (dgv_car.SelectedRows.Count > 0)
            {
                // Lấy XeOtoId của hàng được chọn
                int selectedXeOtoId = (int)dgv_car.SelectedRows[0].Cells["XeOtoId"].Value;

                // Hiển thị hộp thoại xác nhận xóa
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa xe này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        // Gọi phương thức xóa xe từ BUS
                        await _busXeOto.DeleteXeOtoAsync(selectedXeOtoId);

                        // Xóa hàng khỏi DataGridView
                        dgv_car.Rows.RemoveAt(dgv_car.SelectedRows[0].Index);

                        MessageBox.Show("Xóa xe thành công");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Đã xảy ra lỗi khi xóa xe: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một xe để xóa");
            }
        }

        private async void btn_Update_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có hàng được chọn trong DataGridView không
            if (dgv_car.SelectedRows.Count > 0)
            {
                // Lấy XeOtoId của hàng được chọn
                int selectedXeOtoId = (int)dgv_car.SelectedRows[0].Cells["XeOtoId"].Value;

                // Gọi phương thức lấy thông tin chi tiết xe từ BUS
                var xeOto = await _busXeOto.GetXeOtoByIdAsync(selectedXeOtoId);
                Console.WriteLine(xeOto);
                if (xeOto != null)
                {
                    // Tạo một đối tượng FormUpdateOto và truyền thông tin xeOto
                    var updateOtoForm = new FormUpdateOto(_busXeOto, xeOto);

                    // Đăng ký sự kiện cập nhật thành công
                    updateOtoForm.OtoUpdated += UpdateOtoForm_OtoUpdated;

                    // Hiển thị form cập nhật
                    updateOtoForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy xe để cập nhật");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một xe để cập nhật");
            }
        }

        private async void UpdateOtoForm_OtoUpdated(object sender, EventArgs e)
        {
            // Gọi lại phương thức lấy danh sách xe và cập nhật DataGridView
            var xeOtos = await _busXeOto.GetAllXeOtosAsync();

            if (xeOtos != null && xeOtos.Count > 0)
            {
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
    }
}
