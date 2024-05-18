using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products_Management.BL
{
     class CLS_LOGIN
    {
        public DataTable LOGIN(string ID,string PWD)
        {
            DAL.DataAccessLayer DAL= new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@ID",SqlDbType.VarChar);
            param[0].Value = ID;

            param[1] = new SqlParameter("@PWD",SqlDbType.VarChar);
            param[1].Value = PWD;

            DAL.open();
            DataTable Dt=new DataTable();

            Dt = DAL.SelectData("SP_LOGIN",param);
            DAL.close();
            return Dt;
        }
    }
}
