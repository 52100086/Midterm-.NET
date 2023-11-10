using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class MauXe
    {
        public int MauXeId { get; set; }
        public string TenMauXe { get; set; }
        public ICollection<XeOto> XeOtos { get; set; }
    }
}
