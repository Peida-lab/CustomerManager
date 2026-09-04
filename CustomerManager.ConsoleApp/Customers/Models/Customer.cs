namespace CustomerManager.ConsoleApp.Customers.Models;

public record Customer
(
    Guid Id,
    String Name,
    string Email
);
