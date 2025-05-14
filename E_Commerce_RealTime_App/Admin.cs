using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce_RealTime_App
{
    class Product
    {

    }
    internal class Admin
    {
        public void AdminPanel()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("------------------------------------------- ** Admin Panel ** -----------------------------------------");
            Console.ResetColor();
            Console.WriteLine("                                            1. Add the Products                                        ");
            Console.WriteLine("                                            2. Update the Product                                      ");
            Console.WriteLine("                                            3. Delete the Product                                      ");
            Console.WriteLine("                                            4. View All the Products                                   ");
            Console.WriteLine("                                            5. View All the Orders                                     ");
            Console.WriteLine("                                            6. Exit                                                    ");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("-------------------------------------------------------------------------------------------------------");
            Console.ResetColor();
            Console.WriteLine();

            int Choice = 0;
            Choice:
            try
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Enter the Choice : ");
                Console.ResetColor();

                int choice = int.Parse(Console.ReadLine());

                if (choice == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid choice! Choice must not be Zero");
                    Console.ResetColor();
                    goto Choice;
                }
                if (choice > 6)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid choice! Choice must be between 1 and 4");
                    Console.ResetColor();
                    goto Choice;
                }

                Choice = choice;
            }
            catch (FormatException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid choice! Input must not contain characters, symbols, or whitespace");
                Console.ResetColor();
                goto Choice;
            }
            catch (OverflowException e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid choice! Please Enter the Valid Choice");
                Console.ResetColor();
                goto Choice;
            }

           
        }
    }
}
