using BUS;
using DAL;
using DTO;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_XeOto
    {
        private readonly DAL_XeOto _dalXeOto;

        public BUS_XeOto()
        {
            _dalXeOto = new DAL_XeOto(new CarRentalDBContext());
        }

        public Task<List<XeOto>> GetAllXeOtosAsync()
        {
            return _dalXeOto.GetAllXeOtosAsync();
        }

        public XeOto GetXeOtoById(int id)
        {
            return _dalXeOto.GetXeOtoById(id);
        }

        public Task<XeOto> CreateXeOtoAsync(XeOto xeOto)
        {
            return _dalXeOto.CreateXeOtoAsync(xeOto);
        }
        public Task<List<LoaiXe>> GetAllLoaiXesAsync()
        {
            return _dalXeOto.GetAllLoaiXesAsync();
        }

        public Task<List<MauXe>> GetAllMauXesAsync()
        {
            return _dalXeOto.GetAllMauXesAsync();
        }

        public Task<List<HangXe>> GetAllHangXesAsync()
        {
            return _dalXeOto.GetAllHangXesAsync();
        }
		public XeOto UpdateXeOto(XeOto xeOto)
		{
			return _dalXeOto.UpdateXeOto(xeOto);
		}
		public List<XeOto> GetXeOtosByType(int id)
		{
            return _dalXeOto.GetXeOtosByType(id);
		}

		public void DeleteXeOto(int id)
		{
			_dalXeOto.DeleteXeOto(id);
		}

		public Task<List<XeOto>> SearchByBrandAsync(string brand)
        {
            return _dalXeOto.SearchByBrandAsync(brand);
        }


        public Task<List<XeOto>> SearchByTypeAsync(string type)
        {
            return _dalXeOto.SearchByTypeAsync(type);
        }
    }
}
