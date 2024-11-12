using Microsoft.AspNetCore.Mvc;
using ASP.NET_Core_App.Models;
using ASP.NET_Core_App.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;

namespace ASP.NET_Core_App.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : Controller
    {
        private readonly AppDbContext dBContext;
        public EmployeeController(AppDbContext dbContext)
        {
            this.dBContext = dbContext;
        }

        [Authorize(Roles = "Admin")]
        [HttpGet]
        public IActionResult GetAllEmployees()
        {

            var allEmployees = dBContext.Employee.ToList();
            return Ok(allEmployees);
        }

        [HttpGet]
        [Route("{id:guid}")]
        [Authorize(Roles = "Admin")]
        public IActionResult GetEmployeeByID(Guid id)
        {

            var employee = dBContext.Employee.Find(id);

            if (employee is null)
            {
                return NotFound();
            }

            return Ok(employee);
        }

        [HttpPut]
        [Route("{id:guid}")]
        public IActionResult UpdateEmployeeByID(Guid id, AddEmployee UpdateEmployee)
        {
            var employee = dBContext.Employee.Find(id);
            if (employee is null)
            {
                return NotFound();
            }
            employee.Name = UpdateEmployee.Name;
            employee.Email = UpdateEmployee.Email;
            employee.Phone = UpdateEmployee.Phone;

            dBContext.SaveChanges();
            return Ok(employee);
        }

        [HttpPost]
        public IActionResult AddEmployee(AddEmployee AddEmployee)
        {
            var employeeEntity = new Employee()
            {
                Name = AddEmployee.Name,
                Email = AddEmployee.Email,
                Phone = AddEmployee.Phone
            };

            dBContext.Employee.Add(employeeEntity);
            dBContext.SaveChanges();

            return Ok(employeeEntity);
        }

        [HttpDelete]
        [Route("{id:guid}")]
        public IActionResult DeleteEmployeeByID(Guid id)
        {

            var employee = dBContext.Employee.Find(id);

            if (employee is null)
            {
                return NotFound();
            }

            dBContext.Employee.Remove(employee);
            dBContext.SaveChanges();
            return Ok();

        }
    }
}
