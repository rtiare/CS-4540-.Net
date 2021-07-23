﻿using Hw2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hw2.Services
{
    public interface IVaccineService {
        List<Vaccine> GetVaccines();
    }

    public class VaccineService : IVaccineService {

        private readonly AppDbContext _db;
        public VaccineService(AppDbContext db) {
            _db = db;
        }

        public List<Vaccine> GetVaccines() {
            return _db.Vaccines.ToList();
        }
    
    }
    public class MockVaccineService : IVaccineService
    {
        private List<Vaccine> vaccines;

        public MockVaccineService() {
            vaccines = new List<Vaccine> {
                new Vaccine(1, "Pfizer/BioNTech", 2, 21,  10000,   10000)};
        }
        public List<Vaccine> GetVaccines()
        {
            return vaccines;
        }
    }

}
