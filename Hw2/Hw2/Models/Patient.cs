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

        public string Vaccineid { get; set; }

        [DataType(DataType.Date)]
        public DateTime FirstDose { get; set; }

        [DataType(DataType.Date)]
        public string SecondDose { get; set; }

        public Patient() { }


        //create another class with id
        public Patient(string name, string vaccine, DateTime firstDose, string secondDose)
        {
            Name = name;
            Vaccineid = vaccine;
            FirstDose = firstDose;
            SecondDose = secondDose;

        }
    }
}
