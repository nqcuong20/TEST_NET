﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TEST_GK.Entities
{
    public class MyDbContext : DbContext
    {
        public DbSet<SinhVien> SinhViens { get; set; }
        public DbSet<Khoa> Khoas { get; set; }
        public DbSet<MonHoc> MonHocs { get; set; }
        public DbSet<LopHocPhan> LopHocPhans { get; set; }
        public DbSet<KetQua> KetQuas { get; set; }
        public MyDbContext(DbContextOptions options) : base(options)//lấy các thông số khởi tạo của lớp cha
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity
        }
}
