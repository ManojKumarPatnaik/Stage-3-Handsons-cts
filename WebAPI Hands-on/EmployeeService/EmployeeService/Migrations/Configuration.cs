namespace EmployeeService.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using EmployeeService.Models;
    using EmployeeService.Data;

    internal sealed class Configuration : DbMigrationsConfiguration<EmployeeService.Data.EmployeeServiceContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EmployeeService.Data.EmployeeServiceContext context)
        {
            context.Departments.AddOrUpdate(x => x.Id,
                new Department() { Id = 100, Name = "HR" },
                new Department() { Id = 101, Name = "Technical" }
                );

            context.Employees.AddOrUpdate(x => x.Id,
                new Employee() { Id = 1, FirstName = "John", LastName = "Smith", DepartmentId = 101, Salary = 30000 },
                new Employee() { Id = 2, FirstName = "Mary", LastName = "Lane", DepartmentId = 100, Salary = 20000 },
                new Employee() { Id = 3, FirstName = "Steve", LastName = "Lopez", DepartmentId = 101, Salary = 50000 }
                );
        }
    }
}
