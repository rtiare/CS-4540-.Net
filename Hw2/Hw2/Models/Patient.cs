using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Hw2.Models
{
    public class Patient
    {
        //setters and getters
        public int Pid { get; set; }
        public string Name { get; set; }

        public int VaccineId { get; set; }
        public Vaccine VaccineSelected { get; set; }

        [DataType(DataType.Date)]
        public DateTime FirstDose { get; set; }

        [DataType(DataType.Date)]
        public DateTime SecondDose { get; set; }

        public Patient() { }

        public Patient(string name, int vaccine, DateTime firstDose, DateTime secondDose)
        {
            Name = name;
            VaccineId = vaccine;
            FirstDose = firstDose;
            SecondDose = secondDose;

        }
    }
}
