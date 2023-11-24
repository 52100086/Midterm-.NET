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
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            lbl_warning_password = new Label();
            lb_warning_username = new Label();
            btn_Login = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
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
            txt_Username.Location = new Point(276, 115);
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
            txt_Password.Location = new Point(276, 222);
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
            materialLabel1.Location = new Point(372, 36);
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
            materialLabel2.Location = new Point(276, 83);
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
            materialLabel3.Location = new Point(276, 200);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(68, 19);
            materialLabel3.TabIndex = 4;
            materialLabel3.Text = "Mật khẩu";
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
            panel1.BackColor = Color.Azure;
            panel1.Controls.Add(lbl_warning_password);
            panel1.Controls.Add(lb_warning_username);
            panel1.Controls.Add(materialLabel1);
            panel1.Controls.Add(materialLabel2);
            panel1.Controls.Add(txt_Username);
            panel1.Controls.Add(materialLabel3);
            panel1.Controls.Add(btn_Login);
            panel1.Controls.Add(txt_Password);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 64);
            panel1.Name = "panel1";
            panel1.Size = new Size(622, 383);
            panel1.TabIndex = 7;
            // 
            // lbl_warning_password
            // 
            lbl_warning_password.AutoSize = true;
            lbl_warning_password.ForeColor = Color.Red;
            lbl_warning_password.Location = new Point(276, 275);
            lbl_warning_password.Name = "lbl_warning_password";
            lbl_warning_password.Size = new Size(214, 20);
            lbl_warning_password.TabIndex = 5;
            lbl_warning_password.Text = "Mật khẩu không được để trống";
            // 
            // lb_warning_username
            // 
            lb_warning_username.AutoSize = true;
            lb_warning_username.ForeColor = Color.Red;
            lb_warning_username.Location = new Point(276, 168);
            lb_warning_username.Name = "lb_warning_username";
            lb_warning_username.Size = new Size(251, 20);
            lb_warning_username.TabIndex = 1;
            lb_warning_username.Text = "Tên đăng nhập không được để trống";
            // 
            // btn_Login
            // 
            btn_Login.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_Login.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btn_Login.Depth = 0;
            btn_Login.HighEmphasis = true;
            btn_Login.Icon = null;
            btn_Login.Location = new Point(361, 316);
            btn_Login.Margin = new Padding(4, 6, 4, 6);
            btn_Login.MouseState = MaterialSkin.MouseState.HOVER;
            btn_Login.Name = "btn_Login";
            btn_Login.NoAccentTextColor = Color.Empty;
            btn_Login.Size = new Size(105, 36);
            btn_Login.TabIndex = 0;
            btn_Login.Text = "Đăng nhập";
            btn_Login.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btn_Login.UseAccentColor = false;
            btn_Login.UseVisualStyleBackColor = true;
            btn_Login.Click += btn_Login_Click_1;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(628, 450);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Name = "FormLogin";
            Load += FormLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox txt_Username;
        private MaterialSkin.Controls.MaterialTextBox txt_Password;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private PictureBox pictureBox1;
        private Panel panel1;
        private MaterialSkin.Controls.MaterialButton btn_Login;
        private Label lbl_warning_password;
        private Label lb_warning_username;
    }
}