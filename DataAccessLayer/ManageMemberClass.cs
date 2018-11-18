using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
   public class ManageMemberClass
    {
        SqlConnection conn= new SqlConnection(ConnectionClass.ConnectionString);
        public int ManageMembers(int memberId,
            String memberName,
            String memberAddress,
            String contactNumber,
            String emailAddress,
            String gender,
            DateTime dateOfBirth,
            DateTime dateOfJoin,
            String memberDesignation,
            byte[] profilePicture,
            int Mode)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SP_ManageMembers", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@memberId", memberId);
                cmd.Parameters.AddWithValue("@memberName", memberName);
                cmd.Parameters.AddWithValue("@memberAddress", memberAddress);
                cmd.Parameters.AddWithValue("@contactNumber", contactNumber);
                cmd.Parameters.AddWithValue("@emailAddress", emailAddress);
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.Parameters.AddWithValue("@dateOfBirth", dateOfBirth);
                cmd.Parameters.AddWithValue("@dateOfJoin", dateOfJoin);
                cmd.Parameters.AddWithValue("@memberDesignation", memberDesignation);
                cmd.Parameters.AddWithValue("@profilePicture", profilePicture);
                cmd.Parameters.AddWithValue("@Mode", Mode);
                conn.Open();
                int result = cmd.ExecuteNonQuery();
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
