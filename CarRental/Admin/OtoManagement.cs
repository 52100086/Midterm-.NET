using BUS;
using ClosedXML.Excel;
using DTO;
using MaterialSkin;
using MaterialSkin.Controls;
using OfficeOpenXml;
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
    public partial class OtoManagement : Form
    {

        private readonly BUS_XeOto _busXeOto = new BUS_XeOto();
        private BindingSource source = new BindingSource();

        public OtoManagement()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Form addOto = new FormAddOto(this, _busXeOto);
            addOto.ShowDialog();
        }

        private async void OtoManagement_Load(object sender, EventArgs e)
        {


            dgv_car.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            await BindDataToDataGridView();

            foreach (DataGridViewColumn column in dgv_car.Columns)
            {
                if (column.Name == "XeOtoId")
                {
                    column.HeaderText = "ID";
                }
                else if (column.Name == "TrangThai")
                {
                    column.HeaderText = "Trạng thái";
                }
                else if (column.Name == "GiaThue")
                {
                    column.HeaderText = "Giá thuê";
                }
                else if (column.Name == "TenLoaiXe")
                {
                    column.HeaderText = "Loại xe";
                }
                else if (column.Name == "TenHangXe")
                {
                    column.HeaderText = "Hãng xe";
                }
                else if (column.Name == "TenMauXe")
                {
                    column.HeaderText = "Mẫu xe";
                }

            }
        }



        public async Task BindDataToDataGridView()
        {
            var xeOtos = await _busXeOto.GetAllXeOtosAsync();
            if (xeOtos != null && xeOtos.Count > 0)
            {
                var data = xeOtos.Select(x => new
                {
                    x.XeOtoId,
                    x.TrangThai,
                    x.GiaThue,
                    x.LoaiXe.TenLoaiXe,
                    x.HangXe.TenHangXe,
                    x.MauXe.TenMauXe
                }).ToList();
                source.DataSource = data;
                dgv_car.DataSource = source;
            }
            else
            {
                dgv_car.DataSource = null;
            }
        }


        private async void btn_delete_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có một hàng được chọn trong DataGridView hay không
            if (dgv_car.SelectedRows.Count > 0)
            {
                // Lấy hàng được chọn
                DataGridViewRow selectedRow = dgv_car.SelectedRows[0];

                // Lấy giá trị của cột XeOtoId trong hàng được chọn
                int xeOtoId = Convert.ToInt32(selectedRow.Cells["XeOtoId"].Value);

                // Gọi phương thức xóa xe ô tô
                _busXeOto.DeleteXeOto(xeOtoId);

                MessageBox.Show("Xóa xe ô tô thành công");

                await BindDataToDataGridView();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một xe ô tô để xóa");
            }
        }

        private async void btn_update_Click(object sender, EventArgs e)
        {
            if (dgv_car.SelectedRows.Count > 0)
            {
                // Lấy hàng được chọn
                DataGridViewRow selectedRow = dgv_car.SelectedRows[0];

                // Lấy giá trị của cột XeOtoId trong hàng được chọn
                int xeOtoId = Convert.ToInt32(selectedRow.Cells["XeOtoId"].Value);
                FormUpdateOto formUpdateOto = new FormUpdateOto(this, xeOtoId);
                formUpdateOto.ShowDialog();

                // Refresh DataGridView để cập nhật danh sách sau khi xóa
                await BindDataToDataGridView();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một xe ô tô để cap nhat");
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string keyword = txt_search.Text;
            var xeOtos = _busXeOto.SearchByHangXeOrMauXe(keyword);
            if (xeOtos != null && xeOtos.Count > 0)
            {
                dgv_car.DataSource = xeOtos;
                var data = xeOtos.Select(x => new
                {
                    x.XeOtoId,
                    x.TrangThai,
                    x.GiaThue,
                    x.LoaiXe.TenLoaiXe,
                    x.HangXe.TenHangXe,
                    x.MauXe.TenMauXe
                }).ToList();
                dgv_car.DataSource = data;
                dgv_car.Refresh();
            }
            else
            {
                MessageBox.Show("No data to display");
            }
        }
        private void ExportToExcel(DataGridView dataGridView)
        {
            // Lấy đường dẫn thư mục gốc của dự án
            string projectDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;

            // Tạo một workbook mới
            using (var workbook = new XLWorkbook())
            {
                // Tạo một worksheet trong workbook
                var worksheet = workbook.Worksheets.Add("Danh sách Khách hàng");

                // Ghi dữ liệu vào worksheet
                worksheet.Cell("A1").Value = "ID";
                worksheet.Cell("B1").Value = "Trạng thái xe";
                worksheet.Cell("C1").Value = "Giá thuê";
                worksheet.Cell("D1").Value = "Loại xe";
                worksheet.Cell("E1").Value = "Hãng xe";
                worksheet.Cell("F1").Value = "Mẫu xe";


                // Ghi dữ liệu từ DataGridView vào worksheet
                for (int row = 0; row < dataGridView.Rows.Count; row++)
                {
                    for (int col = 0; col < dataGridView.Columns.Count; col++)
                    {
                        // Ghi dữ liệu từ cell của DataGridView vào cell tương ứng của worksheet
                        worksheet.Cell(row + 2, col + 1).Value = dataGridView.Rows[row].Cells[col].Value?.ToString();
                    }
                }

                // Chỉnh đường dẫn và tên file Excel trong thư mục của dự án
                string fileName = $"Export_DanhsachOto_{DateTime.Now.ToString("yyyyMMdd_HHmmss")}.xlsx";
                string filePath = Path.Combine(projectDirectory, fileName);

                // Lưu workbook vào file Excel
                workbook.SaveAs(filePath);
            }
        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            ExportToExcel(dgv_car);
        }


        public async Task<List<XeOto>> ReadDataFromExcel(string filePath)
        {
            var xeOtos = new List<XeOto>();
            using (var package = new ExcelPackage(new FileInfo(filePath)))
            {
                ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
                var worksheet = package.Workbook.Worksheets[0]; 
                for (int row = 2; row <= worksheet.Dimension.End.Row; row++)
                {
                    var typeId = await _busXeOto.GetTypeIdByNameAsync(worksheet.Cells[row, 3].Value.ToString());
                    var brandId = await _busXeOto.GetBrandIdByNameAsync(worksheet.Cells[row, 4].Value.ToString());
                    var modelId = await _busXeOto.GetModelIdByNameAsync(worksheet.Cells[row, 5].Value.ToString());

                    var typeName = worksheet.Cells[row, 3].Value.ToString();
                    var brandName = worksheet.Cells[row, 4].Value.ToString();
                    var modelName = worksheet.Cells[row, 5].Value.ToString();



                    if (typeId == null || brandId == null || modelId == null || typeName == null || brandName == null || modelName == null)
                    {
                        continue;
                    }

                    LoaiXe lx = new LoaiXe { LoaiXeId = (int) typeId, TenLoaiXe = typeName };
                    HangXe hx = new HangXe { HangXeId = (int) brandId, TenHangXe = brandName };
                    MauXe mx = new MauXe { MauXeId = (int) modelId, TenMauXe = modelName };

                    var xeOto = new XeOto
                    {
                        TrangThai = worksheet.Cells[row, 1].Value.ToString(),
                        GiaThue = Convert.ToInt32(worksheet.Cells[row, 2].Value),
                        LoaiXeId = typeId.Value,
                        HangXeId = brandId.Value,
                        MauXeId = modelId.Value,
                        LoaiXe = lx,
                        HangXe = hx,
                        MauXe = mx
                    };
                    xeOtos.Add(xeOto);
                }
            }
            return xeOtos;
        }


        public async Task InsertDataToDatabase(List<XeOto> xeOtos)
        {
            foreach (var xeOto in xeOtos)
            {
                if (xeOto.LoaiXe == null)
                {
                    xeOto.LoaiXe = new LoaiXe();
                    
                }
                if (xeOto.HangXe == null)
                {
                    xeOto.HangXe = new HangXe();
                }

                if (xeOto.MauXe == null)
                {
                    xeOto.MauXe = new MauXe();
                }

                var typeId = await _busXeOto.GetTypeIdByNameAsync(xeOto.LoaiXe.TenLoaiXe);
                var brandId = await _busXeOto.GetBrandIdByNameAsync(xeOto.HangXe.TenHangXe);
                var modelId = await _busXeOto.GetModelIdByNameAsync(xeOto.MauXe.TenMauXe);

                if (typeId == null || brandId == null || modelId == null)
                {
                    continue;
                }

                var newXeOto = new XeOto
                {
                    TrangThai = xeOto.TrangThai,
                    GiaThue = xeOto.GiaThue,
                    LoaiXeId = typeId.Value,
                    HangXeId = brandId.Value,
                    MauXeId = modelId.Value
                };

                await _busXeOto.CreateXeOtoAsync(newXeOto);

            }

        }

        private async void import_excel_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var filePath = openFileDialog.FileName;
                    List<XeOto> xeOtos = await ReadDataFromExcel(filePath);
                    await InsertDataToDatabase(xeOtos);
                    await BindDataToDataGridView();

                }
            }


        }
    }
}
