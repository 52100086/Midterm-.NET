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
    public partial class FormUpdateNV : Form
    {

        private readonly BUS_Account _busAccount = new BUS_Account();
        private FormEmployeeManagement mainForm;
        public string Username { get; set; }

        public FormUpdateNV(FormEmployeeManagement mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;

        }


        private async void btn_add_Click(object sender, EventArgs e)
        {
            
            string newUsername = txt_sdt.Text;

            await _busAccount.UpdateUsernameAsync(Username, newUsername);

            await mainForm.BindDataToDataGridview();
            this.Close();
            
        }


        private void FormUpdateNV_Load(object sender, EventArgs e)
        {
            txt_sdt.Text = Username;
        }


    }
}
