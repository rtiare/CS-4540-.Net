using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VaccineApp.Database;
using VaccineApp.Model;

namespace VaccineApp.Controller
{
    public class VaccineController
    {
        //add vaccine
        public static void addVaccine(VaccineModel newVaccine) => VaccineDatabase.VaccineList.Add(newVaccine);

        //public void addDose(int vaccineID) => data.vaccineList.Find(obj => obj.vaccineID == vaccineID);

       
        
    }
}
