﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBaiGiuXe.Model
{
    public class Account
    {
        private int id;
        private string tenTaiKhoan;
        private string matKhau;
        private string tenNhanVien;
        private bool vaiTro;

        public Account()
        {
        }

        public Account(DataRow row)
        {
            this.Id = Convert.ToInt32(row["id"]);
            this.tenTaiKhoan = row["tenTaiKhoan"].ToString();
            this.tenNhanVien = row["tenNhanVien"].ToString();
            this.vaiTro = (Boolean)row["vaiTro"];
            this.matKhau = row["matKhau"].ToString();
        }
        public string TenTaiKhoan { get => tenTaiKhoan; set => tenTaiKhoan = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public string TenNhanVien { get => tenNhanVien; set => tenNhanVien = value; }
        public bool VaiTro { get => vaiTro; set => vaiTro = value; }
        public int Id { get => id; set => id = value; }
    }
}
