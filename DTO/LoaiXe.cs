using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoaiXe
    {
        public int LoaiXeId { get; set; }
        public string TenLoaiXe { get; set; }
        public ICollection<XeOto> XeOtos { get; set; }
    }

}
