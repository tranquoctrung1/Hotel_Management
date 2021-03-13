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
    public class xlLapHoaDonDAL
    {

        public int ThemThanhToan(HoaDonDTO hoaDonDTO, List<ChiTietHoaDonDTO> dSChiTietHoaDonDTO)
        {
            Provider provider = new Provider();
            try
            {
                DataTable dt = new DataTable();
                provider.Connect();

                // tạo ra mã hóa đơn và ghi vào trong database
                string sqlQueryHD = "SELECT MaHoaDon FROM HOADON";
                dt = provider.Select(CommandType.Text, sqlQueryHD);
                string MaHoaDon;
                if (dt.Rows.Count == 0)
                {
                    MaHoaDon = "HD001";
                }
                else
                {
                    string so0 = "000";
                    string increment = (int.Parse(dt.Rows[dt.Rows.Count - 1].Field<string>(0).Substring(2)) + 1).ToString();
                    MaHoaDon = "HD" + so0.Substring(increment.Length) + increment;
                }

                string sqlQuery = "INSERT INTO HOADON(MaHoaDon, NgayThanhToan, TongThanhTien, MaKhachHang) VALUES(@MaHoaDon, @NgayThanhToan, @TongThanhTien, @MaKhachHang)";

                provider.ExecuteNonQuery(CommandType.Text, sqlQuery,
                     new SqlParameter { ParameterName = "@MaHoaDon", Value = MaHoaDon },
                     new SqlParameter { ParameterName = "@NgayThanhToan", Value = hoaDonDTO.NgayThanhToan },
                     new SqlParameter { ParameterName = "@TongThanhTien", Value = hoaDonDTO.TriGia },
                     new SqlParameter { ParameterName = "@MaKhachHang", Value = hoaDonDTO.MaKhachHang }
                    );

                // tạo ra mã chi tiết hóa đơn và ghi vào trong database

                for (int i = 0; i < dSChiTietHoaDonDTO.Count; i++)
                {
                    string sqlQueryMCTHD = "SELECT MaChiTietHoaDon FROM CHITIETHOADON";
                    DataTable dt_2 = new DataTable();

                    dt_2 = provider.Select(CommandType.Text, sqlQueryMCTHD);

                    string MaChiTietHoaDon;
                    if (dt_2.Rows.Count == 0)
                    {
                        MaChiTietHoaDon = "CTHD001";
                    }
                    else
                    {
                        string so0 = "000";
                        string increment = (int.Parse(dt_2.Rows[dt_2.Rows.Count - 1].Field<string>(0).Substring(4)) + 1).ToString();
                        MaChiTietHoaDon = "CTHD" + so0.Substring(increment.Length) + increment;
                    }

                    string sqlQuery_2 = "INSERT INTO CHITIETHOADON(MaChiTietHoaDon, SoNgayThue, DonGia, ThanhTien, MaPhong, MaHoaDon) VALUES(@MaChiTietHoaDon, @SoNgayThue, @DonGia, @ThanhTien, @MaPhong, @MaHoaDon)";

                    provider.ExecuteNonQuery(CommandType.Text, sqlQuery_2,
                    new SqlParameter { ParameterName = "@MaChiTietHoaDon", Value = MaChiTietHoaDon },
                    new SqlParameter { ParameterName = "@SoNgayThue", Value = dSChiTietHoaDonDTO[i].SoNgayThue },
                    new SqlParameter { ParameterName = "@DonGia", Value = dSChiTietHoaDonDTO[i].DonGia },
                    new SqlParameter { ParameterName = "@ThanhTien", Value = dSChiTietHoaDonDTO[i].ThanhTien },
                    new SqlParameter { ParameterName = "@MaPhong", Value = dSChiTietHoaDonDTO[i].MaPhong },
                    new SqlParameter { ParameterName = "@MaHoaDon", Value = MaHoaDon }
                   );

                    // cập nhật tình trạng phòng

                    string sqlQuery_3 = "UPDATE PHONG SET MaTinhTrang = 'TT001' WHERE MaPhong = @MaPhong";
                    provider.ExecuteNonQuery(CommandType.Text, sqlQuery_3,
                        new SqlParameter { ParameterName = "@MaPhong", Value = dSChiTietHoaDonDTO[i].MaPhong }
                        );
                }


                provider.DisConnect();

                return 1;
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
