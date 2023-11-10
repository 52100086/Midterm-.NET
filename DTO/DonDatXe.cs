namespace DTO
{
    public class DonDatXe
    {
        public int DonDatXeId { get; set; }
        public int KhachHangId { get; set; }
        public int XeOtoId { get; set; }
        public double GiaThue { get; set; }
        public double Thue { get; set; }
        public int NhienLieuId { get; set; }
        public DateTime ThoiGianThue { get; set; }
        public DateTime NgayLap { get; set; }
        public DateTime NgayThanhToan { get; set; }
        public string TrangThai {  get; set; }
        // Navigation Properties
        public virtual KhachHang KhachHang { get; set; }
        public virtual XeOto XeOto { get; set; }
        public virtual NhienLieu NhienLieu { get; set; }
        public ICollection<DonDatXe_TinhNang> DonDatXe_TinhNangs { get; set; }
    }
}
