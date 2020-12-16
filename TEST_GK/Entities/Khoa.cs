using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TEST_GK.Entities
{
    
    public class Khoa
    {

        public int MaKhoa { get; set; }
        public string TenKhoa { get; set; }
        public ICollection<SinhVien> SinhViens { get; set; }
    }
}
