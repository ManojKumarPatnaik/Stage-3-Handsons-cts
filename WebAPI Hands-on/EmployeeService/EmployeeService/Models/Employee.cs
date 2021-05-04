using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EmployeeService.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public float Salary { get; set; }

        //FK
        public int DepartmentId { get; set; }

        //Navigational Property
        public Department Department { get; set; }
    }
}