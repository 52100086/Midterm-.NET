namespace CarRental.Admin
{
	partial class FormOrderManagement
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
			dgv_order = new DataGridView();
			panel3 = new Panel();
			btn_export = new FontAwesome.Sharp.IconButton();
			txt_search = new MaterialSkin.Controls.MaterialTextBox();
			btn_search = new FontAwesome.Sharp.IconButton();
			btn_update = new FontAwesome.Sharp.IconButton();
			btn_delete = new FontAwesome.Sharp.IconButton();
			btn_chitiet = new FontAwesome.Sharp.IconButton();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgv_order).BeginInit();
			panel3.SuspendLayout();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.Controls.Add(dgv_order);
			panel1.Dock = DockStyle.Fill;
			panel1.Location = new Point(0, 101);
			panel1.Name = "panel1";
			panel1.Size = new Size(1098, 388);
			panel1.TabIndex = 6;
			// 
			// dgv_order
			// 
			dgv_order.BackgroundColor = SystemColors.ActiveCaption;
			dgv_order.BorderStyle = BorderStyle.None;
			dgv_order.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = SystemColors.MenuHighlight;
			dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
			dataGridViewCellStyle1.ForeColor = Color.White;
			dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
			dgv_order.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			dgv_order.ColumnHeadersHeight = 29;
			dgv_order.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			dgv_order.Dock = DockStyle.Fill;
			dgv_order.EnableHeadersVisualStyles = false;
			dgv_order.GridColor = Color.DeepSkyBlue;
			dgv_order.Location = new Point(0, 0);
			dgv_order.Name = "dgv_order";
			dgv_order.RowHeadersVisible = false;
			dgv_order.RowHeadersWidth = 51;
			dataGridViewCellStyle2.BackColor = SystemColors.ActiveCaption;
			dataGridViewCellStyle2.ForeColor = Color.White;
			dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = Color.White;
			dgv_order.RowsDefaultCellStyle = dataGridViewCellStyle2;
			dgv_order.RowTemplate.Height = 29;
			dgv_order.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgv_order.Size = new Size(1098, 388);
			dgv_order.TabIndex = 1;
			// 
			// panel3
			// 
			panel3.Controls.Add(btn_export);
			panel3.Controls.Add(txt_search);
			panel3.Controls.Add(btn_search);
			panel3.Controls.Add(btn_update);
			panel3.Controls.Add(btn_delete);
			panel3.Controls.Add(btn_chitiet);
			panel3.Dock = DockStyle.Top;
			panel3.Location = new Point(0, 0);
			panel3.Name = "panel3";
			panel3.Size = new Size(1098, 101);
			panel3.TabIndex = 5;
			// 
			// btn_export
			// 
			btn_export.IconChar = FontAwesome.Sharp.IconChar.None;
			btn_export.IconColor = Color.Black;
			btn_export.IconFont = FontAwesome.Sharp.IconFont.Auto;
			btn_export.Location = new Point(915, 59);
			btn_export.Name = "btn_export";
			btn_export.Size = new Size(136, 29);
			btn_export.TabIndex = 6;
			btn_export.Text = "Xuất excel";
			btn_export.UseVisualStyleBackColor = true;
			// 
			// txt_search
			// 
			txt_search.AnimateReadOnly = false;
			txt_search.BorderStyle = BorderStyle.None;
			txt_search.Depth = 0;
			txt_search.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
			txt_search.LeadingIcon = null;
			txt_search.Location = new Point(367, 38);
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
			btn_search.Location = new Point(656, 59);
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
			btn_update.Location = new Point(250, 59);
			btn_update.Name = "btn_update";
			btn_update.Size = new Size(94, 29);
			btn_update.TabIndex = 3;
			btn_update.Text = "Cập nhật";
			btn_update.UseVisualStyleBackColor = true;
			btn_update.Click += btn_update_Click;
			// 
			// btn_delete
			// 
			btn_delete.IconChar = FontAwesome.Sharp.IconChar.None;
			btn_delete.IconColor = Color.Black;
			btn_delete.IconFont = FontAwesome.Sharp.IconFont.Auto;
			btn_delete.Location = new Point(137, 59);
			btn_delete.Name = "btn_delete";
			btn_delete.Size = new Size(94, 29);
			btn_delete.TabIndex = 2;
			btn_delete.Text = "Xóa";
			btn_delete.UseVisualStyleBackColor = true;
			// 
			// btn_chitiet
			// 
			btn_chitiet.IconChar = FontAwesome.Sharp.IconChar.None;
			btn_chitiet.IconColor = Color.Black;
			btn_chitiet.IconFont = FontAwesome.Sharp.IconFont.Auto;
			btn_chitiet.Location = new Point(19, 59);
			btn_chitiet.Name = "btn_chitiet";
			btn_chitiet.Size = new Size(94, 29);
			btn_chitiet.TabIndex = 1;
			btn_chitiet.Text = "Xem chi tiết";
			btn_chitiet.UseVisualStyleBackColor = true;
			// 
			// FormOrderManagement
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1098, 489);
			Controls.Add(panel1);
			Controls.Add(panel3);
			Name = "FormOrderManagement";
			Text = "FormOrderManagement";
			Load += FormOrderManagement_Load;
			panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dgv_order).EndInit();
			panel3.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
		private DataGridView dgv_order;
		private Panel panel3;
		private FontAwesome.Sharp.IconButton btn_export;
		private MaterialSkin.Controls.MaterialTextBox txt_search;
		private FontAwesome.Sharp.IconButton btn_search;
		private FontAwesome.Sharp.IconButton btn_update;
		private FontAwesome.Sharp.IconButton btn_delete;
		private FontAwesome.Sharp.IconButton btn_chitiet;
	}
}