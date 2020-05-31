using Demo.BussinessLayer;
using Demo.BussinessObject;
using Demo.Web.API.Models;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Demo.Web.API.Controllers
{
    public class EmployeeController : ApiController
    {
        [HttpGet]
        public HttpResponseMessage GetEmployees()
        {
            try
            {
                ApiResponce<List<Employee>> apiResponce = new ApiResponce<List<Employee>>();
                using (Employees employees = new Employees())
                {
                    apiResponce.Responce = employees.GetEmployees();
                    apiResponce.Message = "Record Found";
                    apiResponce.Status = "Success";
                }
                return Request.CreateResponse(HttpStatusCode.OK, apiResponce);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.InnerException);
            }
        }

        [HttpGet]
        public HttpResponseMessage GetEmployee(int id)
        {
            try
            {
                ApiResponce<Employee> apiResponce = new ApiResponce<Employee>();
                using (Employees employees = new Employees())
                {
                    apiResponce.Responce = employees.GetEmployee(id);
                    apiResponce.Message = "Record Found";
                    apiResponce.Status = "Success";
                }
                return Request.CreateResponse(HttpStatusCode.OK, apiResponce);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.InnerException);
            }
        }
    }
}