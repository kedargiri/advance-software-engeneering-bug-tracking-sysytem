using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DataAccessLayer
{
    public class BugEntryClass
    {
        SqlConnection conn = new SqlConnection(ConnectionClass.ConnectionString);
        public int manageBugs(int bugId,
           DateTime bugIdentifiedDate,
           int memberId,
           int projectId,
           String classLibraryName,
           String className,
           String methodName,
           String blockName,
           String lineNumber,
           String bugDetails,
           byte[] snapShotOfBugMessage,
           String codeContainingBug,
           int mode)
        {
            try
            {
                int result = 0;
                SqlCommand cmd = new SqlCommand("SP_ManageBugs", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@bugId", bugId);
                cmd.Parameters.AddWithValue("@bugIdentifiedDate", bugIdentifiedDate);
                cmd.Parameters.AddWithValue("@memberId", memberId);
                cmd.Parameters.AddWithValue("@projectId", projectId);
                cmd.Parameters.AddWithValue("@classLibraryName", classLibraryName);
                cmd.Parameters.AddWithValue("@className", className);
                cmd.Parameters.AddWithValue("@methodName", methodName);
                cmd.Parameters.AddWithValue("@blockName", blockName);
                cmd.Parameters.AddWithValue("@lineNumber", lineNumber);
                cmd.Parameters.AddWithValue("@bugDetails", bugDetails);
                cmd.Parameters.AddWithValue("@snapShotOfBugMessage", snapShotOfBugMessage);
                cmd.Parameters.AddWithValue("@codeContainingBug", codeContainingBug);
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


    }
}
