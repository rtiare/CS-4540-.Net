using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaccineApp.Model
{
    public class VaccineModel
    {
        //constructor to create with properties
        public VaccineModel(string VaccineName, int DoseRequired, int DaysBtwDose, int totalDose) {
            this.VaccineName = VaccineName;
            this.DoseRequired = DoseRequired;
            this.DaysBtwDose = DaysBtwDose;
            this.totalDose = totalDose;
        }

        //setters and getters
        public string VaccineName { get; set; }
        public int DoseRequired { get; set; }
        public int DaysBtwDose { get; set; }
        public int totalDose { get; set; }
    }
}
