namespace CarRental
{
    partial class FormLogin
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
            txt_Username = new MaterialSkin.Controls.MaterialTextBox();
            txt_Password = new MaterialSkin.Controls.MaterialTextBox();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            btn_Login = new FontAwesome.Sharp.IconButton();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txt_Username
            // 
            txt_Username.AnimateReadOnly = false;
            txt_Username.BackColor = Color.Silver;
            txt_Username.BorderStyle = BorderStyle.None;
            txt_Username.Depth = 0;
            txt_Username.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txt_Username.LeadingIcon = null;
            txt_Username.Location = new Point(279, 179);
            txt_Username.MaxLength = 50;
            txt_Username.MouseState = MaterialSkin.MouseState.OUT;
            txt_Username.Multiline = false;
            txt_Username.Name = "txt_Username";
            txt_Username.Size = new Size(290, 50);
            txt_Username.TabIndex = 0;
            txt_Username.Text = "";
            txt_Username.TrailingIcon = null;
            // 
            // txt_Password
            // 
            txt_Password.AnimateReadOnly = false;
            txt_Password.BackColor = Color.WhiteSmoke;
            txt_Password.BorderStyle = BorderStyle.None;
            txt_Password.Depth = 0;
            txt_Password.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txt_Password.LeadingIcon = null;
            txt_Password.Location = new Point(279, 275);
            txt_Password.MaxLength = 50;
            txt_Password.MouseState = MaterialSkin.MouseState.OUT;
            txt_Password.Multiline = false;
            txt_Password.Name = "txt_Password";
            txt_Password.Size = new Size(290, 50);
            txt_Password.TabIndex = 1;
            txt_Password.Text = "";
            txt_Password.TrailingIcon = null;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.BackColor = SystemColors.Highlight;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(373, 119);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(79, 19);
            materialLabel1.TabIndex = 2;
            materialLabel1.Text = "Đăng nhập";
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(279, 157);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(109, 19);
            materialLabel2.TabIndex = 3;
            materialLabel2.Text = "Tên đăng nhập";
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.Location = new Point(279, 253);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(68, 19);
            materialLabel3.TabIndex = 4;
            materialLabel3.Text = "Mật khẩu";
            // 
            // btn_Login
            // 
            btn_Login.BackColor = Color.Orange;
            btn_Login.FlatAppearance.BorderSize = 0;
            btn_Login.FlatStyle = FlatStyle.Flat;
            btn_Login.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            btn_Login.IconColor = Color.Blue;
            btn_Login.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btn_Login.IconSize = 25;
            btn_Login.Location = new Point(358, 355);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(126, 53);
            btn_Login.TabIndex = 5;
            btn_Login.Text = "Đăng nhập";
            btn_Login.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_Login.UseVisualStyleBackColor = false;
            btn_Login.Click += btn_Login_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = Properties.Resources.grey_mercedes_amg_car_wallpaper;
            pictureBox1.Location = new Point(3, 64);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(223, 383);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DeepSkyBlue;
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 64);
            panel1.Name = "panel1";
            panel1.Size = new Size(622, 383);
            panel1.TabIndex = 7;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(628, 450);
            Controls.Add(pictureBox1);
            Controls.Add(btn_Login);
            Controls.Add(materialLabel3);
            Controls.Add(materialLabel2);
            Controls.Add(materialLabel1);
            Controls.Add(txt_Password);
            Controls.Add(txt_Username);
            Controls.Add(panel1);
            Name = "FormLogin";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox txt_Username;
        private MaterialSkin.Controls.MaterialTextBox txt_Password;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private FontAwesome.Sharp.IconButton btn_Login;
        private PictureBox pictureBox1;
        private Panel panel1;
    }
}