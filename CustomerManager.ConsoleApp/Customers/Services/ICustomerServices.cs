using CustomerManager.ConsoleApp.Customers.Models;

namespace CustomerManager.ConsoleApp.Customers.Services;

public interface ICustomerServices
{
    Customer AddCustomer(string name, string email);
    IReadOnlyList<Customer> GetAllCustomers();

}
