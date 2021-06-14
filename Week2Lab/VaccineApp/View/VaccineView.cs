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
        {
            //starts the program menu
            MenuLogic();
        }

        //menu method
        public static void Menu() {
            Console.WriteLine("\nVaccine Management\n");
            Console.WriteLine(String.Format("{0,7}{1,33}{2,22}{3,23}\n", "Name", "Doses Required", "Days Between Doses", "Total Doses Received"));
            Console.WriteLine("---------------------------------------------------------------------------------------");
            for (int i = 0; i < VaccineDatabase.VaccineList.Count; i++) {
                Console.WriteLine(String.Format("{0,-3}{1,-23}{2,-18}{3,-21}{4,-12}\n",
                    $"{VaccineDatabase.VaccineList[i].VaccineId})",
                    $"{VaccineDatabase.VaccineList[i].VaccineName}",
                    $"{VaccineDatabase.VaccineList[i].DoseRequired}",
                    $"{VaccineDatabase.VaccineList[i].DaysBtwDose}",
                    $"{ VaccineDatabase.VaccineList[i].TotalDose}"));
            }
            Console.WriteLine(String.Format("{0,2}{1,18}\n","a)", "Add a new vaccine"));
            Console.WriteLine(String.Format("{0,2}{1,5}\n", "x)", "Exit"));
        }

        //menu logic to handle input/output logic
        public static void MenuLogic() {

            string input;

            do
            {
                Menu();
                Console.Write("Please enter your choice: ");
                input = Console.ReadLine();
                int number;

                // if-else to handle a) and access vaccines
                if (int.TryParse(input, out number))
                {
                    //update doses
                    Console.WriteLine($"\nVaccine Management - {VaccineDatabase.SelectedName(number)}");
                    Console.Write("Please enter how many new doses are received: ");
                    int newDose = int.Parse(Console.ReadLine());
                    VaccineController.AddDose(number, newDose);
                }

                //create new vaccine
                else if (!(int.TryParse(input, out number)) && input == "a")
                {
                    Console.Write("\nEnter the name of vaccine: ");
                    string vaccineName = Console.ReadLine();
                    Console.Write("Enter doses required: ");
                    int doseReq = int.Parse(Console.ReadLine());
                    int? doseDays = null;

                    //ask for doses between days => if +1 doses is required
                    if (doseReq > 1)
                    {
                        Console.Write("Enter days between doses: ");
                        doseDays = int.Parse(Console.ReadLine());
                    }
                    Console.Write("Enter total doses received: ");
                    int totDose = int.Parse(Console.ReadLine());

                    //add new vaccine
                    VaccineController.AddVaccine(new VaccineModel(vaccineName, doseReq, doseDays, totDose));
                }
            }
            //only run if input isn't x
            while (input != "x");
        }
    }
}
