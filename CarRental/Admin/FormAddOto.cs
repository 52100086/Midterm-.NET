using BUS;
using CarRental.Admin;
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
	public partial class FormAddOto : Form
	{
		private readonly BUS_XeOto _busXeOto;

		private PictureBox selectedPictureBox; // Biến tham chiếu đến PictureBox được chọn
		private MaterialLabel selectedMaterialLabel;
        private OtoManagement mainForm;
        public FormAddOto(OtoManagement mainForm, BUS_XeOto bus_XeOto)
		{
			InitializeComponent();
			_busXeOto = bus_XeOto;
            this.mainForm = mainForm;
            selectedPictureBox = pictureBox1;
			selectedMaterialLabel = txt_1;
			PopulateComboBoxes();
		}

		private void pictureBox_Click(object sender, EventArgs e)
		{

			// Bỏ viền của PictureBox trước đó (nếu có)
			if (selectedPictureBox != null)
			{
				selectedPictureBox.BorderStyle = BorderStyle.None;
				selectedMaterialLabel.Font = new Font(selectedMaterialLabel.Font, FontStyle.Regular);
			}

			// Đặt viền cho PictureBox mới được chọn
			selectedPictureBox = (PictureBox)sender;
			selectedPictureBox.BorderStyle = BorderStyle.FixedSingle;
			selectedMaterialLabel = GetLabelForPictureBox(selectedPictureBox);
			selectedMaterialLabel.Font = new Font(selectedMaterialLabel.Font, FontStyle.Bold);
		}
		private MaterialLabel GetLabelForPictureBox(PictureBox pictureBox)
		{

			if (pictureBox == pictureBox1)
			{
				return txt_1;
			}
			else if (pictureBox == pictureBox2)
			{
				return txt_2;
			}
			else if (pictureBox == pictureBox3)
			{
				return txt_3;
			}
			else if (pictureBox == pictureBox4)
			{
				return txt_4;
			}
			else if (pictureBox == pictureBox5)
			{
				return txt_5;
			}
			else if (pictureBox == pictureBox6)
			{
				return txt_6;
			}
			else
			{
				return txt_7;
			}
		}
		private async void PopulateComboBoxes()
		{
			try
			{
				// Retrieve data from the database asynchronously using the BUS_XeOto class
				//List<LoaiXe> loaiXes = await _busXeOto.GetAllLoaiXesAsync();
				List<MauXe> mauXes = await _busXeOto.GetAllMauXesAsync();
				List<HangXe> hangXes = await _busXeOto.GetAllHangXesAsync();


				// Populate the ComboBox for MauXe
				cbx_model.DataSource = mauXes;
				cbx_model.DisplayMember = "TenMauXe";
				cbx_model.ValueMember = "MauXeId";

				// Populate the ComboBox for HangXe
				cbx_hangxe.DataSource = hangXes;
				cbx_hangxe.DisplayMember = "TenHangXe";
				cbx_hangxe.ValueMember = "HangXeId";
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
				int loaiXeId;
				if (selectedPictureBox == pictureBox1)
				{
					loaiXeId = 1;
				}
				else if (selectedPictureBox == pictureBox2)
				{
					loaiXeId = 2;
				}
				else if (selectedPictureBox == pictureBox3)
				{
					loaiXeId = 3;
				}
				else if (selectedPictureBox == pictureBox4)
				{
					loaiXeId = 4;
				}
				else if (selectedPictureBox == pictureBox5)
				{
					loaiXeId = 5;
				}
				else if (selectedPictureBox == pictureBox6)
				{
					loaiXeId = 6;
				}
				else
				{
					loaiXeId = 7;
				}
				// Create a new XeOto object
				var newOto = new XeOto
				{
					GiaThue = Int32.Parse(txt_GiaThue.Text),
					TrangThai = "Sẵn sàng",
					LoaiXeId = loaiXeId,
					HangXeId = ((HangXe)cbx_hangxe.SelectedItem).HangXeId,
					MauXeId = ((MauXe)cbx_model.SelectedItem).MauXeId
					// Set other properties as needed
				};

				// Call the CreateXeOtoAsync method in your BUS_XeOto class
				var createdOto = await _busXeOto.CreateXeOtoAsync(newOto);

				if (createdOto != null)
				{
					MessageBox.Show("XeOto created successfully");
					await mainForm.BindDataToDataGridView();

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
