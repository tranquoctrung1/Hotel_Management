using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management.DAL
{
    class PhongDAL
    {
        public DataTable loadPhongChuaThue()
        {
            Provider provider = new Provider();

            provider.Connect();
            DataTable dt = new DataTable();
            string sqlQuery = "SELECT P.MaPhong,P.TenPhong FROM PHONG P JOIN LOAIPHONG LP ON P.MaLoaiPhong = LP.MaLoaiPhong JOIN LOAITINHTRANG LTT ON LTT.MaTinhTrang = P.MaTinhTrang WHERE LTT.TenTinhTrang=N'Chưa Sử Dụng'";
            dt = provider.Select(CommandType.Text, sqlQuery);

            provider.DisConnect();
            return dt;
        }

        public DataTable loadPhongDaThue()
        {
            Provider provider = new Provider();

            provider.Connect();
            DataTable dt = new DataTable();
            string sqlQuery = "SELECT P.MaPhong,P.TenPhong FROM PHONG P JOIN LOAITINHTRANG LTT ON LTT.MaTinhTrang=P.MaTinhTrang WHERE LTT.TenTinhTrang=N'Đã Sử Dụng'";
            dt = provider.Select(CommandType.Text, sqlQuery);

            provider.DisConnect();
            return dt;
        }

        public string loadTenPhong(string maPhong)
        {
            Provider provider = new Provider();

            provider.Connect();
            DataTable dt = new DataTable();
            string sqlQuery = "SELECT TenPhong FROM PHONG WHERE MaPhong = @MaPhong";
            dt = provider.Select(CommandType.Text, sqlQuery,
                new SqlParameter
                {
                    ParameterName = "@MaPhong",
                    Value = maPhong
                }
                );

            string tenPhong = dt.Rows[0].Field<string>(0);

            provider.DisConnect();
            return tenPhong;
        }

        public DateTime loadNgayThuePhong(string maPhong)
        {
            Provider provider = new Provider();

            provider.Connect();
            DataTable dt = new DataTable();
            string sqlQuery = "SELECT NgayThue FROM PHIEUTHUEPHONG WHERE MaPhong = @MaPhong";
            dt = provider.Select(CommandType.Text, sqlQuery,
                new SqlParameter
                {
                    ParameterName = "@MaPhong",
                    Value = maPhong
                }
                );

            DateTime ngayThue = dt.Rows[0].Field<DateTime>(0);

            provider.DisConnect();
            return ngayThue;
        }

        public double loadDonGia(string maPhong)
        {
            Provider provider = new Provider();

            provider.Connect();
            DataTable dt = new DataTable();
            string sqlQuery = "SELECT LP.DonGia FROM PHONG P JOIN LOAIPHONG LP ON LP.MaLoaiPhong = P.MaLoaiPhong WHERE MaPhong = @MaPhong";
            dt = provider.Select(CommandType.Text, sqlQuery,
                new SqlParameter
                {
                    ParameterName = "@MaPhong",
                    Value = maPhong
                }
                );

            double donGia = dt.Rows[0].Field<double>(0);

            provider.DisConnect();
            return donGia;
        }

        public double loadPhuThuNuocNgoai(string maPhong)
        {
            Provider provider = new Provider();

            provider.Connect();
            DataTable dt = new DataTable();
            string sqlQuery = "SELECT COUNT(*) FROM PHIEUTHUEPHONG PT JOIN CHITIETTHUEPHONG CT ON CT.MaPhieuThuePhong = PT.MaPhieuThuePhong WHERE PT.MaPhong = @MaPhong GROUP BY PT.MaPhieuThuePhong";
            dt = provider.Select(CommandType.Text, sqlQuery,
                new SqlParameter
                {
                    ParameterName = "@MaPhong",
                    Value = maPhong
                }
                );

            int soLuongNguoiTrongPhong = dt.Rows[0].Field<int>(0);
            int soLuongnguoiToiDaTrongPhongQuyDinh = 0;

            string sqlQuerySKTD = "SELECT SoKhachToiDa FROM THAMSO";
            DataTable dataSKTD = new DataTable();
            dataSKTD = provider.Select(CommandType.Text, sqlQuerySKTD);

            soLuongnguoiToiDaTrongPhongQuyDinh = dataSKTD.Rows[0].Field<int>(0);

            double phuThu = 1;
            if (soLuongNguoiTrongPhong > soLuongnguoiToiDaTrongPhongQuyDinh)
            {
                phuThu = 2.5;
            }

            provider.DisConnect();
            return phuThu;
        }

        public double loadTiLePhuThuNuocNgoai(string maPhong)
        {
            Provider provider = new Provider();

            provider.Connect();
            DataTable dt = new DataTable();
            string sqlQuery = "SELECT CT.MaKhachHang FROM PHIEUTHUEPHONG PT JOIN CHITIETTHUEPHONG CT ON CT.MaPhieuThuePhong = PT.MaPhieuThuePhong WHERE PT.MaPhong = @MaPhong";
            dt = provider.Select(CommandType.Text, sqlQuery,
                new SqlParameter
                {
                    ParameterName = "@MaPhong",
                    Value = maPhong
                }
                );

            string sqlQuerySKNN = "SELECT SoKhachNuocNgoai FROM THAMSO";
            DataTable dataSKNN = new DataTable();
            dataSKNN = provider.Select(CommandType.Text, sqlQuerySKNN);

            int soKhachHangNuocNgoaiQuyDinh = dataSKNN.Rows[0].Field<int>(0);
            int soKhachNuocNgoai = 0;

            string maKhachHang = "";

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                maKhachHang = dt.Rows[i].Field<string>(0);
                string sqlQueryMKH = "SELECT MaLoaiKhachHang FROM KHACHHANG WHERE MaKhachHang = @MaKhachHang";
                DataTable dataMaLoaiKhachHang = new DataTable();
                dataMaLoaiKhachHang = provider.Select(CommandType.Text, sqlQueryMKH,
                    new SqlParameter { ParameterName = "@MaKhachHang", Value = maKhachHang }
                    );

                if (dataMaLoaiKhachHang.Rows[0].Field<int>(0) == 2)
                {
                    soKhachNuocNgoai += 1;
                }
            }

            double tiLePhuThu = 1;

            if (soKhachNuocNgoai >= soKhachHangNuocNgoaiQuyDinh)
            {
                string sqlQueryTLPT = "SELECT TiLePhuThu FROM THAMSO";
                DataTable dataTLPT = provider.Select(CommandType.Text, sqlQueryTLPT);

                tiLePhuThu = dataTLPT.Rows[0].Field<double>(0);
            }

            provider.DisConnect();
            return tiLePhuThu;
        }
    }
}
