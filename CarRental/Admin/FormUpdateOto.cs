using BUS;
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
		public event EventHandler OtoUpdated;
		private readonly BUS_XeOto _busXeOto;
		private readonly XeOto _xeOto;
		private PictureBox selectedPictureBox; // Biến tham chiếu đến PictureBox được chọn
		private MaterialLabel selectedMaterialLabel;
		public FormUpdateOto(BUS_XeOto busXeOto, XeOto xeOto)
		{
			InitializeComponent();
			materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
			materialSkinManager.EnforceBackcolorOnAllComponents = true;
			materialSkinManager.AddFormToManage(this);
			materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
			materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
			_busXeOto = busXeOto;
			_xeOto = xeOto;
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
			hy.Text = _xeOto.TrangThai;
			txt_GiaThue.Text = _xeOto.GiaThue.ToString();
			// Hiển thị và chọn giá trị cho các ComboBox LoaiXe, HangXe, MauXe
			await PopulateComboBoxes();
		}

		private async void btn_Update_Click(object sender, EventArgs e)
		{
			//string trangThai = hy.Text;
			string trangThai = cbx_TrangThai.SelectedItem?.ToString();
			int giaThue;
			if (!Int32.TryParse(txt_GiaThue.Text, out giaThue))
			{
				MessageBox.Show("Giá thuê không hợp lệ");
				return;
			}
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

			int hangXeId = (int)cbx_hangxe.SelectedValue;
			int mauXeId = (int)cbx_model.SelectedValue;

			// Cập nhật thông tin của xeOto
			_xeOto.TrangThai = trangThai;
			_xeOto.GiaThue = giaThue;
			_xeOto.LoaiXeId = loaiXeId;
			_xeOto.HangXeId = hangXeId;
			_xeOto.MauXeId = mauXeId;

			try
			{
				// Gọi phương thức cập nhật xe từ BUS
				await _busXeOto.UpdateXeOtoAsync(_xeOto);

				// Gọi sự kiện OtoUpdated để thông báo cập nhật thành công
				OnOtoUpdated();

				// Đóng form cập nhật
				this.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi cập nhật xe: " + ex.Message);
			}
		}
		private void OnOtoUpdated()
		{
			// Kiểm tra xem có người đăng ký sự kiện OtoUpdated hay không
			if (OtoUpdated != null)
			{
				// Gửi sự kiện OtoUpdated
				OtoUpdated(this, EventArgs.Empty);
			}
		}
	}
}
