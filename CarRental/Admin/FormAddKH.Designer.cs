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
            btn_cancel = new FontAwesome.Sharp.IconButton();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            txt_diachi = new MaterialSkin.Controls.MaterialTextBox();
            txt_hoten = new MaterialSkin.Controls.MaterialTextBox();
            txt_sdt = new MaterialSkin.Controls.MaterialTextBox();
            txt_email = new MaterialSkin.Controls.MaterialTextBox();
            btn_add = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_cancel
            // 
            btn_cancel.BackColor = SystemColors.Highlight;
            btn_cancel.FlatStyle = FlatStyle.Flat;
            btn_cancel.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            btn_cancel.IconColor = Color.DeepSkyBlue;
            btn_cancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_cancel.IconSize = 32;
            btn_cancel.ImageAlign = ContentAlignment.MiddleLeft;
            btn_cancel.Location = new Point(75, 410);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(134, 46);
            btn_cancel.TabIndex = 19;
            btn_cancel.Text = "Hủy";
            btn_cancel.UseVisualStyleBackColor = false;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel4.Location = new Point(48, 334);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(50, 19);
            materialLabel4.TabIndex = 18;
            materialLabel4.Text = "Địa chỉ";
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.Location = new Point(48, 246);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(41, 19);
            materialLabel3.TabIndex = 17;
            materialLabel3.Text = "Email";
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(48, 168);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(95, 19);
            materialLabel2.TabIndex = 16;
            materialLabel2.Text = "Số điện thoại";
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(48, 80);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(68, 19);
            materialLabel1.TabIndex = 15;
            materialLabel1.Text = "Họ và tên";
            // 
            // txt_diachi
            // 
            txt_diachi.AnimateReadOnly = false;
            txt_diachi.BackColor = SystemColors.Highlight;
            txt_diachi.BorderStyle = BorderStyle.None;
            txt_diachi.Depth = 0;
            txt_diachi.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txt_diachi.LeadingIcon = null;
            txt_diachi.Location = new Point(161, 315);
            txt_diachi.MaxLength = 50;
            txt_diachi.MouseState = MaterialSkin.MouseState.OUT;
            txt_diachi.Multiline = false;
            txt_diachi.Name = "txt_diachi";
            txt_diachi.Size = new Size(294, 50);
            txt_diachi.TabIndex = 14;
            txt_diachi.Text = "";
            txt_diachi.TrailingIcon = null;
            // 
            // txt_hoten
            // 
            txt_hoten.AnimateReadOnly = false;
            txt_hoten.BackColor = SystemColors.Highlight;
            txt_hoten.BorderStyle = BorderStyle.None;
            txt_hoten.Depth = 0;
            txt_hoten.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txt_hoten.LeadingIcon = null;
            txt_hoten.Location = new Point(161, 64);
            txt_hoten.MaxLength = 50;
            txt_hoten.MouseState = MaterialSkin.MouseState.OUT;
            txt_hoten.Multiline = false;
            txt_hoten.Name = "txt_hoten";
            txt_hoten.Size = new Size(294, 50);
            txt_hoten.TabIndex = 13;
            txt_hoten.Text = "";
            txt_hoten.TrailingIcon = null;
            // 
            // txt_sdt
            // 
            txt_sdt.AnimateReadOnly = false;
            txt_sdt.BackColor = SystemColors.Highlight;
            txt_sdt.BorderStyle = BorderStyle.None;
            txt_sdt.Depth = 0;
            txt_sdt.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txt_sdt.LeadingIcon = null;
            txt_sdt.Location = new Point(161, 149);
            txt_sdt.MaxLength = 50;
            txt_sdt.MouseState = MaterialSkin.MouseState.OUT;
            txt_sdt.Multiline = false;
            txt_sdt.Name = "txt_sdt";
            txt_sdt.Size = new Size(294, 50);
            txt_sdt.TabIndex = 12;
            txt_sdt.Text = "";
            txt_sdt.TrailingIcon = null;
            // 
            // txt_email
            // 
            txt_email.AnimateReadOnly = false;
            txt_email.BackColor = SystemColors.Highlight;
            txt_email.BorderStyle = BorderStyle.None;
            txt_email.Depth = 0;
            txt_email.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txt_email.LeadingIcon = null;
            txt_email.Location = new Point(161, 230);
            txt_email.MaxLength = 50;
            txt_email.MouseState = MaterialSkin.MouseState.OUT;
            txt_email.Multiline = false;
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(294, 50);
            txt_email.TabIndex = 11;
            txt_email.Text = "";
            txt_email.TrailingIcon = null;
            // 
            // btn_add
            // 
            btn_add.BackColor = SystemColors.Highlight;
            btn_add.FlatStyle = FlatStyle.Flat;
            btn_add.IconChar = FontAwesome.Sharp.IconChar.Add;
            btn_add.IconColor = Color.DeepSkyBlue;
            btn_add.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_add.IconSize = 32;
            btn_add.ImageAlign = ContentAlignment.MiddleRight;
            btn_add.Location = new Point(289, 410);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(134, 46);
            btn_add.TabIndex = 10;
            btn_add.Text = "Thêm";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(materialLabel1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btn_cancel);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btn_add);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(materialLabel4);
            panel1.Controls.Add(txt_hoten);
            panel1.Controls.Add(materialLabel3);
            panel1.Controls.Add(txt_sdt);
            panel1.Controls.Add(materialLabel2);
            panel1.Controls.Add(txt_email);
            panel1.Controls.Add(txt_diachi);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 64);
            panel1.Name = "panel1";
            panel1.Size = new Size(501, 489);
            panel1.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Red;
            label4.Location = new Point(161, 368);
            label4.Name = "label4";
            label4.Size = new Size(199, 20);
            label4.TabIndex = 21;
            label4.Text = "Địa chỉ không được để trống";
            label4.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Red;
            label3.Location = new Point(161, 283);
            label3.Name = "label3";
            label3.Size = new Size(190, 20);
            label3.TabIndex = 20;
            label3.Text = "Email không được để trống";
            label3.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Red;
            label2.Location = new Point(161, 201);
            label2.Name = "label2";
            label2.Size = new Size(241, 20);
            label2.TabIndex = 19;
            label2.Text = "Số điện thoại không được để trống";
            label2.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Red;
            label1.Location = new Point(161, 117);
            label1.Name = "label1";
            label1.Size = new Size(176, 20);
            label1.TabIndex = 14;
            label1.Text = "Tên không được để trống";
            label1.Visible = false;
            // 
            // FormAddKH
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(507, 556);
            Controls.Add(panel1);
            ForeColor = SystemColors.ControlText;
            Name = "FormAddKH";
            Text = "Thêm khách hàng";
            Load += FormAddKH_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FontAwesome.Sharp.IconButton btn_cancel;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox txt_diachi;
        private MaterialSkin.Controls.MaterialTextBox txt_hoten;
        private MaterialSkin.Controls.MaterialTextBox txt_sdt;
        private MaterialSkin.Controls.MaterialTextBox txt_email;
        private FontAwesome.Sharp.IconButton btn_add;
        private Panel panel1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}