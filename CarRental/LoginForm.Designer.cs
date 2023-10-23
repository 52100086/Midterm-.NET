namespace CarRental
{
    partial class LoginForm
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
            metroPanel1 = new MetroFramework.Controls.MetroPanel();
            metroPanel2 = new MetroFramework.Controls.MetroPanel();
            btn_Login = new FontAwesome.Sharp.IconButton();
            txt_username = new MetroFramework.Controls.MetroTextBox();
            txt_password = new MetroFramework.Controls.MetroTextBox();
            metroLabel1 = new MetroFramework.Controls.MetroLabel();
            metroLabel2 = new MetroFramework.Controls.MetroLabel();
            metroPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // metroPanel1
            // 
            metroPanel1.CustomBackground = false;
            metroPanel1.Dock = DockStyle.Left;
            metroPanel1.HorizontalScrollbar = false;
            metroPanel1.HorizontalScrollbarBarColor = true;
            metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            metroPanel1.HorizontalScrollbarSize = 10;
            metroPanel1.Location = new Point(0, 0);
            metroPanel1.Name = "metroPanel1";
            metroPanel1.Size = new Size(250, 450);
            metroPanel1.Style = MetroFramework.MetroColorStyle.Blue;
            metroPanel1.StyleManager = null;
            metroPanel1.TabIndex = 0;
            metroPanel1.Theme = MetroFramework.MetroThemeStyle.Light;
            metroPanel1.VerticalScrollbar = false;
            metroPanel1.VerticalScrollbarBarColor = true;
            metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroPanel2
            // 
            metroPanel2.Controls.Add(metroLabel2);
            metroPanel2.Controls.Add(metroLabel1);
            metroPanel2.Controls.Add(txt_password);
            metroPanel2.Controls.Add(txt_username);
            metroPanel2.Controls.Add(btn_Login);
            metroPanel2.CustomBackground = false;
            metroPanel2.Dock = DockStyle.Fill;
            metroPanel2.HorizontalScrollbar = false;
            metroPanel2.HorizontalScrollbarBarColor = true;
            metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            metroPanel2.HorizontalScrollbarSize = 10;
            metroPanel2.Location = new Point(250, 0);
            metroPanel2.Name = "metroPanel2";
            metroPanel2.Size = new Size(550, 450);
            metroPanel2.Style = MetroFramework.MetroColorStyle.Blue;
            metroPanel2.StyleManager = null;
            metroPanel2.TabIndex = 1;
            metroPanel2.Theme = MetroFramework.MetroThemeStyle.Light;
            metroPanel2.VerticalScrollbar = false;
            metroPanel2.VerticalScrollbarBarColor = true;
            metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            metroPanel2.VerticalScrollbarSize = 10;
            // 
            // btn_Login
            // 
            btn_Login.IconChar = FontAwesome.Sharp.IconChar.None;
            btn_Login.IconColor = Color.Black;
            btn_Login.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_Login.Location = new Point(178, 285);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(94, 29);
            btn_Login.TabIndex = 2;
            btn_Login.Text = "Đăng nhập";
            btn_Login.UseVisualStyleBackColor = true;
            // 
            // txt_username
            // 
            txt_username.FontSize = MetroFramework.MetroTextBoxSize.Small;
            txt_username.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            txt_username.Location = new Point(178, 122);
            txt_username.Multiline = false;
            txt_username.Name = "txt_username";
            txt_username.SelectedText = "";
            txt_username.Size = new Size(180, 29);
            txt_username.Style = MetroFramework.MetroColorStyle.Blue;
            txt_username.StyleManager = null;
            txt_username.TabIndex = 3;
            txt_username.Text = "metroTextBox1";
            txt_username.Theme = MetroFramework.MetroThemeStyle.Light;
            txt_username.UseStyleColors = false;
            // 
            // txt_password
            // 
            txt_password.FontSize = MetroFramework.MetroTextBoxSize.Small;
            txt_password.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            txt_password.Location = new Point(178, 212);
            txt_password.Multiline = false;
            txt_password.Name = "txt_password";
            txt_password.SelectedText = "";
            txt_password.Size = new Size(180, 29);
            txt_password.Style = MetroFramework.MetroColorStyle.Blue;
            txt_password.StyleManager = null;
            txt_password.TabIndex = 4;
            txt_password.Text = "metroTextBox2";
            txt_password.Theme = MetroFramework.MetroThemeStyle.Light;
            txt_password.UseStyleColors = false;
            // 
            // metroLabel1
            // 
            metroLabel1.AutoSize = true;
            metroLabel1.CustomBackground = false;
            metroLabel1.FontSize = MetroFramework.MetroLabelSize.Medium;
            metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Light;
            metroLabel1.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            metroLabel1.Location = new Point(85, 131);
            metroLabel1.Name = "metroLabel1";
            metroLabel1.Size = new Size(67, 20);
            metroLabel1.Style = MetroFramework.MetroColorStyle.Blue;
            metroLabel1.StyleManager = null;
            metroLabel1.TabIndex = 5;
            metroLabel1.Text = "Tài khoản";
            metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
            metroLabel1.UseStyleColors = false;
            // 
            // metroLabel2
            // 
            metroLabel2.AutoSize = true;
            metroLabel2.CustomBackground = false;
            metroLabel2.FontSize = MetroFramework.MetroLabelSize.Medium;
            metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Light;
            metroLabel2.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            metroLabel2.Location = new Point(85, 212);
            metroLabel2.Name = "metroLabel2";
            metroLabel2.Size = new Size(66, 20);
            metroLabel2.Style = MetroFramework.MetroColorStyle.Blue;
            metroLabel2.StyleManager = null;
            metroLabel2.TabIndex = 6;
            metroLabel2.Text = "Mật khẩu";
            metroLabel2.Theme = MetroFramework.MetroThemeStyle.Light;
            metroLabel2.UseStyleColors = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(metroPanel2);
            Controls.Add(metroPanel1);
            Name = "LoginForm";
            Text = "LoginForm";
            metroPanel2.ResumeLayout(false);
            metroPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txt_password;
        private MetroFramework.Controls.MetroTextBox txt_username;
        private FontAwesome.Sharp.IconButton btn_Login;
    }
}