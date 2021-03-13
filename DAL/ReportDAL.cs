using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management.DAL
{
    class ReportDAL
    {
        public DataTable DanhSachLoaiPhong()
        {
            Provider provider = new Provider();
            try
            {
                string strSql = "SELECT LP.MaLoaiPhong,LP.TenLoaiPhong FROM LOAIPHONG LP";
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

        public DataTable PhieuCaoBaoDanhThu(string Thang)
        {
            Provider provider = new Provider();
            try
            {
                string strSql = "SELECT PBC.MaLoaiPhong,PBC.DoanhThu,PBC.TiLe,PBC.ThangBaoCaoDoanhThu FROM PHIEUBAOCAODOANHTHU PBC WHERE PBC.ThangBaoCaoDoanhThu=@Thang";
                provider.Connect(); ;
                DataTable dt = provider.Select(CommandType.Text, strSql,
                    new SqlParameter { ParameterName = "@Thang", Value = Thang });
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

        public DataTable PhieuCaoBaoMatDo(string Thang)
        {
            Provider provider = new Provider();
            try
            {
                string strSql = "SELECT MD.ThangBaoCaoMatDo,MD.MaLoaiPhong,MD.MatDo,MD.TiLe FROM PHIEUBAOCAOMATDOSUDUNGPHONG MD WHERE MD.ThangBaoCaoMatDo=@Thang";
                provider.Connect(); ;
                DataTable dt = provider.Select(CommandType.Text, strSql,
                    new SqlParameter { ParameterName = "@Thang", Value = Thang });
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

        public DataTable getRevenue(int month)
        {
            Provider provider = new Provider();

            try
            {
                provider.Connect();
                List<SqlParameter> pars = new List<SqlParameter> { new SqlParameter("@month", month) };
                return provider.Select(CommandType.StoredProcedure, "getRevenue", pars.ToArray());
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

        public DataTable getMatDo(int month)
        {
            Provider provider = new Provider();

            try
            {
                provider.Connect();
                List<SqlParameter> pars = new List<SqlParameter> { new SqlParameter("@month", month) };
                return provider.Select(CommandType.StoredProcedure, "getMucDo", pars.ToArray());
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
        public DataTable LayMaPhieuBaoCaoCuoiCung()
        {

            Provider provider = new Provider();
            try
            {
                string strSql = "SELECT MAX(BC.MaPhieuBaoCaoDoanhThu) FROM PHIEUBAOCAODOANHTHU BC";
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
        public int ThemDataVaoPhieuBaoCao(PhieuCaoBaoDanhThu bc)
        {
            int n = 0;
            Provider provider = new Provider();
            try
            {
                string strSql = "INSERT INTO PHIEUBAOCAODOANHTHU(MaPhieuBaoCaoDoanhThu,ThangBaoCaoDoanhThu,DoanhThu,TiLe,MaLoaiPhong) VALUES (@MaPhieu,@Thang,@DoanhThu,@TiLe,@MaLoaiPhong)";
                provider.Connect(); ;
                n = provider.ExecuteNonQuery(CommandType.Text, strSql,
                    new SqlParameter { ParameterName = "@MaPhieu", Value = bc.MaPhieuBaoCao },
                    new SqlParameter { ParameterName = "@Thang", Value = bc.Thang },
                    new SqlParameter { ParameterName = "@DoanhThu", Value = bc.DoanhThu },
                     new SqlParameter { ParameterName = "@TiLe", Value = bc.TiLe },
                      new SqlParameter { ParameterName = "@MaLoaiPhong", Value = bc.MaLoaiPhong }

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
            return n;
        }
        public DataTable LayMaPhieuBaoCaoMatDOCuoiCung()
        {

            Provider provider = new Provider();
            try
            {
                string strSql = "SELECT MAX(BC.MaPhieuBaoCaoMatDoSuDungPhong) FROM PHIEUBAOCAOMATDOSUDUNGPHONG BC";
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
        public int ThemDataVaoPhieuBaoCaoMatDo(PhieuCaoBaoMatDo bc)
        {
            int n = 0;
            Provider provider = new Provider();
            try
            {
                string strSql = "INSERT INTO PHIEUBAOCAOMATDOSUDUNGPHONG(MaPhieuBaoCaoMatDoSuDungPhong,MaLoaiPhong,MatDo,TiLe,ThangBaoCaoMatDo) VALUES (@MaPhieuBaoCaoMatDoSuDungPhong,@MaLoaiPhong,@MatDo,@TiLe,@ThangBaoCaoMatDo)";
                provider.Connect(); ;
                n = provider.ExecuteNonQuery(CommandType.Text, strSql,
                    new SqlParameter { ParameterName = "@MaPhieuBaoCaoMatDoSuDungPhong", Value = bc.MaPhieuMatDo },
                    new SqlParameter { ParameterName = "@MaLoaiPhong", Value = bc.MaLoaiPhong },
                    new SqlParameter { ParameterName = "@MatDo", Value = bc.MatDo },
                     new SqlParameter { ParameterName = "@TiLe", Value = bc.TiLe },
                      new SqlParameter { ParameterName = "@ThangBaoCaoMatDo", Value = bc.Thang }

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
            return n;
        }
    }
}
