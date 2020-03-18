using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TrashCollector.Models;

namespace TrashCollector.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Employee>()
            .HasData(
            new Employee
            {
                EmployeeId = 1
            }); ;

            builder.Entity<Customer>()
            .HasData(
            new Customer
            {
                CustomerId = 1
            }); ;
        }
        public DbSet<TrashCollector.Models.Customer> Customer { get; set; }
        public DbSet<TrashCollector.Models.Employee> Employee { get; set; }
    }
}
