using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Xml.Linq;

namespace assignmentt
{
    class Program
    {
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
