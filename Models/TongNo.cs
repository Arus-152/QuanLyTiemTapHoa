﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTiemTapHoa.Models
{
    public class TongNo
    {
        public string MaNo { get; set; }
        public string MaKH { get; set; }
        public decimal TongTienNo { get; set; } // tên này phải đúng với tên bạn dùng ở Format
        public string TrangThai { get; set; }
    }
}
