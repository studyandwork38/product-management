using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Products_Management.DAL
{
     class DataAccessLayer
    {
        SqlConnection sqlconnection;
        
        public DataAccessLayer()
        {
            sqlconnection = new SqlConnection(@"Server=.\SQLEXPRESS ; Database=Product_DB ; Integrated Security=true");

        }

        //method to open connection 

        public void open()
        {
          if(sqlconnection.State != ConnectionState.Open) { 
            sqlconnection.Open();
            }
        }

        //method to close connection 

        public void close()
        {
          if(sqlconnection.State == ConnectionState.Open) { 
            sqlconnection.Close();
            }
        }

        //method to read data from database

        public DataTable SelectData(string stored_Procedure, SqlParameter[] param)
        {
            SqlCommand sqlcmd=new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = stored_Procedure;
            if(param != null )
            {
                foreach( SqlParameter p in param )
                {
                    sqlcmd.Parameters.Add( p );
                }
            }
            SqlDataAdapter da = new SqlDataAdapter(sqlcmd);

            DataTable dt= new DataTable();
            dt.Fill(da);
            return dt;

        }
    }
}
