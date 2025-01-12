using MediatR;

namespace CQRS.Commands.CreateProduct
{
    public class CreateProductCommand : IRequest<Guid> 
    { 
        public string Name { get; set; } 
        public decimal Price { get; set; }
    }
}
