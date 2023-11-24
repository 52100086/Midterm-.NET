using DAL;
using DTO;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_KhachHang
    {
        private readonly CarRentalDBContext _context;

        public DAL_KhachHang(CarRentalDBContext context)
        {
            _context = context;
        }

        public async Task<List<KhachHang>> GetAllKhachHangsAsync()
        {
            return await _context.KhachHangs.ToListAsync();
        }

        public KhachHang GetKhachHangByIdAsync(int id)
        {
            return _context.KhachHangs.Find(id);
        }

        public KhachHang CreateKhachHangAsync(KhachHang khachHang)
        {
            _context.KhachHangs.Add(khachHang);
            _context.SaveChanges();
            return khachHang;
        }

		public KhachHang UpdateKhachHang(KhachHang khachHang)
		{
			var existingKhachHang = _context.KhachHangs.Find(khachHang.KhachHangId);
			if (existingKhachHang != null)
			{
				_context.Entry(existingKhachHang).CurrentValues.SetValues(khachHang);
				_context.SaveChanges();
			}
			return khachHang;
		}

		public void DeleteKhachHang(int id)
		{
			var khachHang = _context.KhachHangs.Find(id);
			if (khachHang != null)
			{
				_context.KhachHangs.Remove(khachHang);
				_context.SaveChanges();
			}
		}


		public List<KhachHang> SearchKhachHang(string keyword)
		{
			return _context.KhachHangs
				.Where(x => x.Ten.Contains(keyword) || x.SoDienThoai.Contains(keyword) || x.DiaChi.Contains(keyword))
				.ToList();
		}
        public bool IsPhoneNumberExists(string phoneNumber)
        {
            return _context.KhachHangs.Any(x => x.SoDienThoai == phoneNumber);
        }
    }
}
