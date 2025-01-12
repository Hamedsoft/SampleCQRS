using CQRS.Models;

namespace CQRS.Services
{
    public interface IProductRepository
    {
        Task<Product> GetByIdAsync(Guid id); 
        Task AddAsync(Product product); 
        Task SaveChangesAsync();
    }
}
