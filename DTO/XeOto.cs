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
        public string TrangThai { get; set; }
        public double GiaThue { get; set; }
        public int LoaiXeId { get; set; }
        public int HangXeId { get; set; }
        public int MauXeId { get; set; }

        // Navigation Property
        public virtual LoaiXe LoaiXe { get; set; } 
        public virtual HangXe HangXe { get; set; }
        public virtual MauXe MauXe { get; set; }
        public ICollection<DonDatXe> DonDatXes { get; set; }
    }

}
