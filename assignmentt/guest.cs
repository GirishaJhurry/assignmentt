using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace assignmentt
{
    public class Guest
    {
        public static void Sa_guest(string mode)
        {
            if (string.Equals("g", mode, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Hello. You are now on GUEST mode.");
                assignmentt.Program.Menu();
            }

        }

        public static void KipuFr(char option)
        {
            while (option != 0)
            {
                switch (option)
                {
                    case '1':
                        //Console.Clear();
                        Console.WriteLine(".....Experience.....");
                        assignmentt.Program.todo(1);
                        break;

                    case '2':
                        //Console.Clear();
                        Console.WriteLine("....Education/training.....");
                        assignmentt.Program.todo(2);
                        break;

                    case '3':
                        //Console.Clear();
                        Console.WriteLine(".....skills.....");
                        assignmentt.Program.todo(3);
                        break;

                    case '4':
                        //Console.Clear();
                        Console.WriteLine(".....techinical skills.....");
                        assignmentt.Program.todo(4);
                        break;

                    case '5':
                        //Console.Clear();
                        Console.WriteLine("......Contact.....");
                        assignmentt.Program.todo(5);
                        break;

                    default:
                        
                        break;
                }
            }
            
            assignmentt.Program.Menu();
        }
      /*  public static void todo(int option)
        {
            string filepath;
            StreamReader reader = null;
            if (option == 1)
            {
                filepath = @"C:\Users\CORELAB-USER\Desktop\experience.csv";
                //filepath = @"C:\Users\girisha\OneDrive\Desktop\exp.csv";
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
    } 
}
