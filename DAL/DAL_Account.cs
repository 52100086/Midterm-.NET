using DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Account
    {
        private readonly CarRentalDBContext _context;

        public DAL_Account(CarRentalDBContext context)
        {
            _context = context;
        }

        public async Task RegisterAsync(string username, string password, string role)
        {
            var account = new Account { Username = username, Password = password, Role = role };
            _context.Accounts.Add(account);
            await _context.SaveChangesAsync();
        }

        public async Task<Account> LoginAsync(string username, string password)
        {
            var account = await _context.Accounts.SingleOrDefaultAsync(a => a.Username == username && a.Password == password);
            return account;
        }

        public bool IsAdmin(Account account)
        {
            return account.Role == "admin";
        }

        public bool IsEmployee(Account account)
        {
            return account.Role == "employee";
        }


        public async Task<bool> CheckAccountExistsAsync(string username)
        {
            var account = await _context.Accounts.SingleOrDefaultAsync(a => a.Username == username);
            return account != null;
        }

        public async Task<List<Account>> GetEmployeeAccountsAsync()
        {
            return await _context.Accounts.Where(a => a.Role == "employee").ToListAsync();
        }

        public async Task UpdateAccountAsync(Account account)
        {
            _context.Accounts.Update(account);
            await _context.SaveChangesAsync();
        }



        public async Task DeleteSelectedAccountAsync(int accountId)
        {
            var account = await _context.Accounts.SingleOrDefaultAsync(a => a.AccountId == accountId);
            if (account != null)
            {
                _context.Accounts.Remove(account);
                await _context.SaveChangesAsync();
            }
        }



        public async Task UpdateUsernameAsync(string username, string newUsername)
        {
            var account = await _context.Accounts.SingleOrDefaultAsync(a => a.Username == username);
            if (account != null)
            {
                account.Username = newUsername;
                await _context.SaveChangesAsync();
            }
        }



    }
}
