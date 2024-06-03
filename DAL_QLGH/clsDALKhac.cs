using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QLGH
{
    public class clsDALKhac
    {
        SqlConnection con = new SqlConnection(@"Data Source=MSI\;Initial Catalog=QLGiaoHang;Integrated Security=True");
        public DataTable LayDSVoucher()
        {
            DataTable dt = new DataTable();
            string sql = "SP_LayDSVoucher";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter ds = new SqlDataAdapter(cmd);
            ds.Fill(dt);
            con.Close();
            return dt;
        }
        public void XoaVoucher(string mavoucher)
        {
            string sql = @"SP_XoaVoucher";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@mavoucher", SqlDbType.NVarChar).Value = mavoucher;
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void SuaVoucher(string mavc, string tenvc, string manl, DateTime ngaytao, string thoihang)
        {
            string sql = @"SP_SuaVoucher";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@mavoucher", SqlDbType.NVarChar).Value = mavc;
            cmd.Parameters.Add("tenvoucher", SqlDbType.NVarChar).Value = tenvc;
            cmd.Parameters.Add("@manguoilap", SqlDbType.NVarChar).Value = manl;
            cmd.Parameters.Add("@ngaytao", SqlDbType.DateTime).Value = ngaytao;
            cmd.Parameters.Add("@thoihang", SqlDbType.NVarChar).Value = thoihang;
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void ThemVoucher(string mavc, string tenvc, string manl, DateTime ngaytao, string thoihang)
        {
            string sql = @"SP_ThemVoucher";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@mavoucher", SqlDbType.NVarChar).Value = mavc;
            cmd.Parameters.Add("tenvoucher", SqlDbType.NVarChar).Value = tenvc;
            cmd.Parameters.Add("@manguoilap", SqlDbType.NVarChar).Value = manl;
            cmd.Parameters.Add("@ngaytao", SqlDbType.DateTime).Value = ngaytao;
            cmd.Parameters.Add("@thoihang", SqlDbType.NVarChar).Value = thoihang;
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
