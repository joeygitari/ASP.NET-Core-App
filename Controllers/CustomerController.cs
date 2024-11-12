using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using ASP.NET_Core_App.Services;
using ASP.NET_Core_App.Token;
using Microsoft.AspNetCore.Authorization;

namespace ASP.NET_Core_App.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : Controller
    {
        private readonly Service _customerService;

        public CustomerController(Service customerService)
        {
            _customerService = customerService;
        }

        // GET: api/customer
        [Authorize(Roles = "Admin,User")]
        [HttpGet]
        public async Task<IActionResult> GetAllCustomers()
        {
            var customers = await _customerService.GetCustomersAsync();
            return Ok(customers);
        }

        // GET: api/customer/{id}
        [Authorize(Roles = "Admin,User")]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCustomerById(string id)
        {
            var customer = await _customerService.GetCustomerByIdAsync(id);
            return customer != null ? Ok(customer) : NotFound();
        }

        // POST: api/customer
        [HttpPost]
        [Authorize(Roles = "Admin")]

        public async Task<IActionResult> CreateCustomer([FromBody] CustomerCreateOrUpdate newCustomer)
        {
            // Log incoming headers for debugging
            var headers = Request.Headers;
            foreach (var header in headers)
            {
                Console.WriteLine($"{header.Key}: {header.Value}");
            }

            // Retrieve the token from the Authorization header
            //var token = Request.Headers["Authorization"].ToString().Replace("Bearer ", "").Trim();

            // Temporary hard-coded token for testing
            var token = "BlwgASYaowZyjOLZfdzIiWLJNqRiObj5bwKS2Jp15gQ=";


            // Validate the token
            if (string.IsNullOrWhiteSpace(token))
            {
                return Unauthorized("Authorization token is required.");
            }

            if (!TokenHelper.ValidateToken(token))
            {
                return Unauthorized("Invalid token.");
            }

            // Create the customer if the token is valid
            try
            {
                var createdCustomer = await _customerService.CreateCustomerAsync(newCustomer, token);
                return CreatedAtAction(nameof(GetCustomerById), new { id = createdCustomer.Id }, createdCustomer);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }

        }
    }
}
