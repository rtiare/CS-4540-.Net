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
        private static List<VaccineModel> vaccineList = new List<VaccineModel>() {
            new VaccineModel("Pfizer / BioNTech", 2, 21, 10000),
            new VaccineModel("Johnson & Johnson", 1, null, 5000)
        };

        public static List<VaccineModel> VaccineList {
            get { return vaccineList; }
        }


    }
}
