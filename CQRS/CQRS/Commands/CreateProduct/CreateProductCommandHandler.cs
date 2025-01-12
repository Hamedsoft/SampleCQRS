using CQRS.Models;
using CQRS.Services;
using MediatR;

namespace CQRS.Commands.CreateProduct
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, Guid>
    {
        private readonly IProductRepository _repository; 
        public CreateProductCommandHandler(IProductRepository repository) 
        { 
            _repository = repository; 
        }
        public async Task<Guid> Handle(CreateProductCommand request, CancellationToken cancellationToken) 
        { 
            var product = new Product { Id = Guid.NewGuid(), Name = request.Name, Price = request.Price }; 
            await _repository.AddAsync(product); 
            await _repository.SaveChangesAsync(); 
            return product.Id; 
        }
    }
}