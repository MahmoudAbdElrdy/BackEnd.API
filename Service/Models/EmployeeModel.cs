using System;
using System.Collections.Generic;
using System.Text;

namespace BackEnd.Service.Models
{
   public class EmployeeModel
    {
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public decimal EmployeeSalary { get; set; }
        public DateTime EmployeeBirthDate { get; set; }
        public bool EmployeeGender { get; set; }
    }
}
