﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace assignmentt
{
    class Program
    {
       /* public static void Menu()
        {
            Console.WriteLine();
            Console.WriteLine("********menu**********");
            Console.WriteLine("     1.Experience:");
            Console.WriteLine("     2.Education:");
            Console.WriteLine("     3.Skills:");
            Console.WriteLine("     4.Technological skills: ");
            Console.WriteLine("     5.contact details");
            Console.WriteLine("     0.Go Back");
            Console.WriteLine("**********************");
            Console.WriteLine();
        }*/

        /*public static void todo(int option)
        {
            string filepath;
            StreamReader reader = null;
            if (option == 1)
            {
                //filepath = @"C:\Users\CORELAB-USER\Desktop\experience.csv";
                //filepath = @"C:\Users\girisha\OneDrive\Desktop\exp.csv";
                filepath = @"C:\Users\CORELAB-USER\source\repos\assignmentt\assignmentt\bin\Debug\netcoreapp3.1\experience.csv";
            }
            else if (option == 2)
            {
                filepath = @"C:\Users\CORELAB-USER\Desktop\education.csv";
                //filepath = @"C:\Users\girisha\OneDrive\Desktop\edu.csv";
            }
            else if (option == 3)
            {
                filepath = @"C:\Users\CORELAB-USER\Desktop\skills.csv";
                //filepath = @"C:\Users\girisha\OneDrive\Desktop\skills.csv";
            }
            else if (option == 4)
            {
                filepath = @"C:\Users\CORELAB-USER\Desktop\techskills.csv";
                //filepath = @"C:\Users\girisha\OneDrive\Desktop\techskills.csv";
            }
            else
            {
                filepath = @"C:\Users\CORELAB-USER\Desktop\contact.csv";
                //filepath = @"C:\Users\girisha\OneDrive\Desktop\contact.csv";
            }

            if (File.Exists(filepath))
            {
                reader = new StreamReader(File.OpenRead(filepath));
                List<string> listA = new List<string>();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    foreach (var item in values)
                    {
                        listA.Add(item);
                    }
                    foreach (var coloumn1 in listA)
                    {
                        Console.WriteLine(coloumn1);
                    }

                }
            }

        }*/

        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Are the admin or guest? enter a for admin or g for guest:");
                string mode = Console.ReadLine();

                if (string.Equals("g", mode, StringComparison.OrdinalIgnoreCase))
                {
                    char option;
                    do
                    {
                        Guest.Guest_Main(mode);

                        Console.WriteLine("enter the number associated with the menu you want to view:");
                        option = Console.ReadLine()[0];

                        Guest.Guest_Menu(option);
                    } while (option != '0');
                }
                 
                

                if (string.Equals("a", mode, StringComparison.OrdinalIgnoreCase))
                {
                    char option;
                    do
                    { 
                        Admin.Admin_Main(mode);

                        Console.WriteLine("enter the number associated with the menu you want to view:");
                        option = Console.ReadLine()[0];

                        Admin.Admin_Menu(option);
                    } while (option != '0');
                }

            }
        }
    }
}
/*while (true)
            {
                Loop:
                Console.WriteLine("Are the admin or guest? enter a for admin or g for guest:");
                string mode = Console.ReadLine();

                if (string.Equals("g", mode, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Hello. You are on guest mode.");
                    //Menu();

                    while (true)
                    {
                        //whatyouwannado:
                        Console.WriteLine("enter the number associated with the menu you want to view:");
                        //int option = int.Parse(Console.ReadLine());
                        char option = Console.ReadLine()[0];

                        switch (option)
                        {
                            case '0':
                                goto Loop;
                                Console.Clear();

                            case '1':
                                Console.Clear();
                                Console.WriteLine(".....Experience.....");
                                todo(1);
                                break;

                            case '2':
                                Console.Clear();
                                Console.WriteLine("....Education/training.....");
                                todo(2);
                                break;

                            case '3':
                                Console.Clear();
                                Console.WriteLine(".....skills.....");
                                todo(3);
                                break;

                            case '4':
                                Console.Clear();
                                Console.WriteLine(".....techinical skills.....");
                                todo(4);
                                break;

                            case '5':
                                Console.Clear();
                                Console.WriteLine("......Contact.....");
                                todo(5);
                                break;

                            default:
                                //Console.Clear();
                                break;
                        }
                        
                        Menu();
                else if (string.Equals("a", mode, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Hello. You are on admin mode.");
                }
            }
        }
        }   
    }
}*/