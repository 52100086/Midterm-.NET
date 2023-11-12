namespace CarRental
{
	partial class FormAddKH
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
			btn_add = new FontAwesome.Sharp.IconButton();
			txt_email = new MaterialSkin.Controls.MaterialTextBox();
			txt_sdt = new MaterialSkin.Controls.MaterialTextBox();
			txt_hoten = new MaterialSkin.Controls.MaterialTextBox();
			txt_diachi = new MaterialSkin.Controls.MaterialTextBox();
			materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
			materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
			materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
			materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
			btn_cancel = new FontAwesome.Sharp.IconButton();
			SuspendLayout();
			// 
			// btn_add
			// 
			btn_add.IconChar = FontAwesome.Sharp.IconChar.None;
			btn_add.IconColor = Color.Black;
			btn_add.IconFont = FontAwesome.Sharp.IconFont.Auto;
			btn_add.Location = new Point(283, 469);
			btn_add.Name = "btn_add";
			btn_add.Size = new Size(134, 63);
			btn_add.TabIndex = 0;
			btn_add.Text = "Thêm";
			btn_add.UseVisualStyleBackColor = true;
			btn_add.Click += btn_add_Click;
			// 
			// txt_email
			// 
			txt_email.AnimateReadOnly = false;
			txt_email.BorderStyle = BorderStyle.None;
			txt_email.Depth = 0;
			txt_email.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
			txt_email.LeadingIcon = null;
			txt_email.Location = new Point(155, 306);
			txt_email.MaxLength = 50;
			txt_email.MouseState = MaterialSkin.MouseState.OUT;
			txt_email.Multiline = false;
			txt_email.Name = "txt_email";
			txt_email.Size = new Size(294, 50);
			txt_email.TabIndex = 1;
			txt_email.Text = "";
			txt_email.TrailingIcon = null;
			// 
			// txt_sdt
			// 
			txt_sdt.AnimateReadOnly = false;
			txt_sdt.BorderStyle = BorderStyle.None;
			txt_sdt.Depth = 0;
			txt_sdt.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
			txt_sdt.LeadingIcon = null;
			txt_sdt.Location = new Point(155, 231);
			txt_sdt.MaxLength = 50;
			txt_sdt.MouseState = MaterialSkin.MouseState.OUT;
			txt_sdt.Multiline = false;
			txt_sdt.Name = "txt_sdt";
			txt_sdt.Size = new Size(294, 50);
			txt_sdt.TabIndex = 2;
			txt_sdt.Text = "";
			txt_sdt.TrailingIcon = null;
			// 
			// txt_hoten
			// 
			txt_hoten.AnimateReadOnly = false;
			txt_hoten.BorderStyle = BorderStyle.None;
			txt_hoten.Depth = 0;
			txt_hoten.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
			txt_hoten.LeadingIcon = null;
			txt_hoten.Location = new Point(155, 157);
			txt_hoten.MaxLength = 50;
			txt_hoten.MouseState = MaterialSkin.MouseState.OUT;
			txt_hoten.Multiline = false;
			txt_hoten.Name = "txt_hoten";
			txt_hoten.Size = new Size(294, 50);
			txt_hoten.TabIndex = 3;
			txt_hoten.Text = "";
			txt_hoten.TrailingIcon = null;
			// 
			// txt_diachi
			// 
			txt_diachi.AnimateReadOnly = false;
			txt_diachi.BorderStyle = BorderStyle.None;
			txt_diachi.Depth = 0;
			txt_diachi.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
			txt_diachi.LeadingIcon = null;
			txt_diachi.Location = new Point(155, 383);
			txt_diachi.MaxLength = 50;
			txt_diachi.MouseState = MaterialSkin.MouseState.OUT;
			txt_diachi.Multiline = false;
			txt_diachi.Name = "txt_diachi";
			txt_diachi.Size = new Size(294, 50);
			txt_diachi.TabIndex = 4;
			txt_diachi.Text = "";
			txt_diachi.TrailingIcon = null;
			// 
			// materialLabel1
			// 
			materialLabel1.AutoSize = true;
			materialLabel1.Depth = 0;
			materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
			materialLabel1.Location = new Point(42, 175);
			materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
			materialLabel1.Name = "materialLabel1";
			materialLabel1.Size = new Size(68, 19);
			materialLabel1.TabIndex = 5;
			materialLabel1.Text = "Họ và tên";
			// 
			// materialLabel2
			// 
			materialLabel2.AutoSize = true;
			materialLabel2.Depth = 0;
			materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
			materialLabel2.Location = new Point(42, 250);
			materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
			materialLabel2.Name = "materialLabel2";
			materialLabel2.Size = new Size(95, 19);
			materialLabel2.TabIndex = 6;
			materialLabel2.Text = "Số điện thoại";
			// 
			// materialLabel3
			// 
			materialLabel3.AutoSize = true;
			materialLabel3.Depth = 0;
			materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
			materialLabel3.Location = new Point(42, 322);
			materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
			materialLabel3.Name = "materialLabel3";
			materialLabel3.Size = new Size(41, 19);
			materialLabel3.TabIndex = 7;
			materialLabel3.Text = "Email";
			// 
			// materialLabel4
			// 
			materialLabel4.AutoSize = true;
			materialLabel4.Depth = 0;
			materialLabel4.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
			materialLabel4.Location = new Point(42, 402);
			materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
			materialLabel4.Name = "materialLabel4";
			materialLabel4.Size = new Size(50, 19);
			materialLabel4.TabIndex = 8;
			materialLabel4.Text = "Địa chỉ";
			// 
			// btn_cancel
			// 
			btn_cancel.IconChar = FontAwesome.Sharp.IconChar.None;
			btn_cancel.IconColor = Color.Black;
			btn_cancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
			btn_cancel.Location = new Point(69, 469);
			btn_cancel.Name = "btn_cancel";
			btn_cancel.Size = new Size(134, 63);
			btn_cancel.TabIndex = 9;
			btn_cancel.Text = "Hủy";
			btn_cancel.UseVisualStyleBackColor = true;
			btn_cancel.Click += btn_cancel_Click;
			// 
			// FormAddKH
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(507, 556);
			Controls.Add(btn_cancel);
			Controls.Add(materialLabel4);
			Controls.Add(materialLabel3);
			Controls.Add(materialLabel2);
			Controls.Add(materialLabel1);
			Controls.Add(txt_diachi);
			Controls.Add(txt_hoten);
			Controls.Add(txt_sdt);
			Controls.Add(txt_email);
			Controls.Add(btn_add);
			Name = "FormAddKH";
			Text = "FormAddKH";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private FontAwesome.Sharp.IconButton btn_add;
		private MaterialSkin.Controls.MaterialTextBox txt_email;
		private MaterialSkin.Controls.MaterialTextBox txt_sdt;
		private MaterialSkin.Controls.MaterialTextBox txt_hoten;
		private MaterialSkin.Controls.MaterialTextBox txt_diachi;
		private MaterialSkin.Controls.MaterialLabel materialLabel1;
		private MaterialSkin.Controls.MaterialLabel materialLabel2;
		private MaterialSkin.Controls.MaterialLabel materialLabel3;
		private MaterialSkin.Controls.MaterialLabel materialLabel4;
		private FontAwesome.Sharp.IconButton btn_cancel;
	}
}