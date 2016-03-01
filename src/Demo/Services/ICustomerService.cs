using System.Collections.Generic;
using Demo.Models;

namespace Demo.Services
{
    public interface ICustomerService
    {
        IEnumerable<Customer> LoadTopCustomers();
    }
}