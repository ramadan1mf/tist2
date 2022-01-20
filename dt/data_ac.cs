using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace dataproo.dt
{
    class data_ac
    {
        SqlConnection sqlconn;

        public data_ac()
        {
            sqlconn = new SqlConnection(@"Data Source=dataproo.mssql.somee.com;Integrated Security=False;User ID=dataproo_SQLLogin_1;Password=hnxn1f8bfz;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
        public void open()
        {
            if (sqlconn.State != ConnectionState.Open)
            {
                sqlconn.Open();
            }

        }
        public void close()
        {
            if (sqlconn.State == ConnectionState.Open)
            {
                sqlconn.Close();
            }
        }
        //public DataTable slcdata(string stored_procedure, SqlParameter[] param)
        //{
        //    SqlCommand sqlcmd = new SqlCommand();
        //    sqlcmd.CommandType = CommandType.StoredProcedure;
        //    sqlcmd.CommandText = stored_procedure;
        //    sqlcmd.Connection = sqlconn;

        //    if (param != null)
        //        for (int i = 0; i < param.Length; i++)
        //        {
        //            sqlcmd.Parameters.Add(param[i]);
        //        }
        //}
        //SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
        //DataTable dt = new DataTable();
        //da.Fill (dt);
        //return dt;  
              
    }
}
