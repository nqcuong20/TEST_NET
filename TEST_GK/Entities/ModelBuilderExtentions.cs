using Microsoft.EntityFrameworkCore;
using System;
using TEST_GK.Entities;

namespace DE01_GK.Data.EF
{
    public static class DbInitializer
    {
        public static void SeedDataDefault(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Khoa>().HasData(
                new Khoa { MaKhoa = 1, TenKhoa = "CNTT" },
                new Khoa { MaKhoa = 2, TenKhoa = "SP Vật Lý" },
                new Khoa { MaKhoa = 3, TenKhoa = "SP Toán" },
                new Khoa { MaKhoa = 4, TenKhoa = "Việt Nan Học" },
                new Khoa { MaKhoa = 5, TenKhoa = "Mần Non" },
                new Khoa { MaKhoa = 6, TenKhoa = "Tiểu Học" },
                new Khoa { MaKhoa = 7, TenKhoa = "Ngôn Ngữ Hàn" },
                new Khoa { MaKhoa = 8, TenKhoa = "Ngôn Ngữ Trung" },
                new Khoa { MaKhoa = 9, TenKhoa = "SP Toán" },
                new Khoa { MaKhoa = 10, TenKhoa = "Quốc Phòng" }
                );
            modelBuilder.Entity<MonHoc>().HasData(
          new MonHoc { MaMon = 1, TenMon = "Đường lối", SoTinChi = 3 },
          new MonHoc { MaMon = 2, TenMon = "QP1", SoTinChi = 1 },
          new MonHoc { MaMon = 3, TenMon = "QP2", SoTinChi = 2 },
          new MonHoc { MaMon = 4, TenMon = "QP3", SoTinChi = 3 },
          new MonHoc { MaMon = 5, TenMon = "QP4", SoTinChi = 2 },
          new MonHoc { MaMon = 6, TenMon = "Mác - Lênin", SoTinChi = 5 },
          new MonHoc { MaMon = 7, TenMon = "Giải Tích", SoTinChi = 3 },
          new MonHoc { MaMon = 8, TenMon = "Đại số tuyến tính", SoTinChi = 3 },
          new MonHoc { MaMon = 9, TenMon = "Thể chất 1", SoTinChi = 1 },
          new MonHoc { MaMon = 10, TenMon = "Thể chất 2", SoTinChi = 2 }
          );
            modelBuilder.Entity<SinhVien>().HasData(
                new SinhVien { MaSinhVien = 1, HoTen = "Nguyễn Thị Kim Anh", NgaySinh = new DateTime(2000, 06, 12), DienThoai = 0344135640, MaKhoa = 1 },
                new SinhVien { MaSinhVien = 2, HoTen = "Nguyễn Thị Thùy Trinh", NgaySinh = new DateTime(1998, 07, 02), DienThoai = 0344135640, MaKhoa = 2 },
                new SinhVien { MaSinhVien = 3, HoTen = "Nguyễn Thị Linh", NgaySinh = new DateTime(1999, 03, 12), DienThoai = 0344135640, MaKhoa = 3 },
                new SinhVien { MaSinhVien = 4, HoTen = "Nguyễn Quốc Cường", NgaySinh = new DateTime(2000, 09, 24), DienThoai = 0344135640, MaKhoa = 4 },
                new SinhVien { MaSinhVien = 5, HoTen = "Nguyễn Quốc Khánh", NgaySinh = new DateTime(2000, 12, 03), DienThoai = 0344135640, MaKhoa = 5 },
                new SinhVien { MaSinhVien = 6, HoTen = "Dương Thái Nhật", NgaySinh = new DateTime(1998, 06, 12), DienThoai = 0344135640, MaKhoa = 6 },
                new SinhVien { MaSinhVien = 7, HoTen = "Trần Hoài Đức", NgaySinh = new DateTime(2002, 06, 12), DienThoai = 0344135640, MaKhoa = 7 },
                new SinhVien { MaSinhVien = 8, HoTen = "Trần Văn Nhật Tân", NgaySinh = new DateTime(2001, 11, 26), DienThoai = 0344135640, MaKhoa = 8 }

                );
            modelBuilder.Entity<LopHocPhan>().HasData(
                new LopHocPhan { MaLopHocPhan = 101, NamHoc = 2018, HocKy = 1, MaMon = 1 },
                new LopHocPhan { MaLopHocPhan = 102, NamHoc = 2018, HocKy = 2, MaMon = 2 },
                new LopHocPhan { MaLopHocPhan = 103, NamHoc = 2018, HocKy = 2, MaMon = 3 },
                new LopHocPhan { MaLopHocPhan = 104, NamHoc = 2018, HocKy = 1, MaMon = 4 },
                new LopHocPhan { MaLopHocPhan = 105, NamHoc = 2019, HocKy = 1, MaMon = 5 },
                new LopHocPhan { MaLopHocPhan = 106, NamHoc = 2019, HocKy = 3, MaMon = 6 },
                new LopHocPhan { MaLopHocPhan = 107, NamHoc = 2019, HocKy = 2, MaMon = 7 },
                new LopHocPhan { MaLopHocPhan = 108, NamHoc = 2020, HocKy = 1, MaMon = 8 },
                new LopHocPhan { MaLopHocPhan = 109, NamHoc = 2020, HocKy = 1, MaMon = 9 }
                );
            modelBuilder.Entity<KetQua>().HasData(
                new KetQua { MaSV = 1, LopHocPhan = 101, DiemGK = 10, DiemCK = 9},
                new KetQua { MaSV = 1, LopHocPhan = 102, DiemGK = 10, DiemCK = 9},
                new KetQua { MaSV = 1, LopHocPhan = 103, DiemGK = 10, DiemCK = 9},
                new KetQua { MaSV = 1, LopHocPhan = 104, DiemGK = 10, DiemCK = 9},
                new KetQua { MaSV = 1, LopHocPhan = 105, DiemGK = 10, DiemCK = 9},
                new KetQua { MaSV = 1, LopHocPhan = 106, DiemGK = 10, DiemCK = 9},
                new KetQua { MaSV = 2, LopHocPhan = 101, DiemGK = 10, DiemCK = 9},
                new KetQua { MaSV = 2, LopHocPhan = 102, DiemGK = 10, DiemCK = 9},
                new KetQua { MaSV = 2, LopHocPhan = 103, DiemGK = 10, DiemCK = 9},
                new KetQua { MaSV = 2, LopHocPhan = 104, DiemGK = 10, DiemCK = 9},
                new KetQua { MaSV = 2, LopHocPhan = 105, DiemGK = 10, DiemCK = 9},
                new KetQua { MaSV = 2, LopHocPhan = 106, DiemGK = 10, DiemCK = 9},
                new KetQua { MaSV = 2, LopHocPhan = 107, DiemGK = 10, DiemCK = 9},
                new KetQua { MaSV = 2, LopHocPhan = 108, DiemGK = 10, DiemCK = 9},
                new KetQua { MaSV = 2, LopHocPhan = 109, DiemGK = 10, DiemCK = 9},
                new KetQua { MaSV = 3, LopHocPhan = 101, DiemGK = 10, DiemCK = 9},
                new KetQua { MaSV = 3, LopHocPhan = 102, DiemGK = 10, DiemCK = 9},
                new KetQua { MaSV = 3, LopHocPhan = 103, DiemGK = 10, DiemCK = 9},
                new KetQua { MaSV = 3, LopHocPhan = 104, DiemGK = 10, DiemCK = 9},
                new KetQua { MaSV = 3, LopHocPhan = 105, DiemGK = 10, DiemCK = 9},
                new KetQua { MaSV = 3, LopHocPhan = 106, DiemGK = 10, DiemCK = 9},
                new KetQua { MaSV = 3, LopHocPhan = 107, DiemGK = 10, DiemCK = 9},
                new KetQua { MaSV = 3, LopHocPhan = 108, DiemGK = 10, DiemCK = 9},
                new KetQua { MaSV = 3, LopHocPhan = 109, DiemGK = 10, DiemCK = 9},
                new KetQua { MaSV = 4, LopHocPhan = 101, DiemGK = 10, DiemCK = 9},
                new KetQua { MaSV = 4, LopHocPhan = 102, DiemGK = 10, DiemCK = 9},
                new KetQua { MaSV = 4, LopHocPhan = 103, DiemGK = 10, DiemCK = 9},
                new KetQua { MaSV = 4, LopHocPhan = 104, DiemGK = 10, DiemCK = 9},
                new KetQua { MaSV = 4, LopHocPhan = 105, DiemGK = 10, DiemCK = 9},
                new KetQua { MaSV = 4, LopHocPhan = 106, DiemGK = 10, DiemCK = 9},
                new KetQua { MaSV = 4, LopHocPhan = 107, DiemGK = 10, DiemCK = 9},
                new KetQua { MaSV = 4, LopHocPhan = 108, DiemGK = 10, DiemCK = 9},
                new KetQua { MaSV = 4, LopHocPhan = 109, DiemGK = 10, DiemCK = 9},
                new KetQua { MaSV = 5, LopHocPhan = 101, DiemGK = 10, DiemCK = 9},
                new KetQua { MaSV = 5, LopHocPhan = 103, DiemGK = 10, DiemCK = 9},
                new KetQua { MaSV = 5, LopHocPhan = 104, DiemGK = 10, DiemCK = 9},
                new KetQua { MaSV = 5, LopHocPhan = 106, DiemGK = 10, DiemCK = 9},
                new KetQua { MaSV = 5, LopHocPhan = 107, DiemGK = 10, DiemCK = 9},
                new KetQua { MaSV = 5, LopHocPhan = 108, DiemGK = 10, DiemCK = 9},
                new KetQua { MaSV = 5, LopHocPhan = 109, DiemGK = 10, DiemCK = 9},
                new KetQua { MaSV = 6, LopHocPhan = 101, DiemGK = 10, DiemCK = 9},
                new KetQua { MaSV = 6, LopHocPhan = 103, DiemGK = 10, DiemCK = 9},
                new KetQua { MaSV = 6, LopHocPhan = 104, DiemGK = 10, DiemCK = 9},
                new KetQua { MaSV = 6, LopHocPhan = 105, DiemGK = 10, DiemCK = 9},
                new KetQua { MaSV = 6, LopHocPhan = 106, DiemGK = 10, DiemCK = 9},
                new KetQua { MaSV = 6, LopHocPhan = 107, DiemGK = 10, DiemCK = 9},
                new KetQua { MaSV = 6, LopHocPhan = 108, DiemGK = 10, DiemCK = 9},
                new KetQua { MaSV = 7, LopHocPhan = 101, DiemGK = 10, DiemCK = 9},
                new KetQua { MaSV = 7, LopHocPhan = 102, DiemGK = 10, DiemCK = 9},
                new KetQua { MaSV = 7, LopHocPhan = 103, DiemGK = 10, DiemCK = 9},
                new KetQua { MaSV = 7, LopHocPhan = 104, DiemGK = 10, DiemCK = 9},
                new KetQua { MaSV = 7, LopHocPhan = 105, DiemGK = 10, DiemCK = 9},
                new KetQua { MaSV = 7, LopHocPhan = 106, DiemGK = 10, DiemCK = 9},
                new KetQua { MaSV = 7, LopHocPhan = 107, DiemGK = 10, DiemCK = 9},
                new KetQua { MaSV = 7, LopHocPhan = 108, DiemGK = 10, DiemCK = 9},
                new KetQua { MaSV = 7, LopHocPhan = 109, DiemGK = 10, DiemCK = 9},
                new KetQua { MaSV = 8, LopHocPhan = 101, DiemGK = 10, DiemCK = 9},
                new KetQua { MaSV = 8, LopHocPhan = 102, DiemGK = 10, DiemCK = 9},
                new KetQua { MaSV = 8, LopHocPhan = 103, DiemGK = 10, DiemCK = 9},
                new KetQua { MaSV = 8, LopHocPhan = 104, DiemGK = 10, DiemCK = 9},
                new KetQua { MaSV = 8, LopHocPhan = 105, DiemGK = 10, DiemCK = 9},
                new KetQua { MaSV = 8, LopHocPhan = 106, DiemGK = 10, DiemCK = 9},
                new KetQua { MaSV = 8, LopHocPhan = 107, DiemGK = 10, DiemCK = 9}
                );
        }

    }
}
