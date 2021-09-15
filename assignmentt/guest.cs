using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace assignmentt
{
    public class Guest
    {
        public static void Menu_for_Guest()
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
        }

        public static void Guest_Main(string mode)
        {
            if (string.Equals("g", mode, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("You are now on GUEST mode.");
                Menu_for_Guest();    
            }          
        }

        public static void Guest_Menu(char option)
        {
            switch (option)
            {
                case '0':
                    return;

                case '1':
                    Console.Clear();
                    Console.WriteLine(".....Experience.....");
                    assignmentt.Program.todo(1);
                    break;

                case '2':
                    Console.Clear();
                    Console.WriteLine("....Education/training.....");
                    assignmentt.Program.todo(2);
                    break;

                case '3':
                    Console.Clear();
                    Console.WriteLine(".....skills.....");
                    assignmentt.Program.todo(3);
                    break;

                case '4':
                    Console.Clear();
                    Console.WriteLine(".....technological skills.....");
                    assignmentt.Program.todo(4);
                    break;

                case '5':
                    Console.Clear();
                    Console.WriteLine("......Contact.....");
                    assignmentt.Program.todo(5);
                    break;

                default:
                    Console.Clear();
                    break;
            }
        }
      
        public static void todo(int option)
        {
            string filepath;
            StreamReader reader = null;
            if (option == 1)
            {
                //filepath = @"C:\Users\CORELAB-USER\Desktop\experience.csv";
                //filepath = @"C:\Users\girisha\OneDrive\Desktop\exp.csv";
                filepath = @"C: \Users\CORELAB - USER\source\repos\assignmentt\assignmentt\bin\Debug\netcoreapp3.1\experience.csv";
            }
            else if (option == 2)
            {
                //filepath = @"C:\Users\CORELAB-USER\Desktop\education.csv";
                //filepath = @"C:\Users\girisha\OneDrive\Desktop\edu.csv";
                filepath = @"C: \Users\CORELAB - USER\source\repos\assignmentt\assignmentt\bin\Debug\netcoreapp3.1\education.csv";
            }
            else if (option == 3)
            {
                //filepath = @"C:\Users\CORELAB-USER\Desktop\skills.csv";
                //filepath = @"C:\Users\girisha\OneDrive\Desktop\skills.csv";
                filepath = @"C: \Users\CORELAB - USER\source\repos\assignmentt\assignmentt\bin\Debug\netcoreapp3.1\skills.csv";
            }
            else if (option == 4)
            {
                //filepath = @"C:\Users\CORELAB-USER\Desktop\techskills.csv";
                //filepath = @"C:\Users\girisha\OneDrive\Desktop\techskills.csv";
                filepath = @"C: \Users\CORELAB - USER\source\repos\assignmentt\assignmentt\bin\Debug\netcoreapp3.1\techskills.csv";
            }
            else
            {
                //filepath = @"C:\Users\CORELAB-USER\Desktop\contact.csv";
                //filepath = @"C:\Users\girisha\OneDrive\Desktop\contact.csv";
                filepath = @"C: \Users\CORELAB - USER\source\repos\assignmentt\assignmentt\bin\Debug\netcoreapp3.1\contact.csv";
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
    } 
}
