using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;


namespace Practical.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            EmployeeDbContext context = app.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<EmployeeDbContext>();
            if (context.Database.GetAppliedMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Employees.Any())
            {
                context.Employees.AddRange(
                     new Employee
                     {
                         firstName = "Wod",
                         lastName = "Wiliam",
                         Gender = "Male",
                         Salary = 2505
                     },
                     new Employee
                     {
                         firstName = "Muievzsif",
                         lastName = "Role",
                         Gender = "Female",
                         Salary = 1095
                     },
                     new Employee
                     {
                         firstName = "Yeidwew",
                         lastName = "Donysres",
                         Gender = "Male",
                         Salary = 4532
                     },
                     new Employee
                     {
                         firstName = "Piagavw",
                         lastName = "Nbataaw",
                         Gender = "Male",
                         Salary = 1144
                     },
                     new Employee
                     {
                         firstName = "Heuatdsew",
                         lastName = "Coitefdaw",
                         Gender = "Female",
                         Salary = 3042
                     },
                     new Employee
                     {
                         firstName = "Kevudarw",
                         lastName = "Jertasfad",
                         Gender = "Female",
                         Salary = 2351
                     }
            );
                context.SaveChanges();
            }
        }
    }
}
