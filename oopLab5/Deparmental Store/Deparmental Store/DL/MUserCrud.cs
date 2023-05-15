using Deparmental_Store.BL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Deparmental_Store.DL
{
    public  class MUserCrud
    {
        public static List<MUser> user = new List<MUser>();

        public static void addUserIntoUserList(MUser suerObj)
        {
             user.Add(suerObj);
        }



       
    }
}
