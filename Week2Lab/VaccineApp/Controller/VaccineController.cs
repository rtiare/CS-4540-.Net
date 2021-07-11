﻿using System;
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
        public static void AddVaccine(VaccineModel newVaccine, AppDbContext db) {
            db.Vaccines.Add(newVaccine);
            db.SaveChanges();
        }

        //add new dose
        public static void AddDose(int vaccineId, int newDose, AppDbContext db) {

            var obj = db.Vaccines.Find(vaccineId);
            obj.TotalDose += newDose;
            db.SaveChanges();
        }

        //return selected name
        public static string SelectedName(int id, AppDbContext db)
        {
            var name = db.Vaccines.Where(e => e.Id == id).Select(e => e.VaccineName).FirstOrDefault();
            return name;
        }

    }
}
