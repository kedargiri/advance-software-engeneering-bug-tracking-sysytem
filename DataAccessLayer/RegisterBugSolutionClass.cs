using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
   public class RegisterBugSolutionClass
    {
        SqlConnection conn = new SqlConnection(ConnectionClass.ConnectionString);

        public int manageBugSolutions(int bugSolutionId,
            DateTime dateOfSolutionIdentified,
            int projectId,
            int bugId,
            int memberId,
            String solutionDetails,
            String codeAfterFixingBug,
            int Mode)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SP_ManageBugSolutions", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@bugSolutionId", bugSolutionId);
               cmd.Parameters.AddWithValue("@dateOfSolutionIdentified", dateOfSolutionIdentified);
                cmd.Parameters.AddWithValue("@projectId", projectId);
                cmd.Parameters.AddWithValue("@bugId", bugId);
                cmd.Parameters.AddWithValue("@memberId", memberId);
                cmd.Parameters.AddWithValue("@solutionDetails", solutionDetails);
                cmd.Parameters.AddWithValue("@codeAfterFixingBug", codeAfterFixingBug);
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
