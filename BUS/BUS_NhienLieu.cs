using DAL;
using DTO;
using System.Collections.Generic;

namespace BUS
{
	public class BUS_NhienLieu
	{
		private DAL_NhienLieu _dalNhienLieu;

		public BUS_NhienLieu()
		{
			_dalNhienLieu = new DAL_NhienLieu(new CarRentalDBContext());
		}

		public List<NhienLieu> GetAllNhienLieu()
		{
			return _dalNhienLieu.ListAllNhienLieu();
		}

		public NhienLieu GetNhienLieuById(int nhienLieuId)
		{
			return _dalNhienLieu.GetNhienLieuById(nhienLieuId);
		}

		public NhienLieu AddNhienLieu(NhienLieu nhienLieu)
		{
			return _dalNhienLieu.AddNhienLieu(nhienLieu);
		}

		public NhienLieu UpdateNhienLieu(NhienLieu nhienLieu)
		{
			return _dalNhienLieu.UpdateNhienLieu(nhienLieu);
		}

		public void DeleteNhienLieu(int nhienLieuId)
		{
			_dalNhienLieu.DeleteNhienLieu(nhienLieuId);
		}
	}
}