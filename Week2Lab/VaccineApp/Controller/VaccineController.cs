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

        VaccineDatabase data = new VaccineDatabase();

        public void initialView() {
            data.vaccineList.Add(data.pfizer);
            data.vaccineList.Add(data.jj);
        }

        //add vaccine
        public void addVaccine(VaccineModel newVaccine) => data.vaccineList.Add(newVaccine);

        public void addDose(int vaccineID) { 

        }
        
    }
}
