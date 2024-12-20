using Microsoft.AspNetCore.Mvc;
using PrimeiraAPI.Model;
using PrimeiraAPI.ViewModel;

namespace PrimeiraAPI.Controllers
{
    [ApiController]
    [Route("api/v1/Customer")]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerController(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository ?? throw new ArgumentNullException(nameof(customerRepository));
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody]CustomerViewModel customerView)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState); // Retorna os erros de validação
            }
            
            // Mapeando o ViewModel para a entidade
            var customer = new Customer(                
                customerView.NameStyle,
                customerView.Title,
                customerView.FirstName,
                customerView.MiddleName,
                customerView.LastName,
                customerView.Suffix,
                customerView.CompanyName,
                customerView.SalesPerson,
                customerView.EmailAddress,
                customerView.Phone,
                customerView.PasswordHash,
                customerView.PasswordSalt,                
                customerView.ModifiedDate
            );

            // Adicionando o cliente de forma assíncrona
            await _customerRepository.AddAsync(customer);

            return Ok(); // Retorna 200 OK
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            // Obtém todos os clientes de forma assíncrona
            var customers = await _customerRepository.GetAllAsync();

            return Ok(customers); // Retorna 200 OK com a lista de clientes
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            // Obtém o cliente pelo ID de forma assíncrona
            var customer = await _customerRepository.GetByIdAsync(id);

            if (customer == null)
                return NotFound(); // Retorna 404 se não encontrado

            return Ok(customer); // Retorna 200 OK com o cliente encontrado
        }
    }
}
