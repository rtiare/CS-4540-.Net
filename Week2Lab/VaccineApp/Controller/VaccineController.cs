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
        public static void AddVaccine(VaccineModel newVaccine) => VaccineDatabase.VaccineList.Add(newVaccine);

        //add new dose
        public static void AddDose(int vaccineId, int newDose) => VaccineDatabase.VaccineList.Find(obj => obj.VaccineId == vaccineId).TotalDose += newDose;

    }
}
