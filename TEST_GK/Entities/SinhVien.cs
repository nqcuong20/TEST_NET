using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TEST_GK.Entities
{
    public class SinhVien
    {
        public int MaSinhVien { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public int DienThoai { get; set; }
        public int MaKhoa { get; set; }
        public Khoa Khoa { get; set; }
        public ICollection<KetQua> KetQuas {get;set; }
    }
}
