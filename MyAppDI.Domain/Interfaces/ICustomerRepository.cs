using MyAppDI.Domain.Entities;

namespace MyAppDI.Domain.Interfaces;

public interface ICustomerRepository
{
    IEnumerable<Customer> GetAll();
}
