using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaccineApp.Model
{
    public class VaccineModel
    {
        //ID
        private static int id = 0;
        //constructor to create with properties
        public VaccineModel(string vaccineName, int? doseRequired = null, int? daysBtwDose = null, int? totalDose = null) {
 
            //auto increment ID when adding new object
            id++;
            this.VaccineId = id;
            this.VaccineName = vaccineName;
            this.DoseRequired = doseRequired;
            this.DaysBtwDose = daysBtwDose;
            this.TotalDose = totalDose;
        }

        //setters and getters
        public int VaccineId { get; set; }
        public string VaccineName { get; set; }
        public int? DoseRequired { get; set; }
        public int? DaysBtwDose { get; set; }
        public int? TotalDose { get; set; }
    }
}
