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
                showList();
                Console.Write("Please enter your choice: ");
                input = Console.ReadLine();

                if (input == "a") {
                    Console.Write("\nEnter the name of vaccine: ");
                    string vaccineName = Console.ReadLine();
                    Console.Write("Enter doses required: ");
                    int doseReq = int.Parse(Console.ReadLine());
                    int? doseDays;
                    if (doseReq > 1)
                    {
                        Console.Write("Enter days between doses: ");
                        doseDays = int.Parse(Console.ReadLine());
                    }
                    else {
                        doseDays = null;
                    }
                    Console.Write("Enter total doses received: ");
                    int totDose = int.Parse(Console.ReadLine());

                    //add new vaccine
                    VaccineController.addVaccine(new VaccineModel(vaccineName,doseReq,doseDays,totDose));
                }
            }
            while (input != "x");

        }

        
        public static void showList() {
            Console.WriteLine("\nVaccine Management\n");
            Console.WriteLine("    Name                Doses Required    Days Between Doses    Total Doses Received");
            Console.WriteLine("--------------------------------------------------------------------------------------");
            for (int i = 0; i < VaccineDatabase.VaccineList.Count; i++) {
                Console.WriteLine($"{VaccineDatabase.VaccineList[i].vaccineID})  " +
                    $"{VaccineDatabase.VaccineList[i].VaccineName}   " +
                    $"{VaccineDatabase.VaccineList[i].DoseRequired}                 " +
                    $"{VaccineDatabase.VaccineList[i].DaysBtwDose}" +
                    $"                   {VaccineDatabase.VaccineList[i].totalDose}");
            }
            Console.WriteLine("a) Add a new vaccine");
            Console.WriteLine("x)  Exit");
        }
       


    }
}
