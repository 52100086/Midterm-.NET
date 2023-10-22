using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DonDatXe_TinhNang
    {
        public int DonDatXeId { get; set; }
        public int TinhNangId { get; set; }

        public virtual DonDatXe DonDatXe { get; set; }
        public virtual TinhNangXe TinhNangXe { get; set; }
    }

}
