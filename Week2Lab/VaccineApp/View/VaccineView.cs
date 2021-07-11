using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VaccineApp.Model;
using VaccineApp.Controller;

namespace VaccineApp.View
{
    public class VaccineView
    {
        static void Main(string[] args)
        {
            using var db = new AppDbContext();

            //starts the program menu
            MenuLogic(db);
        }

        //menu method
        public static void Menu(AppDbContext db) {
            Console.WriteLine("\nVaccine Management\n");
            Console.WriteLine(String.Format("{0,7}{1,33}{2,22}{3,23}\n", "Name", "Doses Required", "Days Between Doses", "Total Doses Received"));
            Console.WriteLine("---------------------------------------------------------------------------------------");
            foreach (var v in db.Vaccines.Select(e => e).ToArray())
            {
                Console.WriteLine($"{v}");

            }
            Console.WriteLine(String.Format("{0,2}{1,18}\n","a)", "Add a new vaccine"));
            Console.WriteLine(String.Format("{0,2}{1,5}\n", "x)", "Exit"));
        }
        
        //menu logic to handle input/output logic
        public static void MenuLogic(AppDbContext db) {

            string input;
            do
            {
                Menu(db);
                Console.Write("Please enter your choice: ");
                input = Console.ReadLine();
                int number;

                // if-else to handle a) and access vaccines and access if vaccine exist
                if (int.TryParse(input, out number) && (VaccineController.Exists(number, db)) )
                {
                    //update doses
                    Console.WriteLine($"\nVaccine Management - {VaccineController.SelectedName(number, db)}");
                    Console.Write("Please enter how many new doses are received: ");
                    int newDose = int.Parse(Console.ReadLine());
                    VaccineController.AddDose(number, newDose, db);
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
                    var newVaccine = new VaccineModel {
                        VaccineName = vaccineName,
                        DoseRequired = doseReq,
                        DaysBtwDose = doseDays,
                        TotalDose = totDose
                    };
                    VaccineController.AddVaccine(newVaccine, db);
                }
            }
            //only run if input isn't x
            while (input != "x");
        }
    }
}
