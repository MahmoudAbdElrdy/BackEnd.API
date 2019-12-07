using System;
using System.Collections.Generic;
using System.Text;

namespace BackEnd.DAL.Entities
{
   public class Department
    {
        public int DepartmentID { get; set; }

      public string DepartmentName { get; set; }
       public string DepartmentCode { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
