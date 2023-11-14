using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
	public class BUS_TinhNangXe
	{
		private readonly DAL_TinhNangXe _dalTinhNangXe;

		public BUS_TinhNangXe()
		{
			_dalTinhNangXe = new DAL_TinhNangXe(new CarRentalDBContext());
		}

		public TinhNangXe GetTinhNangXeById(int id)
		{
			return _dalTinhNangXe.GetTinhNangXeById(id);
		}
	}
}
