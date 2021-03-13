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
    class LapPhieuThuePhongDAL
    {
        public Int32 ThemPhieuThuePhong(PhieuThuePhongDTO phieuThuePhong, List<ChiTietThuePhongDTO> dSChiTietThuePhongDTO)
        {
            Provider provider = new Provider();
            DataTable dt = new DataTable();
            provider.Connect();

            // tạo ra mã phiếu thêu phòng và ghi vào trong database
            string sqlQueryMPT = "SELECT MaPhieuThuePhong FROM PHIEUTHUEPHONG";
            dt = provider.Select(CommandType.Text, sqlQueryMPT);
            string MaPhieuThuePhong;
            if (dt.Rows.Count == 0)
            {
                MaPhieuThuePhong = "PT001";
            }
            else
            {
                string so0 = "000";
                string increment = (int.Parse(dt.Rows[dt.Rows.Count - 1].Field<string>(0).Substring(2)) + 1).ToString();
                MaPhieuThuePhong = "PT" + so0.Substring(increment.Length) + increment;
            }

            string sqlQuery = "INSERT INTO PHIEUTHUEPHONG(MaPhieuThuePhong, NgayThue, MaPhong) VALUES(@MaPhieuThuePhong, @NgayThue, @MaPhong)";


            provider.ExecuteNonQuery(CommandType.Text, sqlQuery,
                 new SqlParameter { ParameterName = "@MaPhieuThuePhong", Value = MaPhieuThuePhong },
                 new SqlParameter { ParameterName = "@NgayThue", Value = phieuThuePhong.NgayThue },
                  new SqlParameter { ParameterName = "@MaPhong", Value = phieuThuePhong.MaPhong }
                );

            // tạo ra mã chi tiết phiếu mượn và ghi vào trong database

            for (int i = 0; i < dSChiTietThuePhongDTO.Count; i++)
            {
                string sqlQueryMCTPT = "SELECT MaChiTietThuePhong FROM CHITIETTHUEPHONG";
                DataTable dt_2 = new DataTable();

                dt_2 = provider.Select(CommandType.Text, sqlQueryMCTPT);

                string MaChiTietPhieuThue;
                if (dt_2.Rows.Count == 0)
                {
                    MaChiTietPhieuThue = "CTPT001";
                }
                else
                {
                    string so0 = "000";
                    string increment = (int.Parse(dt_2.Rows[dt_2.Rows.Count - 1].Field<string>(0).Substring(4)) + 1).ToString();
                    MaChiTietPhieuThue = "CTPT" + so0.Substring(increment.Length) + increment;
                }

                string sqlQuery_2 = "INSERT INTO CHITIETTHUEPHONG(MaChiTietThuePhong, MaPhieuThuePhong, MaKhachHang) VALUES(@MaChiTietThuePhong, @MaPhieuThuePhong, @MaKhachHang)";

                provider.ExecuteNonQuery(CommandType.Text, sqlQuery_2,
                     new SqlParameter { ParameterName = "@MaChiTietThuePhong", Value = MaChiTietPhieuThue },
                     new SqlParameter { ParameterName = "@MaPhieuThuePhong", Value = MaPhieuThuePhong },
                     new SqlParameter { ParameterName = "@MaKhachHang", Value = dSChiTietThuePhongDTO[i].MaKhachHang }
                    );
            }

            // cập nhật tình trạng của mã phòng

            string sqlQuery_3 = "UPDATE PHONG SET MaTinhTrang = 'TT002' WHERE MaPhong = @MaPhong";
            provider.ExecuteNonQuery(CommandType.Text, sqlQuery_3,
                new SqlParameter { ParameterName = "@MaPhong", Value = phieuThuePhong.MaPhong }

                );

            provider.DisConnect();

            return 1;
        }

        public int SoLuongKhachToiDaTrongPhong()
        {
            Provider provider = new Provider();
            DataTable dt = new DataTable();
            int soLuong = 0;
            provider.Connect();

            // tạo ra mã phiếu thêu phòng và ghi vào trong database
            string sqlQuery = "SELECT SoKhachToiDa FROM THAMSO";
            dt = provider.Select(CommandType.Text, sqlQuery);

            soLuong = dt.Rows[0].Field<int>(0);

            provider.DisConnect();
            return soLuong;
        }
    }
}
