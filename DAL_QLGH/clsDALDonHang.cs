using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QLGH
{
    public class clsDALDonHang
    {
        SqlConnection con = new SqlConnection(@"Data Source=MSI\;Initial Catalog=QLGiaoHang;Integrated Security=True");
        public DataTable LayDSDonHang()
        {
            DataTable dt = new DataTable();
            string sql = "SP_LayDonHang";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter ds = new SqlDataAdapter(cmd);
            ds.Fill(dt);
            con.Close();
            return dt;
        }
        public void ThemDonHang(string madh, string makh, string mann, string manv, string cuocphi, string khoiluong,string thoihangiao,string ghichu)
        {
            string sql = @"SP_ThemDonHang";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@madh", SqlDbType.NVarChar);
            cmd.Parameters["@madh"].Value = madh;
            cmd.Parameters.Add("@makh", SqlDbType.NVarChar);
            cmd.Parameters["@makh"].Value = makh;
            cmd.Parameters.Add("@mann", SqlDbType.NVarChar);
            cmd.Parameters["@mann"].Value = mann;
            cmd.Parameters.Add("@manv", SqlDbType.NVarChar);
            cmd.Parameters["@manv"].Value = manv;
            cmd.Parameters.Add("@cuocphi", SqlDbType.Decimal);
            cmd.Parameters["@cuocphi"].Value = cuocphi;
            cmd.Parameters.Add("@khoiluong", SqlDbType.Decimal);
            cmd.Parameters["@khoiluong"].Value = khoiluong;
            cmd.Parameters.Add("@thoihangiao", SqlDbType.NVarChar);
            cmd.Parameters["@thoihangiao"].Value = thoihangiao;
            cmd.Parameters.Add("@ghichu", SqlDbType.NVarChar);
            cmd.Parameters["@ghichu"].Value = ghichu;
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void XoaDonHang(string madh)
        {
            string sql = @"SP_XoaDonHang";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@madh", SqlDbType.NVarChar).Value = madh;
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void SuaDonHang(string madh, string makh, string mann, string manv, string cuocphi, string khoiluong, string thoihangiao, string ghichu)
        {
            string sql = @"SP_SuaDonHang";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@madh", SqlDbType.NVarChar).Value = madh;
            cmd.Parameters.Add("@makh", SqlDbType.NVarChar).Value = makh;
            cmd.Parameters.Add("@mann", SqlDbType.NVarChar).Value = mann;
            cmd.Parameters.Add("@manv", SqlDbType.NVarChar).Value = manv;
            cmd.Parameters.Add("@cuocphi", SqlDbType.Decimal).Value = cuocphi;
            cmd.Parameters.Add("@khoiluong", SqlDbType.Decimal).Value = khoiluong;
            cmd.Parameters.Add("@thoihangiao", SqlDbType.NVarChar).Value = thoihangiao;
            cmd.Parameters.Add("@ghichu", SqlDbType.NVarChar).Value = ghichu;
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public DataTable LayDSTinhTrangDH()
        {
            DataTable dt = new DataTable();
            string sql = @"SP_LayTinhTrangDH";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter ds = new SqlDataAdapter(cmd);
            ds.Fill(dt);
            con.Close();
            return dt;
        }
        public void SuaTinhTrangDH(string madh, string tinhtrang, string mota)
        {
            string sql = @"SP_SuaTinhTrang";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@madh", SqlDbType.NVarChar).Value = madh;
            cmd.Parameters.Add("@tinhtrang", SqlDbType.NVarChar).Value = tinhtrang;
            cmd.Parameters.Add("@mota", SqlDbType.NVarChar).Value = mota;
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public DataTable LayDSDHChuaGiao()
        {
            DataTable dt = new DataTable();
            string sql = @"SP_LayDSDHChuaGiao";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter ds = new SqlDataAdapter(cmd);
            ds.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable LayNVgiaoHang()
        {
            DataTable dt = new DataTable();
            string sql = @"select manv from NhanVien where maloainv = N'LNV01'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter ds = new SqlDataAdapter(cmd);
            ds.Fill(dt);
            con.Close();
            return dt;
        }
        public void ThemNguoiGiao(string madh, string manv, string tinhtrang, string ghichu)
        {
            string sql = @"SP_ThemNguoiGiao";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@madh", SqlDbType.NVarChar);
            cmd.Parameters["@madh"].Value = madh;
            cmd.Parameters.Add("@manv", SqlDbType.NVarChar);
            cmd.Parameters["@manv"].Value = manv;
            cmd.Parameters.Add("@tinhtrang", SqlDbType.NVarChar);
            cmd.Parameters["@tinhtrang"].Value = tinhtrang;
            cmd.Parameters.Add("@ghichu", SqlDbType.NVarChar);
            cmd.Parameters["@ghichu"].Value = ghichu;
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public DataTable LayDiaChi(string makh)
        {
            DataTable dt = new DataTable();
            string sql = @"SP_LayDiaChi";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@makh", SqlDbType.NVarChar).Value = makh;
            SqlDataAdapter ds = new SqlDataAdapter(cmd);
            ds.Fill(dt);
            con.Close();
            return dt;
        }
        public void CapNhatCuocPhi(string madh, string cuocphi)
        {
            string sql = @"SP_CapNhatCuocPhi";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@madh", SqlDbType.NVarChar).Value = madh;
            cmd.Parameters.Add("@cuocphi", SqlDbType.Decimal).Value = cuocphi;
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public DataTable LaySoLuongDH()
        {
            DataTable dt = new DataTable();
            string sql = @"SP_TKSoLuongDH";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter ds = new SqlDataAdapter(cmd);
            ds.Fill(dt);
            con.Close();
            return dt;
        }
        public DataSet LayDSCacDH()
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.TableMappings.Add("Table", "DHDaGiao");
            string sql = "SP_LayDSDHDaGiao";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            adapter.SelectCommand = cmd;
            DataSet ds = new DataSet("DHDaGiao");
            adapter.Fill(ds);
            SqlDataAdapter DGGadpter = new SqlDataAdapter();
            DGGadpter.TableMappings.Add("Table", "DHDangGiao");
            string sql1 = "SP_LayDSDHDangGiao";
            SqlCommand cmd1 = new SqlCommand(sql1, con);
            cmd1.CommandType = CommandType.StoredProcedure;
            DGGadpter.SelectCommand = cmd1;
            DGGadpter.Fill(ds);
            SqlDataAdapter DCGadpter = new SqlDataAdapter();
            DCGadpter.TableMappings.Add("Table", "DHChuaGiao");
            string sql2 = "SP_LayDSDHChuaGiao";
            SqlCommand cmd2 = new SqlCommand(sql2, con);
            cmd2.CommandType = CommandType.StoredProcedure;
            DCGadpter.SelectCommand = cmd2;
            DCGadpter.Fill(ds);
            con.Close();
            return ds;
        }
        public DataTable LayDSDHDG()
        {
            DataTable dt = new DataTable();
            string sql = "SP_DSDHDG";
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
