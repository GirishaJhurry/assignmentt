using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace assignmentt
{
    class Program
    { 
        public static void Menu()
        {
            Console.WriteLine();
            Console.WriteLine("********menu**********");
            Console.WriteLine("1.Experience:");
            Console.WriteLine("2.Education:");
            Console.WriteLine("3.Skills:");
            Console.WriteLine("4.Technological skills: ");
            Console.WriteLine("5.contact details");
            Console.WriteLine("0.Go Back");
            Console.WriteLine("**********************");
            Console.WriteLine();
        }

       /* public static void exp()
        {
            string filepath = @"C:\Users\CORELAB-USER\Desktop\experience.csv";
            StreamReader reader = null;

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
        }

        public static void edu()
        {
            string filepath = @"C:\Users\CORELAB-USER\Desktop\education.csv";
            StreamReader reader = null;

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
        }
*/
        public static void todo(int option) {
            string filepath;
            StreamReader reader = null;
            if (option == 1)
            {
                //filepath = @"C:\Users\CORELAB-USER\Desktop\experience.csv";
                filepath = @"C:\Users\girisha\OneDrive\Desktop\exp.csv";
            }
            else if(option == 2) 
            {
                //filepath = @"C:\Users\CORELAB-USER\Desktop\education.csv";
                filepath = @"C:\Users\girisha\OneDrive\Desktop\edu.csv";
            }
            else if(option ==3)
            {
                //filepath = @"C:\Users\CORELAB-USER\Desktop\skills.csv";
                filepath = @"C:\Users\girisha\OneDrive\Desktop\skills.csv";
            }
            else if(option == 4)
            {
                //filepath = @"C:\Users\CORELAB-USER\Desktop\techskills.csv";
                filepath = @"C:\Users\girisha\OneDrive\Desktop\techskills.csv";
            }
            else
            {
                //filepath = @"C:\Users\CORELAB-USER\Desktop\contact.csv";
                filepath = @"C:\Users\girisha\OneDrive\Desktop\contact.csv";
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

        }

        public static void Main(string[] args)
        {
            while (true)
            {
            Loop:
                Console.WriteLine("Are the admin or guest? enter a for admin or g for guest:");
                string mode = Console.ReadLine();

                /*if((mode!= 'a') &&( mode != 'g'))
                {
                    goto Loop;
                *//*}*//*
                if (string.Equals("g",mode,StringComparison.OrdinalIgnoreCase))
                {

                }*/

                //menu
                if (string.Equals("g", mode, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Hello. You are on guest mode.");
                    Menu();

                    while (true)
                    {
                        //whatyouwannado:
                        Console.WriteLine("enter the number associated with the menu you want to view:");
                        //int option = int.Parse(Console.ReadLine());
                        char option = Console.ReadLine()[0];

                            switch (option)
                            {
                                case '0':
                                    //Menu();
                                    goto Loop;

                                case '1':
                                    Console.WriteLine(".....Experience.....");
                                    todo(1);
                                    //Menu();
                                    break;

                                case '2':
                                    Console.WriteLine("....Education/training.....");
                                    todo(2);
                                    //Menu();
                                    break;

                                case '3':
                                    Console.WriteLine(".....skills.....");
                                    todo(3);
                                    //Menu();
                                    break;

                                case '4':
                                    Console.WriteLine(".....techinical skills.....");
                                    todo(4);
                                    //Menu();
                                    break;

                                case '5':
                                    Console.WriteLine("......Contact.....");
                                    todo(5);
                                    //Menu();
                                    break;

                                default:
                                    //goto Loop;
                                    break;
                            }
                            Menu();
                        

                        //goto Loop;
                    }
                }

                else if (string.Equals("a", mode, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Hello. You are on admin mode.");

                }
                

            }
        }   
    }
}