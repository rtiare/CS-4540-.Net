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
        public int Id { get; set; }
        public string Name { get; set; }
        public String Vaccine { get; set; }

        public Vaccine vaccineSelected { get; set; }

        [DataType(DataType.Date)]
        public DateTime FirstDose { get; set; }

        [DataType(DataType.Date)]
        public DateTime SecondDose { get; set; }

        public Patient() { }

        public Patient(string name, string vaccine, DateTime firstDose, DateTime secondDose)
        {
            Name = name;
            Vaccine = vaccine;
            FirstDose = firstDose;
            SecondDose = secondDose;

        }
    }
}
