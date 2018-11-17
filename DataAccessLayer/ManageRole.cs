using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
   public class ManageRole
    {
        SqlConnection conn = new SqlConnection(ConnectionClass.ConnectionString);
        public int ManageRoles(int roleid, string userrolename, string roledescription, int mode)
        {

            try
            {
                int result = 0;
                SqlCommand cmd = new SqlCommand("SP_ManageUserRole", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@userRoleId", roleid);
                cmd.Parameters.AddWithValue("@userRole", userrolename);
                cmd.Parameters.AddWithValue("@roleDescription", roledescription);
                cmd.Parameters.AddWithValue("@mode", mode);
                conn.Open();
                result = cmd.ExecuteNonQuery();
                conn.Close();
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { conn.Close(); }

        }
        public DataTable getalluserroles()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("select * from UserRoleTable",conn);
                cmd.CommandType = CommandType.Text;
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                conn.Close();
                return dt;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { conn.Close(); }
        }


    }
}
