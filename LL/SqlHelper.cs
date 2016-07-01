using System;
using System.Data;
using System.Data.OleDb;
using System.Collections;


namespace SqlHelper
{
    public static class SqlHeper
    {
        static OleDbConnection ConnectDatabase ()
        {
            OleDbConnection conn;
            conn = new OleDbConnection(@"Provider='Microsoft.Jet.OLEDB.4.0';Data Source='"  + @"/para.accdb'");
            return conn;
        }

    }

}