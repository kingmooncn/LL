using System;
using System.Data;
using System.Data.OleDb;
using System.Collections;


namespace SqlHelper
{
    /// <summary>
    /// 连接到access数据库
    /// </summary>
    public static class SqlHeper
    {
        public static OleDbConnection connectDatabase ()
        {
            OleDbConnection conn;
            
            conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source="+ System.Environment.CurrentDirectory+"\\data.accdb");
            return conn;
        }
        /// <summary>
        /// 打开access数据库
        /// </summary>
        /// <param name="conn"></param>
        public static void openDbConnection(OleDbConnection conn)
        {
            try
            {
                conn.Open();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <summary>
        /// 关闭数据库连接
        /// </summary>
        /// <param name="conn"></param>
        public static void closeConnection(OleDbConnection conn)
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
                conn.Dispose();
            }
        }

        /// <summary>
        /// 创建OleDbCommand
        /// </summary>
        /// <param name="conn"></param>
        /// <returns></returns>
        public static OleDbCommand openDbCommand(OleDbConnection conn)
        {
            OleDbCommand comm = new OleDbCommand();
            comm.Connection = conn;
            return comm;
        }

        public static void closeDbCommand(OleDbCommand comm)
        {
            comm.Dispose();
        }

        /// <summary>
        /// 执行SQL
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="sqlstr"></param>
        public static void excuteSql( OleDbConnection conn, OleDbCommand comm,   string sqlstr)
        {
            try
            {
                comm.CommandType = CommandType.Text;
                comm.CommandText = sqlstr;
                comm.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }

        /// <summary>
        /// 读取数据库，返回OleDbDataReader
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="sqlstr"></param>
        /// <returns></returns>
        public static OleDbDataReader dataReader(OleDbCommand comm, OleDbConnection conn,   string sqlstr)
        {

            OleDbDataReader dr = null;
            try
            {
                comm.CommandText = sqlstr;
                comm.CommandType = CommandType.Text;
                dr = comm.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch
            {
                try
                {
                    dr.Close();
                    comm.Dispose();
                }
                catch { }
            }
            return dr;
        }


        public static void dataReader(OleDbConnection conn,OleDbCommand comm, string sqlstr, ref OleDbDataReader dr)
        {

            try
            {
                comm.CommandText = sqlstr;
                comm.CommandType = CommandType.Text;
                dr = comm.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch
            {
                try
                {
                    if (dr != null && !dr.IsClosed)
                        dr.Close();
                }
                catch
                {
                }

            }
        }

        /// <summary>
        /// 读取数据库，返回dataset
        /// </summary>
        /// <param name="comm"></param>
        /// <param name="conn"></param>
        /// <param name="sqlstr"></param>
        /// <returns></returns>
        public static DataSet dataSet(OleDbCommand comm, OleDbConnection conn,string sqlstr)
        {
            DataSet ds = new DataSet();
            OleDbDataAdapter da = new OleDbDataAdapter();
            try
            {
                comm.CommandType = CommandType.Text;
                comm.CommandText = sqlstr;
                da.SelectCommand = comm;
                da.Fill(ds);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
            }
            return ds;
        }

        /// <summary>
        /// 返回指定sql语句的dataset
        /// </summary>
        /// <param name="sqlstr"></param>
        /// <param name="ds"></param>
        public static void dataSet(OleDbCommand comm, OleDbConnection conn, string sqlstr, ref DataSet ds)
        {
            OleDbDataAdapter da = new OleDbDataAdapter();
            try
            {
                comm.CommandType = CommandType.Text;
                comm.CommandText = sqlstr;
                da.SelectCommand = comm;
                da.Fill(ds);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
            }
        }

        /// <summary>
        /// 返回指定sql语句的datatable
        /// </summary>
        /// <param name="sqlstr"></param>
        /// <returns></returns>
        public static DataTable dataTable(OleDbCommand comm, OleDbConnection conn, string sqlstr)
        {
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter();
            try
            {
                comm.CommandType = CommandType.Text;
                comm.CommandText = sqlstr;
                da.SelectCommand = comm;
                da.Fill(dt);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return dt;
        }

        /// <summary>
        /// 返回指定sql语句的datatable
        /// </summary>
        /// <param name="sqlstr"></param>
        /// <param name="dt"></param>
        public static void dataTable(OleDbCommand comm, OleDbConnection conn, string sqlstr, ref DataTable dt)
        {
            OleDbDataAdapter da = new OleDbDataAdapter();
            try
            {
                comm.CommandType = CommandType.Text;
                comm.CommandText = sqlstr;
                da.SelectCommand = comm;
                da.Fill(dt);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <summary>
        /// 返回指定sql语句的dataview
        /// </summary>
        /// <param name="sqlstr"></param>
        /// <returns></returns>
        public static DataView dataView(OleDbCommand comm, OleDbConnection conn, string sqlstr)
        {
            OleDbDataAdapter da = new OleDbDataAdapter();
            DataView dv = new DataView();
            DataSet ds = new DataSet();
            try
            {
                comm.CommandType = CommandType.Text;
                comm.CommandText = sqlstr;
                da.SelectCommand = comm;
                da.Fill(ds);
                dv = ds.Tables[0].DefaultView;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return dv;
        }

        /// <summary>
        /// 将数据读取到dataview dv中
        /// </summary>
        /// <param name="comm"></param>
        /// <param name="conn"></param>
        /// <param name="sqlstr"></param>
        /// <param name="dv"></param>
        public static void dataView(OleDbCommand comm, OleDbConnection conn, string sqlstr,DataView dv)
        {
            OleDbDataAdapter da = new OleDbDataAdapter();
            DataSet ds = new DataSet();
            try
            {
                comm.CommandType = CommandType.Text;
                comm.CommandText = sqlstr;
                da.SelectCommand = comm;
                da.Fill(ds);
                dv = ds.Tables[0].DefaultView;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

    }

}