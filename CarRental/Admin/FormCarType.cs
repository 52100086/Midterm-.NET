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
namespace CarRental.Admin
{
    public partial class FormCarType : Form
    {
        private int khachhangId;
        public FormCarType()
        {
            InitializeComponent();
        }
        public FormCarType(int khachhangId)
        {
            InitializeComponent();
            this.khachhangId = khachhangId;
        }

        private void xe4chomini_Click(object sender, EventArgs e)
        {
            if (khachhangId == null)
            {
                int id = 1;
                FormAdminLayout formAdminLayout = this.ParentForm as FormAdminLayout;
                formAdminLayout.startFormCarTypeList(id);
            }
            else
            {
                FormListCarType formListCarType = new FormListCarType(1, khachhangId);
                formListCarType.ShowDialog();
            }
        }

        private void xe4chosedan_Click(object sender, EventArgs e)
        {
            if (khachhangId == null)
            {
                int id = 2;
                FormAdminLayout formAdminLayout = this.ParentForm as FormAdminLayout;
                formAdminLayout.startFormCarTypeList(id);
            }
            else
            {
                FormListCarType formListCarType = new FormListCarType(2, khachhangId);
                formListCarType.ShowDialog();
            }
        }

        private void xe4chohatchback_Click(object sender, EventArgs e)
        {
            if (khachhangId == null)
            {
                int id = 3;
                FormAdminLayout formAdminLayout = this.ParentForm as FormAdminLayout;
                formAdminLayout.startFormCarTypeList(id);
            }
            else
            {
                FormListCarType formListCarType = new FormListCarType(3, khachhangId);
                formListCarType.ShowDialog();
            }
        }

        private void xe5chocuv_Click(object sender, EventArgs e)
        {
            if (khachhangId == null)
            {
                int id = 4;
                FormAdminLayout formAdminLayout = this.ParentForm as FormAdminLayout;
                formAdminLayout.startFormCarTypeList(id);
            }
            else
            {
                FormListCarType formListCarType = new FormListCarType(4, khachhangId);
                formListCarType.ShowDialog();
            }
        }

        private void xe5chosuv_Click(object sender, EventArgs e)
        {
            if (khachhangId == null)
            {
                int id = 5;
                FormAdminLayout formAdminLayout = this.ParentForm as FormAdminLayout;
                formAdminLayout.startFormCarTypeList(id);
            }
            else
            {
                FormListCarType formListCarType = new FormListCarType(5, khachhangId);
                formListCarType.ShowDialog();
            }
        }

        private void xe7chomvp_Click(object sender, EventArgs e)
        {
            if (khachhangId == null)
            {
                int id = 6;
                FormAdminLayout formAdminLayout = this.ParentForm as FormAdminLayout;
                formAdminLayout.startFormCarTypeList(id);
            }
            else
            {
                FormListCarType formListCarType = new FormListCarType(6, khachhangId);
                formListCarType.ShowDialog();
            }
        }

        private void pickupcar_Click(object sender, EventArgs e)
        {
            if (khachhangId == null)
            {
                int id = 7;
                FormAdminLayout formAdminLayout = this.ParentForm as FormAdminLayout;
                formAdminLayout.startFormCarTypeList(id);
            }
            else
            {
                FormListCarType formListCarType = new FormListCarType(7, khachhangId);
                formListCarType.ShowDialog();
            }
        }
    }
}
