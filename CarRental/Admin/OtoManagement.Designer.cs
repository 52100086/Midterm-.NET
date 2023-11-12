namespace CarRental.Admin
{
	partial class OtoManagement
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
			panel1 = new Panel();
			panel2 = new Panel();
			txt_search = new MaterialSkin.Controls.MaterialTextBox();
			btn_search = new FontAwesome.Sharp.IconButton();
			btn_update = new FontAwesome.Sharp.IconButton();
			btn_delete = new FontAwesome.Sharp.IconButton();
			btn_add = new FontAwesome.Sharp.IconButton();
			materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
			dgv_car = new DataGridView();
			panel1.SuspendLayout();
			panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgv_car).BeginInit();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.Controls.Add(panel2);
			panel1.Controls.Add(dgv_car);
			panel1.Dock = DockStyle.Fill;
			panel1.Location = new Point(3, 64);
			panel1.Name = "panel1";
			panel1.Size = new Size(985, 500);
			panel1.TabIndex = 0;
			// 
			// panel2
			// 
			panel2.Controls.Add(txt_search);
			panel2.Controls.Add(btn_search);
			panel2.Controls.Add(btn_update);
			panel2.Controls.Add(btn_delete);
			panel2.Controls.Add(btn_add);
			panel2.Controls.Add(materialLabel1);
			panel2.Dock = DockStyle.Top;
			panel2.Location = new Point(0, 0);
			panel2.Name = "panel2";
			panel2.Size = new Size(985, 96);
			panel2.TabIndex = 1;
			// 
			// txt_search
			// 
			txt_search.AnimateReadOnly = false;
			txt_search.BorderStyle = BorderStyle.None;
			txt_search.Depth = 0;
			txt_search.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
			txt_search.LeadingIcon = null;
			txt_search.Location = new Point(468, 27);
			txt_search.MaxLength = 50;
			txt_search.MouseState = MaterialSkin.MouseState.OUT;
			txt_search.Multiline = false;
			txt_search.Name = "txt_search";
			txt_search.Size = new Size(266, 50);
			txt_search.TabIndex = 5;
			txt_search.Text = "";
			txt_search.TrailingIcon = null;
			// 
			// btn_search
			// 
			btn_search.IconChar = FontAwesome.Sharp.IconChar.None;
			btn_search.IconColor = Color.Black;
			btn_search.IconFont = FontAwesome.Sharp.IconFont.Auto;
			btn_search.Location = new Point(784, 48);
			btn_search.Name = "btn_search";
			btn_search.Size = new Size(94, 29);
			btn_search.TabIndex = 4;
			btn_search.Text = "Tìm kiếm";
			btn_search.UseVisualStyleBackColor = true;
			// 
			// btn_update
			// 
			btn_update.IconChar = FontAwesome.Sharp.IconChar.None;
			btn_update.IconColor = Color.Black;
			btn_update.IconFont = FontAwesome.Sharp.IconFont.Auto;
			btn_update.Location = new Point(317, 48);
			btn_update.Name = "btn_update";
			btn_update.Size = new Size(94, 29);
			btn_update.TabIndex = 3;
			btn_update.Text = "Cập nhật";
			btn_update.UseVisualStyleBackColor = true;
			// 
			// btn_delete
			// 
			btn_delete.IconChar = FontAwesome.Sharp.IconChar.None;
			btn_delete.IconColor = Color.Black;
			btn_delete.IconFont = FontAwesome.Sharp.IconFont.Auto;
			btn_delete.Location = new Point(197, 48);
			btn_delete.Name = "btn_delete";
			btn_delete.Size = new Size(94, 29);
			btn_delete.TabIndex = 2;
			btn_delete.Text = "Xóa xe";
			btn_delete.UseVisualStyleBackColor = true;
			// 
			// btn_add
			// 
			btn_add.IconChar = FontAwesome.Sharp.IconChar.None;
			btn_add.IconColor = Color.Black;
			btn_add.IconFont = FontAwesome.Sharp.IconFont.Auto;
			btn_add.Location = new Point(72, 48);
			btn_add.Name = "btn_add";
			btn_add.Size = new Size(94, 29);
			btn_add.TabIndex = 1;
			btn_add.Text = "Thêm xe";
			btn_add.UseVisualStyleBackColor = true;
			btn_add.Click += btn_add_Click;
			// 
			// materialLabel1
			// 
			materialLabel1.AutoSize = true;
			materialLabel1.Depth = 0;
			materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
			materialLabel1.Location = new Point(18, 17);
			materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
			materialLabel1.Name = "materialLabel1";
			materialLabel1.Size = new Size(102, 19);
			materialLabel1.TabIndex = 0;
			materialLabel1.Text = "Quản lý xe oto";
			// 
			// dgv_car
			// 
			dgv_car.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgv_car.Dock = DockStyle.Fill;
			dgv_car.Location = new Point(0, 0);
			dgv_car.Name = "dgv_car";
			dgv_car.RowHeadersWidth = 51;
			dgv_car.RowTemplate.Height = 29;
			dgv_car.Size = new Size(985, 500);
			dgv_car.TabIndex = 2;
			// 
			// OtoManagement
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(991, 567);
			Controls.Add(panel1);
			Name = "OtoManagement";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "OtoManagement";
			panel1.ResumeLayout(false);
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dgv_car).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
		private Panel panel2;
		private MaterialSkin.Controls.MaterialTextBox txt_search;
		private FontAwesome.Sharp.IconButton btn_search;
		private FontAwesome.Sharp.IconButton btn_update;
		private FontAwesome.Sharp.IconButton btn_delete;
		private FontAwesome.Sharp.IconButton btn_add;
		private MaterialSkin.Controls.MaterialLabel materialLabel1;
		private DataGridView dgv_car;
	}
}