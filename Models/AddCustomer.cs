﻿namespace ASP.NET_Core_App.Models
{
    public class AddCustomer
    {
        public required string Name { get; set; }
        public required string Email { get; set; }
        public string? Phone { get; set; }
    }
}