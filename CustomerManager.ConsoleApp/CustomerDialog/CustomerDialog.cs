using CustomerManager.ConsoleApp.Customers.Services;

namespace CustomerManager.ConsoleApp.CustomerDialog;

public class CustomerDialog(ICustomerServices customerService) : ICustomerDialog
{
    public void AddCustomerDialog()
    {
        throw new NotImplementedException();
    }

    public void ShowAllCustomersDialog()
    {
        throw new NotImplementedException();
    }
}
