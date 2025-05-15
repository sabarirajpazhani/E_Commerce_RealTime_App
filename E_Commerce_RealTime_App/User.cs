using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_Commerce_Console_App_RealTime;

namespace E_Commerce_RealTime_App
{
    internal class User
    {
        public static Hashtable Order = new Hashtable();    
        public void UserProduct()
        {
            while (true)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("---------------------------------------- ** Shoping Panel **-------------------------------------------");
                Console.ResetColor();
                Console.WriteLine();

                Console.WriteLine("                                         1. Order the Product                                          ");
                Console.WriteLine("                                         2. View the Order                                             ");
                Console.WriteLine("                                         3. View the Cart                                              ");
                Console.WriteLine("                                         4. Exit                                                       ");

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
                        Console.Write("Invalid Choice! Choice must not be Zero");
                        Console.ResetColor();
                        Console.WriteLine();
                        goto Choice;
                    }
                    if (choice > 3)
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

                E_CommerceInterface _E_CommerceMethods = new E_CommerceMethods();

                switch (Choice)
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("                           You have selected option '1' to Order the Product                           ");
                        Console.ResetColor();
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("-------------------------------------------------------------------------------------------------------");
                        Console.ResetColor();
                        Console.WriteLine();

                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("                                          List Of Products                                             ");
                        Console.ResetColor();
                        Console.WriteLine();

                        _E_CommerceMethods.DisplayAllProducts(Admin.ProductDetails);
                        ID:
                        try
                        {
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("Enter the Product ID : ");
                            Console.ResetColor();
                            int productId = int.Parse(Console.ReadLine());

                            if (!Admin.ProductDetails.ContainsKey(productId))
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Product ID Not Found");
                                Console.ResetColor();
                                goto ID;
                            }

                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("                                    -------- Choice the Option --------                                ");
                            Console.ResetColor();
                            Console.WriteLine();
                            Console.WriteLine("                                      1. Purchase the Product (Order)                                  ");
                            Console.WriteLine("                                      2. Add into Cart                                                 ");
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("                                    -----------------------------------                                ");
                            Console.ResetColor();
                            Console.WriteLine();
                        Option:
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("Enter the Choice : ");
                            Console.ResetColor();
                            int choice = int.Parse(Console.ReadLine()); 

                            if(choice == 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Invalid Choice! Choice must not be Zero");
                                Console.ResetColor();
                                goto Option;
                            }

                            if(choice > 2)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Invalid Choice! Enter the Correct Choice");
                                Console.ResetColor();
                                goto Option;
                            }

                            if(choice == 1)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine("                                    -------- Purchasing Product --------                                ");
                                Console.ResetColor();
                                Console.WriteLine();

                                Product product = (Product)Admin.ProductDetails[productId];
                                //var product = (Product) Admin.ProductDetails[i];

                                Console.ForegroundColor = ConsoleColor.Magenta;
                                Console.WriteLine("                                               Products Details                                          ");
                                Console.ResetColor();
                                Console.WriteLine();
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.Write("                                          Product ID         : ");
                                Console.ResetColor();
                                Console.WriteLine(product.Product_ID);
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.Write("                                          Product Name       : ");
                                Console.ResetColor();
                                Console.WriteLine(product.ProductName);
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.Write("                                          Product Category   : ");
                                Console.ResetColor();
                                Console.WriteLine(product.ProductCategory);
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.Write("                                          Product Price      : ");
                                Console.ResetColor();
                                Console.WriteLine(product.ProductPrice);
                                Console.WriteLine();
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine("                                                   Description                                                ");
                                Console.ResetColor();
                                Console.WriteLine(product.ProductDescription);

                                Console.WriteLine();
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine("                                    ------------------------------------                                ");
                                Console.ResetColor();
                                Console.WriteLine();






                            }




                        }
                        catch(FormatException e)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalid ID! Product ID must not contain letters, symbols, or whitespace.");
                            Console.ResetColor();
                            goto ID;
                        }
                        catch(OverflowException e)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalid ID! Please enter the correct Product ID as per the given data.");
                            Console.ResetColor();
                            goto ID;
                        }


                        break;
                }
            }
        }
    }
}
