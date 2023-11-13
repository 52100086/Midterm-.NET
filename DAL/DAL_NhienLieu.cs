using System.Linq;
using System.Collections.Generic;
using DTO;

namespace DAL
{
	public class DAL_NhienLieu
	{
		private CarRentalDBContext _context;

		public DAL_NhienLieu(CarRentalDBContext context)
		{
			_context = context;
		}

		public List<NhienLieu> ListAllNhienLieu()
		{
			return _context.NhienLieus.ToList();
		}

		public NhienLieu GetNhienLieuById(int nhienLieuId)
		{
			return _context.NhienLieus.Find(nhienLieuId);
		}

		public NhienLieu AddNhienLieu(NhienLieu nhienLieu)
		{
			_context.NhienLieus.Add(nhienLieu);
			_context.SaveChanges();
			return nhienLieu;
		}

		public NhienLieu UpdateNhienLieu(NhienLieu nhienLieu)
		{
			var existingNhienLieu = _context.NhienLieus.Find(nhienLieu.NhienLieuId);
			if (existingNhienLieu != null)
			{
				_context.Entry(existingNhienLieu).CurrentValues.SetValues(nhienLieu);
				_context.SaveChanges();
			}
			return nhienLieu;
		}

		public void DeleteNhienLieu(int nhienLieuId)
		{
			var nhienLieu = _context.NhienLieus.Find(nhienLieuId);
			if (nhienLieu != null)
			{
				_context.NhienLieus.Remove(nhienLieu);
				_context.SaveChanges();
			}
		}
	}
}