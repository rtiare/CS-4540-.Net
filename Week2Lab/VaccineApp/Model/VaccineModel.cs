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
        private static int Id = 0;
        //constructor to create with properties
        public VaccineModel(string VaccineName, int? DoseRequired, int? DaysBtwDose, int? totalDose) {
 
            //auto increment ID when adding new object
            Id++;
            this.vaccineID = Id;
            this.VaccineName = VaccineName;
            this.DoseRequired = DoseRequired;
            this.DaysBtwDose = DaysBtwDose;
            this.totalDose = totalDose;
        }

        //setters and getters
        public int vaccineID { get; set; }
        public string VaccineName { get; set; }
        public int? DoseRequired { get; set; }
        public int? DaysBtwDose { get; set; }
        public int? totalDose { get; set; }
    }
}
