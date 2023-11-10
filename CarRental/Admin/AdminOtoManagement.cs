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

namespace CarRental.Admin
{
    public partial class AdminOtoManagement : Form
    {
        private readonly BUS_XeOto _busXeOto;

        public AdminOtoManagement(BUS_XeOto busXeOto)
        {
            InitializeComponent();
            _busXeOto = busXeOto;
        }

        private async void AdminOtoManagement_Load(object sender, EventArgs e)
        {
            var xeOtos = await _busXeOto.GetAllXeOtosAsync();

            if (xeOtos != null && xeOtos.Count > 0)
            {
                dgv_car.DataSource = xeOtos;
                dgv_car.Refresh();
            }
            else
            {
                MessageBox.Show("No data to display");
            }
        }


        private void iconButton1_Click(object sender, EventArgs e)
        {
            Form form = new Admin.FormAddOto();
            form.ShowDialog();
        }
    }
}
