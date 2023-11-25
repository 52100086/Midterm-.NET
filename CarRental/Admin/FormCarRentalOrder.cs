using BUS;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
namespace CarRental.Admin
{
    public partial class FormCarRentalOrder : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        private int xeOtoId;
        private int khachhangId;
        private readonly BUS_KhachHang _busKhachHang = new BUS_KhachHang();
        private readonly BUS_XeOto _busXeOto = new BUS_XeOto();
        private readonly BUS_DonDatXe _busDonDatXe = new BUS_DonDatXe();
        private readonly BUS_TinhNangXe _busTinhNang = new BUS_TinhNangXe();
        private DonDatXe DonDatXe;
        public FormCarRentalOrder(int xeOtoId)
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            this.xeOtoId = xeOtoId;
        }
        public FormCarRentalOrder(int xeOtoId, int khachhangId)
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            this.xeOtoId = xeOtoId;
            this.khachhangId = khachhangId;
        }
        public FormCarRentalOrder(DonDatXe donDatXe)
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            this.DonDatXe = donDatXe;
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            if (khachhangId == 0)
            {
                Dictionary<int, bool> tinhNangXeValues = new Dictionary<int, bool>
                {
                    { 1, cb_bando.Checked },
                    { 2, cb_bluetooth.Checked },
                    { 3, cb_cameralui.Checked },
                    { 4, cb_cameracaple.Checked },
                    { 5, cb_camerahanhtrinh.Checked },
                    { 6, cb_canhbaotocdo.Checked },
                    { 7, cb_cambienlop.Checked },
                    {8, cb_cambienvacham.Checked },
                    {9, cb_cuasotroi.Checked },
                    {10, cb_dinhvigps.Checked },
                    {11, cb_khecamusb.Checked },
                    {12, cb_lopduphong.Checked },
                    {13, cb_napthungxebantai.Checked },
                    {14, cb_camera360.Checked }
                };
                var khachHang = new KhachHang
                {
                    Ten = txt_hoten.Text,
                    Email = txt_email.Text,
                    DiaChi = txt_diachi.Text,
                    SoDienThoai = txt_sdt.Text
                };

                var createKH = _busKhachHang.CreateKhachHangAsync(khachHang);

                var xeOto = _busXeOto.GetXeOtoById(xeOtoId);
                xeOto.TrangThai = "Đang thuê";
                var update = _busXeOto.UpdateXeOto(xeOto);

                var donDatXe = new DonDatXe
                {
                    KhachHangId = createKH.KhachHangId,
                    XeOtoId = xeOtoId,
                    NgayLap = DateTime.Today,
                    TrangThai = "Chưa thanh toán",
                    Thue = Double.Parse(lb_thuengay.Text),
                    GiaThue = Double.Parse(lb_tienthuengay.Text),
                    TongCong = Double.Parse(lb_tongcong.Text),
                    ThoiGianThue = DateTime.Today.AddDays(Int32.Parse(txt_ngay.Text))
                };
                if (rb_xang.Checked)
                {
                    donDatXe.NhienLieuId = 1;
                }
                else if (rb_dien.Checked)
                {
                    donDatXe.NhienLieuId = 2;
                }
                else if (rb_dau.Checked)
                {
                    donDatXe.NhienLieuId = 3;
                }
                else
                {
                    txt_warn.Visible = true;
                    return;
                }
                _busDonDatXe.AddDonDatXe(donDatXe);
                foreach (var tinhNangXe in tinhNangXeValues)
                {
                    if (tinhNangXe.Value)
                    {
                        _busDonDatXe.AddDonDatXe_TinhNang(donDatXe.DonDatXeId, tinhNangXe.Key);
                    }
                }


                MessageBox.Show("Thêm hóa đơn thành công");
                this.Close();
            }
            else
            {
                var khachHang = new KhachHang
                {
                    KhachHangId = khachhangId,
                    Ten = txt_hoten.Text,
                    Email = txt_email.Text,
                    DiaChi = txt_diachi.Text,
                    SoDienThoai = txt_sdt.Text
                };

                var updateKH = _busKhachHang.UpdateKhachHang(khachHang);

                var xeOto = _busXeOto.GetXeOtoById(xeOtoId);
                xeOto.TrangThai = "Đang thuê";
                var update = _busXeOto.UpdateXeOto(xeOto);
                var donDatXe = new DonDatXe
                {
                    KhachHangId = khachHang.KhachHangId,
                    XeOtoId = xeOtoId,
                    NgayLap = DateTime.Today,
                    TrangThai = "Chưa thanh toán",
                    Thue = Math.Round(Double.Parse(lb_thuengay.Text), 2),
                    GiaThue = Math.Round(Double.Parse(lb_tienthuengay.Text), 2),
                    TongCong = Math.Round(Double.Parse(lb_tongcong.Text), 2),
                    ThoiGianThue = DateTime.Today.AddDays(Int32.Parse(txt_ngay.Text))
                };

                Dictionary<int, bool> tinhNangXeValues = new Dictionary<int, bool>
                {
                    { 1, cb_bando.Checked },
                    { 2, cb_bluetooth.Checked },
                    { 3, cb_cameralui.Checked },
                    { 4, cb_cameracaple.Checked },
                    { 5, cb_camerahanhtrinh.Checked },
                    { 6, cb_canhbaotocdo.Checked },
                    { 7, cb_cambienlop.Checked },
                    {8, cb_cambienvacham.Checked },
                    {9, cb_cuasotroi.Checked },
                    {10, cb_dinhvigps.Checked },
                    {11, cb_khecamusb.Checked },
                    {12, cb_lopduphong.Checked },
                    {13, cb_napthungxebantai.Checked },
                    {14, cb_camera360.Checked }
                };
                if (rb_xang.Checked)
                {
                    donDatXe.NhienLieuId = 1;
                }
                else if (rb_dien.Checked)
                {
                    donDatXe.NhienLieuId = 2;
                }
                else if (rb_dau.Checked)
                {
                    donDatXe.NhienLieuId = 3;
                }
                else
                {
                    txt_warn.Visible = true;
                    return;
                }
                _busDonDatXe.AddDonDatXe(donDatXe);
                foreach (var tinhNangXe in tinhNangXeValues)
                {
                    if (tinhNangXe.Value)
                    {
                        _busDonDatXe.AddDonDatXe_TinhNang(donDatXe.DonDatXeId, tinhNangXe.Key);
                    }
                }
                MessageBox.Show("Thêm hóa đơn thành công");
                this.Close();
            }
        }

        private void FormCarRentalOrder_Load(object sender, EventArgs e)
        {
            if (khachhangId != 0)
            {
                var khachhang = _busKhachHang.GetKhachHangByIdAsync(khachhangId);
                txt_hoten.Text = khachhang.Ten;
                txt_email.Text = khachhang.Email;
                txt_diachi.Text = khachhang.DiaChi;
                txt_sdt.Text = khachhang.SoDienThoai;
                txt_warn.Visible = false;
                txt_warn.ForeColor = System.Drawing.Color.Red;
            }
            if (DonDatXe != null)
            {
                txt_warn.Visible = false;
                txt_warn.ForeColor = System.Drawing.Color.Red;
                txt_hoten.Text = DonDatXe.KhachHang.Ten;
                txt_email.Text = DonDatXe.KhachHang.Email;
                txt_diachi.Text = DonDatXe.KhachHang.DiaChi;
                txt_sdt.Text = DonDatXe.KhachHang.SoDienThoai;
                txt_ngay.Text = DonDatXe.ThoiGianThue.ToString();
                if (DonDatXe.NhienLieuId == 1)
                {
                    rb_xang.Checked = true;
                }
                else if (DonDatXe.NhienLieuId == 2)
                {
                    rb_dien.Checked = true;
                }
                else if (DonDatXe.NhienLieuId == 3)
                {
                    rb_dau.Checked = true;
                }
                lb_thuengay.Text = DonDatXe.GiaThue.ToString();
                lb_tienthuengay.Text = DonDatXe.Thue.ToString();
                List<int> tinhNangIds = _busDonDatXe.getListTinhNangcuaDonDatXe(DonDatXe.DonDatXeId);
                // Kiểm tra và thiết lập giá trị checked cho các checkbox tương ứng với tính năng
                cb_bando.Checked = tinhNangIds.Contains(1);
                cb_bluetooth.Checked = tinhNangIds.Contains(2);
                cb_cameralui.Checked = tinhNangIds.Contains(3);
                cb_cameracaple.Checked = tinhNangIds.Contains(4);
                cb_camerahanhtrinh.Checked = tinhNangIds.Contains(5);
                cb_canhbaotocdo.Checked = tinhNangIds.Contains(6);
                cb_cambienlop.Checked = tinhNangIds.Contains(7);
                cb_cambienvacham.Checked = tinhNangIds.Contains(8);
                cb_cuasotroi.Checked = tinhNangIds.Contains(9);
                cb_dinhvigps.Checked = tinhNangIds.Contains(10);
                cb_khecamusb.Checked = tinhNangIds.Contains(11);
                cb_lopduphong.Checked = tinhNangIds.Contains(12);
                cb_napthungxebantai.Checked = tinhNangIds.Contains(13);
                cb_camera360.Checked = tinhNangIds.Contains(14);
                lb_thuengay.Visible = false;
                lb_tienthuengay.Visible = false;
                lb_tongcong.Visible = false;
                lb_tongngay.Visible = false;
                vcl.Visible = false;
                hehe.Visible = false;
                cc.Visible = false;
                materialLabel18.Visible = false;
                materialLabel11.Visible = false;
                materialLabel4.Visible = false;
                materialLabel6.Visible = false;
                materialLabel20.Visible = false;
                materialLabel10.Visible = false;
            }
        }

        private void btn_preview_Click(object sender, EventArgs e)
        {
            double tongtien = 0;
            double thue = 0;
            var xe = _busXeOto.GetXeOtoById(xeOtoId);
            double thuengay = xe.GiaThue;
            double tongngay = 0;
            Dictionary<int, bool> tinhNangXeValues = new Dictionary<int, bool>
            {
                { 1, cb_bando.Checked },
                { 2, cb_bluetooth.Checked },
                { 3, cb_cameralui.Checked },
                { 4, cb_cameracaple.Checked },
                { 5, cb_camerahanhtrinh.Checked },
                { 6, cb_canhbaotocdo.Checked },
                { 7, cb_cambienlop.Checked },
                { 8, cb_cambienvacham.Checked },
                { 9, cb_cuasotroi.Checked },
                { 10, cb_dinhvigps.Checked },
                { 11, cb_khecamusb.Checked },
                { 12, cb_lopduphong.Checked },
                { 13, cb_napthungxebantai.Checked },
                { 14, cb_camera360.Checked }
            };
            foreach (var tinhNangXe in tinhNangXeValues)
            {
                if (tinhNangXe.Value)
                {
                    var tinhnang = _busTinhNang.GetTinhNangXeById(tinhNangXe.Key);
                    thuengay += tinhnang.GiaThue;
                }
            }
            lb_tienthuengay.Text = thuengay.ToString();
            lb_thuengay.Text = (thuengay * 0.08).ToString();
            lb_tongngay.Text = (thuengay * 1.08 * 1.0).ToString();

            double tongcong;
            if (Double.TryParse(txt_ngay.Text, out double ngay) && Double.TryParse(lb_tongngay.Text, out double tongngayParsed))
            {
                tongcong = ngay * tongngayParsed;
                lb_tongcong.Text = tongcong.ToString();
            }
            else
            {
                // Xử lý trường hợp không thể chuyển đổi giá trị thành số
                MessageBox.Show("Ngày không hợp lệ.");
            }
        }
    }
}
