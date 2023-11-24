namespace CarRental.Admin
{
    partial class FormAddNV
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
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            txt_sdt = new MaterialSkin.Controls.MaterialTextBox();
            btn_add = new FontAwesome.Sharp.IconButton();
            dtp_bd = new DateTimePicker();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            SuspendLayout();
            // 
            // btn_cancel
            // 
            btn_cancel.BackColor = SystemColors.Highlight;
            btn_cancel.IconChar = FontAwesome.Sharp.IconChar.None;
            btn_cancel.IconColor = Color.Black;
            btn_cancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_cancel.Location = new Point(57, 344);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(134, 63);
            btn_cancel.TabIndex = 29;
            btn_cancel.Text = "Hủy";
            btn_cancel.UseVisualStyleBackColor = false;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(57, 102);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(95, 19);
            materialLabel2.TabIndex = 26;
            materialLabel2.Text = "Số điện thoại";
            // 
            // txt_sdt
            // 
            txt_sdt.AnimateReadOnly = false;
            txt_sdt.BorderStyle = BorderStyle.None;
            txt_sdt.Depth = 0;
            txt_sdt.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txt_sdt.LeadingIcon = null;
            txt_sdt.Location = new Point(170, 99);
            txt_sdt.MaxLength = 50;
            txt_sdt.MouseState = MaterialSkin.MouseState.OUT;
            txt_sdt.Multiline = false;
            txt_sdt.Name = "txt_sdt";
            txt_sdt.Size = new Size(294, 50);
            txt_sdt.TabIndex = 22;
            txt_sdt.Text = "";
            txt_sdt.TrailingIcon = null;
            // 
            // btn_add
            // 
            btn_add.BackColor = SystemColors.Highlight;
            btn_add.IconChar = FontAwesome.Sharp.IconChar.None;
            btn_add.IconColor = Color.Black;
            btn_add.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_add.Location = new Point(330, 344);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(134, 63);
            btn_add.TabIndex = 20;
            btn_add.Text = "Thêm";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // dtp_bd
            // 
            dtp_bd.Location = new Point(170, 203);
            dtp_bd.Name = "dtp_bd";
            dtp_bd.Size = new Size(294, 27);
            dtp_bd.TabIndex = 30;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(57, 203);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(72, 19);
            materialLabel1.TabIndex = 31;
            materialLabel1.Text = "Ngày sinh";
            // 
            // FormAddNV
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(517, 450);
            Controls.Add(materialLabel1);
            Controls.Add(dtp_bd);
            Controls.Add(btn_cancel);
            Controls.Add(materialLabel2);
            Controls.Add(txt_sdt);
            Controls.Add(btn_add);
            Name = "FormAddNV";
            Text = "Thêm nhân viên";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton btn_cancel;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox txt_sdt;
        private FontAwesome.Sharp.IconButton btn_add;
        private DateTimePicker dtp_bd;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}