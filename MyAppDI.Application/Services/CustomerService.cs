using MyAppDI.Domain.Entities;
using MyAppDI.Domain.Interfaces;

namespace MyAppDI.Application.Services;


public class CustomerService
{
    private readonly ICustomerRepository _repository;

    public CustomerService(ICustomerRepository repository)
    {
        _repository = repository;
    }

    public IEnumerable<Customer> GetAllCustomers()
    {
        return _repository.GetAll();
    }

    public Customer? GetCustomerById(Guid id)
    {
        var customers = _repository.GetAll();
        return customers.FirstOrDefault(c => c.Id == id);

    }
}
