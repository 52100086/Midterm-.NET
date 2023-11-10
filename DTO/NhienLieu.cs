using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhienLieu
    {
        public int NhienLieuId { get; set; }
        public string NhienLieuName { get; set; }

        public ICollection<DonDatXe> DonDatXes { get; set; }

    }
}
