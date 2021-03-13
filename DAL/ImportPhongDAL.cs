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
    public class ImportPhongDAL
    {
        public DataTable DuLieuMCuoiDanhSach()
        {
            Provider provider = new Provider();

            provider.Connect();

            DataTable dt = new DataTable();

            string sqlQuery = "select max(p.MaPhong) from PHONG p";
            dt = provider.Select(CommandType.Text, sqlQuery);

            provider.DisConnect();
            return dt;

        }
        public DataTable DanhSachLoaiPhong()
        {
            Provider provider = new Provider();

            provider.Connect();

            DataTable dt = new DataTable();

            string sqlQuery = "SELECT lp.MaLoaiPhong,lp.TenLoaiPhong FROM LOAIPHONG lp";
            dt = provider.Select(CommandType.Text, sqlQuery);

            provider.DisConnect();
            return dt;

        }
        public DataTable DanhSachLoaiTinhTrang()
        {
            Provider provider = new Provider();

            provider.Connect();

            DataTable dt = new DataTable();

            string sqlQuery = "SELECT ltt.MaTinhTrang,ltt.TenTinhTrang FROM LOAITINHTRANG ltt";
            dt = provider.Select(CommandType.Text, sqlQuery);

            provider.DisConnect();
            return dt;

        }
        public int ThemPhong(PhongDTO p)
        {
            int nRow = 0;
            Provider provider = new Provider();
            try
            {
                string SqlPhong = "INSERT INTO PHONG(MaPhong,TenPhong,MaLoaiPhong,MaTinhTrang) VALUES (@MaPhong,@TenPhong,@MaLoaiPhong,@MaTinhTrang)";
                provider.Connect();
                nRow = provider.ExecuteNonQuery(CommandType.Text, SqlPhong,
                            new SqlParameter { ParameterName = "@MaPhong", Value = p.MaPhong },       
                            new SqlParameter { ParameterName = "@TenPhong", Value = p.TenPhong },
                            new SqlParameter { ParameterName = "@MaLoaiPhong", Value = p.MaLoaiPhong },
                            new SqlParameter { ParameterName = "@MaTinhTrang", Value = p.MaLoaiTinhTrang}
                    );
               
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                provider.DisConnect();
            }
            return nRow;
        }
    }
}
