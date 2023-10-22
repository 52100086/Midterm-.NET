using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TinhNangXe
    {
        public int TinhNangId { get; set; }
        public string TenTinhNang { get; set; }

        public ICollection<DonDatXe_TinhNang> DonDatXe_TinhNangs { get; set; }
    }

}
