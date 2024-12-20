using Microsoft.EntityFrameworkCore;
using PrimeiraAPI.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PrimeiraAPI.Infrastructure
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly ConnectionContext _context;

        // Injeção de dependência via construtor
        public CustomerRepository(ConnectionContext context)
        {
            _context = context;
        }

        // Adiciona um novo cliente no banco de dados
        public async Task AddAsync(Customer customer)
        {
            await _context.Customer.AddAsync(customer); // Adiciona o cliente ao DbSet
            await _context.SaveChangesAsync(); // Salva as mudanças no banco
        }

        // Obtém todos os clientes do banco de dados
        public async Task<List<Customer>> GetAllAsync()
        {
            return await _context.Customer.ToListAsync(); // Retorna todos os clientes como uma lista
        }

        // Caso precise de um método adicional para buscar por id, por exemplo
        public async Task<Customer?> GetByIdAsync(int customerId)
        {
            return await _context.Customer
                .FirstOrDefaultAsync(c => c.CustomerID == customerId); // Busca um cliente por ID
        }
    }
}
