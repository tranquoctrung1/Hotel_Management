using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using Hotel_Management.DAL;

namespace BLL
{
    public class LapDanhMucPhongBLL
    {
        public bool KiemTraMaPhong(string maPhong)
        {
            bool checkMaPhong = true;
            Provider provider = new Provider();

            provider.Connect();

            DataTable dt = new DataTable();
            string sqlQuery = "SELECT MaPhong FROM PHONG";

            dt = provider.Select(CommandType.Text, sqlQuery);

            for (int i = 0; i< dt.Rows.Count; i++)
            {
                if(dt.Rows[i].Field<string>(0) == maPhong)
                {
                    checkMaPhong = false;
                    break;
                }
            }

            provider.DisConnect();

            return checkMaPhong;
        }

        public bool KiemTraTrongDuLieu(PhongDTO phong)
        {
            bool checkTrongDuLieu = false;

           if(phong.MaLoaiPhong != "" && phong.MaLoaiPhong != "" && phong.TenPhong != "" && phong.TinhTrang != "")
            {
                checkTrongDuLieu = true;
            }

            return checkTrongDuLieu;
        }

        public Int32 ThemPhong(PhongDTO phong)
        {
            LapDanhMucPhongDAL lapDanhMucPhongDAL = new LapDanhMucPhongDAL();

            return lapDanhMucPhongDAL.ThemPhong(phong);
        }
    }
}
