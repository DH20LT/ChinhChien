﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChinhChien.DAL_DAO;

namespace ChinhChien.BUS
{
    internal class HoaDonBUS
    {
        private HoaDonDAO hoaDonDAO;

        public HoaDonBUS()
        {
            hoaDonDAO = new HoaDonDAO();
        }
    }
}
