using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayrollSystem
{
    public class EmployeeDetails
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public DateTime StartDate { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public long empPhone { get; set; }
        public string Department { get; set; }
        public double Deductions { get; set; }
        public double Taxable_Pay { get; set; }
        public double Income_Tax { get; set; }
        public double Net_Pay { get; set; }
        public EmployeeDetails(int Id, string Name, double Salary, DateTime StartDate, string Gender, long empPhone, string Address,
                                string Department, double Deductions, double Taxable_Pay, double Income_Tax, double Net_Pay)
        {
            this.Id = Id;
            this.Name = Name;
            this.Salary = Salary;
            this.StartDate = StartDate;
            this.Gender = Gender;
            this.empPhone = empPhone;
            this.Address = Address;
            this.Department = Department;
            this.Deductions = Deductions;
            this.Taxable_Pay = Taxable_Pay;
            this.Income_Tax = Income_Tax;
            this.Net_Pay = Net_Pay;
        }
    }
}
