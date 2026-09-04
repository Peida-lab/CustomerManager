using CustomerManager.ConsoleApp.Customers.Models;

namespace CustomerManager.ConsoleApp.Customers.Services;

public class InMemoryCustomerService : ICustomerServices
{
    public Customer AddCustomer(string name, string email)
    {
        throw new NotImplementedException();
    }

    public IReadOnlyList<Customer> GetAllCustomers()
    {
        throw new NotImplementedException();
    }
}
