using DAL;
using DTO;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_XeOto
    {
        private readonly CarRentalDBContext _context;

        public DAL_XeOto(CarRentalDBContext context)
        {
            _context = context;
        }

        public async Task<List<XeOto>> GetAllXeOtosAsync()
        {
            return await _context.XeOtos.ToListAsync();
        }

        public async Task<XeOto> GetXeOtoByIdAsync(int id)
        {
            return await _context.XeOtos.FindAsync(id);
        }

        public async Task<XeOto> CreateXeOtoAsync(XeOto xeOto)
        {
            _context.XeOtos.Add(xeOto);
            await _context.SaveChangesAsync();
            return xeOto;
        }

        public async Task<XeOto> UpdateXeOtoAsync(XeOto xeOto)
        {
            _context.Entry(xeOto).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return xeOto;
        }

        public async Task DeleteXeOtoAsync(int id)
        {
            var xeOto = await _context.XeOtos.FindAsync(id);
            _context.XeOtos.Remove(xeOto);
            await _context.SaveChangesAsync();
        }


        public async Task<List<XeOto>> SearchByBrandAsync(string brand)
        {
            return await _context.XeOtos.Where(x => x.HangXe == brand).ToListAsync();
        }

        public async Task<List<XeOto>> SearchByModelAsync(string model)
        {
            return await _context.XeOtos.Where(x => x.Model == model).ToListAsync();
        }

        public async Task<List<XeOto>> SearchByTypeAsync(string type)
        {
            // Assuming you have a Type property in XeOto
            return await _context.XeOtos.Where(x => x.LoaiXe.TenLoaiXe == type).ToListAsync();
        }
    }
}
