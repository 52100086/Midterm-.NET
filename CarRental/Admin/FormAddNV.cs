using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental.Admin
{
    public partial class FormAddNV : Form
    {

        private readonly BUS_Account _busAccount = new BUS_Account();
        private FormEmployeeManagement mainForm;

        public FormAddNV(FormEmployeeManagement mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
        }

        private async void btn_add_Click(object sender, EventArgs e)
        {
            string sdt = txt_sdt.Text;
            string birthday = dtp_bd.Value.ToString("ddMMyy");

            bool accountExists = await _busAccount.CheckAccountExistsAsync(sdt);

            if (accountExists)
            {
                MessageBox.Show("Account already existed");
            }
            else
            {
                await _busAccount.RegisterAsync(sdt, birthday, "employee");
                MessageBox.Show("Account created successfully");
                mainForm.BindDataToDataGridview();
                this.Close();
            }
        }



        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
