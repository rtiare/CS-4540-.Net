using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaccineApp.Model
{
    public class VaccineModel
    {
        //setters and getters
        public int Id { get; set; }
        public string VaccineName { get; set; }
        public int? DoseRequired { get; set; }
        public int? DaysBtwDose { get; set; }
        public int? TotalDose { get; set; }

        public override string ToString()
        {
            return String.Format("{0,-3}{1,-23}{2,-18}{3,-21}{4,-12}\n",
                    $"{Id})",
                    $"{VaccineName}",
                    $"{DoseRequired}",
                    $"{DaysBtwDose}",
                    $"{TotalDose}");

                //$"{Id}, {VaccineName}, {DoseRequired}, {DaysBtwDose}, {TotalDose}";
        }
    }
}
