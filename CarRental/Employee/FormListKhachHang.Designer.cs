namespace CarRental.Employee
{
	partial class FormListKhachHang
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
			DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			panel1 = new Panel();
			dgv_khachhang = new DataGridView();
			panel3 = new Panel();
			btn_addKH = new FontAwesome.Sharp.IconButton();
			btn_addorder = new FontAwesome.Sharp.IconButton();
			btn_export = new FontAwesome.Sharp.IconButton();
			txt_searchKH = new MaterialSkin.Controls.MaterialTextBox();
			btn_searchKH = new FontAwesome.Sharp.IconButton();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgv_khachhang).BeginInit();
			panel3.SuspendLayout();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.Controls.Add(dgv_khachhang);
			panel1.Dock = DockStyle.Fill;
			panel1.Location = new Point(0, 101);
			panel1.Name = "panel1";
			panel1.Size = new Size(1076, 435);
			panel1.TabIndex = 6;
			// 
			// dgv_khachhang
			// 
			dgv_khachhang.BackgroundColor = SystemColors.ActiveCaption;
			dgv_khachhang.BorderStyle = BorderStyle.None;
			dgv_khachhang.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = SystemColors.MenuHighlight;
			dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
			dataGridViewCellStyle1.ForeColor = Color.White;
			dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
			dgv_khachhang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			dgv_khachhang.ColumnHeadersHeight = 29;
			dgv_khachhang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			dgv_khachhang.Dock = DockStyle.Fill;
			dgv_khachhang.EnableHeadersVisualStyles = false;
			dgv_khachhang.GridColor = Color.DeepSkyBlue;
			dgv_khachhang.Location = new Point(0, 0);
			dgv_khachhang.Name = "dgv_khachhang";
			dgv_khachhang.RowHeadersVisible = false;
			dgv_khachhang.RowHeadersWidth = 51;
			dataGridViewCellStyle2.BackColor = SystemColors.ActiveCaption;
			dataGridViewCellStyle2.ForeColor = Color.White;
			dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = Color.White;
			dgv_khachhang.RowsDefaultCellStyle = dataGridViewCellStyle2;
			dgv_khachhang.RowTemplate.Height = 29;
			dgv_khachhang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgv_khachhang.Size = new Size(1076, 435);
			dgv_khachhang.TabIndex = 1;
			// 
			// panel3
			// 
			panel3.Controls.Add(btn_addKH);
			panel3.Controls.Add(btn_addorder);
			panel3.Controls.Add(btn_export);
			panel3.Controls.Add(txt_searchKH);
			panel3.Controls.Add(btn_searchKH);
			panel3.Dock = DockStyle.Top;
			panel3.Location = new Point(0, 0);
			panel3.Name = "panel3";
			panel3.Size = new Size(1076, 101);
			panel3.TabIndex = 5;
			// 
			// btn_addKH
			// 
			btn_addKH.IconChar = FontAwesome.Sharp.IconChar.None;
			btn_addKH.IconColor = Color.Black;
			btn_addKH.IconFont = FontAwesome.Sharp.IconFont.Auto;
			btn_addKH.Location = new Point(76, 59);
			btn_addKH.Name = "btn_addKH";
			btn_addKH.Size = new Size(94, 29);
			btn_addKH.TabIndex = 8;
			btn_addKH.Text = "Thêm khách hàng";
			btn_addKH.UseVisualStyleBackColor = true;
			btn_addKH.Click += btn_addKH_Click;
			// 
			// btn_addorder
			// 
			btn_addorder.IconChar = FontAwesome.Sharp.IconChar.None;
			btn_addorder.IconColor = Color.Black;
			btn_addorder.IconFont = FontAwesome.Sharp.IconFont.Auto;
			btn_addorder.Location = new Point(912, 59);
			btn_addorder.Name = "btn_addorder";
			btn_addorder.Size = new Size(136, 29);
			btn_addorder.TabIndex = 7;
			btn_addorder.Text = "Thêm hóa đơn";
			btn_addorder.UseVisualStyleBackColor = true;
			btn_addorder.Click += btn_addorder_Click;
			// 
			// btn_export
			// 
			btn_export.IconChar = FontAwesome.Sharp.IconChar.None;
			btn_export.IconColor = Color.Black;
			btn_export.IconFont = FontAwesome.Sharp.IconFont.Auto;
			btn_export.Location = new Point(912, 24);
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
			txt_searchKH.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
			txt_searchKH.LeadingIcon = null;
			txt_searchKH.Location = new Point(367, 38);
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
			btn_searchKH.Location = new Point(656, 59);
			btn_searchKH.Name = "btn_searchKH";
			btn_searchKH.Size = new Size(94, 29);
			btn_searchKH.TabIndex = 4;
			btn_searchKH.Text = "Tìm kiếm";
			btn_searchKH.UseVisualStyleBackColor = true;
			btn_searchKH.Click += btn_searchKH_Click;
			// 
			// FormListKhachHang
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1076, 536);
			Controls.Add(panel1);
			Controls.Add(panel3);
			Name = "FormListKhachHang";
			Text = "FormListKhachHang";
			Load += FormListKhachHang_Load;
			panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dgv_khachhang).EndInit();
			panel3.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
		private DataGridView dgv_khachhang;
		private Panel panel3;
		private FontAwesome.Sharp.IconButton btn_addorder;
		private FontAwesome.Sharp.IconButton btn_export;
		private MaterialSkin.Controls.MaterialTextBox txt_searchKH;
		private FontAwesome.Sharp.IconButton btn_searchKH;
		private FontAwesome.Sharp.IconButton btn_addKH;
	}
}