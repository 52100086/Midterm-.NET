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
            return await _context.XeOtos
                .Include(x => x.LoaiXe)
                .Include(x => x.HangXe)
                .Include(x => x.MauXe)
                .ToListAsync();
        }

        public XeOto GetXeOtoById(int id)
        {
            return _context.XeOtos.Find(id);
        }

        public async Task<XeOto> CreateXeOtoAsync(XeOto xeOto)
        {
            _context.XeOtos.Add(xeOto);
            await _context.SaveChangesAsync();
            return xeOto;
        }
        public async Task<List<LoaiXe>> GetAllLoaiXesAsync()
        {
            return await _context.LoaiXes.ToListAsync();
        }

        public async Task<List<MauXe>> GetAllMauXesAsync()
        {
            return await _context.MauXes.ToListAsync();
        }

        public async Task<List<HangXe>> GetAllHangXesAsync()
        {
            return await _context.HangXes.ToListAsync();
        }
		public XeOto UpdateXeOto(XeOto xeOto)
		{
			var existingXeOto = _context.XeOtos.Find(xeOto.XeOtoId);
			if (existingXeOto != null)
			{
				_context.Entry(existingXeOto).CurrentValues.SetValues(xeOto);
				_context.SaveChanges();
			}
			return xeOto;
		}

		public void DeleteXeOto(int id)
		{
			var xeOto = _context.XeOtos.Find(id);
			if (xeOto != null)
			{
				_context.XeOtos.Remove(xeOto);
				_context.SaveChanges();
			}
		}

		public List<XeOto> GetXeOtosByType(int id)
		{
			return _context.XeOtos
				.Where(x => x.LoaiXeId == id)
				.Include(x => x.LoaiXe)
				.Include(x => x.HangXe)
				.Include(x => x.MauXe)
				.ToList();
		}

		public List<XeOto> SearchByHangXeOrMauXe(string keyword)
		{
			return _context.XeOtos
				.Where(x => x.HangXe.TenHangXe.Contains(keyword) || x.MauXe.TenMauXe.Contains(keyword))
				.Include(x => x.LoaiXe)
				.Include(x => x.HangXe)
				.Include(x => x.MauXe)
				.ToList();
		}

        public async Task<int?> GetTypeIdByNameAsync(string name)
        {
            var loaiXe = await _context.LoaiXes
                .FirstOrDefaultAsync(x => x.TenLoaiXe == name);

            if (loaiXe != null)
            {
                return loaiXe.LoaiXeId;
            }
            else
            {
                return null;
            }
        }

        public async Task<int?> GetBrandIdByNameAsync(string name)
        {
            var hangXe = await _context.HangXes
                .FirstOrDefaultAsync(x => x.TenHangXe == name);

            if (hangXe != null)
            {
                return hangXe.HangXeId;
            }
            else
            {
                return null;
            }
        }


        public async Task<int?> GetModelIdByNameAsync(string name)
        {
            var mauXe = await _context.MauXes
                .FirstOrDefaultAsync(x => x.TenMauXe == name);

            if (mauXe != null)
            {
                return mauXe.MauXeId;
            }
            else
            {
                return null;
            }
        }



    }
}
