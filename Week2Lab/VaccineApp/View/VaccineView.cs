using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VaccineApp.Model;
using VaccineApp.Database;
using VaccineApp.Controller;

namespace VaccineApp.View
{
    class VaccineView
    {
        static void Main(string[] args)
        {;
            //Console.WriteLine(vacList.vaccineList.Count);
            string input;

            do
            {
                Console.WriteLine("\nVaccine Management");
                Console.WriteLine("Name                Doses Required    Days Between Doses    Total Doses Received");
                Console.WriteLine("--------------------------------------------------------------------------------------");
                showList();
                Console.Write("Please enter your choice: ");
                input = Console.ReadLine();
            }
            while (input != "x");

        }

        
        public static void showList() {
            for (int i = 0; i < VaccineDatabase.VaccineList.Count; i++) {
                Console.WriteLine($"{VaccineDatabase.VaccineList[i].vaccineID})  " +
                    $"{VaccineDatabase.VaccineList[i].VaccineName}   {VaccineDatabase.VaccineList[i].DoseRequired}     " +
                    $"{VaccineDatabase.VaccineList[i].DaysBtwDose}        {VaccineDatabase.VaccineList[i].totalDose}");
            }
        }
       


    }
}
