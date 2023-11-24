using BUS;
using CarRental.Admin;
using CarRental.Employee;
using DTO;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental
{
    public partial class FormLogin : MaterialForm
    {

        private readonly BUS_Account _busAccount = new BUS_Account();


        public FormLogin()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

        }


        private async void btn_Login_Click_1(object sender, EventArgs e)
        {

            if (txt_Username.Text == "")
            {
                lb_warning_username.Visible = true;
                return;
            }
            if (txt_Password.Text == "")
            {
                lbl_warning_password.Visible = true;
                return;
            }
            string username = txt_Username.Text;
            string password = txt_Password.Text;
            Account account = await _busAccount.LoginAsync(username, password);

            if (account != null)
            {
                if (_busAccount.IsAdmin(account))
                {
                    FormAdminLayout form = new FormAdminLayout();
                    form.Show();
                }
                else
                {
                    FormEmployeeLayout form = new FormEmployeeLayout();
                    form.Show();
                }

                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            lb_warning_username.Visible = false;
            lb_warning_username.ForeColor = Color.Red;
            lbl_warning_password.Visible = false;
            lbl_warning_password.ForeColor = Color.Red;

        }
    }
}
