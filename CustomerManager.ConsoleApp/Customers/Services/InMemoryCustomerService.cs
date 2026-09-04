using CustomerManager.ConsoleApp.Customers.Models;

namespace CustomerManager.ConsoleApp.Customers.Services;

public class InMemoryCustomerService : ICustomerServices
{
    private readonly List<Customer> _customerList = [];
    public Customer AddCustomer(string name, string email)
    {
        var customerId = Guid.NewGuid();

        var customer = new Customer(customerId, name, email);
        
        _customerList.Add(customer);

        return customer;
    }

    public IReadOnlyList<Customer> GetAllCustomers()
    {
        return _customerList
            .OrderBy(customer => customer.Name)
            .ToList();
    }
}
