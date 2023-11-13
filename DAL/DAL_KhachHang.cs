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

        public async Task<KhachHang> GetKhachHangByIdAsync(int id)
        {
            return await _context.KhachHangs.FindAsync(id);
        }

        public KhachHang CreateKhachHangAsync(KhachHang khachHang)
        {
            _context.KhachHangs.Add(khachHang);
            _context.SaveChangesAsync();
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


		public async Task<List<KhachHang>> SearchByNameAsync(string name)
        {
            return await _context.KhachHangs.Where(k => k.Ten == name).ToListAsync();
        }

        public async Task<List<KhachHang>> SearchByPhoneAsync(string phone)
        {
            return await _context.KhachHangs.Where(k => k.SoDienThoai == phone).ToListAsync();
        }

        public async Task<List<KhachHang>> SearchByAddressAsync(string address)
        {
            return await _context.KhachHangs.Where(k => k.DiaChi == address).ToListAsync();
        }
    }
}
