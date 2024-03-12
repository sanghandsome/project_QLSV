using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using System.Data;

namespace QLSV
{
    public class Database
    {
        private string connectionString = @"Data Source=SANG;Initial Catalog=QLSV;Integrated Security=True;Encrypt=False";
        private SqlConnection conn;
        private string sql;
        private DataTable dt;
        private SqlCommand cmd;
        public Database()
        {
            try
            {
                conn = new SqlConnection(connectionString);
                conn.Open();
            }
            catch(Exception ex) {
                MessageBox.Show("connected failed: "+ ex.Message);
            }
        }
        public DataTable SelectData(string sql,List<CustomParameter> lstParameter)
        {  
            try
            {
                cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                foreach(var para  in lstParameter)
                {
                    cmd.Parameters.AddWithValue(para.key, para.value);
                }
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi load du lieu: " + ex.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
        public DataRow Select(string sql)
        {
            try
            {
                
                cmd = new SqlCommand(sql,conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt.Rows[0];
            }
            catch(Exception ex ) {
                MessageBox.Show("Lỗi Load Thông Tin Chi Tiết: " + ex.Message );
                return null;
            }
            finally
            {
                conn.Close ();
            }
        }
        public int ExeCute(string sql, List<CustomParameter> lstParameter)
        {
            try
            {
              
                cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                foreach(var p in lstParameter)
                {
                    cmd.Parameters.AddWithValue(p.key,p.value);
                }
                var rs = cmd.ExecuteNonQuery();
                return  (int)rs;
            }
            catch( Exception ex )
            {
                MessageBox.Show("Lỗi Thực Thi Câu Lênh: " + ex.Message);
                return -100;
            }
            finally
            {
                conn.Close ();
            }
        }

    }
}
