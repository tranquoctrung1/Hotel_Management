using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Hotel_Management.DAL
{
    class xlThayDoiQuyDinhDAL
    {
        public DataTable LoadLoaiPhong()
        {
            Provider provider = new Provider();
            try
            {
                string strSql = "select distinct lp.MaLoaiPhong, lp.TenLoaiPhong, lp.DonGia, lp.SoLuongPhong from LOAIPHONG lp";
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

        public DataTable LoadThongTinLoaiPhong(string maloaiphong)
        {
            Provider provider = new Provider();
            try
            {
                string strSql = "select distinct lp.MaLoaiPhong, lp.TenLoaiPhong, lp.DonGia, lp.SoLuongPhong from LOAIPHONG lp WHERE lp.MaLoaiPhong = @maloaiphong ";
                provider.Connect(); ;
                DataTable dt = provider.Select(CommandType.Text, strSql,
                            new SqlParameter { ParameterName = "@maloaiphong", Value = maloaiphong }
                            );

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
        public DataTable LoadLoaiKhach()
        {
            Provider provider = new Provider();
            try
            {
                string strSql = "select lkh.MaLoaiKhachHang, lkh.TenLoaiKhach from LOAIKHACHHANG lkh";
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

        public DataTable LoadThongTinLoaiKhach(int maloaikhach)
        {
            Provider provider = new Provider();
            try
            {
                string strSql = "select lkh.MaLoaiKhachHang, lKH.TenLoaiKhach, lkh.HeSoKhach from LOAIKHACHHANG lkh WHERE lkh.MaLoaiKhachHang = @maloaikhach ";
                provider.Connect(); ;
                DataTable dt = provider.Select(CommandType.Text, strSql,
                            new SqlParameter { ParameterName = "@maloaikhach", Value = maloaikhach }
                            );

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

        public DataTable LoadThamSo(ThamSoDTO ts)
        {
            Provider provider = new Provider();
            try
            {
                string strSql = "select ts.SoKhachToiDa, ts.SoKhachNuocNgoai, ts.TiLePhuThu, ts.SoKhachNoiDia FROM ThamSo ts";
                provider.Connect(); ;
                DataTable dt = provider.Select(CommandType.Text, strSql,
                    new SqlParameter { ParameterName = "@SoKhachToiDa", Value = ts.SoKhachToiDa },
                    new SqlParameter { ParameterName = "@SoKhachNuocNgoai", Value = ts.SoKhachNuocNgoai },
                    new SqlParameter { ParameterName = "@TiLePhuThu", Value = ts.TiLePhuThu },
                    new SqlParameter { ParameterName = "@SoKhachNoiDia", Value = ts.SoKhachNoiDia }
                    );

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

        public int SuaThongTinLoaiPhong(LoaiPhongDTO loai)
        {
            Provider provider = new Provider();
            int n = 0;
            try
            {
                provider.Connect();

                string sql = "update LOAIPHONG set LOAIPHONG.MaLoaiPhong = @MaLoaiPhong, LOAIPHONG.DonGia = @DonGia, LOAIPHONG.SoLuongPhong = @SoLuongPhong where MaLoaiPhong = @MaLoaiPhong";
                n = provider.ExecuteNonQuery(CommandType.Text, sql,
                    new SqlParameter { ParameterName = "@DonGia", Value = loai.DonGia },
                    new SqlParameter { ParameterName = "@SoLuongPhong", Value = loai.SoLuong },
                    new SqlParameter { ParameterName = "@MaLoaiPhong", Value = loai.MaLoaiPhong }
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

        public int SuaHeSoKhach(LoaiKhachHangDTO lkh)
        {
            Provider provider = new Provider();
            int n = 0;
            try
            {
                provider.Connect();

                string sql = "update LOAIKHACHHANG set HeSoKhach = @HeSoKhach where MaLoaiKhachHang = @MaLoaiKhachHang";
                n = provider.ExecuteNonQuery(CommandType.Text, sql,
                    new SqlParameter { ParameterName = "@HeSoKhach", Value = lkh.HeSoKhach },
                    new SqlParameter { ParameterName = "@MaLoaiKhachHang", Value = lkh.MaLoaiKhachHang }
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

        public int SuaThamSo(ThamSoDTO ts)
        {
            Provider provider = new Provider();
            int n = 0;
            try
            {
                provider.Connect();

                string sql = "update THAMSO set SoKhachToiDa = @SoKhachToiDa, SoKhachNuocNgoai = @SoKhachNuocNgoai, SoKhachNoiDia = @SoKhachNoiDia, TiLePhuThu = @TiLePhuThu";
                n = provider.ExecuteNonQuery(CommandType.Text, sql,
                    new SqlParameter { ParameterName = "@SoKhachToiDa", Value = ts.SoKhachToiDa },
                    new SqlParameter { ParameterName = "@SoKhachNuocNgoai", Value = ts.SoKhachNuocNgoai },
                    new SqlParameter { ParameterName = "@SoKhachNoiDia", Value = ts.SoKhachNoiDia },
                    new SqlParameter { ParameterName = "@TiLePhuThu", Value = ts.TiLePhuThu }
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

        public bool IsNumber(string pValue)
        {
            //foreach (Char c in pValue)
            //{
            //    if (!Char.IsDigit(c))
            //        return false;
            //}
            //return true;

            Regex regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
            return regex.IsMatch(pValue);
        }
    }
}
