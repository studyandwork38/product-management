using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Products_Management.BL
{
    class CLS_ADD_PRODUCT
    {
        public DataTable ADD_NEW_PRODUCT()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
        
            DataTable Dt = new DataTable();

            Dt = DAL.SelectData("GET_ALL_CATEGORIES", null);
            DAL.close();
            return Dt;
        }
    }
}
