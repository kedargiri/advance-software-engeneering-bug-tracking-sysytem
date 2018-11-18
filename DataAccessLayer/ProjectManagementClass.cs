using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
  public  class ProjectManagementClass
    {
        SqlConnection conn = new SqlConnection(ConnectionClass.ConnectionString);
        public int manageProjects(int projectId,
          String projectName,
          DateTime projectStartDate,
          DateTime projectEndDate,
          String projectDescription,
          int mode)
        {
            try
            {
                int result = 0;
                SqlCommand cmd = new SqlCommand("SP_ManageProjects", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@projectId", projectId);
                cmd.Parameters.AddWithValue("@projectName", projectName);
               cmd.Parameters.AddWithValue("@projectStartDate", projectStartDate);
                cmd.Parameters.AddWithValue("@projectEndDate", projectEndDate);
                cmd.Parameters.AddWithValue("@ProjectDescription", projectDescription);
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
