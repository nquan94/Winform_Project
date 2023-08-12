using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Bai_4
{
    class KetNoi
    {
        string constr = @"Data Source=NGUYEN-QUAN\SQLEXPRESS;Initial Catalog=PhongMay;Integrated Security=True";
        SqlConnection conn;

        public KetNoi()
        {
            conn = new SqlConnection(constr);
        }
        
        public DataTable Laydulieu(string truyvan)
        {
            SqlDataAdapter da = new SqlDataAdapter(truyvan, conn);
            DataTable tb = new DataTable();
            da.Fill(tb);
            return tb;
        }
        public bool thucthi(string truyvan)
        {
            int r = 0;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(truyvan, conn);
                r = cmd.ExecuteNonQuery();
            }
            catch
            {

            }

            finally { conn.Close(); }
            return r > 0;
        }
    }
}
