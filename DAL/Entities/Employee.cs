using System;
using System.Collections.Generic;
using System.Text;

namespace BackEnd.DAL.Entities
{
  public  class Employee
    {
        public int EmployeeID { get; set; }
      public string EmployeeName { get; set; }
       public decimal EmployeeSalary { get; set; }
        public DateTime EmployeeBirthDate { get; set; }
      public bool EmployeeGender { get; set; }
        public virtual Department department { get; set; }
    }
}
