using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental.Admin
{
	public partial class FormCarType : Form
	{
		public FormCarType()
		{
			InitializeComponent();
		}

		private void xe4chomini_Click(object sender, EventArgs e)
		{
			int id = 1;
			FormAdminLayout formAdminLayout = this.ParentForm as FormAdminLayout;
			formAdminLayout.startFormCarTypeList(id);
		}

		private void xe4chosedan_Click(object sender, EventArgs e)
		{
			int id = 2;
			FormAdminLayout formAdminLayout = this.ParentForm as FormAdminLayout;
			formAdminLayout.startFormCarTypeList(id);
		}

		private void xe4chohatchback_Click(object sender, EventArgs e)
		{
			int id = 3;
			FormAdminLayout formAdminLayout = this.ParentForm as FormAdminLayout;
			formAdminLayout.startFormCarTypeList(id);
		}

		private void xe5chocuv_Click(object sender, EventArgs e)
		{
			int id = 4;
			FormAdminLayout formAdminLayout = this.ParentForm as FormAdminLayout;
			formAdminLayout.startFormCarTypeList(id);
		}

		private void xe5chosuv_Click(object sender, EventArgs e)
		{
			int id = 5;
			FormAdminLayout formAdminLayout = this.ParentForm as FormAdminLayout;
			formAdminLayout.startFormCarTypeList(id);
		}

		private void xe7chomvp_Click(object sender, EventArgs e)
		{
			int id = 6;
			FormAdminLayout formAdminLayout = this.ParentForm as FormAdminLayout;
			formAdminLayout.startFormCarTypeList(id);
		}

		private void pickupcar_Click(object sender, EventArgs e)
		{
			int id = 7;
			FormAdminLayout formAdminLayout = this.ParentForm as FormAdminLayout;
			formAdminLayout.startFormCarTypeList(id);
		}
	}
}
