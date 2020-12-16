using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TEST_GK.Entities
{
    public class LopHocPhan
    {
        public int MaLopHocPhan { get; set; }
        public int NamHoc { get; set; }
        public int HocKy { get; set; }
        public int MonHoc { get; set; }
        public MonHoc Mon { get; set; }
        public ICollection<KetQua> KetQuas { get; set; }
    }
}
