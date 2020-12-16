using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TEST_GK.Entities
{
    public class MonHoc
    {
        public int MaMon { get; set; }
        public string TenMon { get; set; }
        public string SoTinChi { get; set; }
        public ICollection<LopHocPhan> LopHocPhans { get; set; }
    }
}
