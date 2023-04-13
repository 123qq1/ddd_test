using ddd_test.customer.api.contracts;
using ddd_test.customer.infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace ddd_test.customer.api.controllers
{

    [Route("/api/customer")]
    public class customerController : ControllerBase
    {
        private customerRepository _repository;

        public customerController(customerRepository repository)
        {
            _repository = repository;
        }

        [HttpPost]
        [Route("create")]
        public async Task<IActionResult> Create(createCustomerDto dto)
        {
            var customer = await _repository.LoadAsync(dto.customerID);
            customer.Create(
                dto.customerID,
                dto.customerName,
                dto.accountName,
                dto.discordName                
                );

            await _repository.SaveAsync(customer);

            return Ok();
        }
    }
}
