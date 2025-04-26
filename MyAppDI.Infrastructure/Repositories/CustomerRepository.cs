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
            new Customer { Id = Guid.Parse("25b97260-c50f-4496-9d4a-dc5bf256d071"), Name = "Ana López", Email = "ana@example.com" },
            new Customer { Id = Guid.Parse("4ad830c2-7fb8-4504-98dc-53dd7b66d45e"), Name = "Carlos Ramírez", Email = "carlos@example.com" }
        };
    }
}
