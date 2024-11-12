using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using ASP.NET_Core_App.Services;
using ASP.NET_Core_App.Token;
using ASP.NET_Core_App.Data;
using Microsoft.AspNetCore.Authorization;
using ASP.NET_Core_App.Models;

namespace ASP.NET_Core_App.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly AppDbContext dBContext;
        public CustomerController(AppDbContext dbContext)
        {
            this.dBContext = dbContext;
        }

        // GET: api/customer
        [Authorize(Roles = "admin")]
        [HttpGet]
        public IActionResult GetAllCustomers()
        {
            var allCustomers = dBContext.Customer.ToList();
            return Ok(allCustomers);
        }

        [HttpGet]
        [Route("{id:guid}")]
        [Authorize(Roles = "admin")]
        public IActionResult GetCustomerById(Guid id)
        {

            var customer = dBContext.Customer.Find(id);

            if (customer is null)
            {
                return NotFound();
            }

            return Ok(customer);
        }

        [HttpPost]
        public IActionResult AddCustomer(AddCustomer addCustomerDto)
        {
            var customerEntity = new Models.Customer()
            {
                Name = addCustomerDto.Name,
                Email = addCustomerDto.Email,
                Phone = addCustomerDto.Phone
            };

            dBContext.Customer.Add(customerEntity);
            dBContext.SaveChanges();

            return Ok(customerEntity);
        }

        [HttpPut]
        [Route("{id:guid}")]
        public IActionResult UpdateCustomerById(Guid id, UpdateCustomer UpdateCustomerDto)
        {
            var customer = dBContext.Customer.Find(id);
            if (customer is null)
            {
                return NotFound();
            }
            customer.Name = UpdateCustomerDto.Name;
            customer.Email = UpdateCustomerDto.Email;
            customer.Phone = UpdateCustomerDto.Phone;

            dBContext.SaveChanges();
            return Ok(customer);
        }

        [HttpDelete]
        [Route("{id:guid}")]
        public IActionResult DeleteCustomerById(Guid id)
        {

            var customer = dBContext.Customer.Find(id);

            if (customer is null)
            {
                return NotFound();
            }

            dBContext.Customer.Remove(customer);
            dBContext.SaveChanges();
            return Ok();

        }
    }
}
