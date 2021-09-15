using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Blazor.Models;

namespace Blazor.Pages 
{
    public partial class EmployeePage 
    {
        public IEnumerable <Employee> Employees { get; set; }
        
        protected override Task OnInitializedAsync()
        {
            LoadEmployees();
            return base.OnInitializedAsync();
        }

        private void LoadEmployees(){
            Employee e1 = new Employee{
                EmployeeId=1,
                FirstName="Haniel",
                LastName="Obed",
                Email="hanielobed4@gmail.com",
                DateOfBirth = new DateTime(2000,12,04),
                Gender = Gender.Male,
                Department = new Department{DepartmentId=1,DepartmentName="IT"},
                PhotoPath = "images/obed.jpg"
            };

             Employee e2 = new Employee{
                EmployeeId=2,
                FirstName="Yosana",
                LastName="Risya",
                Email="yosanarisya4@gmail.com",
                DateOfBirth = new DateTime(1994,12,08),
                Gender = Gender.Female,
                Department = new Department{DepartmentId=2,DepartmentName="CEO"},
                PhotoPath = "images/risya.jpg"
                  };
                  
             Employee e3 = new Employee{
                EmployeeId=3,
                FirstName="Kezia",
                LastName="Nauli",
                Email="kezianauli4@gmail.com",
                DateOfBirth = new DateTime(2004,12,10),
                Gender = Gender.Male,
                Department = new Department{DepartmentId=2,DepartmentName="Human Resource"},
                PhotoPath = "images/kezia.jpg"
                   };

                   Employees = new List<Employee>{e1,e2,e3};
        }
    }
}