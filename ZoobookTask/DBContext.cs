using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using ZoobookTask.Models;

namespace ZoobookTask
{
    public class DBContext: DbContext
    {
        //public DBContext(DbContextOptions<DbContext> options) : base(options)
        //{

        //}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=ISHTIAQASIF-PC;Database=EmployeeRecords;Integrated Security=True;");
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
