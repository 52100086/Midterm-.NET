﻿using DAL;
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

		public async Task<List<XeOto>> SearchByBrandAsync(string brand)
        {
            return await _context.XeOtos.Where(x => x.HangXe.TenHangXe == brand).ToListAsync();
        }


        public async Task<List<XeOto>> SearchByTypeAsync(string type)
        {
            // Assuming you have a Type property in XeOto
            return await _context.XeOtos.Where(x => x.LoaiXe.TenLoaiXe == type).ToListAsync();
        }
    }
}
