using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QLGH
{
    public class clsDALKhachHang
    {
        SqlConnection con = new SqlConnection(@"Data Source=MSI\;Initial Catalog=QLGiaoHang;Integrated Security=True");
        public DataTable LayDSKhachHang()
        {
            DataTable dt = new DataTable();
            string sql = @"SP_LayDSKhachHang";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter ds = new SqlDataAdapter(cmd);
            ds.Fill(dt);
            con.Close();
            return dt;
        }
        public void ThemKhachHang(string makh, string tenkh, string sdt, string email, string thongtinkhac)
        {
            string sql = @"SP_ThemKhachHang";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@makh", SqlDbType.NVarChar).Value = makh;
            cmd.Parameters.Add("@tenkh", SqlDbType.NVarChar).Value = tenkh;
            cmd.Parameters.Add("@sdt", SqlDbType.NVarChar).Value = sdt;
            cmd.Parameters.Add("@email", SqlDbType.NVarChar).Value = email;
            cmd.Parameters.Add("@thongtinkhac", SqlDbType.NVarChar).Value = thongtinkhac;
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void XoaKhachHang(string makh)
        {
            string sql = @"SP_XoaKhachHang";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@makh", SqlDbType.NVarChar).Value = makh;
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void SuaKhachHang(string makh, string tenkh, string sdt, string email, string thongtinkhac)
        {
            string sql = @"SP_SuaKhachHang";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@makh", SqlDbType.NVarChar).Value = makh;
            cmd.Parameters.Add("@tenkh", SqlDbType.NVarChar).Value = tenkh;
            cmd.Parameters.Add("@sdt", SqlDbType.NVarChar).Value = sdt;
            cmd.Parameters.Add("@email", SqlDbType.NVarChar).Value = email;
            cmd.Parameters.Add("@thongtinkhac", SqlDbType.NVarChar).Value = thongtinkhac;
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public DataTable LayDSNguoiNhan()
        {
            DataTable dt = new DataTable();
            string sql = @"SP_LayDSNguoiNhan";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter ds = new SqlDataAdapter(cmd);
            ds.Fill(dt);
            con.Close();
            return dt;
        }
        public void XoaNguoiNhan(string mann)
        {
            string sql = @"SP_XoaNguoiNhan";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@mann", SqlDbType.NVarChar).Value = mann;
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void SuaNguoiNhan(string mann, string makh, string tennn, string sdt, string email, string cmnd, string diachi, string thongtinkhac)
        {
            string sql = @"SP_SuaNguoiNhan";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@mann", SqlDbType.NVarChar).Value = mann;
            cmd.Parameters.Add("@makh", SqlDbType.NVarChar).Value = makh;
            cmd.Parameters.Add("@tennn", SqlDbType.NVarChar).Value = tennn;
            cmd.Parameters.Add("@sdt", SqlDbType.NVarChar).Value = sdt;
            cmd.Parameters.Add("@email", SqlDbType.NVarChar).Value = email;
            cmd.Parameters.Add("@diachi", SqlDbType.NVarChar).Value = diachi;
            cmd.Parameters.Add("@cmnd", SqlDbType.NVarChar).Value = cmnd;
            cmd.Parameters.Add("@thongtinkhac", SqlDbType.NVarChar).Value = thongtinkhac;
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void ThemNguoiNhan(string mann, string makh, string tennn, string sdt, string email, string cmnd, string diachi, string thongtinkhac)
        {
            string sql = @"SP_ThemNguoiNhan";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@mann", SqlDbType.NVarChar).Value = mann;
            cmd.Parameters.Add("@makh", SqlDbType.NVarChar).Value = makh;
            cmd.Parameters.Add("@tennn", SqlDbType.NVarChar).Value = tennn;
            cmd.Parameters.Add("@sdt", SqlDbType.NVarChar).Value = sdt;
            cmd.Parameters.Add("@email", SqlDbType.NVarChar).Value = email;
            cmd.Parameters.Add("@diachi", SqlDbType.NVarChar).Value = diachi;
            cmd.Parameters.Add("@cmnd", SqlDbType.NVarChar).Value = cmnd;
            cmd.Parameters.Add("@thongtinkhac", SqlDbType.NVarChar).Value = thongtinkhac;
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public DataTable ThongKeSLDH()
        {
            DataTable dt = new DataTable();
            string sql = @"SP_ThongKeSL";
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
