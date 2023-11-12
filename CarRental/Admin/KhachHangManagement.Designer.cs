namespace CarRental.Admin
{
	partial class KhachHangManagement
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			panel3 = new Panel();
			btn_addorder = new FontAwesome.Sharp.IconButton();
			btn_export = new FontAwesome.Sharp.IconButton();
			txt_searchKH = new MaterialSkin.Controls.MaterialTextBox();
			btn_searchKH = new FontAwesome.Sharp.IconButton();
			btn_updateKH = new FontAwesome.Sharp.IconButton();
			btn_deleteKH = new FontAwesome.Sharp.IconButton();
			btn_addKH = new FontAwesome.Sharp.IconButton();
			materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
			dgv_khachhang = new DataGridView();
			panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgv_khachhang).BeginInit();
			SuspendLayout();
			// 
			// panel3
			// 
			panel3.Controls.Add(btn_addorder);
			panel3.Controls.Add(btn_export);
			panel3.Controls.Add(txt_searchKH);
			panel3.Controls.Add(btn_searchKH);
			panel3.Controls.Add(btn_updateKH);
			panel3.Controls.Add(btn_deleteKH);
			panel3.Controls.Add(btn_addKH);
			panel3.Controls.Add(materialLabel2);
			panel3.Dock = DockStyle.Top;
			panel3.Location = new Point(3, 64);
			panel3.Name = "panel3";
			panel3.Size = new Size(1066, 139);
			panel3.TabIndex = 3;
			// 
			// btn_addorder
			// 
			btn_addorder.IconChar = FontAwesome.Sharp.IconChar.None;
			btn_addorder.IconColor = Color.Black;
			btn_addorder.IconFont = FontAwesome.Sharp.IconFont.Auto;
			btn_addorder.Location = new Point(911, 91);
			btn_addorder.Name = "btn_addorder";
			btn_addorder.Size = new Size(136, 29);
			btn_addorder.TabIndex = 7;
			btn_addorder.Text = "Thêm hóa đơn";
			btn_addorder.UseVisualStyleBackColor = true;
			// 
			// btn_export
			// 
			btn_export.IconChar = FontAwesome.Sharp.IconChar.None;
			btn_export.IconColor = Color.Black;
			btn_export.IconFont = FontAwesome.Sharp.IconFont.Auto;
			btn_export.Location = new Point(911, 56);
			btn_export.Name = "btn_export";
			btn_export.Size = new Size(136, 29);
			btn_export.TabIndex = 6;
			btn_export.Text = "Xuất excel";
			btn_export.UseVisualStyleBackColor = true;
			// 
			// txt_searchKH
			// 
			txt_searchKH.AnimateReadOnly = false;
			txt_searchKH.BorderStyle = BorderStyle.None;
			txt_searchKH.Depth = 0;
			txt_searchKH.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
			txt_searchKH.LeadingIcon = null;
			txt_searchKH.Location = new Point(366, 70);
			txt_searchKH.MaxLength = 50;
			txt_searchKH.MouseState = MaterialSkin.MouseState.OUT;
			txt_searchKH.Multiline = false;
			txt_searchKH.Name = "txt_searchKH";
			txt_searchKH.Size = new Size(266, 50);
			txt_searchKH.TabIndex = 5;
			txt_searchKH.Text = "";
			txt_searchKH.TrailingIcon = null;
			// 
			// btn_searchKH
			// 
			btn_searchKH.IconChar = FontAwesome.Sharp.IconChar.None;
			btn_searchKH.IconColor = Color.Black;
			btn_searchKH.IconFont = FontAwesome.Sharp.IconFont.Auto;
			btn_searchKH.Location = new Point(655, 91);
			btn_searchKH.Name = "btn_searchKH";
			btn_searchKH.Size = new Size(94, 29);
			btn_searchKH.TabIndex = 4;
			btn_searchKH.Text = "Tìm kiếm";
			btn_searchKH.UseVisualStyleBackColor = true;
			// 
			// btn_updateKH
			// 
			btn_updateKH.IconChar = FontAwesome.Sharp.IconChar.None;
			btn_updateKH.IconColor = Color.Black;
			btn_updateKH.IconFont = FontAwesome.Sharp.IconFont.Auto;
			btn_updateKH.Location = new Point(249, 91);
			btn_updateKH.Name = "btn_updateKH";
			btn_updateKH.Size = new Size(94, 29);
			btn_updateKH.TabIndex = 3;
			btn_updateKH.Text = "Cập nhật";
			btn_updateKH.UseVisualStyleBackColor = true;
			// 
			// btn_deleteKH
			// 
			btn_deleteKH.IconChar = FontAwesome.Sharp.IconChar.None;
			btn_deleteKH.IconColor = Color.Black;
			btn_deleteKH.IconFont = FontAwesome.Sharp.IconFont.Auto;
			btn_deleteKH.Location = new Point(136, 91);
			btn_deleteKH.Name = "btn_deleteKH";
			btn_deleteKH.Size = new Size(94, 29);
			btn_deleteKH.TabIndex = 2;
			btn_deleteKH.Text = "Xóa";
			btn_deleteKH.UseVisualStyleBackColor = true;
			// 
			// btn_addKH
			// 
			btn_addKH.IconChar = FontAwesome.Sharp.IconChar.None;
			btn_addKH.IconColor = Color.Black;
			btn_addKH.IconFont = FontAwesome.Sharp.IconFont.Auto;
			btn_addKH.Location = new Point(18, 91);
			btn_addKH.Name = "btn_addKH";
			btn_addKH.Size = new Size(94, 29);
			btn_addKH.TabIndex = 1;
			btn_addKH.Text = "Thêm khách hàng";
			btn_addKH.UseVisualStyleBackColor = true;
			// 
			// materialLabel2
			// 
			materialLabel2.AutoSize = true;
			materialLabel2.Depth = 0;
			materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
			materialLabel2.Location = new Point(18, 17);
			materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
			materialLabel2.Name = "materialLabel2";
			materialLabel2.Size = new Size(142, 19);
			materialLabel2.TabIndex = 0;
			materialLabel2.Text = "Quản lý khách hàng";
			// 
			// dgv_khachhang
			// 
			dgv_khachhang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgv_khachhang.Dock = DockStyle.Fill;
			dgv_khachhang.Location = new Point(3, 64);
			dgv_khachhang.Name = "dgv_khachhang";
			dgv_khachhang.RowHeadersWidth = 51;
			dgv_khachhang.RowTemplate.Height = 29;
			dgv_khachhang.Size = new Size(1066, 522);
			dgv_khachhang.TabIndex = 4;
			// 
			// KhachHangManagement
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1072, 589);
			Controls.Add(panel3);
			Controls.Add(dgv_khachhang);
			Name = "KhachHangManagement";
			Text = "KhachHangManagement";
			panel3.ResumeLayout(false);
			panel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dgv_khachhang).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Panel panel3;
		private FontAwesome.Sharp.IconButton btn_addorder;
		private FontAwesome.Sharp.IconButton btn_export;
		private MaterialSkin.Controls.MaterialTextBox txt_searchKH;
		private FontAwesome.Sharp.IconButton btn_searchKH;
		private FontAwesome.Sharp.IconButton btn_updateKH;
		private FontAwesome.Sharp.IconButton btn_deleteKH;
		private FontAwesome.Sharp.IconButton btn_addKH;
		private MaterialSkin.Controls.MaterialLabel materialLabel2;
		private DataGridView dgv_khachhang;
	}
}