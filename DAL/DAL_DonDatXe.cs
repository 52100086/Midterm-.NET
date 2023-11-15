using DAL;
using DTO;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace DAL
{
	public class DAL_DonDatXe
	{
		private CarRentalDBContext _context;

		public DAL_DonDatXe(CarRentalDBContext context)
		{
			_context = context;
		}
		public async Task<List<DonDatXe>> ListAllDonDatXe()
		{
			return await _context.DonDatXes
					.Include(x => x.NhienLieu)
					.Include(x => x.KhachHang)
					.Include(x => x.XeOto)
					.ToListAsync();
		}

		public DonDatXe GetDonDatXeById(int donDatXeId)
		{
			return _context.DonDatXes.Find(donDatXeId);
		}

		public DonDatXe AddDonDatXe(DonDatXe donDatXe)
		{
			_context.DonDatXes.Add(donDatXe);
			_context.SaveChanges();
			return donDatXe;
		}

		public DonDatXe UpdateDonDatXe(DonDatXe donDatXe)
		{
			var existingDonDatXe = _context.DonDatXes.Find(donDatXe.DonDatXeId);
			if (existingDonDatXe != null)
			{
				_context.Entry(existingDonDatXe).CurrentValues.SetValues(donDatXe);
				_context.SaveChanges();
			}
			return donDatXe;
		}

		public void DeleteDonDatXe(int donDatXeId)
		{
			var donDatXe = _context.DonDatXes.Find(donDatXeId);
			if (donDatXe != null)
			{
				_context.DonDatXes.Remove(donDatXe);
				_context.SaveChanges();
			}
		}
		public void AddDonDatXe_TinhNang(int donDatXeId, int tinhNangId)
		{
			var donDatXe_TinhNang = new DonDatXe_TinhNang
			{
				DonDatXeId = donDatXeId,
				TinhNangId = tinhNangId
			};
			_context.DonDatXe_TinhNangs.Add(donDatXe_TinhNang);
			_context.SaveChanges();
		}
		public List<int> getListTinhNangcuaDonDatXe(int donDatXeId)
		{
			var donDatXe = _context.DonDatXes
				.Include(x => x.DonDatXe_TinhNangs)
				.FirstOrDefault(x => x.DonDatXeId == donDatXeId);

			if (donDatXe != null)
			{
				return donDatXe.DonDatXe_TinhNangs.Select(d => d.TinhNangId).ToList();
			}

			return new List<int>();
		}
	}
}