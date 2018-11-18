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
                cmd.Parameters.AddWithValue("@userPassword", UserPassword);
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


        //public DataTable getAllUsers()
        //{
        //    try
        //    {
        //        DataTable dt = new DataTable();
        //        SqlCommand cmd = new SqlCommand("select u.userId as Id,m.memberName as Name,u.userName as Username,u.userPassword as Password, r.userRole as Role from UserTable u, MemberTable m, UserRoleTable r where u.userRoleId=r.userRoleId and u.memberId=m.memberId", conn);
        //        cmd.CommandType = CommandType.Text;
        //        conn.Open();
        //        SqlDataReader dr = cmd.ExecuteReader();
        //        dt.Load(dr);
        //        conn.Close();
        //        return dt;
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //    finally { conn.Close(); }
        //}
        //public DataTable userType(String userName, String userPassword)
        //{
        //    try
        //    {
        //        DataTable dt = new DataTable();
        //        SqlCommand cmd = new SqlCommand("select userRole from UserRoleTable where userRoleId=(select userRoleId from UserTable where userName=@userName and userPassword=@userPassword)", conn);
        //        cmd.CommandType = CommandType.Text;
        //        cmd.Parameters.AddWithValue("@userName", userName);
        //        cmd.Parameters.AddWithValue("@userPassword", userPassword);
        //        conn.Open();
        //        SqlDataReader dr = cmd.ExecuteReader();
        //        dt.Load(dr);
        //        conn.Close();

        //        return dt;
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //    finally { conn.Close(); }
        //}

        //public DataTable getAllMembers()
        //{
        //    try
        //    {
        //        DataTable dt = new DataTable();
        //        SqlCommand cmd = new SqlCommand("Select * from MemberTable", conn);
        //        conn.Open();
        //        SqlDataReader dr = cmd.ExecuteReader();
        //        dt.Load(dr);
        //        conn.Close();
        //        return dt;
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //    finally { conn.Close(); }

        //}

        //public DataTable getAllUserRoles()
        //{
        //    try
        //    {
        //        DataTable dt = new DataTable();
        //        SqlCommand cmd = new SqlCommand("SELECT * FROM UserRoleTable", conn);
        //       cmd .CommandType = CommandType.Text;
        //        conn.Open();
        //        SqlDataReader dataReaderToGetAllTheRoleInformation = cmd.ExecuteReader();
        //        dt.Load(dataReaderToGetAllTheRoleInformation);
        //        conn.Close();
        //        return dt;
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }




        //}


    }
}
    
