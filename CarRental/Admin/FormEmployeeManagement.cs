using BUS;
using DAL;
using DTO;
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
    public partial class FormEmployeeManagement : Form
    {

        private readonly BUS_Account _busAccount = new BUS_Account();
        public FormEmployeeManagement()
        {
            InitializeComponent();
        }

        private void btn_addNV_Click(object sender, EventArgs e)
        {
            Form nv = new FormAddNV(this);
            nv.ShowDialog();
        }

        private async void FormEmployeeManagement_Load(object sender, EventArgs e)
        {

            dgv_nhanvien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            await BindDataToDataGridview();

            foreach (DataGridViewColumn column in dgv_nhanvien.Columns)
            {
                if (column.Name == "AccountId")
                {
                    column.HeaderText = "ID";
                }
                else if (column.Name == "Username")
                {
                    column.HeaderText = "Số điện thoại";
                }

            }




        }

        public async Task BindDataToDataGridview()
        {
            var accounts = await _busAccount.GetEmployeeAccountsAsync();

            if (accounts != null && accounts.Count > 0)
            {
                dgv_nhanvien.DataSource = accounts;
                var data = accounts.Select(x => new
                {
                    x.AccountId,
                    x.Username,
                }).ToList();

                dgv_nhanvien.DataSource = data;
                dgv_nhanvien.Refresh();
            }
            else
            {
                dgv_nhanvien.DataSource = null;
            }
        }

        private void dgv_nhanvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void btn_deleteNV_Click(object sender, EventArgs e)
        {
            int selectedAccountId = GetSelectedAccountId();
            if (selectedAccountId > 0)
            {
                await _busAccount.DeleteSelectedAccountAsync(selectedAccountId);
                await BindDataToDataGridview();
            }
        }


        private int GetSelectedAccountId()
        {
            if (dgv_nhanvien.SelectedRows.Count > 0)
            {
                var selectedAccount = dgv_nhanvien.SelectedRows[0].DataBoundItem;
                return (int)selectedAccount.GetType().GetProperty("AccountId").GetValue(selectedAccount, null);
            }
            return 0;
        }


        private async void dgv_nhanvien_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_nhanvien.SelectedRows.Count > 0)
            {
                var selectedAccount = (Account)dgv_nhanvien.SelectedRows[0].DataBoundItem;
                await _busAccount.UpdateAccountAsync(selectedAccount);
            }
        }

        private void btn_updateNV_Click(object sender, EventArgs e)
        {
            string selectedUsername = dgv_nhanvien.CurrentRow.Cells["Username"].Value.ToString();

            FormUpdateNV update = new FormUpdateNV(this)
            {
                Username = selectedUsername
            };

            update.ShowDialog();
        }

    }
}
