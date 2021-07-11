using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VaccineApp.Model;


namespace VaccineApp
{
    public class AppDbContext : DbContext
    {
        private readonly string ConnectionString =
            "Server=cs3.calstatela.edu;Database=cs4540stu30;User ID = cs4540stu30; Password=qKNZQtCkG5Qf";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer(ConnectionString).UseLazyLoadingProxies();
        }

        public DbSet<VaccineModel> Vaccines { get; set; } 
    }
}
