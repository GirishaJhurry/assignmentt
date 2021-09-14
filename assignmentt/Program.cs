using System;

namespace assignmentt
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.1
            Loop:
            Console.WriteLine("Are the admin or guest? enter 0 for admin or 1 for guest:");
            var mode= int.Parse(Console.ReadLine());

            if((mode!= 0) &&( mode != 1))
            {
                goto Loop;
            }

            //menu
            if (mode == 1)
            {
                Console.WriteLine("********menu**********");
                Console.WriteLine("1.Experience:");
                Console.WriteLine("2.Education:");
                Console.WriteLine("3.Skills:");
                Console.WriteLine("4.Technological skills: ");
                Console.WriteLine("5.contact details");
                Console.WriteLine("**********************");
                Console.WriteLine("enter the number associated with the menu you want to view:");
                int option = int.Parse(Console.ReadLine());

            }




        }
    }
}
