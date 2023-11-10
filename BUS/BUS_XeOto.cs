using BUS;
using DAL;
using DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_XeOto
    {
        private readonly DAL_XeOto _dalXeOto;

        public BUS_XeOto(DAL_XeOto dalXeOto)
        {
            _dalXeOto = dalXeOto;
        }

        public Task<List<XeOto>> GetAllXeOtosAsync()
        {
            return _dalXeOto.GetAllXeOtosAsync();
        }

        public Task<XeOto> GetXeOtoByIdAsync(int id)
        {
            return _dalXeOto.GetXeOtoByIdAsync(id);
        }

        public Task<XeOto> CreateXeOtoAsync(XeOto xeOto)
        {
            return _dalXeOto.CreateXeOtoAsync(xeOto);
        }

        public Task<XeOto> UpdateXeOtoAsync(XeOto xeOto)
        {
            return _dalXeOto.UpdateXeOtoAsync(xeOto);
        }

        public Task DeleteXeOtoAsync(int id)
        {
            return _dalXeOto.DeleteXeOtoAsync(id);
        }

        public Task<List<XeOto>> SearchByBrandAsync(string brand)
        {
            return _dalXeOto.SearchByBrandAsync(brand);
        }

        public Task<List<XeOto>> SearchByModelAsync(string model)
        {
            return _dalXeOto.SearchByModelAsync(model);
        }

        public Task<List<XeOto>> SearchByTypeAsync(string type)
        {
            return _dalXeOto.SearchByTypeAsync(type);
        }
    }
}
