using System;
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
                    Console.WriteLine(".....Create.....");
                    
                    break;

                case '2':
                    Console.Clear();
                    Console.WriteLine("....Read.....");
                    
                    break;

                case '3':
                    Console.Clear();
                    Console.WriteLine(".....Update.....");
                    
                    break;

                case '4':
                    Console.Clear();
                    Console.WriteLine(".....Delete.....");
                    
                    break;

                default:
                    Console.Clear();
                    break;

            }
        }
    }
}
