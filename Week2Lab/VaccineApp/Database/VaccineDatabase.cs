using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VaccineApp.Model;

namespace VaccineApp.Database
{
    public class VaccineDatabase
    {
        //array
        private static List<VaccineModel> vaccineList = new List<VaccineModel>() {
            new VaccineModel("Pfizer/BioNTech", 2, 21, 10000),
            new VaccineModel("Johnson & Johnson", 1, null, 5000)
        };

        //return object based on ID
        public static VaccineModel Selected(int id) => vaccineList.Find(obj => obj.vaccineID == id);

        //return seclected name of vaccine
        public static string SelectedName(int id) => vaccineList.Find(obj => obj.vaccineID == id).VaccineName;

        //return list
        public static List<VaccineModel> VaccineList {
            get { return vaccineList; }
        }


    }
}
