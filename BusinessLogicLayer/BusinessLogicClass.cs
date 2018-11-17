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
    }
}
