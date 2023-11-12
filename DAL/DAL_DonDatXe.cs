using DTO;
using System.Linq;

namespace DAL
{
	public class DAL_DonDatXe
	{
		private CarRentalDBContext _context;

		public DAL_DonDatXe(CarRentalDBContext context)
		{
			_context = context;
		}
		public List<DonDatXe> ListAllDonDatXe()
		{
			return _context.DonDatXes.ToList();
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
	}
}