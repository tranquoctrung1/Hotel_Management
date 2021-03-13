using DTO;
using Hotel_Management.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management.BLL
{
    class xlThayDoiQuyDinhBLL
    {
        public DataTable LoadThongTinLoaiPhong(string maloaiphong)
        {
            xlThayDoiQuyDinhDAL xl = new xlThayDoiQuyDinhDAL();
            return xl.LoadThongTinLoaiPhong(maloaiphong);
        }

        public DataTable LoadLoaiPhong()
        {
            xlThayDoiQuyDinhDAL xl = new xlThayDoiQuyDinhDAL();
            return xl.LoadLoaiPhong();
        }

        public DataTable LoadLoaiKhach()
        {
            xlThayDoiQuyDinhDAL xl = new xlThayDoiQuyDinhDAL();
            return xl.LoadLoaiKhach();
        }

        public DataTable LoadThongTinLoaiKhach(int maloaikhach)
        {
            xlThayDoiQuyDinhDAL xl = new xlThayDoiQuyDinhDAL();
            return xl.LoadThongTinLoaiKhach(maloaikhach);
        }

        public DataTable LoadThamSo(ThamSoDTO ts)
        {
            xlThayDoiQuyDinhDAL xl = new xlThayDoiQuyDinhDAL();
            return xl.LoadThamSo(ts);
        }
        public int SuaThongTinLoaiPhong(LoaiPhongDTO loai)
        {
            xlThayDoiQuyDinhDAL xl = new xlThayDoiQuyDinhDAL();
            return xl.SuaThongTinLoaiPhong(loai);
        }

        public int SuaHeSoKhach(LoaiKhachHangDTO lkh)
        {
            xlThayDoiQuyDinhDAL xl = new xlThayDoiQuyDinhDAL();
            return xl.SuaHeSoKhach(lkh);
        }

        public int SuaThamSo(ThamSoDTO ts)
        {
            xlThayDoiQuyDinhDAL xl = new xlThayDoiQuyDinhDAL();
            return xl.SuaThamSo(ts);
        }

        public bool IsNumber(string pValue)
        {
            xlThayDoiQuyDinhDAL xl = new xlThayDoiQuyDinhDAL();
            return xl.IsNumber(pValue);
        }
    }
}
