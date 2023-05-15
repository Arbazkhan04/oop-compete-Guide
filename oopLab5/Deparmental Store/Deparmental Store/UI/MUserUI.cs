using Deparmental_Store.BL;
using Deparmental_Store.DL;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deparmental_Store.UI
{
    public class MUserUI
    {

       public static  void loginScreenMenu()
        {
            Console.WriteLine("--------login menu -----------");
            Console.WriteLine("1-SignUp ");
            Console.WriteLine("2-SignIn");
            Console.WriteLine("3-Exit");
        }

        public static int getInput()
        {
            Console.WriteLine("Enter your option ");
            int opt = int.Parse(Console.ReadLine());
            return opt;
        }

        public static void singUp()
        {

            Console.Write("Enter you name");
            string name = Console.ReadLine();
            Console.Write("Enter your password ");
            string  password = Console.ReadLine();
            Console.Write("Enter your role ");
            string role= Console.ReadLine();
            if(role=="admin")
            {
                MUser user = new MUser(name, password, role);
                storeLoginDataIntoTheFileWithAdmin(user);
                MUserCrud.addUserIntoUserList(user);
            }
            else if(role=="user")
            {
                MUser user = new MUser(name, password);
                storeLoginDataIntoTheFileWithoutAdmin(user);
                MUserCrud.addUserIntoUserList(user);
            }
            else
            {
                Console.WriteLine("Enter coorect role in lower case");
            }
            
            Console.ReadKey();

        }


        public static  void singIn()
        {
            bool isExist = false;
           
            Console.Write("Enter your name");
            String UName = Console.ReadLine();
            Console.Write("Enter your password ");
            String UPass = Console.ReadLine();
            for (int i = 0; i < MUserCrud.user.Count; i++)
            {
                if (MUserCrud.user[i].name == UName && MUserCrud.user[i].password == UPass)
                {
                    isExist = true;
                    AdminProductUI.navigationForAdmin();
                    Console.Write("User Exist ");
                }
               else if (MUserCrud.user[i].name == UName && MUserCrud.user[i].password == UPass&& MUserCrud.user[i].role=="admin")
                {
                    isExist = true;
                    Console.Write("User Exist ");
                }
            }
           
           if(!isExist)
            {
                Console.Write("user not exist ");
            }
            
            
            Console.ReadKey();
        }



        public static  void storeLoginDataIntoTheFileWithoutAdmin(MUser userObj)
        {
            String path = "C:\\Users\\Arbaz khan\\Desktop\\MUser.txt";
            StreamWriter file = new StreamWriter(path, true);

            file.WriteLine(userObj.name + "," + userObj.password);
            file.Flush();
            file.Close();
        }

        public  static void storeLoginDataIntoTheFileWithAdmin(MUser userObj)
        {
            String path = "C:\\Users\\Arbaz khan\\Desktop\\MUser.txt";
            StreamWriter file = new StreamWriter(path, true);

            file.WriteLine(userObj.name + "," + userObj.password + "," + userObj.role);
            file.Flush();
            file.Close();
        }


        public static void loadLoginDataIntoArray()
        {
            String path = "C:\\Users\\Arbaz khan\\Desktop\\MUser.txt";
            if (File.Exists(path))
            {
                StreamReader file = new StreamReader(path);
                String record;
                while ((record = file.ReadLine()) != null)
                {
                    if (parseData(record, 3) == "admin")
                    {
                        string name = parseData(record, 1);
                        //Console.Write(name[totalUser]);
                        string password = parseData(record, 2);
                        string role = parseData(record, 3);

                        MUser user = new MUser(name, password, role);

                        MUserCrud.addUserIntoUserList(user);
                    }

                    else
                    {
                        string name = parseData(record, 1);
                        //Console.Write(name[totalUser]);
                        string password = parseData(record, 2);
                        MUser user = new MUser(name, password);

                        MUserCrud.addUserIntoUserList(user);
                        
                    }
                }

                file.Close();
            }
            else
            {
                Console.Write("Path not exist ");
            }

        }

        static String parseData(string data, int line)
        {
            int commaCount = 1;
            String item = "";
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == ',')
                {
                    commaCount++;
                }
                else if (commaCount == line)
                {
                    item += data[i];
                }
            }
            return item;
        }

    }
}
