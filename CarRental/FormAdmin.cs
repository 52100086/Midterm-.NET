using System;
using FontAwesome.Sharp;
using System.Data;
using System.ComponentModel;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace CarRental
{
    public partial class FormAdmin : Form
    {
        private IconButton current;
        private Panel leftBorder;
        private Form insideFormCurrent;
        public FormAdmin()
        {

            InitializeComponent();
            leftBorder = new Panel();
            leftBorder.Size = new Size(7, 74);
            panel_Nav.Controls.Add(leftBorder);

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;

            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void Activate_Btn(object senderBtn, Color c)
        {
            if (senderBtn != null)
            {
                Disable_Btn();
                current = (IconButton)senderBtn;
                current.BackColor = Color.FromArgb(255, 255, 0);
                current.ForeColor = c;
                current.TextAlign = ContentAlignment.MiddleCenter;
                current.IconColor = c;
                current.TextImageRelation = TextImageRelation.TextBeforeImage;
                current.ImageAlign = ContentAlignment.MiddleRight;
                // left border
                leftBorder.BackColor = c;
                leftBorder.Location = new Point(0, current.Location.Y);
                leftBorder.Visible = true;
                leftBorder.BringToFront();
                // Content
                img_Content.IconChar = current.IconChar;
                img_Content.IconColor = c;
                lbl_Content.Text = current.Text;

            }
        }
        private void Disable_Btn()
        {
            if (current != null)
            {
                current.BackColor = Color.FromArgb(255, 0, 255);
                current.ForeColor = Color.AliceBlue;
                current.TextAlign = ContentAlignment.MiddleLeft;
                current.IconColor = Color.AliceBlue;
                current.TextImageRelation = TextImageRelation.ImageBeforeText;
                current.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void btn_OtoManagement_Click(object sender, EventArgs e)
        {
            Activate_Btn(sender, Color.FromArgb(0, 255, 0));
            Open_Form_Inside(new Admin.AdminOtoManagement());
        }

        private void btn_Customer_Click(object sender, EventArgs e)
        {
            Activate_Btn(sender, Color.FromArgb(0, 255, 0));
            Open_Form_Inside(new Admin.AdminCustomerManagement());

        }

        private void btn_Orders_Click(object sender, EventArgs e)
        {
            Activate_Btn(sender, Color.FromArgb(0, 255, 0));
            Open_Form_Inside(new Admin.AdminOrdersManagement());


        }

        private void btn_Schedule_Click(object sender, EventArgs e)
        {
            Activate_Btn(sender, Color.FromArgb(0, 255, 0));
            Open_Form_Inside(new Admin.AdminScheduleManagement());

        }

        private void btn_Statistic_Report_Click(object sender, EventArgs e)
        {
            Activate_Btn(sender, Color.FromArgb(0, 255, 0));
            Open_Form_Inside(new Admin.AdminStatistics_Report());

        }

        private void btn_Employee_Click(object sender, EventArgs e)
        {
            Activate_Btn(sender, Color.FromArgb(0, 255, 0));
            Open_Form_Inside(new Admin.AdminEmployeeManagement());


        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void Reset()
        {
            Disable_Btn();
            leftBorder.Visible = false;

            img_Content.IconChar = IconChar.Home;
            img_Content.IconColor = Color.AliceBlue;
            lbl_Content.Text = "Trang chủ";
        }

        private void img_Logo_Click(object sender, EventArgs e)
        {
            insideFormCurrent.Close();
            Reset();
        }

        private void panel_Header_MouseDown(object sender, MouseEventArgs e)
        {

            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void Open_Form_Inside(Form insideForm)
        {
            if (img_Content != null)
            {
                insideFormCurrent.Close();
            }
            insideFormCurrent = insideForm;
            insideForm.TopLevel = false;
            insideForm.FormBorderStyle = FormBorderStyle.None;
            insideForm.Dock = DockStyle.Fill;
            panel_Main.Controls.Add(insideForm);
            panel_Main.Tag = insideForm;
            insideForm.BringToFront();
            insideForm.Show();
            lbl_Content.Text = insideForm.Text;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Maximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void FormAdmin_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                FormBorderStyle = FormBorderStyle.None;
            else
                FormBorderStyle = FormBorderStyle.Sizable;
        }
    }
}