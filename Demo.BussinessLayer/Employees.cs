using Demo.BussinessObject;
using Demo.DataAccessLayer;
using System;
using System.Collections.Generic;

namespace Demo.BussinessLayer
{
    public class Employees : IDisposable
    {
        public void Dispose()
        {
        }

        /// <summary>
        /// This method is used for get all employees
        /// </summary>
        /// <returns></returns>
        public List<Employee> GetEmployees()
        {
            try
            {
                using (EmployeeFactory factory = new EmployeeFactory())
                {
                    return factory.GetEmployees();
                }
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
                using (EmployeeFactory factory = new EmployeeFactory())
                {
                    return factory.GetEmployee(empId);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}