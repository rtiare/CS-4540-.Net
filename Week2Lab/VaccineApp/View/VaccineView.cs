using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VaccineApp.Model;

namespace VaccineApp.View
{
    class VaccineView
    {
        static void Main(string[] args)
        {
            VaccineModel v = new VaccineModel("Pfizer", 10, 23, 1000);

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
