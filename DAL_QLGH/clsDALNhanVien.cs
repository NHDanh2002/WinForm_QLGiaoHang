using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DAL_QLGH
{
    public class clsDALNhanVien
    {
        SqlConnection con = new SqlConnection(@"Data Source=MSI\;Initial Catalog=QLGiaoHang;Integrated Security=True");
        public DataTable LayDSNhanVien()
        {
            DataTable dt = new DataTable();
            string sql = "SP_LayDSNV";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter ds = new SqlDataAdapter(cmd);
            ds.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable LayMaLoaiNV()
        {
            DataTable dt = new DataTable();
            string sql = "SP_LayMaLoaiNV";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter ds = new SqlDataAdapter(cmd);
            ds.Fill(dt);
            con.Close();
            return dt;
        }
        public void XoaNhanVien(string manv)
        {
            string sql = @"SP_XoaNhanVien";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@manv", SqlDbType.NVarChar).Value = manv;
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void SuaNhanVien(string manv, string maloainv, string tennv, string sdt, string email, byte[] anh, string thongtinkhac)
        {
            string sql = @"SP_SuaNhanVien";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@manv", SqlDbType.NVarChar).Value = manv;
            cmd.Parameters.Add("@maloainv", SqlDbType.NVarChar).Value = maloainv;
            cmd.Parameters.Add("@tennv", SqlDbType.NVarChar).Value = tennv;
            cmd.Parameters.Add("@sdt", SqlDbType.NVarChar).Value = sdt;
            cmd.Parameters.Add("@email", SqlDbType.NVarChar).Value = email;
            cmd.Parameters.Add("@anh", SqlDbType.VarBinary).Value = anh;
            cmd.Parameters.Add("@thongtinkhac", SqlDbType.NVarChar).Value = thongtinkhac;
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void ThemNhanVien(string manv, string maloainv, string tennv, string sdt, string email, byte[] anh, string thongtinkhac)
        {
            string sql = @"SP_ThemNhanVien";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@manv", SqlDbType.NVarChar).Value = manv;
            cmd.Parameters.Add("@maloainv", SqlDbType.NVarChar).Value = maloainv;
            cmd.Parameters.Add("@tennv", SqlDbType.NVarChar).Value = tennv;
            cmd.Parameters.Add("@sdt", SqlDbType.NVarChar).Value = sdt;
            cmd.Parameters.Add("@email", SqlDbType.NVarChar).Value = email;
            cmd.Parameters.Add("@anh", SqlDbType.VarBinary).Value = anh;
            cmd.Parameters.Add("@thongtinkhac", SqlDbType.NVarChar).Value = thongtinkhac;
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public DataTable LayLoaiNV()
        {
            DataTable dt = new DataTable();
            string sql = "SP_LayDSLoaiNV";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter ds = new SqlDataAdapter(cmd);
            ds.Fill(dt);
            con.Close();
            return dt;
        }
        public void XoaLoaiNV(string maloainv)
        {
            string sql = @"SP_XoaLoaiNV";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@maloainv", SqlDbType.NVarChar).Value = maloainv;
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void SuaLoaiNV(string maloainv, string tenloainv, string mota)
        {
            string sql = @"SP_SuaLoaiNV";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@maloainv", SqlDbType.NVarChar).Value = maloainv;
            cmd.Parameters.Add("@tenloainv", SqlDbType.NVarChar).Value = tenloainv;
            cmd.Parameters.Add("@mota", SqlDbType.NVarChar).Value = mota;
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void ThemLoaiNV(string maloainv, string tenloainv, string mota)
        {
            string sql = @"SP_ThemLoaiNV";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@maloainv", SqlDbType.NVarChar).Value = maloainv;
            cmd.Parameters.Add("@tenloainv", SqlDbType.NVarChar).Value = tenloainv;
            cmd.Parameters.Add("@mota", SqlDbType.NVarChar).Value = mota;
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public DataTable TKSLDonHangLap()
        {
            DataTable dt = new DataTable();
            string sql = "SP_SLDonHangLap";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter ds = new SqlDataAdapter(cmd);
            ds.Fill(dt);
            con.Close();    
            return dt;
        }
        public DataTable TKSLDonHangGiao()
        {
            DataTable dt = new DataTable();
            string sql = "SP_SLDonHangGiao";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter ds = new SqlDataAdapter(cmd);
            ds.Fill(dt);
            con.Close();
            return dt;
        }
    }
}
