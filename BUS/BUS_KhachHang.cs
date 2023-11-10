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

        public BUS_KhachHang(DAL_KhachHang dalKhachHang)
        {
            _dalKhachHang = dalKhachHang;
        }

        public Task<List<KhachHang>> GetAllKhachHangsAsync()
        {
            return _dalKhachHang.GetAllKhachHangsAsync();
        }

        public Task<KhachHang> GetKhachHangByIdAsync(int id)
        {
            return _dalKhachHang.GetKhachHangByIdAsync(id);
        }

        public Task<KhachHang> CreateKhachHangAsync(KhachHang khachHang)
        {
            return _dalKhachHang.CreateKhachHangAsync(khachHang);
        }

        public Task<KhachHang> UpdateKhachHangAsync(KhachHang khachHang)
        {
            return _dalKhachHang.UpdateKhachHangAsync(khachHang);
        }

        public Task DeleteKhachHangAsync(int id)
        {
            return _dalKhachHang.DeleteKhachHangAsync(id);
        }

        public Task<List<KhachHang>> SearchByNameAsync(string name)
        {
            return _dalKhachHang.SearchByNameAsync(name);
        }

        public Task<List<KhachHang>> SearchByPhoneAsync(string phone)
        {
            return _dalKhachHang.SearchByPhoneAsync(phone);
        }

        public Task<List<KhachHang>> SearchByAddressAsync(string address)
        {
            return _dalKhachHang.SearchByAddressAsync(address);
        }
    }
}
