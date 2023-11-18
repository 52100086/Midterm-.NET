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
	public partial class FormUpdateOto : MaterialForm
	{
		readonly MaterialSkin.MaterialSkinManager materialSkinManager;
		private readonly BUS_XeOto _busXeOto = new BUS_XeOto();
		private int _xeOtoId;
		private PictureBox selectedPictureBox; // Biến tham chiếu đến PictureBox được chọn
		private MaterialLabel selectedMaterialLabel;
		private OtoManagement mainForm;
		//private 
		public FormUpdateOto(OtoManagement mainForm, int xeOtoId)
		{
			InitializeComponent();
			materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
			materialSkinManager.EnforceBackcolorOnAllComponents = true;
			materialSkinManager.AddFormToManage(this);
			materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
			materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
			_xeOtoId = xeOtoId;
            this.mainForm = mainForm;
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
		private async Task PopulateComboBoxes()
		{
			try
			{
				// Retrieve data from the database asynchronously using the BUS_XeOto class
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

				// Populate the ComboBox for TrangThai
				List<string> trangthai = new List<string> { "Sẵn sàng", "Đang bảo trì", "Đang thuê" };
				cbx_TrangThai.DataSource = trangthai;
			}
			catch (Exception ex)
			{
				// Handle and log any exceptions that occur during data retrieval
				MessageBox.Show("An error occurred while populating the ComboBoxes: " + ex.Message);
			}
		}

		private async void FormUpdateOto_Load(object sender, EventArgs e)
		{
			await PopulateComboBoxes();
			XeOto xeOto = _busXeOto.GetXeOtoById(_xeOtoId);
			txt_GiaThue.Text = xeOto.GiaThue.ToString();
			cbx_hangxe.SelectedItem = cbx_hangxe.Items.Cast<HangXe>().FirstOrDefault(h => h.HangXeId == xeOto.HangXeId);
			cbx_model.SelectedItem = cbx_model.Items.Cast<MauXe>().FirstOrDefault(m => m.MauXeId == xeOto.MauXeId);
			cbx_TrangThai.SelectedItem = xeOto.TrangThai;

			SelectPictureBoxByLoaiXeId(xeOto.LoaiXeId);
		}

		private void SelectPictureBoxByLoaiXeId(int loaiXeId)
		{
			// Bỏ viền của PictureBox trước đó (nếu có)
			if (selectedPictureBox != null)
			{
				selectedPictureBox.BorderStyle = BorderStyle.None;
				selectedMaterialLabel.Font = new Font(selectedMaterialLabel.Font, FontStyle.Regular);
			}

			// Chọn PictureBox tương ứng với loaiXeId
			switch (loaiXeId)
			{
				case 1:
					selectedPictureBox = pictureBox1;
					selectedMaterialLabel = txt_1;
					break;
				case 2:
					selectedPictureBox = pictureBox2;
					selectedMaterialLabel = txt_2;
					break;
				case 3:
					selectedPictureBox = pictureBox3;
					selectedMaterialLabel = txt_3;
					break;
				case 4:
					selectedPictureBox = pictureBox4;
					selectedMaterialLabel = txt_4;
					break;
				case 5:
					selectedPictureBox = pictureBox5;
					selectedMaterialLabel = txt_5;
					break;
				case 6:
					selectedPictureBox = pictureBox6;
					selectedMaterialLabel = txt_6;
					break;
				default:
					selectedPictureBox = pictureBox7;
					selectedMaterialLabel = txt_7;
					break;
			}

			// Đặt viền cho PictureBox mới được chọn
			selectedPictureBox.BorderStyle = BorderStyle.FixedSingle;
			selectedMaterialLabel.Font = new Font(selectedMaterialLabel.Font, FontStyle.Bold);
		}

		private async void btn_Update_Click(object sender, EventArgs e)
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
				var update = new XeOto
				{
					XeOtoId = _xeOtoId,
					GiaThue = Int32.Parse(txt_GiaThue.Text),
					TrangThai = cbx_TrangThai.SelectedItem.ToString(),
					LoaiXeId = loaiXeId,
					HangXeId = ((HangXe)cbx_hangxe.SelectedItem).HangXeId,
					MauXeId = ((MauXe)cbx_model.SelectedItem).MauXeId
					// Set other properties as needed
				};

				// Call the CreateXeOtoAsync method in your BUS_XeOto class
				var createdOto = _busXeOto.UpdateXeOto(update);

				if (createdOto != null)
				{
					MessageBox.Show("XeOto is updated successfully");
                    await mainForm.BindDataToDataGridView();

                }
                else
				{
					// Failed to create the XeOto object
					MessageBox.Show("Failed to update XeOto");
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
