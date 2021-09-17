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

                    Console.WriteLine(".....Inserting CSV file.....");
                    Guest.Menu_for_Guest();                

                    Adding_in_file();

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
                    //Updating(option);
                    break;

                case '4':
                    Console.Clear();
                    Console.WriteLine(".....Deleting.....");
                    Guest.Menu_for_Guest();


                    Deleting();

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
                filepath = "experience.csv";
                }
            else if (option == '2')
            {
                filepath = "edu.csv";
                }
            else if (option == '3')
            {
                filepath = "skills.csv";
            }
            else if (option == '4')
            {
                filepath = "techskills.csv";
            }
            else
            {
                filepath = "contact.csv";
            }
            return filepath;
        }

        public static void Adding_in_file() 
        {
            Console.WriteLine("enter the file you want to insert into:");
            char option = Console.ReadLine()[0];
            string csvpath = Finding_Filepath(option);
           

            var csvcontent = new StringBuilder();
            
            if (File.Exists(csvpath))
            {
                Console.WriteLine(csvpath);
         
                Console.Write("enter data in:");
                
                string  data = Convert.ToString(Console.ReadLine());
                Console.WriteLine(data);

                File.AppendAllText(csvpath, $",{data}");

            }
        }

        public static void Deleting()
        {
            Console.WriteLine("enter the file you want to delete:");
            char option = Console.ReadLine()[0];
            string csvpath = Finding_Filepath(option);

            if (File.Exists(csvpath))
            {
                var lines = File.ReadAllLines(csvpath);
                string[] values = lines[0].Split(",");
                for (int i = 0; i < values.Length; i++) 
                {
                        Console.WriteLine( i + ". " + values[i]);
                }

                Console.WriteLine("enter the number you want to delete:");
                int searchid = Convert.ToInt32(Console.ReadLine());

                string[] ZafrKiEna = File.ReadAllText(csvpath).Split(new char[] { ',' });
                StringBuilder ObjStringBuilder = new StringBuilder();
                
                for (int i = 0; i <=values.Length; i++)
                {
                    if (ZafrKiEna[i].Contains(ZafrKiEna[searchid]))
                        continue;
                    ObjStringBuilder.Append(values[i] + ",");
                }
                ObjStringBuilder.ToString().Remove(ObjStringBuilder.Length - 1);
                File.WriteAllText(csvpath, ObjStringBuilder.ToString());
            }
        }
        
        /* 
                    {
                    
                    var values = line.Split(',');
                    foreach (var item in values)
                    {
                        listA.Add(item);
                    }
                    foreach (var coloumn1 in listA)
                    {
                        Console.WriteLine(coloumn1);
                    }

                    }*//*

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

                        //
                    }
                }
            }

        }*/
       /* public static void Deleting(char option)
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

        }*/
    }
}

