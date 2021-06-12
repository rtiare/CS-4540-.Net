using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaccineApp.View
{
    class VaccineView
    {
        static void Main(string[] args)
        {

            string input;

            do
            {
                Console.WriteLine("\nVaccine Management");
                Console.WriteLine("Name                Doses Required    Days Between Doses    Total Doses Received");
                Console.WriteLine("--------------------------------------------------------------------------------------");
                
                Console.Write("Please enter your choice: ");
                input = Console.ReadLine();
            }
            while (input != "x");

        }


    }
}
