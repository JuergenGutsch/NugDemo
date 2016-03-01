using System.Collections.Generic;
using Demo.Models;
using GenFu;

namespace Demo.Services
{
    public class CustomerService : ICustomerService
    {
        public IEnumerable<Customer> LoadTopCustomers()
        {
            return A.ListOf<Customer>(50);
        }
    }
}