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
    public partial class AdminOtoManagement : Form
    {
        public AdminOtoManagement()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Form form = new Admin.FormAddOto();
            form.ShowDialog();
        }
    }
}
