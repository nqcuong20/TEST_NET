using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TEST_GK.Entities
{
    public class KetQua
    {
        public int MaSV { get; set; }
        public SinhVien SV { get; set; }
        public int LopHocPhan { get; set; }
        public LopHocPhan LHP { get; set; }
    }
}
