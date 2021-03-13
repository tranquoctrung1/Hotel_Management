using DTO;
using Hotel_Management.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LapDanhMucPhongDAL
    {
        
        public Int32 ThemPhong(PhongDTO phong)
        {
            Provider provider = new Provider();
            int nRows = 0;

            provider.Connect();

            string sqlQuery = "INSERT INTO PHONG(MaPhong, TenPhong, MaLoaiPhong, GhiChu, MaTinhTrang) VALUES (@MaPhong, @TenPhong, @MaLoaiPhong, @GhiChu, @MaTinhTrang)";
            nRows = provider.ExecuteNonQuery(CommandType.Text, sqlQuery, 
                new SqlParameter {ParameterName = "@MaPhong", Value = phong.MaPhong},
                new SqlParameter { ParameterName = "@TenPhong", Value = phong.TenPhong },
                new SqlParameter { ParameterName = "@MaLoaiPhong", Value = phong.MaLoaiPhong },
                new SqlParameter { ParameterName = "@GhiChu", Value = phong.GhiChu },
                new SqlParameter { ParameterName = "@MaTinhTrang", Value = phong.TinhTrang}
                );

            provider.DisConnect();

            return nRows;
        }
    }
}
