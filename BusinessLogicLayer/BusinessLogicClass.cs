using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
namespace BusinessLogicLayer
{
    public class BusinessLogicClass
    {
        ManageRole mr = new ManageRole();
        ManageUser mu = new ManageUser();
        ManageMemberClass mc = new ManageMemberClass();
        ProjectManagementClass pmc = new ProjectManagementClass();
        ProjectMemberClass PMC = new ProjectMemberClass();
        BugEntryClass bec = new BugEntryClass();
        RegisterBugSolutionClass rb = new RegisterBugSolutionClass();
        public bool ManageRoles(int roleid, string userrolename, string roledescription, int mode)
        {
            try
            {
                bool result = false;
                int x = mr.ManageRoles(roleid, userrolename, roledescription, mode);
                   if(x>0)
                    result = true;
                else
                    result = false;

                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool Manageusers(int UserId, int UserRoleId, int MemberId, string UserName, string UserPassword, int Mode)
        {
            try
            {
                bool result = false;
                int a = mu.Manageusers(UserId, UserRoleId, MemberId, UserName, UserPassword, Mode);
                if (a > 0)
                    result = true;
                else
                    result = false;
                    
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public bool ManageMembers(int memberId,
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
                bool result = false;
                int b=mc.ManageMembers(memberId,
                    memberName,
                    memberAddress,
                    contactNumber,
                    emailAddress,
                    gender,
                    dateOfBirth,
                    dateOfJoin,
                    memberDesignation,
                    profilePicture,
                    Mode);
                if (b > 0)
                    result = true;
                else
                    result = false;

                return result;
            }
            catch (Exception ex)
            {


                throw ex;
            }
         }

        public bool manageProjects(int projectId,
         String projectName,
         DateTime projectStartDate,
         DateTime projectEndDate,
         String projectDescription,
         int mode)
        {

            try
            {
                bool result = false;
                int rs = pmc.manageProjects(projectId, projectName, projectStartDate, projectEndDate, projectDescription, mode);
                if (rs > 0)
                    result = true;
                else
                    result = false;

                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
       public bool manageProjectMembers(int id,
      int projectid,
      int memberid,
      String memberRole,
      String memberResponsibilities,
      int Mode)
        {
            try
            {
               bool result= false;
                int rs = PMC.manageMembersInProject(id,projectid,memberid, memberRole, memberResponsibilities,Mode);
                if(rs>0)
                    result =true;
                else
                result= false;



                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public bool manageBugs(int bugId,
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
                int rs = bec.manageBugs(bugId, bugIdentifiedDate, memberId, projectId, classLibraryName, className, methodName, blockName, lineNumber, bugDetails, snapShotOfBugMessage, codeContainingBug, mode);
                if (rs > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool manageBugSolutions(int bugSolutionId,
            DateTime dateOfSolutionIdentified,
            int projectId,
            int bugId,
            int memberId,
            string solutionDetails,
            string codeAfterFixingBug,
            int mode)
        {
            try
            {
                int rs = rb.manageBugSolutions(bugSolutionId, dateOfSolutionIdentified, projectId, bugId, memberId, solutionDetails, codeAfterFixingBug, mode);
                if (rs > 0)
                    return true;
                else return false;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }



    }  
    }

