using BUS;
using DTO;
using MaterialSkin.Controls;
using ScottPlot;
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
    public partial class FormChart : MaterialForm
    {

        private readonly BUS_DonDatXe _busDonDatXe = new BUS_DonDatXe();

        public FormChart()
        {
            InitializeComponent();
        }

        private async void FormChart_Load(object sender, EventArgs e)
        {
            var rentals = await _busDonDatXe.GetAllDonDatXe();
            var rentals_paid = rentals.Where(x => x.TrangThai == "Đã thanh toán");
            var groupedRentals = rentals_paid.GroupBy(d => new { d.XeOto.HangXe, d.XeOto.MauXe, d.NgayThanhToan });

            // Prepare the data for the chart
            var brandModelTime = new List<string>();
            var revenues = new List<double>();
            var dates = new List<DateTime>();

            foreach (var group in groupedRentals)
            {
                brandModelTime.Add($"{group.Key.HangXe} {group.Key.MauXe} {group.Key.NgayThanhToan}");
                revenues.Add(group.Sum(r => r.TongCong));
                dates.Add(group.Key.NgayThanhToan);
            }

            double[] revenuesArray = revenues.ToArray(); //
            double[] datesArray = dates.Select(d => d.ToOADate()).ToArray(); 

            // Plot the data
            plt_1.Plot.AddScatter(datesArray, revenuesArray);
            
            plt_1.Refresh();
        }



    }
}
    