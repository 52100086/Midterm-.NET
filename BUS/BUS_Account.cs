using DAL;
using DocumentFormat.OpenXml.InkML;
using DTO;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_Account
    {
        private readonly DAL_Account _dalAccount;

        public BUS_Account()
        {
            _dalAccount = new DAL_Account(new CarRentalDBContext());
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


        public async Task<bool> CheckAccountExistsAsync(string username)
        {
            return await _dalAccount.CheckAccountExistsAsync(username);
        }

        public async Task<List<Account>> GetEmployeeAccountsAsync()
        {
            return await _dalAccount.GetEmployeeAccountsAsync();
        }

        public async Task DeleteSelectedAccountAsync(int accountId)
        {
            await _dalAccount.DeleteSelectedAccountAsync(accountId);
        }

        public async Task UpdateAccountAsync(Account account)
        {
            await _dalAccount.UpdateAccountAsync(account);
        }


        public async Task UpdateUsernameAsync(string username, string newUsername)
        {
            await _dalAccount.UpdateUsernameAsync(username, newUsername);
        }



    }
}
