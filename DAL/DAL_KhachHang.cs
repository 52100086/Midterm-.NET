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

        public async Task<KhachHang> CreateKhachHangAsync(KhachHang khachHang)
        {
            _context.KhachHangs.Add(khachHang);
            await _context.SaveChangesAsync();
            return khachHang;
        }

        public async Task<KhachHang> UpdateKhachHangAsync(KhachHang khachHang)
        {
            _context.Entry(khachHang).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return khachHang;
        }

        public async Task DeleteKhachHangAsync(int id)
        {
            var khachHang = await _context.KhachHangs.FindAsync(id);
            _context.KhachHangs.Remove(khachHang);
            await _context.SaveChangesAsync();
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
