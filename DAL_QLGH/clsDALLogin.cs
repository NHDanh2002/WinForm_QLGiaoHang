using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QLGH
{
    public class clsDALLogin
    {
        SqlConnection con = new SqlConnection(@"Data Source=MSI\;Initial Catalog=QLGiaoHang;Integrated Security=True");
        public DataTable Login()
        {
            DataTable dt = new DataTable();
            string sql = "Select * From TaiKhoan";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter ds = new SqlDataAdapter(cmd);
            ds.Fill(dt);
            con.Close();
            return dt;
        }
    }
}
