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
using System.Windows.Forms.DataVisualization.Charting;

namespace CarRental.Admin
{
    public partial class FormUpdateOto : Form
    {
        private readonly BUS_XeOto _busXeOto;
        private readonly XeOto _xeOto;

        // Khai báo sự kiện OtoUpdated
        public event EventHandler OtoUpdated;

        public FormUpdateOto(BUS_XeOto busXeOto, XeOto xeOto)
        {
            InitializeComponent();
            _busXeOto = busXeOto;
            _xeOto = xeOto;
            PopulateComboBoxes();
        }

        private async void FormUpdateOto_Load(object sender, EventArgs e)
        {
            // Hiển thị thông tin chi tiết của xe trong các điều khiển TextBox, ComboBox, ...
            txt_TrangThai.Text = _xeOto.TrangThai;
            txt_GiaThue.Text = _xeOto.GiaThue.ToString();
            // Hiển thị và chọn giá trị cho các ComboBox LoaiXe, HangXe, MauXe
            await PopulateComboBoxes();
        }

        private async Task PopulateComboBoxes()
        {
            try
            {
                // Retrieve data from the database asynchronously using the BUS_XeOto class
                List<LoaiXe> loaiXes = await _busXeOto.GetAllLoaiXesAsync();
                List<MauXe> mauXes = await _busXeOto.GetAllMauXesAsync();
                List<HangXe> hangXes = await _busXeOto.GetAllHangXesAsync();

                // Populate the ComboBox for LoaiXe
                cbx_LoaiXe.DataSource = loaiXes;
                cbx_LoaiXe.DisplayMember = "TenLoaiXe";
                cbx_LoaiXe.ValueMember = "LoaiXeId";

                // Populate the ComboBox for MauXe
                cbx_MauXe.DataSource = mauXes;
                cbx_MauXe.DisplayMember = "TenMauXe";
                cbx_MauXe.ValueMember = "MauXeId";

                // Populate the ComboBox for HangXe
                cbx_HangXe.DataSource = hangXes;
                cbx_HangXe.DisplayMember = "TenHangXe";
                cbx_HangXe.ValueMember = "HangXeId";
            }
            catch (Exception ex)
            {
                // Handle and log any exceptions that occur during data retrieval
                MessageBox.Show("An error occurred while populating the ComboBoxes: " + ex.Message);
            }
        }

        private async void btn_Update_Click(object sender, EventArgs e)
        {
            // Kiểm tra và lấy thông tin cập nhật từ các điều khiển TextBox, ComboBox, ...
            string trangThai = txt_TrangThai.Text;
            int giaThue;
            if (!Int32.TryParse(txt_GiaThue.Text, out giaThue))
            {
                MessageBox.Show("Giá thuê không hợp lệ");
                return;
            }
            int loaiXeId = (int)cbx_LoaiXe.SelectedValue;
            int hangXeId = (int)cbx_HangXe.SelectedValue;
            int mauXeId = (int)cbx_MauXe.SelectedValue;

            // Cập nhật thông tin của xeOto
            _xeOto.TrangThai = trangThai;
            _xeOto.GiaThue = giaThue;
            _xeOto.LoaiXeId = loaiXeId;
            _xeOto.HangXeId = hangXeId;
            _xeOto.MauXeId = mauXeId;

            try
            {
            // Gọi phương thức cập nhật xe từ BUS
                await _busXeOto.UpdateXeOtoAsync(_xeOto);

                // Gọi sự kiện OtoUpdated để thông báo cập nhật thành công
                OnOtoUpdated();

                // Đóng form cập nhật
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi cập nhật xe: " + ex.Message);
            }
        }

        private void OnOtoUpdated()
        {
            // Kiểm tra xem có người đăng ký sự kiện OtoUpdated hay không
            if (OtoUpdated != null)
            {
                // Gửi sự kiện OtoUpdated
                OtoUpdated(this, EventArgs.Empty);
            }
        }
    }
}
