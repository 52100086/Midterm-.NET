namespace DTO
{
    public class DonDatXe
    {
        public int DonDatXeId { get; set; }
        public int KhachHangId { get; set; }
        public int XeOtoId { get; set; }
        public decimal GiaThue { get; set; }
        public string NhienLieu { get; set; }
        public DateTime ThoiGianThue { get; set; }

        // Navigation Properties
        public virtual KhachHang KhachHang { get; set; }
        public virtual XeOto XeOto { get; set; }

        public ICollection<DonDatXe_TinhNang> DonDatXe_TinhNangs { get; set; }
    }

}
