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


    }
}
