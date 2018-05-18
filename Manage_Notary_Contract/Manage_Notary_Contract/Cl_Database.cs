using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manage_Notary_Contract 
{
    public class Cl_Database : IDisposable
    {
        SqlConnection cnn;
        SqlCommand cmd;
        SqlDataAdapter da;

        static string s = Environment.MachineName;
        string ConnectionString = "Server=" + s +";database=Notary_Contract;integrated security=true";


        public void Dispose()
        {
            if (cnn != null)
            {
                cnn.Dispose();
                cnn = null;
            }
            if (cmd != null)
            {
                cmd.Dispose();
                cmd = null;
            }
            if (da != null)
            {
                da.Dispose();
                da = null;
            }

        }
        public Cl_Database()
        {
            cnn = new SqlConnection(ConnectionString);
        }
        public bool KiemTraKetNoi(ref string err)
        {
            try
            {
                cnn.Open();
                return true;
            }
            catch(Exception ex)
            {
                err = ex.Message;
                return false;
            }
        }
        
        public DataTable getDataTable(ref string err, string sql, CommandType type, params SqlParameter[] param)
        {
            DataTable dt = null;
            try
            {
                if (cnn.State == ConnectionState.Open)
                    cnn.Close();
                cnn.Open();
                cmd = new SqlCommand(sql,cnn);
                cmd.CommandType = type;
                cmd.CommandTimeout = 600;
                cmd.Parameters.Clear();
                if(param != null)
                {
                    foreach(SqlParameter pa in param){
                        cmd.Parameters.Add(pa);
                    } 
                }
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                err = ex.Message;
            }
            finally
            {
                cnn.Close();
            }
            return dt;  
        }
        public bool ExNonQueryData(ref string err, string sql, CommandType type, params SqlParameter[] param)
        {
            try
            {
                if (cnn.State == ConnectionState.Open)
                    cnn.Close();
                cnn.Open();
                cmd = new SqlCommand(sql, cnn);
                cmd.CommandType = type;
                cmd.CommandTimeout = 600;
                cmd.Parameters.Clear();
                if (param != null)
                {
                    foreach (SqlParameter pa in param)
                    {
                        cmd.Parameters.Add(pa);
                    }
                }
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
            }
            finally
            {
                cnn.Close();
            }
            return false;
        }
        public object getDataScalar(ref string err, string sql, CommandType type, params SqlParameter[] param)
        {
            object ob = null;
            try
            {
                if (cnn.State == ConnectionState.Open)
                    cnn.Close();
                cnn.Open();
                cmd = new SqlCommand(sql, cnn);
                cmd.CommandType = type;
                cmd.CommandTimeout = 600;
                cmd.Parameters.Clear();
                foreach(SqlParameter p in param)
                {
                    cmd.Parameters.Add(p);
                }
                ob = cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                err = ex.Message;
            }
            finally
            {
                cnn.Close();
            }
            return ob;
        }
        public SqlDataReader GetDataSqlReader(ref string err, string sql, CommandType type, params SqlParameter[] param)
        {
            SqlDataReader dataReader = null;
            try
            {
                if (cnn.State == ConnectionState.Open)
                    cnn.Close();
                cnn.Open();
                cmd = new SqlCommand(sql, cnn);
                cmd.CommandType = type;
                cmd.CommandTimeout = 600;
                cmd.Parameters.Clear();
                foreach(SqlParameter p in param)
                {
                    cmd.Parameters.Add(p);
                }
                dataReader = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {

                err = ex.Message;
            }
            finally
            {
                
                cnn.Close();
            }
            return dataReader;
        }
    }
}
