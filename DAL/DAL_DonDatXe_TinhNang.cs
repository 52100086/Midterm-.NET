using System.Linq;
using System.Collections.Generic;
using DTO;

namespace DAL
{
	public class DAL_DonDatXe_TinhNang
	{
		private CarRentalDBContext _context;

		public DAL_DonDatXe_TinhNang(CarRentalDBContext context)
		{
			_context = context;
		}

		public List<DonDatXe_TinhNang> ListAllDonDatXe_TinhNang()
		{
			return _context.DonDatXe_TinhNangs.ToList();
		}

		public DonDatXe_TinhNang GetDonDatXe_TinhNangById(int donDatXe_TinhNangId)
		{
			return _context.DonDatXe_TinhNangs.Find(donDatXe_TinhNangId);
		}

		public DonDatXe_TinhNang AddDonDatXe_TinhNang(DonDatXe_TinhNang donDatXe_TinhNang)
		{
			_context.DonDatXe_TinhNangs.Add(donDatXe_TinhNang);
			_context.SaveChanges();
			return donDatXe_TinhNang;
		}

		public DonDatXe_TinhNang UpdateDonDatXe_TinhNang(DonDatXe_TinhNang donDatXe_TinhNang)
		{
			var existingDonDatXe_TinhNang = _context.DonDatXe_TinhNangs.Find(donDatXe_TinhNang.DonDatXeId);
			if (existingDonDatXe_TinhNang != null)
			{
				_context.Entry(existingDonDatXe_TinhNang).CurrentValues.SetValues(donDatXe_TinhNang);
				_context.SaveChanges();
			}
			return donDatXe_TinhNang;
		}

		public void DeleteDonDatXe_TinhNang(int donDatXe_TinhNangId)
		{
			var donDatXe_TinhNang = _context.DonDatXe_TinhNangs.Find(donDatXe_TinhNangId);
			if (donDatXe_TinhNang != null)
			{
				_context.DonDatXe_TinhNangs.Remove(donDatXe_TinhNang);
				_context.SaveChanges();
			}
		}
	}
}