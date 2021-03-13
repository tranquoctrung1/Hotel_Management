using DTO;
using Hotel_Management.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management.DAL
{
    public class xlTraCuuPhongDAL
    {
        public DataTable LoadTimKiem(PhongDTO p, LoaiPhongDTO lp, LoaiTinhTrangDTO tt)
        {
            Provider provider = new Provider();

            try
            {
                provider.Connect();

                string strSql = "select distinct p.TenPhong, lp.TenLoaiPhong, lp.DonGia, tt.TenTinhTrang from Phong p join LoaiPhong lp on p.MaLoaiPhong = lp.MaLoaiPhong join LOAITINHTRANG tt on p.MaTinhTrang = tt.MaTinhTrang WHERE BiXoa = 1  ";
                string sqlwhere = " ";




                if (p.MaPhong != "1")
                {
                    sqlwhere += "AND p.MaPhong = @MaPhong";
                    sqlwhere += " ";

                }
                if (p.TenPhong != "1")
                {
                    sqlwhere += "AND p.TenPhong = @TenPhong";
                    sqlwhere += " ";

                }
                if (lp.DonGia != 1)
                {
                    sqlwhere += "AND lp.DonGia = @DonGia";
                    sqlwhere += " ";
                }
                if (lp.MaLoaiPhong != "1")
                {
                    sqlwhere += "AND lp.MaLoaiPhong = @MaLoaiPhong";
                    sqlwhere += " ";


                }
                if (tt.TenTinhTrang != "1")
                {
                    sqlwhere += "AND tt.TenTinhTrang = @TenTinhTrang";
                    sqlwhere += " ";
                }
                string sql = strSql + sqlwhere;

                DataTable dt = provider.Select(CommandType.Text, sql,
                                new SqlParameter { ParameterName = "@MaPhong", Value = p.MaPhong },
                                new SqlParameter { ParameterName = "@TenPhong", Value = p.TenPhong },
                                new SqlParameter { ParameterName = "@DonGia", Value = lp.DonGia },
                                new SqlParameter { ParameterName = "@TenTinhTrang", Value = tt.TenTinhTrang },
                                new SqlParameter { ParameterName = "@MaLoaiPhong", Value = lp.MaLoaiPhong });
                return dt;
                // return sqlTruyVan;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                provider.DisConnect();
            }
        }

        public DataTable LoadLoaiPhong()
        {
            Provider provider = new Provider();
            try
            {
                string strSql = "select distinct lp.MaLoaiPhong, lp.TenLoaiPhong from LOAIPHONG lp";
                provider.Connect(); ;
                DataTable dt = provider.Select(CommandType.Text, strSql);
                return dt;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                provider.DisConnect();
            }
        }
        public DataTable LoadTraCuu()
        {
            Provider provider = new Provider();
            try
            {
                string strSql = "select  p.TenPhong, lp.TenLoaiPhong, lp.DonGia, tt.TenTinhTrang from Phong p join LoaiPhong lp on p.MaLoaiPhong = lp.MaLoaiPhong join LOAITINHTRANG tt on p.MaTinhTrang = tt.MaTinhTrang WHERE BiXoa = 1";
                provider.Connect(); ;
                DataTable dt = provider.Select(CommandType.Text, strSql);
                return dt;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                provider.DisConnect();
            }
        }

        public DataTable LoadTinhTrang()
        {
            Provider provider = new Provider();
            try
            {
                string strSql = "select distinct tt.MaTinhTrang, tt.TenTinhTrang from LOAITINHTRANG tt";
                provider.Connect(); ;
                DataTable dt = provider.Select(CommandType.Text, strSql);
                return dt;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                provider.DisConnect();
            }
        }
    }
}
