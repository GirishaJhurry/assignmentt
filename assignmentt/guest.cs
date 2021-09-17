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
            Console.WriteLine("************menu**************");
            Console.WriteLine("*     1.Experience           *");
            Console.WriteLine("*     2.Education            *");
            Console.WriteLine("*     3.Skills               *");
            Console.WriteLine("*     4.Technological skills *");
            Console.WriteLine("*     5.contact details      *");
            Console.WriteLine("*     0.Go Back              *");
            Console.WriteLine("******************************");
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
        public static void todo(char option)
        {
            string filepath;
            //StreamReader reader = null;
            if (option == '1')
            {
                filepath = "experience.csv";
            }
            else if (option == '2')
            {
                filepath = "education.csv";
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
           
            if (File.Exists(filepath))
            {

                var lines = File.ReadAllLines(filepath);
               
                string[] values = lines[0].Split(",");

                for (int i = 0; i < values.Length; i++)
                    Console.WriteLine(values[i]);

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
                    todo('1');
                    break;

                case '2':
                    Console.Clear();
                    Console.WriteLine("....Education/training.....");
                    todo('2');
                    break;

                case '3':
                    Console.Clear();
                    Console.WriteLine(".....skills.....");
                    todo('3');
                    break;

                case '4':
                    Console.Clear();
                    Console.WriteLine(".....technological skills.....");
                    todo('4');
                    break;

                case '5':
                    Console.Clear();
                    Console.WriteLine("......Contact.....");
                    todo('5');
                    break;

                default:
                    Console.Clear();
                    break;
            }
        } 
    } 
}
