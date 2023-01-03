using EmployeePayrollSystem;
using System.Collections.Generic;

namespace EmployeePayrollTest
{
    [TestClass]
    public class UnitTest1
    {
        EmployeePayrollOperations employeePayrollOperations= new EmployeePayrollOperations();
        [TestMethod]
        public void GivenMultipleEmployeeDetails_ShouldReturnTotalExecutionTime()
        {
            List<EmployeeDetails> employeeDetails= new List<EmployeeDetails>();
            employeeDetails.Add(new EmployeeDetails(Id: 11, Name: "Karan", Salary: 20000, StartDate: new DateTime(2022, 06, 01), Gender: "M", empPhone: 987732, Address: "Goa", Department: "Developer", Deductions: 200, Taxable_Pay: 500, Income_Tax: 600, Net_Pay: 19500));
            employeeDetails.Add(new EmployeeDetails(Id: 12, Name: "Himanshu", Salary: 30000, StartDate: new DateTime(2022, 05, 01), Gender: "M", empPhone: 716098, Address: "shimla", Department: "HR", Deductions: 200, Taxable_Pay: 500, Income_Tax: 600, Net_Pay: 19500));
            employeeDetails.Add(new EmployeeDetails(Id: 13, Name: "Rohan", Salary: 40000, StartDate: new DateTime(2022, 04, 01), Gender: "M", empPhone: 610987, Address: "haryana", Department: "Accounts", Deductions: 200, Taxable_Pay: 500, Income_Tax: 600, Net_Pay: 19500));
            employeeDetails.Add(new EmployeeDetails(Id: 14, Name: "Kunal", Salary: 50000, StartDate: new DateTime(2022, 03, 01), Gender: "M", empPhone: 721098, Address: "punjab", Department: "IT", Deductions: 200, Taxable_Pay: 500, Income_Tax: 600, Net_Pay: 19500));
            employeeDetails.Add(new EmployeeDetails(Id: 15, Name: "Poonam", Salary: 35000, StartDate: new DateTime(2022, 02, 01), Gender: "F", empPhone: 895321, Address: "ahmedabad", Department: "Finance", Deductions: 200, Taxable_Pay: 500, Income_Tax: 600, Net_Pay: 19500));
            
            DateTime startTime= DateTime.Now;
            employeePayrollOperations.AddMultiplesEmployeesWithoutUsingThread(employeeDetails);        //Adding multiple employees
            DateTime stopTime= DateTime.Now;
            Console.WriteLine("Elapsed Time WITHOUT Thread :"+(stopTime-startTime));        //Without Thread    UC1

        }
    }
}