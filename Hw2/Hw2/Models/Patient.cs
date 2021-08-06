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

        public int Vaccineid { get; set; }
        public Vaccine VaccineSelected { get; set; }

        [DataType(DataType.Date)]
        public DateTime FirstDose { get; set; }

        [DataType(DataType.Date)]
        public DateTime SecondDose { get; set; }

        public Patient() { }


        //create another class with id
        public Patient(string name, int vaccine, DateTime firstDose, DateTime secondDose)
        {
            Name = name;
            Vaccineid = vaccine;
            FirstDose = firstDose;
            SecondDose = secondDose;

        }
    }
}
