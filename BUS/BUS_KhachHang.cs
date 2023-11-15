using BUS;
using DAL;
using DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_KhachHang
    {
        private readonly DAL_KhachHang _dalKhachHang;

        public BUS_KhachHang()
        {
            _dalKhachHang = new DAL_KhachHang(new CarRentalDBContext());
        }

        public Task<List<KhachHang>> GetAllKhachHangsAsync()
        {
            return _dalKhachHang.GetAllKhachHangsAsync();
        }

        public KhachHang GetKhachHangByIdAsync(int id)
        {
            return _dalKhachHang.GetKhachHangByIdAsync(id);
        }

        public KhachHang CreateKhachHangAsync(KhachHang khachHang)
        {
            return _dalKhachHang.CreateKhachHangAsync(khachHang);
        }

		public KhachHang UpdateKhachHang(KhachHang khachHang)
		{
			return _dalKhachHang.UpdateKhachHang(khachHang);
		}

		public void DeleteKhachHang(int id)
		{
			_dalKhachHang.DeleteKhachHang(id);
		}

		public List<KhachHang> SearchKhachHang(string keyword)
		{
			return _dalKhachHang.SearchKhachHang(keyword);
		}
	}
}
