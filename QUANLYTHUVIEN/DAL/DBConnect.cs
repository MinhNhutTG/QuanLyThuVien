using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QUANLYTHUVIEN.DTO;

namespace QUANLYTHUVIEN.DAL
{
    public class DBConnect
    {
        SqlConnection sqlConn;
        SqlDataAdapter da;
        DataSet ds;
        public DBConnect()
        {
            string strCnn = "Data source= MinhNhutSoftware\\SQLEXPRESS; Database=QuanLyThuVien; Integrated Security = True";                    // chỉnh lại cái Data source với database của bây
            sqlConn = new SqlConnection(strCnn);
        }
        public DataTable Execute(string sqlStr)
        {
            da = new SqlDataAdapter(sqlStr, sqlConn);
            ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }
        public void ExecuteNonQuery(string strSQL)
        {
            SqlCommand sqlcmd = new SqlCommand(strSQL, sqlConn);
            sqlConn.Open();
            sqlcmd.ExecuteNonQuery();
            sqlConn.Close();
        }
    }
}
