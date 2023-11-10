using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HangXe
    {
        public int HangXeId {  get; set; }
        public string TenHangXe { get; set; }
        public ICollection<XeOto> XeOtos { get; set; }

    }
}
