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
        public VaccineModel pfizer = new VaccineModel("Pfizer / BioNTech", 2, 21, 10000);
        public VaccineModel jj = new VaccineModel("Johnson & Johnson", 1, null, 5000);

        public List<VaccineModel> vaccineList { get; set; }
    }
}
