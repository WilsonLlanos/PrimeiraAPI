namespace PrimeiraAPI.Model
{
    public interface ICustomerRepository
    {
        Task AddAsync(Customer customer); // Método assíncrono

        Task<List<Customer>> GetAllAsync(); // Método assíncrono para buscar todos os clientes

        Task<Customer> GetByIdAsync(int customerId); // Adicionado um método para buscar por ID (opcional)
    }
}

