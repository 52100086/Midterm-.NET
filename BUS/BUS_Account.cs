using DAL;
using DTO;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_Account
    {
        private readonly DAL_Account _dalAccount;

        public BUS_Account(DAL_Account dalAccount)
        {
            _dalAccount = dalAccount;
        }

        public async Task RegisterAsync(string username, string password, string role)
        {
            await _dalAccount.RegisterAsync(username, password, role);
        }

        public async Task<Account> LoginAsync(string username, string password)
        {
            return await _dalAccount.LoginAsync(username, password);
        }

        public bool IsAdmin(Account account)
        {
            return _dalAccount.IsAdmin(account);
        }

        public bool IsEmployee(Account account)
        {
            return _dalAccount.IsEmployee(account);
        }
    }
}
