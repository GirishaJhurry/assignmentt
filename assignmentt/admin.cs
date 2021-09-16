using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace assignmentt
{
    class Admin
    {
        public static void Menu_for_Admin()
        {
            Console.WriteLine();
            Console.WriteLine("********menu**********");
            Console.WriteLine("*     1.Create       *");
            Console.WriteLine("*     2.Read         *");
            Console.WriteLine("*     3.Update       *");
            Console.WriteLine("*     4.Delete       *");
            Console.WriteLine("*     0.Go Back      *");
            Console.WriteLine("**********************");
            Console.WriteLine();
        }
        public static void Admin_Main(string mode)
        {
            if (string.Equals("a", mode, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("You are now on admin mode.");
                Menu_for_Admin();

            }
        }
        public static void Admin_Menu(char option)
        {
            switch (option)
            {
                case '0':
                    return;

                case '1':
                    Console.Clear();
                    Console.WriteLine(".....Creating A New CSV file.....");
                    string csvpath = @"C:\Users\girisha\source\repos\trial\assignmentt\bin\Debug\netcoreapp3.1\new.csv";
                    StringBuilder csvcontent = new StringBuilder();
                    Console.WriteLine("enter data in:");
                    string data = Convert.ToString(Console.ReadLine());

                    string[] words = data.Split(',');
                    int count = words.GetLength(0);

                    for (int index = 0; index < count; index++)
                        csvcontent.AppendLine(words[index]);

                    File.WriteAllText(csvpath, csvcontent.ToString());
                    //File.AppendAllText(csvpath, csvcontent.ToString());
                    break;

                case '2':
                    Console.Clear();
                    Console.WriteLine("....Reading.....");
                    Console.WriteLine("Please select the file you wish to view");
                    Guest.Menu_for_Guest();
                    Console.Write("File:");
                    option = Console.ReadLine()[0];
                    Guest.Guest_Menu(option);

                    break;

                case '3':
                    Console.Clear();
                    Console.WriteLine(".....Updating.....");
                    Console.Write("Please select the file you wish to update");
                    Guest.Menu_for_Guest();
                    Console.Write("File:");
                    option = Console.ReadLine()[0];
                    Updating(option);
                    break;

                case '4':
                    Console.Clear();
                    Console.WriteLine(".....Deleting.....");
                    Console.Write("Please select the file you wish to delete data");
                    Guest.Menu_for_Guest();
                    Console.Write("File:");
                    option = Console.ReadLine()[0];
                    Deleting(option);

                    break;

                default:
                    Console.Clear();
                    break;
            }

        }
        public static string Finding_Filepath(char option)
        {
            string filepath;
            if (option == '1')
            {
                //filepath = @"C:\Users\CORELAB-USER\Desktop\experience.csv";
                //filepath = @"C:\Users\girisha\OneDrive\Desktop\exp.csv";
                //filepath = @"C:\Users\girisha\source\repos\assignmentt\assignmentt\bin\Debug\netcoreapp3.1\exp.csv";
                filepath = @"C:\Users\girisha\source\repos\trial\assignmentt\bin\Debug\netcoreapp3.1\exp.csv";
                //filepath = @"C: \Users\CORELAB - USER\source\repos\assignmentt\assignmentt\bin\Debug\netcoreapp3.1\experience.csv";
            }
            else if (option == '2')
            {
                //filepath = @"C:\Users\CORELAB-USER\Desktop\education.csv";
                //filepath = @"C:\Users\girisha\OneDrive\Desktop\edu.csv";
                //filepath = @"C:\Users\girisha\source\repos\assignmentt\assignmentt\bin\Debug\netcoreapp3.1\edu.csv";
                filepath = @"C:\Users\girisha\source\repos\trial\assignmentt\bin\Debug\netcoreapp3.1\edu.csv";
                //filepath = @"C: \Users\CORELAB - USER\source\repos\assignmentt\assignmentt\bin\Debug\netcoreapp3.1\education.csv";
            }
            else if (option == '3')
            {
                //filepath = @"C:\Users\CORELAB-USER\Desktop\skills.csv";
                //filepath = @"C:\Users\girisha\OneDrive\Desktop\skills.csv";
                //filepath = @"C:\Users\girisha\source\repos\assignmentt\assignmentt\skills.csv";
                filepath = @"C:\Users\girisha\source\repos\trial\assignmentt\bin\Debug\netcoreapp3.1\skills.csv";
                //filepath = @"C: \Users\CORELAB - USER\source\repos\assignmentt\assignmentt\bin\Debug\netcoreapp3.1\skills.csv";
            }
            else if (option == '4')
            {
                //filepath = @"C:\Users\CORELAB-USER\Desktop\techskills.csv";
                //filepath = @"C:\Users\girisha\OneDrive\Desktop\techskills.csv";
                //filepath = @"C:\Users\girisha\source\repos\assignmentt\assignmentt\techskills.csv";
                filepath = @"C:\Users\girisha\source\repos\trial\assignmentt\bin\Debug\netcoreapp3.1\techskills.csv";
                //filepath = @"C: \Users\CORELAB - USER\source\repos\assignmentt\assignmentt\bin\Debug\netcoreapp3.1\techskills.csv";
            }
            else
            {
                //filepath = @"C:\Users\CORELAB-USER\Desktop\contact.csv";
                //filepath = @"C:\Users\girisha\OneDrive\Desktop\contact.csv";
                //filepath = @"C:\Users\girisha\source\repos\assignmentt\assignmentt\bin\Debug\netcoreapp3.1\contact.csv";
                filepath = @"C:\Users\girisha\source\repos\trial\assignmentt\bin\Debug\netcoreapp3.1\contact.csv";
                //filepath = @"C: \Users\CORELAB - USER\source\repos\assignmentt\assignmentt\bin\Debug\netcoreapp3.1\contact.csv";
            }
            return filepath;
        }
        public static void Updating(char option)
        {
            StreamReader reader = null;
            string filepath = Finding_Filepath(option);

            StringComparer comparer = StringComparer.OrdinalIgnoreCase;
            reader = new StreamReader(File.OpenRead(filepath));
            StringBuilder newword = new StringBuilder();
            List<string> listA = new List<string>();

            if (File.Exists(filepath))
            {
                Console.Write("enter the detail you want to update: ");
                string searchtext = Console.ReadLine();

                Console.Write("enter the new detail: ");
                string updatedword = Console.ReadLine();

                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    String[] values = line.Split(',');
                    int count = values.GetLength(0);

                    for (int i = 0; i < count; i++)
                    {
                        string item = values[i];
                        if (comparer.Compare(item, searchtext) == 0)
                        {
                            line = item.Replace(searchtext, updatedword);
                            newword.AppendLine(values[i]);
                            line = String.Join(",", item);
                            listA.Add(line);
                        }
                        for (int index = 0; index < count; index++)
                            newword.AppendLine(values[index]);

                        //File.WriteAllText(filepath, newword.ToString());
                    }
                }
            }

        }
        public static void Deleting(char option)
        {
            string filepath = Finding_Filepath(option);

            StringComparer comparer = StringComparer.OrdinalIgnoreCase;
            List<string> linesToWrite = new List<string>();

            Console.Write("enter the detail you want to delete: ");
            string deletetext = Console.ReadLine();

            String[] values = System.IO.File.ReadAllLines(filepath);

            try
            {
                for (int i = 0; i < values.Length; i++)
                {
                    string[] fields = values[i].Split(',');
                    for (int j = 0; j < fields.Length; j++)
                    {
                        if (comparer.Compare(fields[j], deletetext) == 0)
                        {
                           linesToWrite.Remove(fields[j]);
                        }
                    }
                    File.WriteAllLines(filepath, linesToWrite);
                }
            }
            catch( Exception)
            {
                Console.WriteLine("pan kapav");
            }

        }
    }
}

