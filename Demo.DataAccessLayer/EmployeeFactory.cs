using Demo.BussinessObject;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Demo.DataAccessLayer
{
    public class EmployeeFactory : IDisposable
    {
        public void Dispose()
        {
        }

        /// <summary>
        /// This method is used for get all employee
        /// </summary>
        /// <returns></returns>
        public List<Employee> GetEmployees()
        {
            try
            {
                List<Employee> employees = new List<Employee>();

                employees.Add(new Employee() { EmployeeId = 1, EmployeeCode = "EMP001", EmployeeName = "Ramesh Kumar", ContactNo = "9876543210", City = "Delhi" });
                employees.Add(new Employee() { EmployeeId = 2, EmployeeCode = "EMP002", EmployeeName = "Mohan Kumar", ContactNo = "9876543211", City = "Haryana" });
                employees.Add(new Employee() { EmployeeId = 3, EmployeeCode = "EMP003", EmployeeName = "Sohan Kumar", ContactNo = "9876543212", City = "Mumbai" });
                employees.Add(new Employee() { EmployeeId = 4, EmployeeCode = "EMP004", EmployeeName = "Vijay Kumar", ContactNo = "9876543213", City = "Bhopal" });

                return employees;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// This method is used for get employee by id
        /// </summary>
        /// <param name="empId"></param>
        /// <returns></returns>
        public Employee GetEmployee(int empId)
        {
            try
            {
                var employees = GetEmployees();
                Employee employee = employees.FirstOrDefault(x => x.EmployeeId == empId);
                return employee;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}