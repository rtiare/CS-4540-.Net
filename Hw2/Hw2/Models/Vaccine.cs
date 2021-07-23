using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hw2.Models
{
    public class Vaccine
    {
        //setters and getters
        public int Id { get; set; }
        public string VaccineName { get; set; }
        public int? DoseRequired { get; set; }
        public int? DaysBtwDose { get; set; }
        public int? TotalDose { get; set; }

        public int? DoseLeft { get; set; }

        public Vaccine() { }

        public Vaccine(string name, int? dose, int? days, int? total, int? left ) {
            //Id = id;
            VaccineName = name;
            DoseRequired = dose;
            DaysBtwDose = days;
            TotalDose = total;
            DoseLeft = left;
        }

        public override string ToString()
        {
            return String.Format("{0,-3}{1,-23}{2,-18}{3,-21}{4,-12}\n",
                    $"{Id})",
                    $"{VaccineName}",
                    $"{DoseRequired}",
                    $"{DaysBtwDose}",
                    $"{TotalDose}");
        }

    }
}
