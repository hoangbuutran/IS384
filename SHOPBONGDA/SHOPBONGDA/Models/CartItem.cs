﻿using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SHOPBONGDA.Models
{
    [Serializable]
    public class CartItem
    {
        public SANPHAM SanPham { get; set; }
        public int SoLuong { get; set; }
    }
}