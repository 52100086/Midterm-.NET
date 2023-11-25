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
            double[] datesArray = dates.Select(d => double.Parse(d.ToString("dd"))).ToArray();

            // Plot the data
            plt_1.Plot.AddScatter(datesArray, revenuesArray);
            plt_1.Plot.XLabel("Ngày");
            plt_1.Plot.YLabel("Doanh thu");
            plt_1.Plot.Title("Doanh thu theo ngày");
            plt_1.Plot.XTicks(datesArray);

            plt_1.Refresh();
            var groupType = rentals_paid.GroupBy(d => new { d.XeOto.LoaiXe, d.NgayThanhToan });
            var bar = new List<string>();
            var revenues_loaixe = new List<double>();
            var loaixe = new List<string>();

            foreach (var group in groupType)
            {
                bar.Add($"{group.Key.LoaiXe} {group.Key.NgayThanhToan}");
                revenues_loaixe.Add(group.Sum(r => r.TongCong));
                loaixe.Add(group.Key.LoaiXe.TenLoaiXe);
            }

            string[] barArr = bar.ToArray();
            double[] revenuesArr = revenues_loaixe.ToArray();
            string[] loaixeArr = loaixe.ToArray();
            Color[] colors = new Color[revenuesArr.Length];
            for (int i = 0; i < colors.Length; i++)
            {
                colors[i] = Color.Blue;  // Màu xanh
            }

            var barPlot = plt_2.Plot.AddBar(revenuesArr, colors[0]); // Thêm tất cả các cột vào biểu đồ
            plt_2.Plot.XTicks(loaixeArr);
            plt_2.Plot.XLabel("Loại xe");
            plt_2.Plot.YLabel("Doanh thu");
            plt_2.Plot.Title("Doanh thu theo loại xe");
            plt_2.Refresh();

        }



    }
}
