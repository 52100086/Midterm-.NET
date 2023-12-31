﻿using BUS;
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
    public partial class FormListCarType : Form
    {
        private readonly BUS_XeOto _busXeOto = new BUS_XeOto();
        private int loaixeId;
        private int khachHangId;
        public FormListCarType(int loaixeId)
        {
            InitializeComponent();
            this.loaixeId = loaixeId;
        }
        public FormListCarType(int loaixeId, int khachHangId)
        {
            InitializeComponent();
            this.loaixeId = loaixeId;
            this.khachHangId = khachHangId;
        }
        private void FormListCarType_Load(object sender, EventArgs e)
        {
            dgv_cartype.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            var xeOtos = _busXeOto.GetXeOtosByType(loaixeId);
            if (xeOtos != null && xeOtos.Count > 0)
            {
                var data = xeOtos
                    .Where(x => x.TrangThai == "Sẵn sàng")
                    .Select(x => new
                    {
                        x.XeOtoId,
                        TrangThai = "Sẵn sàng",
                        x.GiaThue,
                        x.LoaiXe.TenLoaiXe,
                        x.HangXe.TenHangXe,
                        x.MauXe.TenMauXe
                    })
                    .ToList();

                dgv_cartype.DataSource = data;
                dgv_cartype.Refresh();
            }
            else
            {
                MessageBox.Show("No data to display");
            }
        }

        private void btn_addtoorder_Click(object sender, EventArgs e)
        {
            if (dgv_cartype.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgv_cartype.SelectedRows[0];
                int xeOtoId = Convert.ToInt32(selectedRow.Cells["XeOtoId"].Value);
                if (khachHangId == null)
                {
                    FormCarRentalOrder carDetailsForm = new FormCarRentalOrder(xeOtoId);

                    // Hiển thị form CarDetailsForm
                    carDetailsForm.Show();
                }
                else
                {
                    FormCarRentalOrder carDetailsForm = new FormCarRentalOrder(xeOtoId, khachHangId);
                    // Hiển thị form CarDetailsForm
                    carDetailsForm.Show();
                }
            }
            else
            {
                MessageBox.Show("No row selected");
            }
        }
    }
}
