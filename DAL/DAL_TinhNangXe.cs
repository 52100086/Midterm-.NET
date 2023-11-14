using DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
	public class DAL_TinhNangXe
	{
		private readonly CarRentalDBContext _context;

		public DAL_TinhNangXe(CarRentalDBContext context)
		{
			_context = context;
		}

		public TinhNangXe GetTinhNangXeById(int id)
		{
			return _context.TinhNangXes.Find(id);
		}
	}
}
