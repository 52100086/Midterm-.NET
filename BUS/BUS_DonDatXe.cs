using DAL;
using DTO;
using System.Collections.Generic;

using DAL;
using DTO;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.InkML;

namespace BUS
{
	public class BUS_DonDatXe
	{
		private DAL_DonDatXe _dalDonDatXe;

		public BUS_DonDatXe()
		{
			_dalDonDatXe = new DAL_DonDatXe(new CarRentalDBContext());
		}

		public Task<List<DonDatXe>> GetAllDonDatXe()
		{
			return _dalDonDatXe.ListAllDonDatXe();
		}

		public DonDatXe GetDonDatXeById(int donDatXeId)
		{
			return _dalDonDatXe.GetDonDatXeById(donDatXeId);
		}

		public DonDatXe AddDonDatXe(DonDatXe donDatXe)
		{
			return _dalDonDatXe.AddDonDatXe(donDatXe);
		}

		public DonDatXe UpdateDonDatXe(DonDatXe donDatXe)
		{
			return _dalDonDatXe.UpdateDonDatXe(donDatXe);
		}

		public void DeleteDonDatXe(int donDatXeId)
		{
			_dalDonDatXe.DeleteDonDatXe(donDatXeId);
		}
		public void AddDonDatXe_TinhNang(int donDatXeId, int tinhNangId)
		{
			_dalDonDatXe.AddDonDatXe_TinhNang(donDatXeId, tinhNangId);
		}
		public List<int> getListTinhNangcuaDonDatXe(int donDatXeId)
		{
			return _dalDonDatXe.getListTinhNangcuaDonDatXe(donDatXeId);
		}
        public List<DonDatXe> GetDonDatXeByKhachHangId(int khachHangId)
        {
			return _dalDonDatXe.GetDonDatXeByKhachHangId(khachHangId);
        }
    }
}