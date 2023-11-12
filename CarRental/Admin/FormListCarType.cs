using BUS;
using DTO;
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
	public partial class FormListCarType : Form
	{
		private readonly BUS_XeOto _busXeOto;
		private int loaixeId;
		public FormListCarType(BUS_XeOto bus_XeOto, int loaixeId)
		{
			InitializeComponent();
			_busXeOto = bus_XeOto;
			this.loaixeId = loaixeId;
		}

		private void FormListCarType_Load(object sender, EventArgs e)
		{
			materialTextBox1.Text = loaixeId.ToString();
			var xeOtos = _busXeOto.GetXeOtosByType(loaixeId);
			if (xeOtos != null && xeOtos.Count > 0)
			{
				var data = xeOtos
					.Where(x => x.TrangThai == "Sẵn sàng")
					.Select(x => new
					{
						x.XeOtoId,
						TrangThai = "Sẵn sàng",
						x.GiaThue,
						x.LoaiXe.TenLoaiXe,
						x.HangXe.TenHangXe,
						x.MauXe.TenMauXe
					})
					.ToList();

				dgv_cartype.DataSource = data;
				dgv_cartype.Refresh();
			}
			else
			{
				MessageBox.Show("No data to display");
			}
			
		}
	}
}
