using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
   public class ManageUser
    {
        SqlConnection conn = new SqlConnection(ConnectionClass.ConnectionString);
        public int Manageusers(int UserId, int UserRoleId, int MemberId, string UserName, string UserPassword, int Mode)
        {
            try
            {
                int result = 0;
                SqlCommand cmd = new SqlCommand("SP_ManageUsers", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@userId", UserId);
                cmd.Parameters.AddWithValue("@userRoleId", UserRoleId);
                cmd.Parameters.AddWithValue("@memberId", MemberId);
                cmd.Parameters.AddWithValue("@userName", UserName);
                cmd.Parameters.AddWithValue("@mode", Mode);
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
    }
}
