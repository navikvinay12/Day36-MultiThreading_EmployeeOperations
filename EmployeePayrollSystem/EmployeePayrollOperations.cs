using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayrollSystem
{
    public class EmployeePayrollOperations
    {
        public static string connectionString = @"Data Source=(localdb)\ProjectModels;Initial Catalog = PayrollService; Integrated Security = True";
        public SqlConnection connection ;
        List<EmployeeDetails> model = new List<EmployeeDetails>();
        public bool AddEmployee(EmployeeDetails model)     //Adding Employee into Table.
        {
            connection = new SqlConnection(connectionString);
            try
            {
                using (this.connection)
                {
                    this.connection.Open();
                    SqlCommand command = new SqlCommand("spAddEmployeeDetails", this.connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Name", model.Name);
                    command.Parameters.AddWithValue("@Salary", model.Salary);
                    command.Parameters.AddWithValue("@StartDate", DateTime.Now);
                    command.Parameters.AddWithValue("@Gender", model.Gender);
                    command.Parameters.AddWithValue("@empPhone", model.empPhone);
                    command.Parameters.AddWithValue("@Address", model.Address);
                    command.Parameters.AddWithValue("@Department", model.Department);
                    command.Parameters.AddWithValue("@Deductions", model.Deductions);
                    command.Parameters.AddWithValue("@Taxable_Pay", model.Taxable_Pay);
                    command.Parameters.AddWithValue("@Income_Tax", model.Income_Tax);
                    command.Parameters.AddWithValue("@Net_Pay", model.Net_Pay);
                    int count = command.ExecuteNonQuery();
                    if (count != 0)
                    {
                        //Console.WriteLine("Employee has been Added successfully into the table .");
                        return true;
                    }
                    else
                    {
                        //Console.WriteLine("Insert Query failed");
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                this.connection.Close();
            }
        }
        public void AddMultiplesEmployeesWithoutUsingThread(List<EmployeeDetails> model)
        {
            model.ForEach(data =>
            {
                Console.WriteLine("Employee being Added :"+ data.Name);
                this.AddEmployee(data);
                Console.WriteLine("Employee Added :" + data.Name);
            });
        }
    }
}
