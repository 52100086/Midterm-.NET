using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace CarRental
{
    public partial class LoginForm : Form
    {
        private readonly BUS_Account _busAccount;

        public LoginForm(BUS_Account busAccount)
        {
            InitializeComponent();
            _busAccount = busAccount;
        }



        private async void btn_Login_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text;
            string password = txt_password.Text;
            Account account = await _busAccount.LoginAsync(username, password);

            if (account != null)
            {
                if (_busAccount.IsAdmin(account))
                {
                    FormAdmin fAdmin = new FormAdmin();
                    fAdmin.Show();
                    Hide();
                }
                else if (_busAccount.IsEmployee(account))
                {
                    FormEmployee fEmployee = new FormEmployee();
                    fEmployee.Show();
                    Hide();
                }
            }
            else
            {
                MessageBox.Show("Wrong username or password");
            }

        }
    }
}
