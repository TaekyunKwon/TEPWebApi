using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TEPWebApi.Models;

namespace TEPWebApi.Controllers
{
    public class EmployeeController : ApiController
    {
        Employee[] employees = new Employee[]
        {
            new Employee {Id=1, Name="Ted"},
            new Employee {Id=2, Name="Fernando"},
            new Employee {Id=3, Name="Heidi"},
            new Employee {Id=4, Name="Kate"},
            new Employee {Id=5, Name="John"}
        };

        public IEnumerable<Employee> GetAllEmployees()
        {
            return employees;
        }

        public IHttpActionResult GetEmployee(int id)
        {
            var employee = employees.FirstOrDefault(p => p.Id == id);

            if(employee == null)
            {
                return NotFound();
            } else
            {
                return Ok(employee);
            }
        }
    }
}
