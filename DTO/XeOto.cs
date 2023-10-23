using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class XeOto
    {
        public int XeOtoId { get; set; }
        public string HangXe { get; set; }
        public string Model { get; set; }
        public string TrangThai { get; set; }
        public decimal GiaThue { get; set; }
        public string NhienLieu { get; set; }
        public int LoaiXeId { get; set; }

        // Navigation Property
        public virtual LoaiXe LoaiXe { get; set; } 

        public ICollection<DonDatXe> DonDatXes { get; set; }
    }

}
