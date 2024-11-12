using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Collections.Generic;
using ASP.NET_Core_App.Models;
using ASP.NET_Core_App.Token;
namespace ASP.NET_Core_App.Services
{
    public class Service
    {
        private readonly HttpClient _httpClient;
        private readonly string serviceRoot;

        public Service(HttpClient httpClient)
        {
            _httpClient = httpClient;
            serviceRoot = "http://jo:7048/BC240/ODataV4/Company('CRONUS%20International%20Ltd.')";
        }

        public async Task<List<Customer>> GetCustomersAsync()
        {
            var url = $"{serviceRoot}/CustomerList";
            var response = await _httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                var jsonString = await response.Content.ReadAsStringAsync();
                var jsonData = JsonDocument.Parse(jsonString);
                var customers = jsonData.RootElement.GetProperty("value");

                return JsonSerializer.Deserialize<List<Customer>>(customers.ToString());
            }
            return new List<Customer>();
        }

        public async Task<Customer?> GetCustomerByIdAsync(string id)
        {
            var url = $"{serviceRoot}/CustomerList('{id}')";
            var response = await _httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                var jsonString = await response.Content.ReadAsStringAsync();
                return JsonSerializer.Deserialize<Customer>(jsonString);
            }
            return null;
        }

        public async Task<Customer> CreateCustomerAsync(CustomerCreateOrUpdate newCustomer, string token)
        {
            // Validate the token
            if (!TokenHelper.ValidateToken(token))
            {
                throw new UnauthorizedAccessException("Invalid token provided.");
            }

            var url = $"{serviceRoot}/CustomerCard";
            var jsonContent = JsonSerializer.Serialize(newCustomer);
            var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync(url, content);
            response.EnsureSuccessStatusCode();

            var jsonString = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<Customer>(jsonString);
        }

        public async Task<List<Employee>> GetEmployeesAsync()
        {
            var url = $"{serviceRoot}/EmployeeList";
            var response = await _httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                var jsonString = await response.Content.ReadAsStringAsync();
                var jsonData = JsonDocument.Parse(jsonString);
                var employees = jsonData.RootElement.GetProperty("value");

                return JsonSerializer.Deserialize<List<Employee>>(employees.ToString());
            }
            return new List<Employee>();
        }

        public async Task<Employee?> GetEmployeeByIdAsync(string id)
        {
            var url = $"{serviceRoot}/EmployeeList('{id}')";
            var response = await _httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                var jsonString = await response.Content.ReadAsStringAsync();
                return JsonSerializer.Deserialize<Employee>(jsonString);
            }
            return null;
        }

        public async Task<Employee> CreateEmployeeAsync(EmployeeCreateOrUpdate newEmployee, string token)
        {
            // Validate the token
            if (!TokenHelper.ValidateToken(token))
            {
                throw new UnauthorizedAccessException("Invalid token provided.");
            }

            var url = $"{serviceRoot}/CustomerCard";
            var jsonContent = JsonSerializer.Serialize(newEmployee);
            var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync(url, content);
            response.EnsureSuccessStatusCode();

            var jsonString = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<Employee>(jsonString);
        }
    }

    public class Customer
    {
        public string No { get; set; }
        public string Name { get; set; }
        public string Contact { get; set; }
        public string Post_Code { get; set; }
        public string Country_Region_Code { get; set; }
        public string Phone_No { get; set; }
        public string Currency_Code { get; set; }
        public string Salesperson_Code { get; set; }
        public string Customer_Posting_Group { get; set; }
        public string Last_Date_Modified { get; set; }
    }

    public class Employee
    {
        public string No { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Job_Title { get; set; }
        public string Country_Region_Code { get; set; }
        public string Phone_No { get; set; }
        public string E_Mail { get; set; }
    }

    public class CustomerCreateOrUpdate
    {
        public string No { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public string Country_Region_Code { get; set; }
        public string Post_Code { get; set; }
        public string Phone_No { get; set; }
        public string E_Mail { get; set; }
    }

    public class EmployeeCreateOrUpdate
    {
        public string No { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Job_Title { get; set; }
        public string Country_Region_Code { get; set; }
        public string Phone_No { get; set; }
        public string E_Mail { get; set; }
    }
}
