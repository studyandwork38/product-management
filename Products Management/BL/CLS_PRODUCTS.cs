using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Products_Management.BL
{
    class CLS_PRODUCTS
    {
        public DataTable GET_ALL_CATEGORIES()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
        
            DataTable Dt = new DataTable();

            Dt = DAL.SelectData("GET_ALL_CATEGORIES", null);
            DAL.close(); 
            return Dt;
        }

        public void ADD_PRODUCT(int ID_CAT,string ID_PRODUCT,string LABEL,int QTE,string PRICE,byte[] IMG)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param= new SqlParameter[6];

            param[0] = new SqlParameter("@ID_CAT", SqlDbType.Int);
            param[0].Value = ID_CAT;

            param[1] = new SqlParameter("@ID_PRODUCT", SqlDbType.VarChar,30);
            param[1].Value = ID_PRODUCT;
            param[2] = new SqlParameter("@LABEL", SqlDbType.VarChar, 30);
            param[2].Value=LABEL;
            param[3] = new SqlParameter("@QTE", SqlDbType.Int);
            param[3].Value = QTE;
            param[4]= new SqlParameter("@PRICE",SqlDbType.VarChar,50);
            param[4].Value=PRICE;
            param[5] = new SqlParameter("@IMG", SqlDbType.Image);
            param[5].Value = IMG;

            DAL.ExcuteCommand("ADD_PRODUCT", param);
            DAL.close();
        }
    }
}
