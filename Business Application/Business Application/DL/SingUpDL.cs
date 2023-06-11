using Business_Application.BL;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Application.DL
{
    public class SingUpDL
    {
        public static List<SingUp> userList=new List<SingUp>();

        public static void adddUSerIntoUserLsit(SingUp user)
        {
            userList.Add(user);
        }

        public static bool isAdminAlreadyResitered(SingUp user)
        {
            int count = 0;

            foreach(SingUp users in  userList)
            {
                if(users.role==user.role)
                {
                    count++;
                }
            }
           return count >= 1 ? true : false;
        }

        public static bool userExist(userLogin lUser) //check user exist
        {
            foreach(SingUp user in userList)
            {
                if(user.name==lUser.name && user.password==lUser.pasword && user.role==lUser.role)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
