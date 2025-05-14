using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_Commerce_RealTime_App;

namespace E_Commerce_Console_App_RealTime
{
    internal interface E_CommerceInterface
    {
        void AdminLogin();
    }

    public class E_CommerceMethods : E_CommerceInterface
    {
        public void AdminLogin()
        {
            string AdminFilePath = @"D:\FileHandling\E_Commerce\Admin.txt";


            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("                                 --------->> Welcome Admin <<---------                                 ");
            Console.ResetColor();
            Console.WriteLine();
            AdminUserName:
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Enter the User Admin Name : ");
            Console.ResetColor();
            string AdminUserName = Console.ReadLine();


            if (File.Exists(AdminFilePath))
            {
                foreach (string i in File.ReadAllLines(AdminFilePath))
                {
                    string[] admin = i.Split(',');
                    if (admin[0] == AdminUserName)
                    {
                        Password:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("Enter Admin Password : ");
                        Console.ResetColor();

                        string password = Console.ReadLine();

                        if (admin[1] == password)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Authorized :)");
                            Console.ResetColor();

                            Admin _admin = new Admin();
                            _admin.AdminPanel();


                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalid Password! Please Enter the Valid Password");
                            Console.ResetColor();
                            goto Password;
                        }
                       
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid Admin User Name. Enter the Correct Admin User Name ");
                        Console.ResetColor();
                        goto AdminUserName;
                    }
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("The admin database is disconnected.Please verify the path and reconnect");
                Console.ResetColor();
                Console.WriteLine();
            }
        }
    }
}
