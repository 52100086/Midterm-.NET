using BUS;
using DAL;

namespace CarRental
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var context = new CarRentalDBContext();
            var busAccount = new BUS_Account(new DAL_Account(context));

            Application.Run(new LoginForm(busAccount));
        }
    }
}
