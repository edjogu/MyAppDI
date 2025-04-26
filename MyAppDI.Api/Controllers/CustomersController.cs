using Microsoft.AspNetCore.Mvc;
using MyAppDI.Application.Services;
using MyAppDI.Domain.Entities;

namespace MyAppDI.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CustomersController : ControllerBase
{
    private readonly CustomerService _service;

    public CustomersController(CustomerService service)
    {
        _service = service;
    }

    /// <summary>
    /// Obtiene todos los clientes.
    /// </summary>
    /// <returns>Lista de clientes.</returns>
    /// <response code="200">Lista de clientes obtenida correctamente.</response>
    /// <response code="500">Error interno del servidor.</response>
    /// <response code="404">No se encontraron clientes.</response>
    /// <response code="400">Solicitud incorrecta.</response>
    /// <response code="401">No autorizado.</response>
    /// <response code="403">Prohibido.</response>
    /// <response code="408">Tiempo de espera agotado.</response>
    /// <response code="429">Demasiadas solicitudes.</response>
    /// <response code="503">Servicio no disponible.</response>
    /// <response code="504">Tiempo de espera agotado en la puerta de enlace.</response>
    /// <response code="511">Autenticación de red requerida.</response>
    /// <response code="418">Soy una tetera.</response>
    /// <response code="451">No disponible por razones legales.</response>
    [HttpGet]
    public ActionResult<IEnumerable<Customer>> Get()
    {
        var customers = _service.GetAllCustomers();
        return Ok(customers);
    
    }
    /// <summary>
    /// Obtiene un cliente por su ID.
    /// </summary>
    /// <param name="id">ID del cliente.</param>
    /// <returns>Cliente encontrado.</returns>
    /// <response code="200">Cliente encontrado.</response>
    /// <response code="404">Cliente no encontrado.</response>
    [HttpGet("{id}")]
    public ActionResult<Customer?> GetById(Guid id)
    {
        var customer = _service.GetCustomerById(id);
        if (customer == null)
        {
            return NotFound();
        }
        return Ok(customer);
    }
}
