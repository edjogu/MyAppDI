using MyAppDI.Domain.Entities;
using MyAppDI.Domain.Interfaces;

namespace MyAppDI.Infrastructure.Repositories;

public class CustomerRepository : ICustomerRepository
{
    public IEnumerable<Customer> GetAll()
    {
        // Simulación de datos (mock)
        return new List<Customer>
        {
            new Customer { Id = Guid.NewGuid(), Name = "Ana López", Email = "ana@example.com" },
            new Customer { Id = Guid.NewGuid(), Name = "Carlos Ramírez", Email = "carlos@example.com" }
        };
    }
}
