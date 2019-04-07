using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using QL_BanHang.Model;
using QL_BanHang.Obiect;


namespace QL_BanHang.Control
{
    class KhachHangCtr
    {
        KhachHangMod nvMod = new KhachHangMod();
        HoaDonMod hdMod = new HoaDonMod();
        ChiTietMod ctMod = new ChiTietMod();
        public DataTable GetData()
        {
            return nvMod.GetData();
        }
        public bool AddData(KhachHangObj khObj)
        {
            return nvMod.AddData(khObj);
        }
        public bool UpdData(KhachHangObj khObj)
        {
            return nvMod.UpdData(khObj);
        }

        public bool UpdDiem(KhachHangObj khObj)
        {
            return nvMod.UpdDiem(khObj);
        }

        public bool DelData(string ma)
        {
            var hoaDons = hdMod.GetDataByKH(ma);

            bool isDeleted = true;

            foreach (DataRow row in hoaDons.Rows)
            {
                isDeleted = ctMod.DelDataHoaDon(Convert.ToString(row["MaHD"]));
            }
            
            if (isDeleted)
            {
                isDeleted = hdMod.DelDataKhachHang(ma);
            }
            if (isDeleted)
            {
                isDeleted = nvMod.DelData(ma);
            }
            return isDeleted;
        }
    }
}
