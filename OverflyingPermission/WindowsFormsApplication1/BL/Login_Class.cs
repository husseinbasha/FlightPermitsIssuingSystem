using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsApplication1.BL
{
    class Login_Class
    {
        public DataTable LOGIN(string ID, string Password)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            param[0].Value = ID;

            param[1] = new SqlParameter("@Password", SqlDbType.VarChar, 50);
            param[1].Value = Password;
            DAL.Open();

            //هذه الداله لجلب البيانات من قاعدة البيانات 
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("SP_LOGIN", param);
            DAL.Close();
            return Dt;
        }

        public void Add_User(string ID, string UserFullName, string Password,
              string UserType)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            param[0].Value = ID;

            param[1] = new SqlParameter("@UserFullName", SqlDbType.VarChar, 50);
            param[1].Value = UserFullName;

            param[2] = new SqlParameter("@Password", SqlDbType.VarChar, 50);
            param[2].Value = Password;

            param[3] = new SqlParameter("@UserType", SqlDbType.VarChar, 50);
            param[3].Value = UserType;


            DAL.ExecuteCommand("Add_User", param);
            DAL.Close();

        }
        public void Edit_User(string ID, string UserFullName, string Password,
           string UserType)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            param[0].Value = ID;

            param[1] = new SqlParameter("@UserFullName", SqlDbType.VarChar, 50);
            param[1].Value = UserFullName;

            param[2] = new SqlParameter("@Password", SqlDbType.VarChar, 50);
            param[2].Value = Password;

            param[3] = new SqlParameter("@UserType", SqlDbType.VarChar, 50);
            param[3].Value = UserType;


            DAL.ExecuteCommand("Edit_User", param);
            DAL.Close();

        }

        public void Delete_User(string ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            param[0].Value = ID;
            DAL.ExecuteCommand("Delete_User", param);
            DAL.Close();

        }


        public DataTable SearchUsers(string Criterion)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@Criterion", SqlDbType.VarChar, 50);
            param[0].Value = Criterion;


            Dt = DAL.SelectData("SearchUsers", param);
            DAL.Close();
            return Dt;
        }

    }



}
