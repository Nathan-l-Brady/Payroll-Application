using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Brady_N_PayRoll_Application.Models;

namespace Brady_N_PayRoll_Application.Data
{
    public class Brady_N_PayRoll_ApplicationContext : DbContext
    {
        public Brady_N_PayRoll_ApplicationContext (DbContextOptions<Brady_N_PayRoll_ApplicationContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<position>().HasData(
                new position { positionId = 1, positionName = "Team Lead" },

                new position { positionId = 2, positionName = "Team member" },

                new position { positionId = 3, positionName = "Manager"}
                );

            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    EmployeeID = 10,
                    firstName = "John",
                    lastName = "Doe",
                    Address = "550 East Spring st",
                    phone = "123-456-7890",
                    hourlyRate = 15,
                    postionId = 1,
                    email = "JohnDoe123@gmail.com"
                     
                   
                });     
        }

        public DbSet<Brady_N_PayRoll_Application.Models.Employee> Employee { get; set; } = default!;
        public DbSet<Brady_N_PayRoll_Application.Models.position> position { get; set; } = default!;
    }
}
