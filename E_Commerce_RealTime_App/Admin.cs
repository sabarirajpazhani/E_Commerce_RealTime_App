using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_Commerce_Console_App_RealTime;
using E_Commerce_RealTime_App.Exceptions;

namespace E_Commerce_RealTime_App
{
    class Product
    {
        public int Product_ID { get; set; } 
        public string ProductName { get; set; } 
        public intProductCategory {  get; set; }   
        public int ProductPrice { get; set; }   
        public int Stock { get; set; }
        public string ProductDescription { get; set; }

        public Product(int Product_ID, string ProductName, int ProductCategory, int ProductPrice, int Stock, string ProductDescription)
        {
            this.Product_ID = Product_ID;
            this.ProductName = ProductName;
            this.ProductCategory = ProductCategory;
            this.ProductPrice = ProductPrice;
            this.Stock = Stock; 
            this.ProductDescription = ProductDescription;
        }

        void DisplayProduct(int Product_ID, string ProductName, int ProductCategory, int ProductPrice, int Stock)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("                              --------- Newly Registed Products ---------                              ");
            Console.ResetColor();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write($"                                         Product ID         : ");
            Console.ResetColor();
            Console.WriteLine(Product_ID);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write($"                                         Product Name       : ");
            Console.ResetColor();
            Console.WriteLine(ProductName);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write($"                                         Product Category   : ");
            Console.ResetColor();
            Console.WriteLine(ProductCategory);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write($"                                         Product Price      : ");
            Console.ResetColor();
            Console.WriteLine(ProductPrice);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write($"                                         Product Stock      : ");
            Console.ResetColor();
            Console.WriteLine(Stock);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("                              -------------------------------------------                              ");
            Console.ResetColor();
            Console.WriteLine();

        }

    }
    internal class Admin
    {
        public static int Product_ID = 100;
        public void AdminPanel()
        {
            E_CommerceInterface _E_CommerceMethods = new E_CommerceMethods();

            List<string> Category = new List<string>{"Electrocs", "Fashion", "Home & Kitchen", "Beauty & Personal Care","Health & Wellness","Books & Stationary" ,"Sports & Outdoors"};
            Hashtable ProductDetails = new Hashtable(); 


            while (true)
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

                string ProductName = "None";
                string ProductCategory = "None";
                int ProductPrice = 0;
                int Stock = 0;
                string ProductDescription = "None";
                switch (Choice)
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("                           You have selected option '1' to add a new product                           ");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("-------------------------------------------------------------------------------------------------------");
                        Console.ResetColor();
                        Console.WriteLine();

                        ProductName:
                        try
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("Enter the Product Name : ");
                            Console.ResetColor();
                            string productName = Console.ReadLine();
                            _E_CommerceMethods.isNullString(productName);
                            _E_CommerceMethods.isValidString(productName);
                            ProductName = productName;
                        }
                        catch (IsNullExpection e)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(e.Message);
                            Console.ResetColor();
                            goto ProductName;
                        }
                        catch (IsValidStringExpection e)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(e.Message);
                            Console.ResetColor();
                            goto ProductName;
                        }

                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("                              -------- Choose the Product Category --------                            ");
                        Console.ResetColor();
                        Console.WriteLine();
                        int sno = 1;
                        foreach(string i in Category)
                        {
                            Console.WriteLine($"                                  {sno}. {i}");
                            sno++;
                        }
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("                              ---------------------------------------------");
                        Console.ResetColor();

                        CategoryNumber:
                        try
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Enter the Category Number : ");
                            Console.ResetColor();
                            int categoryNumber = int.Parse(Console.ReadLine());

                            if (categoryNumber == 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Invalid Category Number! Category Number must not be Zero");
                                Console.ResetColor();
                                goto CategoryNumber;
                            }
                            if(categoryNumber > 7)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Invalid Category Number! Category Number must be between 1 and 7");
                                Console.ResetColor();
                                goto CategoryNumber;
                            }
                            ProductCategory = Category[categoryNumber - 1];
                        }
                        catch (FormatException)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalid Category Number! Input must not contain characters, symbols, or whitespace");
                            Console.ResetColor();
                            goto Choice;
                        }
                        catch (OverflowException e)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalid Category Number! Please Enter the Valid Category Number");
                            Console.ResetColor();
                            goto Choice;
                        }

                    ProductPrice:
                        try
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Enter the Product Price : ");
                            Console.ResetColor();
                            int productPrice = int.Parse(Console.ReadLine());

                            if (productPrice == 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Invalid Product Price! Product Price must not be Zero");
                                Console.ResetColor();
                                goto ProductPrice;
                            }

                            ProductPrice = productPrice;
                        }
                        catch (FormatException)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalid Product Price! Price must not contain characters, symbols, or whitespace");
                            Console.ResetColor();
                            goto ProductPrice;
                        }
                        catch (OverflowException e)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalid Product Price! Please Enter the Valid Product Price");
                            Console.ResetColor();
                            goto ProductPrice;
                        }

                    Stock:
                        try
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Enter the Product Stock : ");
                            Console.ResetColor();
                            int stock= int.Parse(Console.ReadLine());

                            if (stock == 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Invalid Stock! Stock must not be Zero");
                                Console.ResetColor();
                                goto Stock;
                            }

                            Stock = stock;
                        }
                        catch (FormatException)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalid Stock! Stock must not contain characters, symbols, or whitespace");
                            Console.ResetColor();
                            goto Stock;
                        }
                        catch (OverflowException e)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalid Product Stock! Please Enter the Valid Stock");
                            Console.ResetColor();
                            goto Stock;
                        }

                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine($"                       -------- Enter the Description of {ProductName} --------                       ");
                        Console.ResetColor();
                        Console.WriteLine();
                        ProductDescription = Console.ReadLine();

                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine($"                       --------------------------------------------------------                       ");
                        Console.ResetColor();

                        Product_ID++;

                        Product products = new Product(Product_ID, ProductName, ProductCategory, ProductPrice, Stock, ProductDescription);





                }

            }
        }
    }
}
