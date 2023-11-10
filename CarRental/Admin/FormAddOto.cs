using BUS;
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
    public partial class FormAddOto : Form
    {
        private readonly BUS_XeOto _busXeOto;

        public FormAddOto(BUS_XeOto busXeOto)
        {
            InitializeComponent();
            _busXeOto = busXeOto;
            PopulateComboBoxes();
        }
        private async void PopulateComboBoxes()
        {
            try
            {
                // Retrieve data from the database asynchronously using the BUS_XeOto class
                List<LoaiXe> loaiXes = await _busXeOto.GetAllLoaiXesAsync();
                List<MauXe> mauXes = await _busXeOto.GetAllMauXesAsync();
                List<HangXe> hangXes = await _busXeOto.GetAllHangXesAsync();

                // Populate the ComboBox for LoaiXe
                cbx_LoaiXe.DataSource = loaiXes;
                cbx_LoaiXe.DisplayMember = "TenLoaiXe";
                cbx_LoaiXe.ValueMember = "LoaiXeId";

                // Populate the ComboBox for MauXe
                cbx_MauXe.DataSource = mauXes;
                cbx_MauXe.DisplayMember = "TenMauXe";
                cbx_MauXe.ValueMember = "MauXeId";

                // Populate the ComboBox for HangXe
                cbx_HangXe.DataSource = hangXes;
                cbx_HangXe.DisplayMember = "TenHangXe";
                cbx_HangXe.ValueMember = "HangXeId";
            }
            catch (Exception ex)
            {
                // Handle and log any exceptions that occur during data retrieval
                MessageBox.Show("An error occurred while populating the ComboBoxes: " + ex.Message);
            }
        }
        private async void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                // Create a new XeOto object
                var newOto = new XeOto
                {
                    TrangThai = txt_TrangThai.Text,
                    GiaThue = Int32.Parse(txt_GiaThue.Text),
                    LoaiXeId = ((LoaiXe)cbx_LoaiXe.SelectedItem).LoaiXeId,
                    HangXeId = ((HangXe)cbx_HangXe.SelectedItem).HangXeId,
                    MauXeId = ((MauXe)cbx_MauXe.SelectedItem).MauXeId
                    // Set other properties as needed
                };

                // Call the CreateXeOtoAsync method in your BUS_XeOto class
                var createdOto = await _busXeOto.CreateXeOtoAsync(newOto);

                if (createdOto != null)
                {
                    // Success, the XeOto object was created
                    // Do something with the createdOto object

                    MessageBox.Show("XeOto created successfully");
                }
                else
                {
                    // Failed to create the XeOto object
                    MessageBox.Show("Failed to create XeOto");
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur during the operation
                MessageBox.Show("An error occurred: " + ex.Message);
            }

            // Optionally, you can close the form or perform other actions after the creation
            this.Close();
        }
    }
}
