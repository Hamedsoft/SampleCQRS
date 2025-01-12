using CQRS.Models;
using MediatR;

namespace CQRS.Queries.GetProductById
{
    public class GetProductByIdQuery : IRequest<Product> 
    { 
        public Guid Id { get; set; } 
    }
}
