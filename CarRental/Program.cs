using BUS;
using DAL;

namespace CarRental
{
	internal static class Program
	{
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			// To customize application configuration such as set high DPI settings or default font,
			// see https://aka.ms/applicationconfiguration.
			var context = new CarRentalDBContext();
			var bus = new BUS_XeOto(new DAL_XeOto(context));
			var busKH = new BUS_KhachHang(new DAL_KhachHang(context));
			ApplicationConfiguration.Initialize();
			Application.Run(new FormAdminLayout(bus,busKH));
		}
	}
}