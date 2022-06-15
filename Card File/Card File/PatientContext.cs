using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Card_File
{
    /// <summary>
    /// @Author Daniel Cifka
    /// @Version 1.0
    /// This class hold collection of all data in database
    /// </summary>
    public  class PatientContext: DbContext
    {
        public DbSet<Patient> Patients { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=patients.db"); ///Connection into our database
        }
    }
}
