using DAL;
using DTO;
using System.Collections.Generic;

namespace BUS
{
	public class BUS_DonDatXe_TinhNang
	{
		private DAL_DonDatXe_TinhNang _dalDonDatXe_TinhNang;

		public BUS_DonDatXe_TinhNang()
		{
			_dalDonDatXe_TinhNang = new DAL_DonDatXe_TinhNang(new CarRentalDBContext());
		}

		public List<DonDatXe_TinhNang> GetAllDonDatXe_TinhNang()
		{
			return _dalDonDatXe_TinhNang.ListAllDonDatXe_TinhNang();
		}

		public DonDatXe_TinhNang GetDonDatXe_TinhNangById(int donDatXe_TinhNangId)
		{
			return _dalDonDatXe_TinhNang.GetDonDatXe_TinhNangById(donDatXe_TinhNangId);
		}

		public DonDatXe_TinhNang AddDonDatXe_TinhNang(DonDatXe_TinhNang donDatXe_TinhNang)
		{
			return _dalDonDatXe_TinhNang.AddDonDatXe_TinhNang(donDatXe_TinhNang);
		}

		public DonDatXe_TinhNang UpdateDonDatXe_TinhNang(DonDatXe_TinhNang donDatXe_TinhNang)
		{
			return _dalDonDatXe_TinhNang.UpdateDonDatXe_TinhNang(donDatXe_TinhNang);
		}

		public void DeleteDonDatXe_TinhNang(int donDatXe_TinhNangId)
		{
			_dalDonDatXe_TinhNang.DeleteDonDatXe_TinhNang(donDatXe_TinhNangId);
		}
	}
}