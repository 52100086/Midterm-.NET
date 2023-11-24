using CarRental.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental.Employee
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
            if (khachhangId == 0)
            {
                int id = 1;
                FormEmployeeLayout formEmployeeLayout = this.ParentForm as FormEmployeeLayout;
                formEmployeeLayout.startFormCarTypeList(id);
            }
            else
            {
                FormListCarType formListCarType = new FormListCarType(1, khachhangId);
                formListCarType.ShowDialog();
            }
        }

        private void xe4chosedan_Click(object sender, EventArgs e)
        {
            if (khachhangId == 0)
            {
                int id = 2;
                FormEmployeeLayout formEmployeeLayout = this.ParentForm as FormEmployeeLayout;
                formEmployeeLayout.startFormCarTypeList(id);
            }
            else
            {
                FormListCarType formListCarType = new FormListCarType(2, khachhangId);
                formListCarType.ShowDialog();
            }
        }

        private void xe4chohatchback_Click(object sender, EventArgs e)
        {
            if (khachhangId == 0)
            {
                int id = 3;
                FormEmployeeLayout formEmployeeLayout = this.ParentForm as FormEmployeeLayout;
                formEmployeeLayout.startFormCarTypeList(id);
            }
            else
            {
                FormListCarType formListCarType = new FormListCarType(3, khachhangId);
                formListCarType.ShowDialog();
            }
        }

        private void xe5chocuv_Click(object sender, EventArgs e)
        {
            if (khachhangId == 0)
            {
                int id = 4;
                FormEmployeeLayout formEmployeeLayout = this.ParentForm as FormEmployeeLayout;
                formEmployeeLayout.startFormCarTypeList(id);
            }
            else
            {
                FormListCarType formListCarType = new FormListCarType(4, khachhangId);
                formListCarType.ShowDialog();
            }
        }

        private void xe5chosuv_Click(object sender, EventArgs e)
        {
            if (khachhangId == 0)
            {
                int id = 5;
                FormEmployeeLayout formEmployeeLayout = this.ParentForm as FormEmployeeLayout;
                formEmployeeLayout.startFormCarTypeList(id);
            }
            else
            {
                FormListCarType formListCarType = new FormListCarType(5, khachhangId);
                formListCarType.ShowDialog();
            }
        }

        private void xe7chomvp_Click(object sender, EventArgs e)
        {
            if (khachhangId == 0)
            {
                int id = 6;
                FormEmployeeLayout formEmployeeLayout = this.ParentForm as FormEmployeeLayout;
                formEmployeeLayout.startFormCarTypeList(id);
            }
            else
            {
                FormListCarType formListCarType = new FormListCarType(6, khachhangId);
                formListCarType.ShowDialog();
            }
        }

        private void pickupcar_Click(object sender, EventArgs e)
        {
            if (khachhangId == 0)
            {
                int id = 7;
                FormEmployeeLayout formEmployeeLayout = this.ParentForm as FormEmployeeLayout;
                formEmployeeLayout.startFormCarTypeList(id);
            }
            else
            {
                FormListCarType formListCarType = new FormListCarType(7, khachhangId);
                formListCarType.ShowDialog();
            }
        }
    }
}
